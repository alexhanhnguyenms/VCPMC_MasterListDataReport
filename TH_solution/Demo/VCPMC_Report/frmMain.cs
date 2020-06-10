using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH.Demo.VCPMC_Report.common;
using System.Linq;
using TH.Demo.VCPMC_Report.models;
using System.IO;
using TH.Demo.VCPMC_Report.csv;
using LoadingIndicator.WinForms;
using System.Threading;
using TH.Demo.VCPMC_Report.enums;
using DetectLanguage;
using TH.Demo.VCPMC_Report.detect;

namespace TH.Demo.VCPMC_Report
{
    public partial class frmMain : Form
    {
        #region Variable
        private int PageSize = 50000;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0;
        List<YoutubeFile> currentDataSource = new List<YoutubeFile>();
        //private LongOperation _longOperation;
        Operation operation = Operation.LoadData;
        string currentDirectory = "";
        #endregion

        #region Contructor
        public frmMain()
        {
            InitializeComponent();

            // Initialize long operation with control which will
            // be overlayed during long operations
            //_longOperation = new LongOperation(this);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            timerClock.Enabled = true;
            cboDetectAPI.SelectedIndex = 0;
            Core.Innit();
            tscbFile.SelectedIndex = 0;
            EnableControl(Core.IsLogin);
            if (Core.IsLogin)
            {
                tssUser.Text = Core.User;                
            }
            else
            {
                tssUser.Text = "";
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
                if (Core.IsLogin)
                {
                    tssUser.Text = Core.User;                   
                }
            }
            EnableControl(Core.IsLogin);

            #region MyRegion
#if DEBUG
            txtPathFile.Text = @"E:\Solution\Source Code\trung tam tac quyen am nhac\test.csv";
#endif
            #endregion
        }

        private void EnableControl(bool isEnable)
        {
            try
            {
                if (isEnable)
                {
                    tsbLogInOut.Text = "Logout";
                }
                else
                {
                    tsbLogInOut.Text = "Login";
                }
                tsmConfig.Enabled = isEnable;

                EnableLoadData(isEnable);

                EnableCreateReport(false);
                EnableCbSelectFile(false);
                EnableSaveFile(false);
                EnableControlPagging(false);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void EnableLoadData(bool isEnable)
        {
            mainStatus.Invoke(new MethodInvoker(delegate
            {
                tsbSelectFile.Enabled = isEnable;
                tsbLoadFile.Enabled = isEnable;
            }));           
        }

        private void EnableCreateReport(bool isEnable)
        {
            mainStatus.Invoke(new MethodInvoker(delegate
            {
                tsbCreateReport.Enabled = isEnable;
            }));
           
        }
        private void EnableCbSelectFile(bool isEnable)
        {
            mainStatus.Invoke(new MethodInvoker(delegate
            {
                tscbFile.Enabled = isEnable;
            }));
            
        }
        private void EnableSaveFile(bool isEnable)
        {
            mainStatus.Invoke(new MethodInvoker(delegate
            {
                tsSaveReport.Enabled = isEnable;
            }));
           
        }
        private void EnableControlPagging(bool isEnable)
        {
            try
            {
                btnFirstPAge.Invoke(new MethodInvoker(delegate
                {
                    btnFirstPAge.Enabled = isEnable;
                }));
                btnPrevPage.Invoke(new MethodInvoker(delegate
                {
                    btnPrevPage.Enabled = isEnable;
                }));
                btnNxtPage.Invoke(new MethodInvoker(delegate
                {
                    btnNxtPage.Enabled = isEnable;
                }));
                btnLastPage.Invoke(new MethodInvoker(delegate
                {
                    btnLastPage.Enabled = isEnable;
                }));
                txtPageCurrent.Invoke(new MethodInvoker(delegate
                {
                    txtPageCurrent.Enabled = isEnable;
                }));
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region ts
        private void tmsAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void tsmConfig_Click(object sender, EventArgs e)
        {
            frmConfig frm = new frmConfig();
            frm.ShowDialog();
        }

        private void tsbLogInOut_Click(object sender, EventArgs e)
        {
            if(Core.IsLogin)
            {
                Core.IsLogin = false;
                Core.User = "";
            }
            else
            {
                tssUser.Text = "";
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
                if (Core.IsLogin)
                {
                    tssUser.Text = Core.User;
                }
            }
            EnableControl(Core.IsLogin);
        }
        #endregion

        #region Load data
        private void tsbSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                txtPathFile.Text = "";
                var filePath = string.Empty;
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx";
                    //openFileDialog.InitialDirectory = "D:\\";                   
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                        txtPathFile.Text = filePath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.ToString()}");
            }
        }

        private async void tsbLoadFile_Click(object sender, EventArgs e)
        {
            operation = Operation.LoadData;
            pcloader.Visible = true;
            pcloader.Dock = DockStyle.Fill;
            backgroundWorker1.RunWorkerAsync();           
        }

        private void LoadData()
        {
            try
            {
                if (txtPathFile.Text.Trim() == "")
                {
                    mainStatus.Invoke(new MethodInvoker(delegate
                    {
                        tssInfo1.Text = "Please select file...";
                        tssInfo1.BackColor = Color.Pink;
                        tssInfo1.ForeColor = Color.White;
                    }));                   
                    return;
                }
                else
                {
                    mainStatus.Invoke(new MethodInvoker(delegate
                    {
                        tssInfo1.Text = "";
                    }));                   
                }
                mainTool.Invoke(new MethodInvoker(delegate
                {
                    tscbFile.SelectedIndex = 0;
                }));
                //remove data file before reload
                #region clear data
                Core.YoutubeFiles.Clear();
                Core.YoutubeFiles1.Clear();
                Core.YoutubeFiles2.Clear();
                Core.YoutubeFiles3.Clear();
                Core.YoutubeFiles4_non_vi.Clear();
                Core.YoutubeFiles4_vi.Clear();
                Core.YoutubeFiles4_again_aftert_Convert_vi.Clear();
                Core.YoutubeFiles5_non_vi.Clear();
                Core.YoutubeFiles5_vi.Clear();
                Core.YoutubeFiles5_again_aftert_Convert_vi.Clear();
                #endregion

                DateTime startDate = DateTime.Now;
               
                string fileName = txtPathFile.Text.Trim();                
                CsvLumenWorksHelper.ReadCsv(fileName);
                currentDataSource = Core.YoutubeFiles;
                CalculateTotalPages(currentDataSource);

                dgvMain.Invoke(new MethodInvoker(delegate {
                    dgvMain.DataSource = GetPage(currentDataSource, CurrentPageIndex, PageSize);
                }));
                
                TimeSpan timeSpan = DateTime.Now - startDate;

                mainStatus.Invoke(new MethodInvoker(delegate
                {
                    tssInfo1.Text = $"total time load data: {timeSpan.TotalSeconds.ToString()}(s), toal record: {Core.YoutubeFiles.Count.ToString()}";
                }));

                mainStatus.Invoke(new MethodInvoker(delegate
                {
                    tssInfo1.BackColor = Color.Green;
                    tssInfo1.ForeColor = Color.White;
                }));

                //return;
            }
            catch (Exception ex)
            {
                mainStatus.Invoke(new MethodInvoker(delegate
                {
                    tssInfo1.Text = "Load data from file is error!";
                    tssInfo1.BackColor = Color.Red;
                    tssInfo1.ForeColor = Color.White;
                }));
                
                //MessageBox.Show($"Error: {ex.ToString()}");
                //return;
            }
        }

        IList<YoutubeFile> GetPage(IList<YoutubeFile> list, int page, int pageSize)
        {
            return list.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
        #endregion

        #region Create Report
        private void tsbCreateReport_Click(object sender, EventArgs e)
        {
            try
            {
                operation = Operation.CreateReporting;
                pcloader.Visible = true;
                pcloader.Dock = DockStyle.Fill;
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception)
            {               
            }
                  
        }

        private void CreateReport()
        {
            try
            {
                DateTime startDate = DateTime.Now;
                //create reporting
                Core.CreateReporting(cheIsrcVi.Checked, cheLabelVi.Checked, cheTitleVi.Checked, indexDetect, txtKey.Text.Trim());
                //Save File                
                TimeSpan timeSpan = DateTime.Now - startDate;
                mainStatus.Invoke(new MethodInvoker(delegate
                {
                    tssCreateReportInfo.Text = $"total time load data: {timeSpan.TotalSeconds.ToString()}(s)";
                    tssCreateReportInfo.BackColor = Color.Green;
                    tssCreateReportInfo.ForeColor = Color.White;
                }));
                
            }
            catch (Exception ex)
            {
                mainStatus.Invoke(new MethodInvoker(delegate
                {
                    tssCreateReportInfo.BackColor = Color.Red;
                    tssCreateReportInfo.ForeColor = Color.White;
                    //MessageBox.Show($"Error: {ex.ToString()}");
                }));                
            }
        }

        private void tscbFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentPageIndex = 1;
                dgvMain.DataSource = null;
                switch (tscbFile.SelectedIndex)
                {
                    case 0:
                        currentDataSource = Core.YoutubeFiles;                       
                        break;
                    case 1:
                        currentDataSource = Core.YoutubeFiles1;                       
                        break;
                    case 2:
                        currentDataSource = Core.YoutubeFiles2;                       
                        break;
                    case 3:
                        currentDataSource = Core.YoutubeFiles3;                        
                        break;
                    case 4:
                        currentDataSource = Core.YoutubeFiles4_non_vi;                        
                        break;
                    case 5:
                        currentDataSource = Core.YoutubeFiles4_vi;                       
                        break;
                    case 6:
                        currentDataSource = Core.YoutubeFiles4_again_aftert_Convert_vi;
                        break;
                    case 7:
                        currentDataSource = Core.YoutubeFiles5_non_vi;                       
                        break;
                    case 8:
                        currentDataSource = Core.YoutubeFiles5_vi;                       
                        break;
                    case 9:
                        currentDataSource = Core.YoutubeFiles5_again_aftert_Convert_vi;
                        break;
                    default:
                        break;
                }
                CalculateTotalPages(currentDataSource);
                dgvMain.DataSource = GetPage(currentDataSource, CurrentPageIndex, PageSize);
                tssCreateReportInfo.Text = $"{tscbFile.Text}, total record: {currentDataSource.Count}";
                tssCreateReportInfo.BackColor = Color.Green;
                tssCreateReportInfo.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                tssCreateReportInfo.BackColor = Color.Red;
                tssCreateReportInfo.ForeColor = Color.White;
                //MessageBox.Show($"Show data is error, {ex.ToString()}");
            }
        }
        #endregion

        #region Save file
        private void tsSaveReport_Click(object sender, EventArgs e)
        {
            currentDirectory = "";           
            OpenFileDialog folderBrowser = new OpenFileDialog();
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);

                currentDirectory = folderPath;
            }
            if(currentDirectory == "" )
            {
                return;
            }
            operation = Operation.SaveFile;
            pcloader.Visible = true;
            pcloader.Dock = DockStyle.Fill;
            backgroundWorker1.RunWorkerAsync();

        }

        private void SaveFile(string folderPath)
        {
            try
            {
                DateTime startDate = DateTime.Now;
                bool check = WriteReportHelper.WriteCsv(folderPath);
                TimeSpan timeSpan = DateTime.Now - startDate;
                if (check)
                {
                    mainStatus.Invoke(new MethodInvoker(delegate
                    {
                        tssCreateReportInfo.Text = $"Save report to file be successful, total time save: {timeSpan.TotalSeconds.ToString()}(s)";
                        tssCreateReportInfo.BackColor = Color.Green;
                        tssCreateReportInfo.ForeColor = Color.White;
                    }));

                }
                else
                {
                    mainStatus.Invoke(new MethodInvoker(delegate
                    {
                        tssCreateReportInfo.Text = $"Save report to file be Failure";
                        tssCreateReportInfo.BackColor = Color.Red;
                        tssCreateReportInfo.ForeColor = Color.White;
                    }));

                }
            }
            catch (Exception ex)
            {
                mainStatus.Invoke(new MethodInvoker(delegate
                {
                    tssCreateReportInfo.Text = $"Save report to file be Failure";
                    tssCreateReportInfo.BackColor = Color.Red;
                    tssCreateReportInfo.ForeColor = Color.White;
                }));
                
            }
        }
        #endregion

        #region Timer
        private void timerClock_Tick(object sender, EventArgs e)
        {
            try
            {
                Core.Time = DateTime.Now;
                tssTimeSys.Text = Core.Time.ToString("dd/MM/yyyy HH:mm:ss");
            }
            catch (Exception)
            {


            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (operation == Operation.LoadData)
            {
                LoadData();
                EnableCreateReport(true);
                EnableControlPagging(true);
               
                EnableCbSelectFile(false);
                EnableSaveFile(false);
                mainStatus.Invoke(new MethodInvoker(delegate
                {
                    tssCreateReportInfo.Text = "...";
                    tssCreateReportInfo.BackColor = Color.Green;
                    tssCreateReportInfo.ForeColor = Color.White;
                }));

            }
            else if (operation == Operation.CreateReporting)
            {
                CreateReport();
                EnableCbSelectFile(true);
                EnableSaveFile(true);

                mainTool.Invoke(new MethodInvoker(delegate
                {
                    tscbFile.SelectedIndex = 0;
                }));
            }
            else if (operation == Operation.SaveFile)
            {
                SaveFile(currentDirectory);                              
            }
            else if(operation == Operation.TestDetectLanguage)
            {
                TestDetectLanguage(txtLanguageDetect.Text.Trim(), indexDetect);
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcloader.Visible = false;
        }
        #endregion

        #region paging

        private void CalculateTotalPages(List<YoutubeFile> dataSource)
        {
            int rowCount = dataSource.Count;           
            this.TotalPage = rowCount / PageSize;
            if (rowCount % PageSize > 0) // if remainder is more than  zero 
            {
                this.TotalPage += 1;
            }
            lbTotalPage.Invoke(new MethodInvoker(delegate {
                lbTotalPage.Text = $"({TotalPage})";
            }));
            txtPageCurrent.Invoke(new MethodInvoker(delegate {
                txtPageCurrent.Value = CurrentPageIndex;
            }));

           
        }
        private void btnFirstPAge_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = 1;
            txtPageCurrent.Value = CurrentPageIndex;
            this.dgvMain.DataSource = GetPage(Core.YoutubeFiles, CurrentPageIndex, PageSize);
        }

        private void btnNxtPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex < this.TotalPage)
            {
                this.CurrentPageIndex++;
                txtPageCurrent.Value = CurrentPageIndex;
                this.dgvMain.DataSource = GetPage(Core.YoutubeFiles, CurrentPageIndex, PageSize);
            }
        }
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                txtPageCurrent.Value = CurrentPageIndex;
                this.dgvMain.DataSource = GetPage(Core.YoutubeFiles, CurrentPageIndex, PageSize);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = TotalPage;
            txtPageCurrent.Value = CurrentPageIndex;
            this.dgvMain.DataSource = GetPage(Core.YoutubeFiles, CurrentPageIndex, PageSize);
        }
        private void txtPageCurrent_ValueChanged(object sender, EventArgs e)
        {
            //if(txtPageCurrent.Value < 0)
            //{
            //    txtPageCurrent.Value = 0;
            //}
            //else if(txtPageCurrent.Value > TotalPage)
            //{
            //    txtPageCurrent.Value = TotalPage;
            //}
            //this.CurrentPageIndex = (int)txtPageCurrent.Value;
            //this.dgvMain.DataSource = GetPage(MainSystem.YoutubeFiles, CurrentPageIndex, pageSize);
        }

        private void txtPageCurrent_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtPageCurrent.Value < 0)
                    {
                        txtPageCurrent.Value = 0;
                    }
                    else if (txtPageCurrent.Value > TotalPage)
                    {
                        txtPageCurrent.Value = TotalPage;
                    }
                    this.CurrentPageIndex = (int)txtPageCurrent.Value;
                    this.dgvMain.DataSource = GetPage(Core.YoutubeFiles, CurrentPageIndex, PageSize);
                }
            }
            catch (Exception)
            {

                //throw;
            }
        }

        #endregion

        #region detect language        
        int indexDetect = 0;
        private void btnDetectLanguage_Click(object sender, EventArgs e)
        {
            try
            {
                indexDetect = cboDetectAPI.SelectedIndex;
                operation = Operation.TestDetectLanguage;
                pcloader.Visible = true;
                pcloader.Dock = DockStyle.Fill;
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                int x = 0;
            }
        }
        private void TestDetectLanguage(string language, int indexDetect)
        {           
            try
            {
                LanguageDetect languageDetect = new LanguageDetect(txtKey.Text.Trim());
                bool check = languageDetect.DetectLanguage(language, indexDetect);
                lbResultDeLag.Invoke(new MethodInvoker(delegate
                {
                    if (check)
                    {

                        lbResultDeLag.Text = "vietnamese";
                    }
                    else
                    {
                        lbResultDeLag.Text = "not vietnamese";
                    }
                }));
                
            }
            catch (Exception)
            {
                //throw;
            }           
        }       
        #endregion
        
    }
}

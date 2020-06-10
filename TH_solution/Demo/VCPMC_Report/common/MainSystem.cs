using DetectLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH.Demo.VCPMC_Report.detect;
using TH.Demo.VCPMC_Report.models;

namespace TH.Demo.VCPMC_Report.common
{
    public static class Core
    {
        #region system
        /// <summary>
        /// Check login system
        /// </summary>
        public static bool IsLogin = false;
        /// <summary>
        /// User
        /// </summary>
        public static string User = "Admin";
        /// <summary>
        /// password login to system
        /// </summary>
        public static string Password = "";
        /// <summary>
        /// Time of system
        /// </summary>
        public static DateTime Time = DateTime.Now;
        /// <summary>
        /// Path of master list file
        /// </summary>
        public static string Path = "";
        /// <summary>
        /// name of master list file
        /// </summary>
        public static string FileName = "";
        #endregion

        #region Report config
        /// <summary>
        /// file config 1
        /// </summary>
        public static ConfigFile ConfigFile1;
        /// <summary>
        /// file config 2
        /// </summary>
        public static ConfigFile ConfigFile2;
        /// <summary>
        /// file config 3
        /// </summary>
        public static ConfigFile ConfigFile3;
        /// <summary>
        /// file config 4 vi
        /// </summary>
        public static ConfigFile ConfigFile4_vi;
        //public static ConfigFile ConfigFile4_again_aftert_Convert_vi;
        /// <summary>
        /// file config 4 - none vi
        /// </summary>
        public static ConfigFile ConfigFile4_non_vi;
        /// <summary>
        /// file config 5 vi
        /// </summary>
        public static ConfigFile ConfigFile5_vi;
        //public static ConfigFile ConfigFile5_again_aftert_Convert_vi;
        /// <summary>
        /// file config 5 none vi
        /// </summary>
        public static ConfigFile ConfigFile5_non_vi;
        #endregion

        #region Data source
        /// <summary>
        /// master list data
        /// </summary>
        public static List<YoutubeFile> YoutubeFiles { get; set; } = new List<YoutubeFile>();
        /// <summary>
        /// report 1 data
        /// </summary>
        public static List<YoutubeFile> YoutubeFiles1 { get; set; } = new List<YoutubeFile>();
        /// <summary>
        /// report 2 data
        /// </summary>
        public static List<YoutubeFile> YoutubeFiles2 { get; set; } = new List<YoutubeFile>();
        /// <summary>
        /// report 3 data
        /// </summary>
        public static List<YoutubeFile> YoutubeFiles3 { get; set; } = new List<YoutubeFile>();
        /// <summary>
        /// report 4-non-vi data
        /// </summary>
        public static List<YoutubeFile> YoutubeFiles4_non_vi { get; set; } = new List<YoutubeFile>();
        /// <summary>
        /// report 4-vi data
        /// </summary>
        public static List<YoutubeFile> YoutubeFiles4_vi { get; set; } = new List<YoutubeFile>();
        /// <summary>
        /// report 4- again after get vi data
        /// </summary>
        public static List<YoutubeFile> YoutubeFiles4_again_aftert_Convert_vi { get; set; } = new List<YoutubeFile>();
        /// <summary>
        /// report 5-none vi data
        /// </summary>
        public static List<YoutubeFile> YoutubeFiles5_non_vi { get; set; } = new List<YoutubeFile>();
        /// <summary>
        /// report 5-vi data
        /// </summary>
        public static List<YoutubeFile> YoutubeFiles5_vi { get; set; } = new List<YoutubeFile>();
        /// <summary>
        /// report 5- after get vi data
        /// </summary>
        public static List<YoutubeFile> YoutubeFiles5_again_aftert_Convert_vi { get; set; } = new List<YoutubeFile>();
        #endregion

        #region test
        static string test = "";
        #endregion

        #region innit
        /// <summary>
        /// Khởi tạo thông số
        /// </summary>
        public static void Innit()
        {
            Path = Environment.CurrentDirectory;
            LoadConfig();
        }
        /// <summary>
        /// Load file config of report
        /// </summary>
        public static void LoadConfig()
        {
            ConfigFile1 = XmlHelper.ReadXML(NameReport.File1);
            ConfigFile2 = XmlHelper.ReadXML(NameReport.File2);
            ConfigFile3 = XmlHelper.ReadXML(NameReport.File3);
            ConfigFile4_vi = XmlHelper.ReadXML(NameReport.File4_vi);
            ConfigFile4_non_vi = XmlHelper.ReadXML(NameReport.File4_non_vi);
            ConfigFile5_vi = XmlHelper.ReadXML(NameReport.File5_vi);
            ConfigFile5_non_vi = XmlHelper.ReadXML(NameReport.File5_non_vi);
        }
        #endregion

        #region Convert to uppercase

        #endregion

        #region convert to unicode

        #endregion


        #region Create report
        /// <summary>
        /// Create report to total 7 file
        /// </summary>
        /// <param name="isCheckIsrc"></param>
        /// <param name="isCheckLabel"></param>
        /// <param name="isCheckTitle"></param>
        /// <param name="indexDetect"></param>
        /// <param name="key"></param>
        public static void CreateReporting(bool isCheckIsrc, bool isCheckLabel, bool isCheckTitle, int indexDetect, string key)
        {
            try
            {
                LanguageDetect languageDetect = new LanguageDetect(key);
                #region clear data
                Core.YoutubeFiles1.Clear();
                Core.YoutubeFiles2.Clear();
                Core.YoutubeFiles3.Clear();
                Core.YoutubeFiles4_non_vi.Clear();
                Core.YoutubeFiles4_vi.Clear();
                Core.YoutubeFiles5_non_vi.Clear();
                Core.YoutubeFiles5_vi.Clear();
                #endregion

                bool check = true;
                for (int i = 0; i < Core.YoutubeFiles.Count; i++)
                {
                    #region 1.file1   
                    check = true;
                    foreach (var item in Core.ConfigFile1.configItems)
                    {
                        if (item.IsCheck)
                        {
                            check = Compare(i, item);
                            if (!check)
                            {
                                break;
                            }
                        }
                    }                    
                    if(check)
                    {
                        YoutubeFile youtubeFileClone = (YoutubeFile)Core.YoutubeFiles[i].Clone();
                        Core.YoutubeFiles1.Add(youtubeFileClone);
                    }
                    #endregion

                    #region 2.file2
                    check = true;
                    foreach (var item in Core.ConfigFile2.configItems)
                    {
                        if (item.IsCheck)
                        {
                            check = Compare(i, item);
                            if (!check)
                            {
                                break;
                            }
                        }
                    }
                    if (check)
                    {
                        YoutubeFile youtubeFileClone = (YoutubeFile)Core.YoutubeFiles[i].Clone();
                        Core.YoutubeFiles2.Add(youtubeFileClone);
                    }
                    #endregion

                    #region 3.file3
                    check = true;
                    foreach (var item in Core.ConfigFile3.configItems)
                    {
                        if (item.IsCheck)
                        {
                            check = Compare(i, item);
                            if (!check)
                            {
                                break;
                            }
                        }
                    }
                    if (check)
                    {
                        YoutubeFile youtubeFileClone = (YoutubeFile)Core.YoutubeFiles[i].Clone();
                        Core.YoutubeFiles3.Add(youtubeFileClone);
                    }
                    #endregion

                    #region 4.file4-none-vi
                    check = true;
                    foreach (var item in Core.ConfigFile4_non_vi.configItems)
                    {
                        if (item.IsCheck)
                        {
                            check = Compare(i, item);
                            if (!check)
                            {
                                break;
                            }
                        }
                    }
                    if (check)
                    {
                        YoutubeFile youtubeFileClone = (YoutubeFile)Core.YoutubeFiles[i].Clone();
                        Core.YoutubeFiles4_non_vi.Add(youtubeFileClone);
                    }
                    else
                    {
                        int a = 1;
                    }    
                    #endregion

                    #region 5.file5-none-vi
                    check = true;
                    foreach (var item in Core.ConfigFile5_non_vi.configItems)
                    {
                        if (item.IsCheck)
                        {
                            check = Compare(i, item);
                            if (!check)
                            {
                                break;
                            }
                        }
                    }
                    if (check)
                    {
                        YoutubeFile youtubeFileClone = (YoutubeFile)Core.YoutubeFiles[i].Clone();
                        Core.YoutubeFiles5_non_vi.Add(youtubeFileClone);
                    }
                    #endregion

                    #region 6.file4-vi
                    //1. điều kiện                    
                    check = true;
                    foreach (var item in Core.ConfigFile4_vi.configItems)
                    {
                        if (item.IsCheck)
                        {
                            check = Compare(i, item);
                            if (!check)
                            {
                                break;
                            }
                        }
                    }                   
                    if (check)
                    {
                        if(isCheckIsrc)
                        {
                            List<ViDetectItem> itemCompare = Core.ConfigFile4_vi.viDetectItems;
                            #region loc tiếng việt                       
                            check = CheckVi(check, i, itemCompare, isCheckLabel, isCheckTitle);
                            #endregion
                            ////neu chua phai la tieng viet, dungapi
                            ////cuoi cung dung API
                            //if (!check)
                            //{
                            //    check = languageDetect.DetectLanguage(Core.YoutubeFiles[i].TITLE, indexDetect);
                            //    //test
                            //    if(check)
                            //    {
                            //        int a = 1;
                            //    }
                            //}
                        }                       
                        //file4-vi: file tieng viet   
                        if (check)
                        {
                            YoutubeFile youtubeFileClone = (YoutubeFile)Core.YoutubeFiles[i].Clone();
                            Core.YoutubeFiles4_vi.Add(youtubeFileClone);
                        }
                        else
                        {
                            //file4-agin-none-vi: file tieng viet   
                            YoutubeFile youtubeFileClone = (YoutubeFile)Core.YoutubeFiles[i].Clone();
                            Core.YoutubeFiles4_again_aftert_Convert_vi.Add(youtubeFileClone);
                        }
                    }
                    #endregion

                    #region 7.file5-vi
                    check = true;
                    foreach (var item in Core.ConfigFile5_vi.configItems)
                    {
                        if (item.IsCheck)
                        {
                            check = Compare(i, item);
                            if (!check)
                            {
                                break;
                            }
                        }
                    }
                    if (check)
                    {
                        if(isCheckIsrc)
                        {
                            List<ViDetectItem> itemCompare = Core.ConfigFile4_vi.viDetectItems;
                            #region loc tiếng việt                       
                            check = CheckVi(check, i, itemCompare, isCheckLabel, isCheckTitle);
                            #endregion
                            ////neu chua phai la tieng viet, dungapi
                            ////cuoi cung dung API
                            //if (!check)
                            //{
                            //    check = languageDetect.DetectLanguage(Core.YoutubeFiles[i].TITLE, indexDetect);
                            //    //test
                            //    if (check)
                            //    {
                            //        int a = 1;
                            //    }
                            //}
                        }
                        //file5-vi: file tieng viet   
                        if (check)
                        {
                            YoutubeFile youtubeFileClone = (YoutubeFile)Core.YoutubeFiles[i].Clone();
                            Core.YoutubeFiles5_vi.Add(youtubeFileClone);
                        }      
                        else
                        {
                            //file5-agin-none-vi: file tieng viet   
                            YoutubeFile youtubeFileClone = (YoutubeFile)Core.YoutubeFiles[i].Clone();
                            Core.YoutubeFiles5_again_aftert_Convert_vi.Add(youtubeFileClone);
                        }
                    }
                    #endregion                   

                }
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
            }
        }
        /// <summary>
        /// Check is vietnamese
        /// </summary>
        /// <param name="check"></param>
        /// <param name="i"></param>
        /// <param name="itemCompare"></param>
        /// <returns></returns>
        private static bool CheckVi(bool check, int i, List<ViDetectItem> itemCompare, bool isCheckLabel, bool isCheckTitle)
        {
            string CountTry = "";
            check = false;
            if (Core.YoutubeFiles[i].ISRC == null || Core.YoutubeFiles[i].ISRC.Length < 2)
            {
                check = false;
            }
            else
            {
                //1.ISRC
                CountTry = Core.YoutubeFiles[i].ISRC.Substring(0, 2);
                IEnumerable<ViDetectItem> query = from item in itemCompare
                                                  where item.ColumnName == "ISRC"
                                                  select item;
                int count = query.ToList().Count;
                foreach (var item in query)
                {
                    if (item.IsCheck)
                    {
                        check = CompareVi(i, item, CountTry);
                        if (check)
                        {
                            break;
                        }
                    }
                }
                //2.LABEL 
                if (check)
                {
                    if(isCheckLabel)
                    {
                        #region kiểm theo label
                        query = from item in itemCompare
                                where item.ColumnName == "LABEL"
                                select item;
                        count = query.ToList().Count;

                        foreach (var item in query)
                        {
                            if (item.IsCheck)
                            {
                                check = CompareVi(i, item, CountTry);
                                if (check)
                                {
                                    break;
                                }
                            }
                        }
                        if (check)
                        {
                            if(isCheckTitle)
                            {
                                #region kiểm theo title
                                //3.TITLE 
                                query = from item in itemCompare
                                        where item.ColumnName == "TITLE"
                                        select item;
                                count = query.ToList().Count;
                                foreach (var item in query)
                                {
                                    if (item.IsCheck)
                                    {
                                        check = CompareVi(i, item, CountTry);
                                        if (check)
                                        {
                                            break;
                                        }
                                    }
                                }
                                #endregion
                            }                           
                        }
                        else
                        {
                            int a = 1;
                        }
                        #endregion
                    }                  

                }                
                
            }

            return check;
        }
        /// <summary>
        /// Compare data with condition in the config file of report
        /// </summary>
        /// <param name="i"></param>
        /// <param name="configItem"></param>
        /// <returns></returns>
        private static bool Compare(int i, ConfigItem configItem)
        {
            bool check = true;
            switch (configItem.ColumnName)
            {
                case "ID":
                    if (Core.YoutubeFiles[i].ID == configItem.Value)
                    {
                        check = false;
                    }
                    break;
                case "TITLE":
                    if (Core.YoutubeFiles[i].TITLE == configItem.Value)
                    {
                        check = false;
                    }
                    break;
                case "ARTIST":
                    if (Core.YoutubeFiles[i].ARTIST == configItem.Value)
                    {
                        check = false;
                    }
                    break;
                case "ALBUM":
                    if (Core.YoutubeFiles[i].ALBUM == configItem.Value)
                    {
                        check = false;
                    }
                    break;
                case "LABEL":
                    if (Core.YoutubeFiles[i].LABEL == configItem.Value)
                    {
                        check = false;
                    }
                    break;
                case "ISRC":
                    if (Core.YoutubeFiles[i].ISRC == configItem.Value)
                    {
                        check = false;
                    }
                    break;
                case "COMP_ID":
                    if (Core.YoutubeFiles[i].COMP_ID == configItem.Value)
                    {
                        check = false;
                    }
                    break;
                case "COMP_TITLE":
                    if (Core.YoutubeFiles[i].COMP_TITLE == configItem.Value)
                    {
                        check = false;
                    }
                    break;
                case "COMP_ISWC":
                    if (Core.YoutubeFiles[i].COMP_ISWC == configItem.Value)
                    {
                        check = false;
                    }
                    break;
                case "COMP_WRITERS":
                    if (Core.YoutubeFiles[i].COMP_WRITERS == configItem.Value)
                    {
                        check = false;
                    }
                    break;
                case "COMP_CUSTOM_ID":
                    if (Core.YoutubeFiles[i].COMP_CUSTOM_ID == configItem.Value)
                    {
                        check = false;
                    }
                    break;
                case "QUANTILE":
                    if (Core.YoutubeFiles[i].QUANTILE == configItem.Value)
                    {
                        check = false;
                    }
                    break;
                default:
                    break;
            }

            return check;
        }
        /// <summary>
        /// Compare is vietnamese
        /// </summary>
        /// <param name="i"></param>
        /// <param name="configItem"></param>
        /// <param name="CountTry"></param>
        /// <returns></returns>
        private static bool CompareVi(int i, ViDetectItem configItem, string CountTry = "")
        {
            bool check = false;
            switch (configItem.ColumnName)
            {
                //case "ID":
                //    if (Core.YoutubeFiles[i].ID == configItem.Value)
                //    {
                //        check = false;
                //    }
                //    break;
               
                //case "ARTIST":
                //    if (Core.YoutubeFiles[i].ARTIST == configItem.Value)
                //    {
                //        check = false;
                //    }
                //    break;
                //case "ALBUM":
                //    if (Core.YoutubeFiles[i].ALBUM == configItem.Value)
                //    {
                //        check = false;
                //    }
                //    break;
                case "ISRC":                    
                    if (CountTry == configItem.Value)
                    {
                        check = true;
                    }
                    break;
                case "LABEL":
                    if (Core.YoutubeFiles[i].LABEL == configItem.Value)
                    {
                        check = true;
                    }
                    break;
                case "TITLE":
                    check = VnHelper.Detect(Core.YoutubeFiles[i].TITLE);     
                    if(check)
                    {
                        int a = 1;
                    }    
                    break;
                //case "COMP_ID":
                //    if (Core.YoutubeFiles[i].COMP_ID == configItem.Value)
                //    {
                //        check = false;
                //    }
                //    break;
                //case "COMP_TITLE":
                //    if (Core.YoutubeFiles[i].COMP_TITLE == configItem.Value)
                //    {
                //        check = false;
                //    }
                //    break;
                //case "COMP_ISWC":
                //    if (Core.YoutubeFiles[i].COMP_ISWC == configItem.Value)
                //    {
                //        check = false;
                //    }
                //    break;
                //case "COMP_WRITERS":
                //    if (Core.YoutubeFiles[i].COMP_WRITERS == configItem.Value)
                //    {
                //        check = false;
                //    }
                //    break;
                //case "COMP_CUSTOM_ID":
                //    if (Core.YoutubeFiles[i].COMP_CUSTOM_ID == configItem.Value)
                //    {
                //        check = false;
                //    }
                //    break;
                //case "QUANTILE":
                //    if (Core.YoutubeFiles[i].QUANTILE == configItem.Value)
                //    {
                //        check = false;
                //    }
                //    break;
                default:
                    break;
            }

            return check;
        }
        #endregion
    }
}

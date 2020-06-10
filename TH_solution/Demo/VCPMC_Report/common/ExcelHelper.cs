using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH.Demo.VCPMC_Report.common
{
    public class ExcelHelper
    {
        public void ReadExcel(string FullName)
        {
            //HSSF => dùng cho XLS (Excel 97-2003)
            // Lấy stream file
            FileStream fs = new FileStream(FullName, FileMode.Open);

            // Khởi tạo workbook để đọc
            HSSFWorkbook wb = new HSSFWorkbook(fs);

            // Lấy sheet đầu tiên
            ISheet sheet = wb.GetSheetAt(0);

            // đọc sheet này bắt đầu từ row 2 (0, 1 bỏ vì tiêu đề)
            int rowIndex = 2;

            // xuất thong báo
            Console.OutputEncoding = Encoding.UTF8; // để xuất ra console tv có dấu
            Console.WriteLine("Thông tin SV từ file Excel");

            // nếu vẫn chưa gặp end thì vẫn lấy data
            while (sheet.GetRow(rowIndex).GetCell(0).StringCellValue.ToLower() != "end")
            {
                // lấy row hiện tại
                var nowRow = sheet.GetRow(rowIndex);

                // vì ta dùng 3 cột A, B, C => data của ta sẽ như sau
                var MSSV = nowRow.GetCell(0).StringCellValue;
                var Name = nowRow.GetCell(1).StringCellValue;
                var Phone = nowRow.GetCell(2).StringCellValue;

                // Xuất ra thông tin lên màn hình
                Console.WriteLine("MSSV: {0} | Họ & Tên: {1} | SDT: {2}", MSSV, Name, Phone);

                // tăng index khi lấy xong
                rowIndex++;
            }
        }
        public void ReadExcel2(string FullName)
        {
            //XSSF => dùng cho XLSX (Excel 2007+)
            // Lấy stream file
            FileStream fs = new FileStream(FullName, FileMode.Open);

            // Khởi tạo workbook để đọc
            XSSFWorkbook wb = new XSSFWorkbook(fs);

            // Lấy sheet đầu tiên
            ISheet sheet = wb.GetSheetAt(0);

            // đọc sheet này bắt đầu từ row 2 (0, 1 bỏ vì tiêu đề)
            int rowIndex = 2;

            // xuất thong báo
            Console.OutputEncoding = Encoding.UTF8; // để xuất ra console tv có dấu
            Console.WriteLine("Thông tin SV từ file Excel XLSX");

            // nếu vẫn chưa gặp end thì vẫn lấy data
            while (sheet.GetRow(rowIndex).GetCell(0).StringCellValue.ToLower() != "end")
            {
                // lấy row hiện tại
                var nowRow = sheet.GetRow(rowIndex);

                // vì ta dùng 3 cột A, B, C => data của ta sẽ như sau
                var MSSV = nowRow.GetCell(0).StringCellValue;
                var Name = nowRow.GetCell(1).StringCellValue;
                var Phone = nowRow.GetCell(2).StringCellValue;

                // Xuất ra thông tin lên màn hình
                Console.WriteLine("MSSV: {0} | Họ & Tên: {1} | SDT: {2}", MSSV, Name, Phone);

                // tăng index khi lấy xong
                rowIndex++;
            }
        }

        /// <summary>
        ///  Attemps to read workbook as XLSX, then XLS, then fails.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public IWorkbook ReadWorkbook(string path)
        {
            IWorkbook book = null;
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                // Try to read workbook as XLSX:
                try
                {
                    book = new XSSFWorkbook(fs);
                }
                catch (Exception ex1)
                {
                    book = null;
                    MessageBox.Show($"Read file is error, {ex1.ToString()}");
                }

                // If reading fails, try to read workbook as XLS:
                if (book == null)
                {
                    book = new HSSFWorkbook(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Read file is error, {ex.ToString()}");
            }
            return book;
        }

        public void Write(List<object> list)
        {
            try
            {
                //// Danh sách SV
                //List<SinhVien> list = new List<SinhVien>()
                //{
                //    new SinhVien{ MSSV = "15211TT00xx", Name = "Trần Minh Phát", Phone = "090999xxxx" },
                //    new SinhVien{ MSSV = "15211TT00xx", Name = "Võ Phương Quân", Phone = "090999xxxx" },
                //    new SinhVien{ MSSV = "15211TT00xx", Name = "Lê Bảo Long", Phone = "090999xxxx" },
                //    new SinhVien{ MSSV = "15211TT00xx", Name = "Nguyễn Trung Hiếu", Phone = "090999xxxx" },
                //};

                // khởi tạo wb rỗng
                XSSFWorkbook wb = new XSSFWorkbook();

                // Tạo ra 1 sheet
                ISheet sheet = wb.CreateSheet();

                // Bắt đầu ghi lên sheet

                // Tạo row
                var row0 = sheet.CreateRow(0);
                // Merge lại row đầu 3 cột
                row0.CreateCell(0); // tạo ra cell trc khi merge
                CellRangeAddress cellMerge = new CellRangeAddress(0, 0, 0, 2);
                sheet.AddMergedRegion(cellMerge);
                row0.GetCell(0).SetCellValue("Thông tin sinh viên");

                // Ghi tên cột ở row 1
                var row1 = sheet.CreateRow(1);
                row1.CreateCell(0).SetCellValue("MSSV");
                row1.CreateCell(1).SetCellValue("Tên");
                row1.CreateCell(2).SetCellValue("Phone");

                // bắt đầu duyệt mảng và ghi tiếp tục
                int rowIndex = 2;
                foreach (var item in list)
                {
                    // tao row mới
                    var newRow = sheet.CreateRow(rowIndex);

                    // set giá trị
                    //newRow.CreateCell(0).SetCellValue(item.MSSV);
                    //newRow.CreateCell(1).SetCellValue(item.Name);
                    //newRow.CreateCell(2).SetCellValue(item.Phone);

                    // tăng index
                    rowIndex++;
                }

                // xong hết thì save file lại
                FileStream fs = new FileStream(@"E:\sinhvien.xlsx", FileMode.CreateNew);
                wb.Write(fs);
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}

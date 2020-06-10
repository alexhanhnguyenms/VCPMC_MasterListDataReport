using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH.Demo.VCPMC_Report.common;
using TH.Demo.VCPMC_Report.models;

namespace TH.Demo.VCPMC_Report.csv
{
    /// <summary>
    /// Ghi bao Cao
    /// </summary>
    public class WriteReportHelper
    {
        public static bool WriteCsv(string folderPath)
        {
            try
            {
                bool check = false;
                int count = 0;
                string message = "";
                check = WriteCsv(Core.YoutubeFiles1, $"{folderPath}\\{NameReport.File1}.csv");
                if (check) count++;
                check = WriteCsv(Core.YoutubeFiles2, $"{folderPath}\\{NameReport.File2}.csv");
                if (check) count++;
                check = WriteCsv(Core.YoutubeFiles3, $"{folderPath}\\{NameReport.File3}.csv");
                if (check) count++;
                check = WriteCsv(Core.YoutubeFiles4_non_vi, $"{folderPath}\\{NameReport.File4_non_vi}.csv");
                if (check) count++;
                check = WriteCsv(Core.YoutubeFiles5_non_vi, $"{folderPath}\\{NameReport.File5_non_vi}.csv");
                if (check) count++;
                check = WriteCsv(Core.YoutubeFiles4_vi, $"{folderPath}\\{NameReport.File4_vi}.csv");
                if (check) count++;
                check = WriteCsv(Core.YoutubeFiles5_vi, $"{folderPath}\\{NameReport.File5_vi}.csv");
                if (check) count++;
                //test
                //check = WriteCsv(Core.YoutubeFiles, $"{folderPath}\\{NameReport.File1}1.csv");

                if (count == 7)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                //MessageBox.Show(ex.ToString());
            }
        }
        private static bool WriteCsv(List<YoutubeFile> dataSource, string fullPath)
        {
            bool result = false;
            try
            {
                // Write sample data to CSV file
                using (CsvFileWriter writer = new CsvFileWriter(fullPath))
                {
                    //1.header
                    string strHeader = "ID,TITLE,ARTIST,ALBUM,LABEL,ISRC,COMP_ID,COMP_TITLE,COMP_ISWC,COMP_WRITERS,COMP_CUSTOM_ID,QUANTILE";
                    string[] strArray = strHeader.Split(',');
                    CsvRow row = new CsvRow();
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        row.Add(strArray[i]);
                    }
                    writer.WriteRow(row);
                    //2.data
                    foreach (var item in dataSource)
                    {
                        row = new CsvRow();
                        row.Add(item.ID);
                        row.Add(item.TITLE);
                        row.Add(item.ARTIST);
                        row.Add(item.ALBUM);
                        row.Add(item.LABEL);
                        row.Add(item.ISRC);

                        row.Add(item.COMP_ID);
                        row.Add(item.COMP_TITLE);
                        row.Add(item.COMP_ISWC);
                        row.Add(item.COMP_WRITERS);
                        row.Add(item.COMP_CUSTOM_ID);
                        row.Add(item.QUANTILE);

                        writer.WriteRow(row);
                    }
                }
                result = true;
            }
            catch (Exception)
            {

                result = false;
            }
            return result;
        }

        
        
    }
}

using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TH.Demo.VCPMC_Report.common;
using TH.Demo.VCPMC_Report.models;

namespace TH.Demo.VCPMC_Report.csv
{
    public class CsvLumenWorksHelper
    {
        public static void ReadCsv(string fullPath)
        {
            try
            {
                Core.YoutubeFiles.Clear();
                int fieldCount = 0;
                int rowCountBefore = 0;
                // open the file "data.csv" which is a CSV file with headers               
                List<YoutubeFile> YoutubeFiles = new List<YoutubeFile>();
                using (CsvReader csv = new CsvReader(new StreamReader(fullPath), true))
                {
                    fieldCount = csv.FieldCount;
                    string[] headers = csv.GetFieldHeaders();
                    //rowCountBefore = csv.Count();
                    YoutubeFile item = null;
                    long no = 1;
                    while (csv.ReadNextRecord())
                    {

                        item = new YoutubeFile();
                        item.NO = no;
                        item.ID = csv[0].Trim();
                        item.TITLE = csv[1].Trim();
                        item.ARTIST = csv[2].Trim();
                        item.ALBUM = csv[3].Trim();
                        item.LABEL = csv[4].Trim();
                        item.ISRC = csv[5].Trim();

                        item.COMP_ID = csv[6].Trim();
                        item.COMP_TITLE = csv[7].Trim();
                        item.COMP_ISWC = csv[8].Trim();
                        item.COMP_WRITERS = csv[9].Trim();
                        item.COMP_CUSTOM_ID = csv[10].Trim();
                        item.QUANTILE = csv[11].Trim();
                        YoutubeFiles.Add(item);
                        no++;
                    }
                }
                Core.YoutubeFiles = YoutubeFiles;               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
       
    }
}

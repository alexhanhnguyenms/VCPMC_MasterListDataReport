using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH.Demo.VCPMC_Report.models;

namespace TH.Demo.VCPMC_Report.csv
{
    /// <summary>
    /// Class to store one CSV row
    /// </summary>
    public class CsvRow : List<string>
    {       
        public string LineText { get; set; }
    }   
}

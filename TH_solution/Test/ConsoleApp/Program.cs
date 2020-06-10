using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH.Demo.VCPMC_Report.common;

namespace TH.Test.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "ù";
            bool check = VnHelper.Detect(str);
            int a = 1;
        }
    }
}

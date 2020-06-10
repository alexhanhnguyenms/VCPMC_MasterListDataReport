﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.Demo.VCPMC_Report.models
{
    /// <summary>
    /// Phần tử caais hình
    /// </summary>
    public class ConfigItem
    {
        /// <summary>
        /// Tên Cột
        /// </summary>
        public string ColumnName { get; set; }
        /// <summary>
        /// Giá trị
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Sắp xếp
        /// </summary>
        public int Order { get; set; } = 0;
        /// <summary>
        /// Có lọc không
        /// </summary>
        public bool IsCheck { get; set; }
    }
}
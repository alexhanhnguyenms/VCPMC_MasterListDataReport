using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.Demo.VCPMC_Report.models
{
    public class YoutubeFile: ICloneable
    {
        public long NO { get; set; } = 0;
        /// <summary>
        /// mã
        /// </summary>
        public string ID { get; set; }     
        /// <summary>
        /// Tiêu đề bài hát
        /// </summary>
        public string TITLE { get; set; }
        /// <summary>
        /// Nghệ sĩ
        /// </summary>
        public string ARTIST { get; set; }
        /// <summary>
        /// Album
        /// </summary>
        public string ALBUM { get; set; }
        /// <summary>
        /// Nhãn, công ty sản xuất
        /// </summary>
        public string LABEL { get; set; }
        /// <summary>
        /// Quốc gia đăng ký và bảo hộ
        /// </summary>
        public string ISRC { get; set; }
        /// <summary>
        /// Mã bài hát
        /// </summary>
        public string COMP_ID { get; set; }
        /// <summary>
        /// Tên bài hát
        /// </summary>
        public string COMP_TITLE { get; set; }
        /// <summary>
        /// Mã bảo hộ
        /// </summary>
        public string COMP_ISWC { get; set; }
        public string COMP_WRITERS { get; set; }
        /// <summary>
        /// Mã khách hàng sử dụng
        /// </summary>
        public string COMP_CUSTOM_ID { get; set; }
        /// <summary>
        /// Số lượng
        /// </summary>
        public string QUANTILE { get; set; }

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}

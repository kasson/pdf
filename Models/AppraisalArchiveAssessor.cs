using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    /// <summary>
    /// ผู้ประเมิน, หมายเหตุผู้รับรอง, ผู้แก้ไข
    /// </summary>
    public class AppraisalArchiveAssessor
    {
        #region -------------------------------PA
        /// <summary>
        /// สร้างโดย
        /// </summary> 
        public String CreatedBy { get; set; }//
        /// <summary>
        /// วันที่สร้าง
        /// </summary>
        public DateTime CreatedTime { get; set; }//
        /// <summary>
        /// แก้ไขโดย
        /// </summary> 
        public String UpdateBy { get; set; }//
        /// <summary>
        /// วันที่แก้ไข
        /// </summary>
        public DateTime UpdateTime { get; set; }//
        #endregion

        #region ---------------------------ผู้รับรอง
        /// <summary>
        /// หมายเหตุจากผู้รับรอง
        /// </summary>
        public String EndorseeNote { get; set; } //
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class LB_FDetailsModel
    {
        /// <summary>
        /// PRIMARY KEY
        /// </summary>
        public int FDetailsId { get; set; }
        /// <summary>
        /// วิธีการประเมินที่ใช้
        /// </summary>
        public string AssessmentNote { get; set; }
        /// <summary>
        /// การประเมินทรัพย์สินด้านการใช้ประโยชน์สูงสุด
        /// </summary>
        public string PropertyAnalysisNote { get; set; }
        /// <summary>
        /// รายละเอียดของS1
        /// </summary>
        public string NoteS1 { get; set; }
        /// <summary>
        /// รายละเอียดของS2
        /// </summary>
        public string NoteS2 { get; set; }
        /// <summary>
        /// รายละเอียดของS3
        /// </summary>
        public string NoteS3 { get; set; }
        /// <summary>
        /// รายละเอียดของS4
        /// </summary>
        public string NoteS4 { get; set; }
        /// <summary>
        /// รายละเอียดของS5
        /// </summary>
        public string NoteS5 { get; set; }
        /// <summary>
        /// รายละเอียดของS6
        /// </summary>
        public string NoteS6 { get; set; }
        /// <summary>
        /// รายละเอียดของS7
        /// </summary>
        public string NoteS7 { get; set; }
        /// <summary>
        /// รายละเอียดของS8
        /// </summary>
        public string NoteS8 { get; set; }
        /// <summary>
        /// รายละเอียดของS9
        /// </summary>
        public string NoteS9 { get; set; }
        /// <summary>
        /// สรุป
        /// </summary>
        public string AbstractNote { get; set; }
        /// <summary>
        /// หมายเหตุ
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// Foreign Key
        /// </summary>
        public string JobNo { get; set; }
    }
}

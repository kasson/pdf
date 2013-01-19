using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class AppraisalArchivePrimaryAppointment
    {
        /// <summary>
        /// วันที่นัดสำรวจเบื้องต้น
        /// </summary>
        public DateTime AppointDate { get; set; }
        /// <summary>
        /// สถานที่นัดสำรวจ
        /// </summary>
        public String AppointPlace { get; set; }
        /// <summary>
        /// ชื่อผู้นำสำรวจ
        /// </summary>
        public String AppointName { get; set; }
        /// <summary>
        /// เบอร์โทรติดต่อ
        /// </summary>
        public String AppointPhone { get; set; }
    }
}

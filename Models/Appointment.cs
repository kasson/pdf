using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    /// <summary>
    /// การนัดหมาย ทั้งที่เป็นข้อมูลจาก server (CS นัด) และ ผู้ประเมินนัดเอง
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// วันที่นัดหมาย
        /// </summary>
        public DateTime? AppointDate { get; set; }

        /// <summary>
        /// เบอร์โทรศัพท์
        /// </summary>
        /// <remarks>
        /// บน server ใช้คำว่า APPOINT_TEL
        /// </remarks>
        public string AppointPhoneNo { get; set; }

        /// <summary>
        /// นัดหมายกับใคร (ชื่อผู้นำสำรวจ)
        /// </summary>
        /// <remarks>
        /// บน server จะใช้คำว่า APPOINT_NAME
        /// </remarks>
        public string AppointWith { get; set; }

        /// <summary>
        /// สถานที่นัดหมาย
        /// </summary>
        public string AppointPlace { get; set; }

        /// <summary>
        /// ข้อมูลการนัดหมายของผู้ประเมินเอง, กรณีผู้ประเมินนัด
        /// </summary>
        public Appraiser AppraiserInfo { get; set; }
        /// <summary>
        /// ข้อมูลการนัดหมายจาก CS, กรณี CS เป็นผู้นัด
        /// </summary>
        public CS_Info CsInfo { get; set; }

        /// <summary>
        /// ข้อมูลผู้นัด
        /// </summary>
        /// <example>
        /// ผู้ประเมิน หรือ CS เป็นต้น
        /// </example>
        /// 
        public string AppointBy
        {
            get
            {
                return CsInfo != null ? "CS" : "ผู้ประเมิน";
            }
        }

        /// <summary>
        /// ข้อมูลการนัดหมายโดยผู้ประเมิน
        /// </summary>
        public class Appraiser
        {
            /// <summary>
            /// เวลาที่นัดหมาย (เวลาเริ่มต้น)
            /// </summary>
            public TimeSpan? FromAppointmentTime { get; set; }
            /// <summary>
            /// เวลาที่นัดหมาย (เวลาสิ้นสุด)
            /// </summary>
            public TimeSpan? ThruAppointmentTime { get; set; }
            /// <summary>
            /// หมายเหตุ
            /// </summary>
            public string Remark { get; set; }
        }


        /// <summary>
        /// ข้อมูลการนัดหมายโดย CS
        /// </summary>
        public class CS_Info
        {
            /// <summary>
            /// APPOINT_TIME, NVARCHAR2(3)
            /// </summary>
            public string AppointTime { get; set; }
            /// <summary>
            /// APPOINT_OTHER, ใช้ประกอบกับ APPOINT_TIME
            /// </summary>
            public string AppointOther { get; set; }
            /// <summary>
            /// APPOINT_STAT
            /// </summary>
            /// <remarks>
            /// เท่าที่ดูข้อมูลบน server เหมือนจะเป็น Y/N
            /// </remarks>
            public bool AppointStat { get; set; }
            /// <summary>
            /// APPOINT_NOTE, ใช้ประกอบกับ APPOINT_STAT
            /// </summary>
            public string Remark { get; set; }

            //// ไม่ใช้ เพราะไม่เข้าใจ เห็นข้อมูลบน server มีแต่ 1 หมดเลย
            //public int AppointSelect { get; set; }
        }
    }
}

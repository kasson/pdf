using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class AppraisalArchive
    {
        public AppraisalArchiveHeader Header { get; set; }

        public IEnumerable<AppraisalArchiveImage> Images { get; set; }

        public GridSaleSurvey SurveyOfC { get; set; }

        public IEnumerable<GridSaleSurvey> Surveys { get; set; }

        public IEnumerable<AppraisalArchiveFormData> Data { get; set; }

        /// <summary>
        /// รายการงานนัดหมาย
        /// </summary>
        //public IEnumerable<WS_AppointmentsModel> Appointments { get; set; }
        public IEnumerable<Appointment> Appointments { get; set; }

        /// <summary>
        /// รายการข้อมูล CS offline
        /// </summary>
        public IEnumerable<Menu_CSofflineModel> CsOfflines { get; set; }
    }

    /// <summary>
    /// รหัสธนาคาร, ประเภทสินเชื่อ, ประเภทหลักประกัน (เก่า-ใหม่), รหัสเรื่อง, รหัสแบบฟอร์มประเมิน, สถานะงาน, รหัสฝ่าย, เลขใบคำขอ, ประเภทหลักประกัน, รหัสศูนย์ PA, รหัสประเภททรัพย์สิน, รหัสลักษณะงาน
    /// </summary>
    public class AppraisalArchiveHeader
    {
        /// <summary>
        /// เลขรหัสธนาคาร
        /// </summary>
        public string AppNo { get; set; }//
        /// <summary>
        /// วันที่ใบสมัคร
        /// </summary>
        public DateTime AppDate { get; set; }//
        /// <summary>
        /// เลขที่ใบคำขอ
        /// </summary>
        public string ReqNo { get; set; }//        
        /// <summary>
        /// วันที่ใบคำขอ
        /// </summary>
        public DateTime ReqDate { get; set; }//                
        /// <summary>
        /// ฝ่าย
        /// </summary>
        public String DeptID { get; set; }//        
        /// <summary>
        /// ประเภทหลักประกัน
        /// </summary>
        public String JobType { get; set; } //
        /// <summary>
        /// หน่วยงานธนาคาร
        /// </summary>
        public String BankBranchID { get; set; }//
        /// <summary>
        /// ประเภทสินเชื่อ
        /// </summary>
        public String BcreditID { get; set; }//
        /// <summary>
        /// ประเภทงาน
        /// </summary>
        public String CreditID { get; set; }
        /// <summary>
        /// รหัสประเภททรัพย์สิน
        /// </summary>
        public String CollatGrpID { get; set; }
        /// <summary>
        /// ลักษณะงาน
        /// </summary>
        public String CollatID { get; set; }
        /// <summary>
        /// รหัสเรื่อง
        /// </summary>
        public String JobNo { get; set; }//        
        /// <summary>
        /// วันที่ออกรหัสเรื่อง
        /// </summary>
        public DateTime JobDate { get; set; }//   
        /// <summary>
        /// รหัสเรื่องเดิม (มาจากตาราง CAT0051 จากฝั่ง Server)
        /// </summary>
        public String OldJobNo { get; set; }
        /// <summary>
        /// ศูนย์ PA
        /// </summary>
        public String HubID { get; set; }//        
        /// <summary>
        /// รหัสแบบสำรวจ
        /// </summary>
        public String FormID { get; set; }//
        /// <summary>
        /// สถานะงาน 1-9
        /// </summary>
        public String StatusReq { get; set; }//
        /// <summary>
        /// เจ้าหน้าที่ผู้ประเมิน (มาจากตาราง CAT0021 จากฝั่ง Server)
        /// </summary>
        public String OwnerEmpID { get; set; }
        /// <summary>        
        /// SLA(PAC)
        /// </summary>
        public int PAC_SLA { get; set; }
        /// <summary>
        /// SLA(Bank)
        /// </summary>
        public int Bank_SLA { get; set; }

        public AppraisalArchiveBank BankDatas { get; set; }

        public AppraisalArchiveAssessor Assessors { get; set; }

        public AppraisalArchivePrimaryAppointment PrimaryAppointments { get; set; }
    }

    public class AppraisalArchiveFormData
    {
        public string Code { get; set; }
        public object FormData { get; set; }
    }

    public class AppraisalArchiveImage
    {
        // On server
        public string ServerPath { get; set; }  // image path
        public string ServerName { get; set; }  // image name
        // On tablet
        public string LocalPath { get; set; }
    }
}

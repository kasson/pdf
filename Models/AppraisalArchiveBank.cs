using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    /// <summary>
    /// ข้อมูลเบื้องต้นจากเจ้าหน้าที่ CS, ข้อมูลติดต่อธนาคาร
    /// </summary>
    public class AppraisalArchiveBank
    {
        #region ------------------------ผู้ขอประเมิน
        /// <summary>
        /// เลขที่ใบ Payin
        /// </summary>
        public String PayinNo { get; set; }//      
        /// <summary>
        /// ชื่อลูกค้า
        /// </summary>
        public String CustName { get; set; }//
        /// <summary>
        /// บ้านเลขที่
        /// </summary>
        public String CustAddress { get; set; }//
        /// <summary>
        /// หมู่
        /// </summary>
        public String CustMoo { get; set; }//
        /// <summary>
        /// ซอย
        /// </summary>
        public String CustSoi { get; set; }//
        /// <summary>
        /// ถนน
        /// </summary>
        public String CustRoad { get; set; }//
        /// <summary>
        /// รหัสไปรษณีย์
        /// </summary>
        public String CustZipcode { get; set; }
        /// <summary>
        /// เบอร์โทร
        /// </summary>
        public String CustPhone { get; set; }
        /// <summary>
        /// ครั้งที่ทบทวน
        /// </summary> 
        public String ReworkNo { get; set; }

        /// <summary>
        /// ตำบล
        /// </summary>
        public int TambolID { get; set; }//
        /// <summary>
        /// อำเภอ
        /// </summary>
        public int AmphurID { get; set; }//
        /// <summary>
        /// จังหวัด
        /// </summary>
        public int ProvinceID { get; set; }//

        public ThaiLocation Location { get; set; }

        #endregion

        #region -------------------------ธนาคาร

        /// <summary>
        /// เอกสารส่งกลับที่
        /// </summary>
        public String ReturnAppTo { get; set; }//
        /// <summary>
        /// ผู้ส่งเรื่อง
        /// </summary>
        public String AppContactName { get; set; }//
        /// <summary>
        /// เบอร์โทรติดต่อผู้ส่งเรื่อง
        /// </summary>
        public String AppContactPhone { get; set; }//
        /// <summary>
        /// เลขที่ลูกหนี้
        /// </summary>
        public String BankCustNo { get; set; }//
        /// <summary>
        /// อีเมล์ธนาคาร
        /// </summary>
        public String BankEmail { get; set; }//
        #endregion

        #region ----------------------------------Call Service
        /// <summary>
        /// หมายเหตุ จาก CS
        /// </summary>
        public String CSNote { get; set; }//        
        #endregion
    }
}

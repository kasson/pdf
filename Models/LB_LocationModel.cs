using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class LB_LocationModel
    {
        /// <summary>
        /// เลขที่ใบคำขอ
        /// </summary>
        public String ReqNo { get; set; }
        /// <summary>
        /// เลขที่รหัสเรื่อง
        /// </summary>
        public String JobNo { get; set; }

        /// <summary>
        /// รหัสประเภทหนังสือสำคัญ (จาก CAT0012)
        /// </summary>
        public String DoctypeID { get; set; }
        /// <summary>
        /// หมู่บ้าน/โครงการ
        /// </summary>
        public String CollatNameChoice { get; set; }
        /// <summary>
        /// รายละเอียดราคากลางกรมที่ดิน
        /// </summary>
        public String CollatDetail { get; set; }
        /// <summary>
        /// ราคาประเมิน(บาท/ตร.ม.)
        /// </summary>
        public Double TotalCollatPrice { get; set; }
        /// <summary>
        /// ที่ตั้งทรัพย์สิน
        /// </summary>
        public int LocationType { get; set; }
        /// <summary>
        /// เลขที่
        /// </summary>
        public String AddressNumber { get; set; }
        /// <summary>
        /// ติดอยู่กับ
        /// </summary>        
        public String Nearby { get; set; }
        /// <summary>
        /// หมู่บ้าน
        /// </summary>
        public String CollatAddr { get; set; }
        /// <summary>
        /// ซอย
        /// </summary>
        public String CollatSoi { get; set; }
        /// <summary>
        /// ถนน
        /// </summary>
        public String CollatRoad { get; set; }
        /// <summary>
        /// ถนนหลัก
        /// </summary>
        public String CollatMainRoad { get; set; }
        /// <summary>
        /// เลขถนนหลัก
        /// </summary>
        public String CollatMainRoadID { get; set; }
        /// <summary>
        /// กม.ที่
        /// </summary>
        public String AtKm { get; set; }
        /// <summary>
        /// ตั้งอยู่บนเกาะหรือไม่
        /// </summary>
        public bool IslandCheck { get; set; }
        /// <summary>
        /// ตั้งอยู่บนเกาะ
        /// </summary>
        public String Island { get; set; }
        /// <summary>
        /// ห่างจาก
        /// </summary>
        public String AwayFrom { get; set; }
        /// <summary>
        /// ไปทาง
        /// </summary>
        public String Toward { get; set; }

        ///// <summary>
        ///// รหัสจังหวัด
        ///// </summary>
        //public int ProvinceID { get; set; }
        ///// <summary>
        ///// รหัสอำเภอ
        ///// </summary>
        //public int AmphurID { get; set; }
        ///// <summary>
        ///// รหัสตำบล
        ///// </summary>
        //public int TambolID { get; set; }
        //public ThaiLocation Location { get; set; }

        /// <summary>
        /// ที่ดินห่างจากถนน ระยะทาง (เมตร)
        /// </summary>
        public Double CollatFarFrom { get; set; }
        /// <summary>
        /// รายละเอียดที่ตั้ง
        /// </summary>
        public String CollatAddrDetail { get; set; }
        /// <summary>
        /// สิทธิการใช้ทางเข้าออก
        /// </summary>
        public int CollatWalk { get; set; }
        /// <summary>
        /// ข้อจำกัดการใช้ประโยชน์ที่ดิน ตามพรบผังเมือง
        /// </summary>
        public int CollatRestrict { get; set; }
        /// <summary>
        /// รหัสวิธีการประเมิน
        /// </summary>
        public int ApproahID { get; set; }
        /// <summary>
        /// ละติจูดของที่ตั้งทรัพย์สิน
        /// </summary>
        public Double LbLatitude { get; set; }
        /// <summary>
        /// ลองจิจูดของที่ตั้งทรัพย์สิน
        /// </summary>
        public Double LbLongitude { get; set; }
        /// <summary>
        /// UTM ของที่ตั้งทรัพย์สิน
        /// </summary>
        public String LbUtm { get; set; }
        /// <summary>
        /// หมายเหตุ 1
        /// </summary>
        public String Note { get; set; }
        /// <summary>
        /// หมายเหตุ 2
        /// </summary>
        public String Note2 { get; set; }
        /// <summary>
        /// รวมจำนวนสิ่งปลูกสร้างทั้งหมด
        /// </summary>
        public Double TotalBldg { get; set; }
        /// <summary>
        /// รวมราคาประเมินสิ่งปลูกสร้างทั้งหมด
        /// </summary>
        public Double TotalBldgPrice { get; set; }
        /// <summary>
        /// รวมราคาประเมินที่ดินที่ทั้งหมด
        /// </summary>
        public Double TotalLandPrice { get; set; }
        /// <summary>
        /// คำอธิบายราคากลาง
        /// </summary>
        public String CollatNotePrice { get; set; }
        /// <summary>
        /// จำนวนแปลง
        /// </summary>
        public Double CollatQty { get; set; }
        /// <summary>
        /// ลำดับทรัพย์ในรายงานประเมิน
        /// </summary>
        public Double JobCollatSeq { get; set; }
    }
}

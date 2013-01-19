using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class LB_LanddocModel
    {
        public Guid? TabletID { get; set; }

        /// <summary>
        /// เลขที่ใบคำขอ
        /// </summary>
        public String ReqNo { get; set; }
        /// <summary>
        /// เลขที่รหัสเรื่อง
        /// </summary>
        public String JobNo { get; set; }
        /// <summary>
        /// แห่งที่ (เพื่อออกรหัสเรื่องที่)
        /// </summary>
        public String JobSeq { get; set; }
        /// <summary>
        /// หลักประกันใหม่ หรือหลักประกันเดิม
        /// </summary>
        public String CollatNewOld { get; set; }
        /// <summary>
        /// รวมเนื้อที่ทั้งหมด
        /// </summary>
        public Double CollatSpace { get; set; }

        /// <summary>
        /// ลำดับทรัพย์สินใน
        /// </summary>
        public int PageNo { get; set; }
        /// <summary>
        /// รหัสประเภทหนังสือสำคัญ (CAT0012)
        /// </summary>
        public String DoctypeID { get; set; }
        /// <summary>
        /// ชื่อประเภทหนังสือกรรมสิทธิ์ (หน้าสรุปราคา)
        /// </summary>
        public String DoctypeName { get; set; }
        /// <summary>
        /// อ้างอิง (หน้าสรุปราคา)
        /// </summary>
        public String Refference { get; set; }
        /// <summary>
        /// เลขที่หนังสือสำคัญ (เลขที่โฉนด เลขที่ นส3 etc.)
        /// </summary>
        public String CollatDocNo { get; set; }
        /// <summary>
        /// เลขที่ดิน
        /// </summary>        
        public String LandNo { get; set; }
        /// <summary>
        /// หน้าสำรวจ
        /// </summary>
        public String LandPage { get; set; }
        /// <summary>
        /// เล่ม/หน้า
        /// </summary>
        public String LandPageNo { get; set; }
        /// <summary>
        /// ระวาง
        /// </summary>
        public String LandRavang { get; set; }
        /// <summary>
        /// รหัสสภาพที่ดิน
        /// </summary>
        public int LandStateID { get; set; }
        /// <summary>
        /// บุริมสิทธิ์หรือภาระติดพัน
        /// </summary>
        public int LandResponse { get; set; }
        /// <summary>
        /// ผู้ถือกรรมสิทธิ์ที่ดิน
        /// </summary>
        public String LandOwner { get; set; }
        /// <summary>
        /// ชื่อผู้ทรงสิทธิ์
        /// </summary>
        public int LandRight { get; set; }
        /// <summary>
        /// ประเมินเฉพาะส่วน Y=แบ่งส่วนประเมิน, N=ประเมินทั้งหมด
        /// </summary>
        public bool PartialAssessment { get; set; }
        ///// <summary>
        ///// เนื้อที่ประเมิน (ไร่)
        ///// </summary>
        //[BindTo(Resource.Id.LandRai)]
        //public Double LandRai{ get; set; }
        ///// <summary>
        ///// เนื้อที่ประเมืน (งาน)
        ///// </summary>
        //[BindTo(Resource.Id.LandNgan)]
        //public Double LandNgan { get; set; }
        /// <summary>
        /// เนื้อที่ประเมิน (วา)
        /// </summary>
        ///         
        public Double LandWah { get; set; }
        ///// <summary>
        ///// เนื้อที่ทั้งหมด (ไร่)
        ///// </summary>
        //public Double TotalRai { get; set; }
        ///// <summary>
        ///// เนื้อที่ทั้งหมด (งาน)
        ///// </summary>
        //public Double TotalNgan { get; set; }
        /// <summary>
        /// เนื้อที่ทั้งหมด (ตรว.)
        /// </summary>
        public Double TotalWah { get; set; }
        ///// <summary>
        ///// จังหวัดที่ตั้งตามโฉนด
        ///// </summary>
        //public int LandProvinceID { get; set; } 
        ///// <summary>
        ///// อำเภอที่ตั้งตามโฉนด
        ///// </summary>
        //[BindTo(Resource.Id.LandAmphurID, ElementType = typeof(AmphurDataLists))]
        //public int LandAmphurID { get; set; }
        ///// <summary>
        ///// ตำบลที่ตั้งตามโฉนด
        ///// </summary>
        //[BindTo(Resource.Id.LandTambolID, ElementType = typeof(TambolDataLists))]
        //public int LandTambolID { get; set; }
        //[BindTo(Resource.Id.ThaiLocation, Hint = "tambol")]
        //public ThaiLocation LocationTH { get; set; }
        /// <summary>
        /// ราคากลางกรมที่ดิน
        /// </summary>
        public Double CollatStdPrice { get; set; }
        /// <summary>
        /// ราคาต่อตารางวา
        /// </summary>
        public Double CollatUnitPrice { get; set; }
        /// <summary>
        /// ราคาประเมิน
        /// </summary>
        public Double TotalCollatPrice { get; set; }
        /// <summary>
        /// หมายเหตุต่อเอกสารสิทธิ์
        /// </summary>
        public String Note { get; set; }
        /// <summary>
        /// เลือกพิกัดเป็นพิกัดทรัพย์สิน
        /// </summary>
        public bool CoordinatesCheck { get; set; }
        /// <summary>
        /// ละติจูดของกรรมสิทธิ์
        /// </summary>
        public Double LanddocLatitude { get; set; }
        /// <summary>
        /// ลองจิจูดของกรรมสิทธิ์
        /// </summary>
        public Double LanddocLongitude { get; set; }
        /// <summary>
        /// UTM ของกรรมสิทธิ์
        /// </summary>
        public String LanddocUtm { get; set; }

        /// <summary>
        /// รหัสประเภททรัพย์สิน
        /// </summary>
        public String CollatGrpID { get; set; }
        /// <summary>
        /// รหัสลักษณะงาน
        /// </summary>
        public String CollatID { get; set; }
        /// <summary>
        /// จำนวนทรัพย์สิน
        /// </summary>
        public Double CollatQty { get; set; }
        /// <summary>
        /// LAND_TOTAL
        /// </summary>
        public String LandTotal { get; set; }
        /// <summary>
        /// กลุ่มที่
        /// </summary>
        public int PriceGroupNo { get; set; }
        /// <summary>
        /// ลำดับหลักประกัน
        /// </summary>
        public int GauranteeOrderNo { get; set; }
        /// <summary>
        /// พื้นที่ ไร่-งาน-วา
        /// </summary>
        public String PriceSpace { get { return ((int)LandWah / 400).ToString() + "-" + ((int)(LandWah - ((int)(LandWah / 400) * 400)) / 100).ToString() + "-" + (LandWah % 100).ToString() + "ไร่"; } set { } }
        //public String PriceSpace { get; set; }

    }
}

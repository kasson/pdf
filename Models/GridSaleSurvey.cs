using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    // Creator
    partial class GridSaleSurvey
    {
        public static GridSaleSurvey Create()
        {
            return new GridSaleSurvey()
            {
                Images = new List<AppraisalArchiveImage>(),
            };
        }
    }

    /// <summary>
    /// ข้อมูลที่ได้จากการสำรวจเพื่อนำไปประกอบ Grid sale
    /// i.e. ข้อมูลของ S# ทั้งหลายนั่นเอง
    /// </summary>
    public partial class GridSaleSurvey
    {
        /// <summary>
        /// Unique identifier to IDENTIFY S#.
        /// </summary>
        public Guid SID { get; set; }

        /// <summary>
        /// ภาพของ S#
        /// </summary>
        public IEnumerable<AppraisalArchiveImage> Images { get; set; }




        /// <summary>
        /// แหล่งข้อมูล
        /// </summary>
        /// <value>
        /// 1 - ประกาศขาย
        /// 2 - ซื้อขาย
        /// 3 - สอบถาม
        /// </value>
        public int InformationSource { get; set; }

        /// <summary>
        /// สอบถามจาก (ชื่อผู้ให้ข้อมูล)
        /// </summary>
        public string Informant { get; set; }

        /// <summary>
        /// เบอร์โทร (ของผู้ให้ข้อมูล)
        /// </summary>
        public string InformantPhoneNo { get; set; }

        /// <summary>
        /// วันที่ซื้อขาย / สอบถาม
        /// </summary>
        public DateTime? InformDate { get; set; }

        /// <summary>
        /// ราคาเสนอขาย (บาท)
        /// </summary>
        public double? ProposePrice { get; set; }

        /// <summary>
        /// ราคาเหมาะสม (บาท)
        /// </summary>
        public double? AppropriatePrice { get; set; }

        /// <summary>
        /// ประเภททรัพย์ (โดยอ้างจาก CollatGroup)
        /// </summary>
        public string CollatGroupID { get; set; }

        /// <summary>
        /// รูปร่างทรัพย์สิน
        /// </summary>
        public string AssetShape { get; set; }

        /// <summary>
        /// ขนาดความกว้าง (ม.)
        /// </summary>
        public int? Width { get; set; }
        /// <summary>
        /// ขนาดความยาว (ม.)
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// สภาพเก่า-ใหม่
        /// </summary>
        /// <value>
        /// 1 - เก่า
        /// 2 - ปานกลาง
        /// 3 - ใหม่
        /// </value>
        public int? HowNew { get; set; }

        /// <summary>
        /// มีส่วนติดทางเข้า-ออก (ม.)
        /// </summary>
        public int StreetSideWidth { get; set; }

        /// <summary>
        /// เนื้อที่ (เป็น ตร.วา) นำไปแสดงผลในหน่วยไร่ x-x-xx
        /// </summary>
        public double AreaSqWa { get; set; }

        /// <summary>
        /// เนื้อที่ (เป็น ตร.ม.) ใช้แทนเนื้อที่ ตร.วา ในบางกรณี
        /// </summary>
        public double? AreaSqM { get; set; }

        /// <summary>
        /// อยู่ในโครงการจัดสรรเดียวกับทรัพย์สิน (C) หรือไม่
        /// </summary>
        public bool IsSameHousingEstate { get; set; }





        /*
         * ข้อมูล สภาพแวดล้อม  / ทำเลที่ตั้ง
         */

        /// <summary>
        /// ทำเลที่ตั้งติดถนนหลัก หรือ อยู่ในซอย
        /// </summary>
        /// <value>
        /// 5 - ถนนซอยย่อย
        /// 10 - ถนนซอย
        /// 15 - ติดถนนหลัก
        /// </value>
        public int HowCloseToMainStreet { get; set; }

        /// <summary>
        /// ระยะห่างจากถนนหลัก (ม.)
        /// </summary>
        public int? DistanceFromMainStreet { get; set; }

        /// <summary>
        /// ที่อยู่ (เลขที่)
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// ซอย
        /// </summary>
        public string Soi { get; set; }
        /// <summary>
        /// ถนน
        /// </summary>
        /// <example>ศรีจันทร์</example>
        public string Road { get; set; }
        /// <summary>
        /// ชื่อถนนหลัก, ในกรณีตั้งอยู่บนถนนที่แยกจากถนนหลัก
        /// </summary>
        /// <example>มิตรภาพ (ทล.2)</example>
        public string MainStreet { get; set; }

        /// <summary>
        /// ทำเล เหมาะสำหรับประกอบกิจการอะไร
        /// </summary>
        /// <example>
        /// ทำเลเกษตรกรรม
        /// ทำเลพานิชยกรรม
        /// </example>
        public int SuitablePlaceForID { get; set; }

        /// <summary>
        /// ความหนาแน่นของประชากร
        /// </summary>
        /// <value>
        /// 3 - มาก
        /// 2 - ปานกลาง
        /// 1 - น้อย
        /// </value>
        public int PopulationDensity { get; set; }

        // ปัจจัยบวกด้านสภาพแวดล้อม

        /// <summary>
        /// แปลงมุม
        /// </summary>
        public bool PlusCorner { get; set; }
        /// <summary>
        /// ห้องมุม
        /// </summary>
        public bool PlusCornerRoom { get; set; }
        /// <summary>
        /// แปลงริม
        /// </summary>
        public bool PlusEdge { get; set; }
        /// <summary>
        /// ย่านชุมชนดีกว่า
        /// </summary>
        public bool PlusGoodCommunity { get; set; }
        /// <summary>
        /// ติดสวนสาธารณะ
        /// </summary>
        public bool PlusNearByPark { get; set; }
        /// <summary>
        /// ติดทะเลสาบ
        /// </summary>
        public bool PlusNearByLake { get; set; }
        /// <summary>
        /// ชั้นล่างค้าขายได้
        /// </summary>
        public bool PlusCanDoBusiness { get; set; }
        /// <summary>
        /// ชั้นบนภูมิทัศน์ดีกว่า
        /// </summary>
        public bool PlusHasBetterHighView { get; set; }

        // ปัจจัยลบด้านสภาพแวดล้อม

        /// <summary>
        /// อยู่ตรงทางสามแพร่ง
        /// </summary>
        public bool MinusThreeWayJunction { get; set; }
        /// <summary>
        /// ใกล้แหล่งมลภาวะ
        /// </summary>
        public bool MinusPollution { get; set; }
        /// <summary>
        /// ย่านชุมชนด้อยค่า
        /// </summary>
        public bool MinusSlum { get; set; }
        /// <summary>
        /// การใช้ประโยชน์ด้อยค่าอื่น ๆ
        /// </summary>
        public bool MinusOther { get; set; }

        /// <summary>
        /// ระบุการใช้ประโยชน์ด้อยค่าอื่น ๆ, กรณีเลือกการใช้ประโยชน์ด้อยค่าอื่น ๆ
        /// </summary>
        public string MinusOtherText { get; set; }

        /// <summary>
        /// องค์ประกอบราคา 1 (0-25%) สภาพแวดล้อม / ทำเลที่ตั้ง
        /// </summary>
        public int FactorLocation { get; set; }





        /*
         * ลักษณะและสภาพทรัพย์สิน
         */

        /// <summary>
        /// ลักษณะและสภาพทรัพย์สิน
        /// </summary>
        public string AssetCondition { get; set; }

        /// <summary>
        /// ราคาถมที่ (บาท) (ถ้ามี)
        /// </summary>
        public double? ReclamationSpending { get; set; }

        /// <summary>
        /// องค์ประกอบราคา 2 (0-20%) ลักษณะและสภาพทรัพย์สิน
        /// </summary>
        public int FactorCondition { get; set; }





        /*
         * ทางเข้า-ออก
         */

        /// <summary>
        /// ทางเข้า-ออก
        /// </summary>
        public int RoadTypeID { get; set; }

        /// <summary>
        /// ความกว้างของทางเข้า-ออก (ม.)
        /// </summary>
        public int RoadWidth { get; set; }

        /// <summary>
        /// สภาพถนน
        /// True - สภาพดี
        /// False - สภาพชำรุด
        /// </summary>
        public bool RoadCondition { get; set; }

        /// <summary>
        /// มีท่อระบายน้ำ
        /// </summary>
        public bool HasDrain { get; set; }

        /// <summary>
        /// องค์ประกอบราคา 3 (0-15%) สภาพทางเข้า-ออก
        /// </summary>
        public int FactorRoad { get; set; }





        /*
         * ระบบสาธารณูปโภค
         */

        /// <summary>
        /// มีระบบสาธารณูปโภค
        /// </summary>
        public bool HasInfrastructure { get; set; }

        /// <summary>
        /// มีไฟฟ้า
        /// </summary>
        public bool HasElectricity { get; set; }
        /// <summary>
        /// มีโทรศัพท์ พื้นฐาน
        /// </summary>
        public bool HasTelephone { get; set; }
        /// <summary>
        /// มีประปา
        /// </summary>
        public bool HasWater { get; set; }
        /// <summary>
        /// มีน้ำบาดาล
        /// </summary>
        public bool HasGroundWater { get; set; }
        /// <summary>
        /// มีระบบรักษาความปลอดภัย
        /// </summary>
        public bool HasSecurity { get; set; }

        /// <summary>
        /// ระยะห่างจากจุดสิ้นสุดสาธารณูปโภค (ม.), กรณีไม่มีสาธารณูปโภค
        /// </summary>
        public int? DistanceFromInfrastructure { get; set; }

        /// <summary>
        /// องค์ประกอบราคา 4 (0-15%) ระบบสาธารณูปโภค
        /// </summary>
        public int FactorInfrastructure { get; set; }





        /*
         * ข้อจำกัด และ การใช้ประโยชน์
         */

        /// <summary>
        /// ระบุข้อจำกัดการใช้ประโยชน์ (รวมทั้งระบุว่าไม่มีด้วย)
        /// </summary>
        public int AssetRestrictionID { get; set; }

        /// <summary>
        /// ปัจจุบันมีการใช้ประโยชน์
        /// </summary>
        public bool IsUtilizing { get; set; }

        /// <summary>
        /// องค์ประกอบราคา 5 (0-10%) ข้อจำกัดการใช้ประโยชน์
        /// </summary>
        public int FactorRestriction { get; set; }






        /*
         * สภาพคล่องในการซื้อขาย เปลี่ยนมือ
         */

        /// <summary>
        /// สภาพคล่องในการซื้อขาย เปลี่ยนมือ ของทรัพย์สิน
        /// </summary>
        /// <value>
        /// 5 - ต่ำ
        /// 10 - ปานกลาง
        /// 15 - สูง
        /// </value>
        public int AssetLiquidity { get; set; }

        /// <summary>
        /// เหตุผลประกอบ
        /// </summary>
        public string AssetLiquidityReason { get; set; }

        /// <summary>
        /// องค์ประกอบราคา 6 (0-15%) สภาพคล่องในการซื้อขายเปลี่ยนมือ
        /// </summary>
        public int FactorLiquidity { get; set; }




        /*
         * ประกอบ และ สรุป
         */

        /// <summary>
        /// หมายเหตุ
        /// </summary>
        public string Remark { get; set; }

        // คำนวณราคา

        /// <summary>
        /// ละติจูด
        /// </summary>
        public string GridsaleSurveyLatitude { get; set; }

        /// <summary>
        /// ลองติจูด
        /// </summary>
        public string GridsaleSurveyLongitude { get; set; }

    }
}

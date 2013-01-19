using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class LB_BuildingModel
    {
        public Guid? TabletID { get; set; }

        /// <summary>
        /// ลำดับสิ่งปลูกสร้าง
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// สิ่งปลูกสร้างหมายเลข
        /// </summary>
        public string BldgNo { get; set; }

        /// <summary>
        /// เลขที่บ้าน
        /// </summary>
        public string BldgAddr { get; set; }
        /// <summary>
        /// โฉนดเลขที่
        /// </summary>
        public string CollatNo { get; set; }
        /// <summary>
        /// กรรมสิทธิ์ของ
        /// </summary>
        public string BldgOwner { get; set; }
        /// <summary>
        /// A สป.จำนวนหน่วย
        /// </summary>
        public Double BldgQty { get; set; }
        /// <summary>
        /// สภาพ สป.
        /// </summary>
        public String BldgCondition { get; set; }
        /// <summary>
        /// อายุ สป. เพื่อคำนวณ
        /// </summary>
        public Double BldgAge { get; set; }
        /// <summary>
        /// B พื้นที่รวม(ตร.ม.)
        /// </summary>
        public Double BldgSpace
        {
            get
            {
                if (LandBuildingMaterial.Count() != 0)
                {
                    return LandBuildingMaterial.Sum(it => it.RoomLength * it.RoomWidth);
                }
                return 0;
            }

            set { }
        }
        //[BindTo(Resource.Id.BldgPriceM)]
        /// <summary>
        /// G ราคา ตร.ม.ละ(=A-F-E)
        /// </summary>
        public Double BldgPriceM { get; set; }
        /// <summary>
        /// ราคารวมต่อตารางวา
        /// </summary>
        public Double UnitCost { get; set; }
        /// <summary>
        /// ราคารวม
        /// </summary>
        public Double TotalCost { get; set; }
        /// <summary>
        /// H เป็นเงิน(บาท)(=B*G)
        /// </summary>
        public Double BldgTotalAmt { get; set; }
        /// <summary>
        /// A*B ค่าก่อสร้างในปัจจุบัน
        /// </summary>
        //[BindTo(Resource.Id.BldgCost)]
        public Double BldgCost { get; set; }
        /// <summary>
        /// A ค่าก่อสร้างในปัจจุบัน/ตรม.
        /// </summary>
        public Double BldgCostM { get; set; }
        /// <summary>
        /// D %ค่าเสื่อมราคาปีละ
        /// </summary>
        public Double BldgDeprePercent { get; set; }
        /// <summary>
        /// F*D ค่าเสื่อมราคาทั้งสิ้น (บาท)
        /// </summary>
        public Double BldgDepreAmt { get; set; }
        /// <summary>
        /// F ค่าเสื่อมราคาทั้งสิ่น (บาท)
        /// </summary>
        public Double BldgDepreAmtM { get; set; }
        /// <summary>
        /// อยู่ระหว่างก่อสร้าง
        /// </summary>
        public string BuidingStage { get; set; }
        /// <summary>
        /// ก่อสร้างแล้วกี่เปอร์เซ็น
        /// </summary>
        public Double BuidingPercent { get; set; }
        /// <summary>
        /// E * B ปรับค่ารบกวนเนื่องจากสาเหตุอื่นๆ
        /// </summary>
        public Double BldgAdjAmt { get; set; }
        /// <summary>
        /// E ปรับค่ารบกวนเนื่องจากสาเหตุอื่นๆ/ตรม.
        /// </summary>
        public Double BldgAdjM { get; set; }
        /// <summary>
        /// หมายเหตุ
        /// </summary>
        public string BldgNote { get; set; }
        /// <summary>
        /// ประเภทอาคาร
        /// </summary>
        public int BldgType { get; set; }
        /// <summary>
        /// เนื่องจาก
        /// </summary>        
        //[BindTo(Resource.Id.As, ElementType = typeof(BuildingAsDataLists))]
        //public int As { get; set; }
        /// <summary>
        /// ประเภทอาคารที่ใช้ประเมินมูลค่าทรัพย์สิน
        /// </summary>
        public int BuildingToAssessmentType { get; set; }
        /// <summary>
        /// คิดมูลค่าอาคารเป็นหน่วย YES = ใช่, NO = ไม่ใช่
        /// </summary>
        //[BindTo(Resource.Id.CalcUnit)]
        public string CalcUnit { get; set; }
        /// <summary>
        /// พื้นที่โดยผู้ประเมิน
        /// </summary>
        public Double ManualBldgSpace { get; set; }
        /// <summary>
        /// พื้นที่โดยผู้ประเมิน (หน้าสรุปราคา)
        /// </summary>
        public String BuildingManualSpace { get { return ManualBldgSpace.ToString() + "ตร.ม."; } set { } }
        /// <summary>
        /// C สร้างมาแล้วกี่ปี
        /// </summary>
        public Double BldgAgeCalc { get; set; }
        /// <summary>
        /// จำนวนชั้น
        /// </summary>
        public int NumFloor { get; set; }
        /// <summary>
        /// มีชั้นลอย  Y = มีชั้นลอย, N = ไม่มี
        /// </summary>
        public bool FloatingFloor { get; set; }
        /// <summary>
        /// สิ่งปลูกสร้างย่อย
        /// </summary>
        public Double BldgSubNo { get; set; }
        /// <summary>
        /// Y = 2PAGE, N=1PAGE
        /// </summary>
        //[BindTo(Resource.Id.NumBldg)]
        public string NumBldg { get; set; }

        /// <summary>
        /// เลือกคำนวณรอนสิทธิ์
        /// </summary>
        public bool DepriveCalculation { get; set; }
        /// <summary>
        /// ค่าก่อสร้างหักค่าเสื่อมแล้ว
        /// </summary>
        public Double BldgReducePrice { get; set; }
        /// <summary>
        /// อายุสิ่งปลูกสร้าง(ปี)
        /// </summary>
        public int BuidingLive { get; set; }
        /// <summary>
        /// อายุการใช้งาน(ปี)
        /// </summary>
        public int BuidingAge { get; set; }
        /// <summary>
        /// อายุสัญญาเช่าที่เหลือ
        /// </summary>ห
        public int BalanceLeaseAge { get; set; }
        /// <summary>
        /// มูลค่าทรัพย์สินต่อตารางเมตร (รอนสิทธิ์)
        /// </summary>
        public Double LeaseUnitPrice { get; set; }
        /// <summary>
        /// สถานที่ใช้เป็น
        /// </summary>
        public String LandUseTo { get; set; }
        /// <summary>
        /// โครงสร้าง คสล.
        /// </summary>
        public bool BldgStructure { get; set; }
        /// <summary>
        /// โครงสร้าง ไม้
        /// </summary>
        public bool WoodStructure { get; set; }
        /// <summary>
        /// โครงสร้าง เหล็ก
        /// </summary>
        public bool SteelStructure { get; set; }
        /// <summary>
        /// โครงสร้าง อื่นๆ
        /// </summary>
        public bool OtherStructure { get; set; }
        /// <summary>
        /// รายละเอียดอื่นๆของโครงสร้าง
        /// </summary>
        public String OtherStructureNote { get; set; }
        /// <summary>
        /// คำนวนสูตร สป.
        /// </summary>
        //[BindTo(Resource.Id.BuidingCal)]
        public String BuildingCal { get; set; }
        /// <summary>
        /// เสา คสล.
        /// </summary>
        public bool BldgPillar { get; set; }
        /// <summary>
        /// เสา ไม้
        /// </summary>
        public bool WoodPillar { get; set; }
        /// <summary>
        /// เสา เหล็ก
        /// </summary>
        public bool SteelPillar { get; set; }
        /// <summary>
        /// เสา อื่นๆ
        /// </summary>
        public bool OtherPillar { get; set; }
        /// <summary>
        /// รายละเอียดอื่นๆของเสา
        /// </summary>
        public String OtherPillarNote { get; set; }
        /// <summary>
        /// โครงหลังคา คสล.
        /// </summary>
        public bool BldgCover { get; set; }
        /// <summary>
        /// โครงหลังคา ไม้
        /// </summary>
        public bool WoodCover { get; set; }
        /// <summary>
        /// โครงหลังคา เหล็ก
        /// </summary>
        public bool SteelCover { get; set; }
        /// <summary>
        /// โครงหลังคา อื่นๆ
        /// </summary>
        public bool OtherCover { get; set; }
        /// <summary>
        /// รายละเอียดอื่นๆของโครงหลังคา
        /// </summary>
        public String OtherCoverNote { get; set; }
        /// <summary>
        /// วัสดุมุง คสล.
        /// </summary>
        public bool BldgRoof { get; set; }
        /// <summary>
        /// วัสดุมุง กระเบื้องลอนคู่
        /// </summary>
        public bool TwoTileRoof { get; set; }
        /// <summary>
        /// วัสดุมุง กระเบื้องซีแพค
        /// </summary>
        public bool CpagRoof { get; set; }
        /// <summary>
        /// วัสดุมุง กระเบื้องราง
        /// </summary>
        public bool RangRoof { get; set; }
        /// <summary>
        /// วัสดุมุง เหล็กเคลือบรีดลอน
        /// </summary>
        public bool CoateSteelRoof { get; set; }
        /// <summary>
        /// วัสดุมุง สังกะสี
        /// </summary>
        public bool ZingRoof { get; set; }
        /// <summary>
        /// วัสดุมุง วัสดุโปร่งแสง
        /// </summary>
        public bool LightRoof { get; set; }
        /// <summary>
        /// วัสดุมุง อื่นๆ
        /// </summary>
        public bool OtherRoof { get; set; }
        /// <summary>
        /// รายละเอียดอื่นๆวัสดุมุง
        /// </summary>
        public String OtherRoofNote { get; set; }
        /// <summary>
        /// ฝ้าเพดาน ยิบซั่มบอร์ด
        /// </summary>
        public bool GypsumCeiling { get; set; }
        /// <summary>
        /// ฝ้าเพดาน กระเบื้องแผ่นเรียบ
        /// </summary>
        public bool SmoothCeiling { get; set; }
        /// <summary>
        /// ฝ้าเพดาน ไม้อัด
        /// </summary>
        public bool PlyWoodCeiling { get; set; }
        /// <summary>
        /// ฝ้าเพดาน อื่นๆ
        /// </summary>
        public bool OtherCeiling { get; set; }
        /// <summary>
        /// รายละเอียดอื่นๆฝ้าเพดาน
        /// </summary>
        public String OtherCeilingNote { get; set; }
        /// <summary>
        /// ผนังภายนอก ฉาบปูนเรียบ
        /// </summary>
        public bool SmoothExWall { get; set; }
        /// <summary>
        /// ผนังภายนอก ก่ออิฐ/บล็อก
        /// </summary>
        public bool BlockExWall { get; set; }
        /// <summary>
        /// ผนังภายนอก โชว์แนว
        /// </summary>
        public bool ShowExWall { get; set; }
        /// <summary>
        /// ผนังภายนอก ไม้
        /// </summary>
        public bool WoodExWall { get; set; }
        /// <summary>
        /// ผนังภายนอก ทาสี
        /// </summary>
        public bool ColorExWall { get; set; }
        /// <summary>
        /// ผนังภายนอก ไม่ทาสี
        /// </summary>
        public bool NoColorExWall { get; set; }
        /// <summary>
        /// ผนังภายนอก กรวดล้าง
        /// </summary>
        public bool GravelExWall { get; set; }
        /// <summary>
        /// ผนังภายนอก อื่นๆ
        /// </summary>
        public bool OtherExWall { get; set; }
        /// <summary>
        /// รายละเอียดอื่นๆผนังภายนอก
        /// </summary>
        public String OtherExWallNote { get; set; }
        /// <summary>
        /// ผนังภายใน ฉาบปูนเรียบ
        /// </summary>
        public bool SmoothInWall { get; set; }
        /// <summary>
        /// ผนังภายใน ไม้อัด
        /// </summary>
        public bool WoodInWall { get; set; }
        /// <summary>
        /// ผนังภายใน ยิบซัมบอร์ด
        /// </summary>
        public bool GypsumInWall { get; set; }
        /// <summary>
        /// ผนังภายใน กระจก
        /// </summary>
        public bool MirrorInWall { get; set; }
        /// <summary>
        /// ผนังภายใน ทาสี
        /// </summary>
        public bool ColorInWall { get; set; }
        /// <summary>
        /// ผนังภายใน ไม่ทาสี
        /// </summary>
        public bool NoColorInWall { get; set; }
        /// <summary>
        /// ผนังภายใน วอลเปเปอร์
        /// </summary>
        public bool WallpaperInWall { get; set; }
        /// <summary>
        /// ผนังภายใน อื่นๆ
        /// </summary>
        public bool OtherInWall { get; set; }
        /// <summary>
        /// รายละเอียดอื่นๆผนังภายใน
        /// </summary>
        public String OtherInWallNote { get; set; }
        /// <summary>
        /// บันได คสล.
        /// </summary>
        public bool BldgStair { get; set; }
        /// <summary>
        /// บันได ไม้
        /// </summary>
        public bool WoodStair { get; set; }
        /// <summary>
        /// บันได เหล็ก
        /// </summary>
        public bool SteelStair { get; set; }
        /// <summary>
        /// บันได อื่นๆ
        /// </summary>
        public bool OtherStair { get; set; }
        /// <summary>
        /// รายละเอียดอื่นๆของบันได
        /// </summary>
        public String OtherStairNote { get; set; }
        /// <summary>
        /// กลุ่มที่
        /// </summary>
        public int BuildingPriceGroupNo { get; set; }
        /// <summary>
        /// เลขหลักประกัน
        /// </summary>
        public int BuildingGauranteeOrderNo { get; set; }
        /// <summary>
        /// รายการ (หน้าสรุปราคา)
        /// </summary>
        public String BldgTypeName { get; set; }

        public IEnumerable<LB_MaterialModel> LandBuildingMaterial { get; set; }





        /// <summary>
        /// ประเภทอาคาร
        /// </summary>
        public string Data01 { get; set; }
    }
    public class LB_MaterialModel
    {
        /// <summary>
        /// รายละเอียดสิ่งปลูกสร้าง
        /// </summary>
        public int FBuidingDetailLId { get; set; }
        /// <summary>
        /// ลำดับการพิมพ์
        /// </summary>
        public double Order { get; set; }
        /// <summary>
        /// ชั้นที่
        /// </summary>
        public string FloorId { get; set; }
        /// <summary>
        /// ห้อง/ขนาด/คำอธิบาย
        /// </summary>
        public string ConstructName { get; set; }
        /// <summary>
        /// หินแกรนิตใหญ่
        /// </summary>
        public string M1 { get; set; }
        /// <summary>
        /// หินแกรนิตเล็ก
        /// </summary>
        public string M2 { get; set; }
        /// <summary>
        /// หินอ่อนใหญ่
        /// </summary>
        public string M3 { get; set; }
        /// <summary>
        /// หินอ่อนเล็ก
        /// </summary>
        public string M4 { get; set; }
        /// <summary>
        /// ไม้
        /// </summary>
        public string M5 { get; set; }
        /// <summary>
        /// ไม้เข้าลิ้น
        /// </summary>
        public string M6 { get; set; }
        /// <summary>
        /// ไม้ปาร์เก้ใหญ่
        /// </summary>
        public string M7 { get; set; }
        /// <summary>
        /// ไม้ปาร์เก้เล็ก
        /// </summary>
        public string M8 { get; set; }
        /// <summary>
        /// หินขัด
        /// </summary>
        public string M9 { get; set; }
        /// <summary>
        /// กระเบื้องเคลือบใหญ่
        /// </summary>
        public string M10 { get; set; }
        /// <summary>
        /// กระเบื้องเคลือบเล็ก
        /// </summary>
        public string M11 { get; set; }
        /// <summary>
        /// กระเบื้องเคลือบโมเสค
        /// </summary>
        public string M12 { get; set; }
        /// <summary>
        /// กระเบื้องยาง
        /// </summary>
        public string M13 { get; set; }
        /// <summary>
        /// คสล.
        /// </summary>
        public string M14 { get; set; }
        /// <summary>
        /// อื่นๆ
        /// </summary>
        public string M15 { get; set; }
        /// <summary>
        /// ลำดับสิ่งปลูกสร้าง
        /// </summary>
        public int PageNo { get; set; }
        /// <summary>
        /// กว้าง
        /// </summary>
        public double RoomWidth { get; set; }
        /// <summary>
        /// ยาว
        /// </summary>
        public double RoomLength { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDFlibHelper.Models;

namespace PDFlibHelper
{
    public static class _Mock
    {
        public static AppraisalArchive AppraisalArchive
        {
            get
            {
                return new AppraisalArchive
                {
                    Appointments = new List<Appointment>
                        {
                            new Appointment{
                                AppointDate = DateTime.Now,
                            }
                        },
                    Header = new AppraisalArchiveHeader
                    {
                        BankDatas = new AppraisalArchiveBank
                        {
                            CustName = "นาย.พีรวัส พรหมเดชบุญ",
                            ReworkNo = "2",
                        },
                        JobNo = "5507574-1/1",
                        BankBranchID = "ทีมลูกค้าผู้ประกอบบการ 2 สุขุมวิท 33 (บางกะปิ)",
                        CreditID = "1", //อาจเป็น Spinner
                        OldJobNo = "4708051-1/1",
                        //EmpFirstName = "สกุล",
                        //EmpLastName = "จารุธนเศรษฐ์",
                        //EmpTitleName = "ดร",
                        //CollatGrp = "มินิแฟคทอรี่"
                    }
                };
            }
        }

        public static LB_WorksheetModel LB_WorksheetModel
        {
            get
            {
                return new LB_WorksheetModel
            {
                AbridgeImage = true,
                CheckPerfection = false,
                BatteryCharger = true,
                CheckCorrect = false,

                CheckBoxFlag01 = true,
                CheckBoxFlag02 = true,
                CheckBoxFlag03 = true,
                CheckBoxFlag04 = true,
                CheckBoxFlag05 = true,
                CheckBoxFlag06 = true,
                CheckBoxFlag07 = true,
                CheckBoxFlag08 = true,
                CheckBoxFlag09 = true,
                CheckBoxFlag10 = true,
                CheckBoxFlag11 = true,
                CheckBoxFlag12 = true,
                CheckBoxFlag13 = true,
                CheckBoxFlag14 = true,
                CheckBoxFlag15 = true,
                CheckBoxFlag16 = true,
                CheckBoxFlag17 = true,
                CheckBoxFlag18 = true,
                CheckBoxFlag19 = true,
                CheckBoxFlag20 = true,
                CheckBoxFlag21 = true,
                CheckBoxFlag22 = true,
                CheckBoxFlag23 = true,
                CheckBoxFlag24 = true,
                CheckBoxFlag25 = true,
                CheckBoxFlag26 = true,
                CheckBoxFlag27 = true,
            };
            }
        }

        public static LB_BuildingModel LB_BuildingModel
        {
            get
            {
                return new LB_BuildingModel
            {
                BldgNo = "1",
                BldgSubNo = 0,
                BldgAddr = "98/33",
                BldgType = 1,
                CollatNo = "",
                BldgOwner = "ไม่มีเอกสารแสดงกรรมสิทธิ์",
                BldgQty = 1,
                BldgAge = 20,

                BldgCost = 0.00,
                BldgCostM = 0.00,
                BldgDeprePercent = 3,
                BldgDepreAmt = 0.00,
                BldgDepreAmtM = 0.00,
                BldgAdjAmt = 0.00,
                BldgAdjM = 0.00,
                BldgStructure = true,
                WoodStructure = false,
                SteelStructure = false,
                OtherStructure = false,
                BldgPillar = false,
                WoodPillar = false,
                SteelPillar = false,
                OtherPillar = true,
                BldgCover = false,
                WoodCover = false,
                SteelCover = true,
                OtherCover = false,
                BldgRoof = false,
                TwoTileRoof = false,
                CpagRoof = false,
                RangRoof = false,
                CoateSteelRoof = false,
                ZingRoof = false,
                LightRoof = false,
                OtherRoof = false,
                GypsumCeiling = false,
                SmoothCeiling = false,
                PlyWoodCeiling = false,
                OtherCeiling = false,
                SmoothExWall = false,
                BlockExWall = false,
                ShowExWall = false,
                WoodExWall = false,
                ColorExWall = false,
                NoColorExWall = false,
                GravelExWall = false,
                OtherExWall = false,
                SmoothInWall = false,
                WoodInWall = false,
                GypsumInWall = false,
                MirrorInWall = false,
                ColorInWall = false,
                NoColorInWall = false,
                WallpaperInWall = false,
                OtherInWall = false,
                BldgStair = false,
                WoodStair = false,
                SteelStair = false,
                OtherStair = false,
                LandBuildingMaterial = new List<LB_MaterialModel>()
                {
                    new LB_MaterialModel(){
                        FloorId = "1",
                        ConstructName = "ขนาด",
                        RoomWidth = 5,
                        RoomLength = 9,
                        M1 = "42",
                        M2 = "75",
                        M3 = "42",
                        M4 = "2",
                        M5 = "45",
                        M6 = "15",
                        M7 = "100",
                        M8 = "4",
                        M9 = "4",
                        M10 = "4",
                        M11 = "4",
                        M13 = "4",
                        M14 = "4",
                        M15 = "..........................",
                    },
                    new LB_MaterialModel(){
                        FloorId = "2",
                        ConstructName = "ขนาด",
                        RoomWidth = 5,
                        RoomLength = 9,
                        M1 = "42",
                        M2 = "75",
                        M3 = "42",
                        M4 = "2",
                        M5 = "45",
                        M6 = "15",
                        M7 = "100",
                        M8 = "4",
                        M9 = "4",
                        M10 = "4",
                        M11 = "4",
                        M13 = "4",
                        M14 = "4",
                        M15 = "..........................",
                    },
                }
            };
            }
        }

        public static LB_FDetailsModel LB_FDetailsModel
        {
            get
            {
                return new LB_FDetailsModel
                {
                    AssessmentNote = string.Format(@"ในการประเมินครังนี้ บริษัทโพรเกรส แอไฟรซัล จำกัด เลือกใช้วิธีการประเมินมูลค่าที่เหมาะสมกับลักษณะของทรัพย์สิน คือ วิธีการเทียบราคาตลาด (Market Approach) เนื่องจากมีข้อมูลเปรียบเทียบกับราคาตลาดที่เหมาะสม ตามรายละเอียดที่ได้แสดงไว้ในเล่มรายงานประเมินนี้แล้วการวิเคราะห์ทรัพย์สินด้านการใช้ประโยชน์สูงสุดและดีที่สุด :ผู้ประเมินมูลค่าทรัพย์สินมีความเห็นว่าการใช้ประโยชน์สูงสุดและดีที่สุดของทรัพย์สินคือโรงงานอุตสาหกรรม"),
                    NoteS1 = string.Format(@"เป็นราราประกาศขายมินิแฟคทอรี่ 3 ชั้น เนื้อที่ 0-2-29 ไร่ ในราคา 9,990,000.-บาท เป็นราคาที่สามารถต่อรองได้ พิจารณาจากสภาพแวดล้อมและราคาตลาดในบริเวณใกล้เคียงแล้วเห็นว่าควรปรับลงเหลือราคาคูหาละ9,000,000.-บาท เพื่อให้เกิดสภาพคล่องในการซื้อ-ขาย (นำมาหาราคาที่ดิน S1 เนื้อที่ดิน 0-2-29 ไร่ พื้นที่ใช้สอย 1,060. ตร.ม. ราคาที่เหมาะสม 9,000,000.-บาท หักค่าดำเนินการ 10% เป็ฯเงิน 900,000.-บาท หักมูลค่าสิ่งปลูกสร้าง 1,060 ตร.ม.ๆละ5,000.-บาท เป็นเงิน 5,300,000.-บาท คงเหลือมูลค่าที่ดิน 2,800,000.- เฉลี่ยตร.ว.ละ 12,000.-บาท(ปัดเศษ))-ทำเลที่ตั้งเดียวกันแต่ มีเนื้อที่ดินและพื้นที่ใช้สอยน้อยกว่าทรัพย์สิน"),
                    NoteS2 = string.Format(@"เป็นราคาซื้อ-ขาย มินิแฟคทอรี่ 3 ชั้น เนื้อที่ 0-1-88 ไร ในราคา 8,000,000.-บาท เมื่อประมาณปี 53 (ผู้ให้ข้อมูลเป็นผู้พักอาศัยในระแวกนั้น) พิจารณาสภาพแวดล้อมและราคาตลาดในบริเวณใกล้เคียงแล้วเห็นว่าเป็นราคาที่เหมาะสม -มีเนื้อที่ดินและพื้นที่ใช้สอยน้อยกว่า สภาพอาคารด้อยกว่าทรัพย์สิน"),
                    NoteS3 = string.Format(@"เป็นราคาประกาศขาย มินิแฟคทอรี่ 3 ชั้น เนื้อที่ 0-2-08 ไร่ ในราคา 11,000,000.-บาท ไม่สามารถต่อรองได้ (ผู้ให้ขอมูลเป็นเจ้าของ) พิจารณาจากสภาพแวดล้อมและราคาตลาดในบริเวณใกล้เคียงแล้วเห็นว่าเหมาะสมที่ราคาคูหาละ 10,500,000.-บาท -ถึงทำเลที่ตั้งจะดีกว่าแต่มีเนื้อที่ดินและพื้นที่ใช้สอยน้อยกว่าทรัพย์สิน"),
                    AbstractNote = string.Format(@"จากการเปรียบเทียบข้อมูลตลาด S1 เมื่อเปรียบเทียบกับทรัพย์สิน จะมีสภาพแวดล้อม ใกล้เคียงกับทรัพย์สินที่ประเมินค่ามากที่สุด แต่ทรัพย์สิน มีพื้นที่ใช้สอยและขนาดเนื้อที่ดิน และสภาพอากาศที่แตกต่างกัน จึงประเมินมูลค่าสูงกว่า โดยมีแนวคิดในการประเมินดังนี้
-ทรัพย์สิน เมื่อเทียบกับ S1 เนื้อที่ดินเนื้อที่ดิน 0-2-29 ไร่ พื้นที่ใช้สอย 1,060ตร.ม. ราคาเบื้องต้น คูหาละ
9,000,000.-บาท
-ทรัพย์ศินมีพื้นที่ใช้สอยส่วนใหญ่เป็นโรงงาน มากว่า 280ตร.ม.ๆละ5,000.-บาท เป็นเงิน 1,400,000.-บาท
-ทรัพย์สินมีเนื้อที่ดินมากกว่า 0-0-46.8 ไร่ คิด ตร.ว.ละ 12,000.-บาท เป็นเงิน 561,600.-
-รวมเป็นเงิน 10,961,600.-บาท จึงปรับเป็น ยูนิตละ 11,000,000.-บาท"),
                    Note = string.Format(@"-ผู้ประเมินได้ดำเนินการสำรวจหาข้อมูลตลาด ที่ใช้เปรียบเทียบ ซึ่งมีที่ตั้งอยู่ใกล้เคียงกับทรัพย์สิน แล้วพบว่าไม่มีการซื้อ-ขายเกิดขึ้น การประเมินค่าในครั้งนี้จึงใช้ข้อมูลเสนอขายและราคาประกาศขายที่มี ศักยภาพและตั้งอยู่ในบริเวณใกล้เคียงกันที่สุดทรัพย์สินที่ประเมินค่า มาใช้ในการวิเคราะห์เปรียบเทียบ-ในวันสำรวจได้ทำการตรวจสอบระวาง ณ สำนักงานที่ดินจังหวัดนครปฐม สาขาสามพรานแล้วพบว่า ที่ตั้งถูกต้องโดยทรัพย์สินๆฯตั้งอยู่ในซอย 3 ภายในโครงการแฟคทอรี่แลนด์ 2 มีจุดโยงยึดห่างจากท้ายซอย 3 ทางด้านทิศเหนือประมาณ 160 เมตร

-จากการสอบถามผู้อาศัยใกล้เคียงที่ตั้งทรัพย์สิน ทราบว่า ทรัพย์สินตั้งอยู่ในเขตพื้นที่ ที่เคยได้รับผลอุทกภัย
ในปี 2554 โดยมีระดับน้ำท่วมขังสูง ประมาณ 1.00 เมตร")
                };
            }
        }

        public static LB_LocationModel LB_LocationModel
        {
            get
            {
                return new LB_LocationModel
            {
                CollatAddr = "แฟคทอรี่แลนด์ 2",
                CollatSoi = "โครงการแฟคทอรี่แลนด์ 2",
                CollatRoad = "พุทธมณฑลสาย 5",
                CollatAddrDetail = "ตั้งอยู่ในโครงการแฟคทอรี่แลนด์ 2 ห่างจากถนนพุทธมณฑลสาย 5 ประมาณ 350 เมตร",
                CollatWalk = 1,     //อาจเป็น Spinner
                CollatRestrict = 1, //อาจเป็น Spinner
            };
            }
        }

        public static LB_LanddocModel LB_LanddocModel
        {
            get
            {
                return new LB_LanddocModel
            {
            };
            }
        }

        public static LB_PriceSummaryModel LB_PriceSummaryModel
        {
            get
            {
                return new LB_PriceSummaryModel
            {
            };
            }
        }
    }
}

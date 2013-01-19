using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class LB_WorksheetModel
    {
        /// <summary>
        /// เลขที่ใบคำขอ
        /// </summary>
        public string ReqNo { get; set; }
        /// <summary>
        /// เลขที่รหัสเรื่อง
        /// </summary>
        public string JobNo { get; set; }
        /// <summary>
        /// primary key
        /// </summary>
        public int WorksheetID { get; set; }
        /// <summary>
        /// ย่อ/ขยายรูปโฉนด และคำนวณกว้าง-ยาว ของทรัพย์สินหรือต่อโฉนด (กรณีหลายแปลง
        /// </summary>
        public bool AbridgeImage { get; set; }
        /// <summary>
        /// ชาร์จแบตเตอรี่ และล้าง File ใน Memory ของ Tablet
        /// </summary>
        public bool BatteryCharger { get; set; }
        /// <summary>
        /// ตั้งวันที่ให้ตรงตามวันที่สำรวจ
        /// </summary>
        public bool DateSetting { get; set; }
        /// <summary>
        /// ตรวจสอบความถูกต้องของรายงานทุกหน้า ตัวพิมพ์ คำสะกดต่างๆ และใช้วลีมาตรฐาน ความสมบูรณ์ของภาพถ่ายทรัพย์สินที่ประเมินค่าตามหลักเกณฑ์ของบริษัทฯ
        /// </summary>
        public bool CheckCorrect { get; set; }
        /// <summary>
        /// ตรวจสอบความสมบูรณ์ของรายงาน และเอกสารแนบประกอบการประเมิน
        /// </summary>
        public bool CheckPerfection { get; set; }









        /// <summary>
        /// เตรียมความพร้อมของข้อมูล SและC ใกล้เคียง(ถ้ามี)
        /// </summary>	
        public bool CheckBoxFlag01 { get; set; }

        /// <summary>
        /// ยืนยันเวลาและสถานที่ในการนัดหมายกับลูกค้า/ผู้สำรวจ
        /// </summary>
        public bool CheckBoxFlag02 { get; set; }

        /// <summary>
        /// เตรียมความพร้อมของอุปรณ์ที่จะใช้ในการสำรวจ
        /// </summary>	
        public bool CheckBoxFlag03 { get; set; }

        /// <summary>
        /// กล้องถ่ายรูป
        /// </summary>	
        public bool CheckBoxFlag04 { get; set; }

        /// <summary>
        /// กระดาษทำการ
        /// </summary>	
        public bool CheckBoxFlag05 { get; set; }

        /// <summary>
        /// สายวัด ล้อวัด ไม้บรรทัด
        /// </summary>	
        public bool CheckBoxFlag06 { get; set; }

        /// <summary>
        /// เข็มทิศ
        /// </summary>	
        public bool CheckBoxFlag07 { get; set; }


        /// <summary>
        /// จับทิศ
        /// </summary>	
        public bool CheckBoxFlag08 { get; set; }

        /// <summary>
        /// วัดขนาด
        /// </summary>	
        public bool CheckBoxFlag09 { get; set; }

        /// <summary>
        /// ตรวจสอบลักษณะที่ดินเช่น รูปแปลงฯตำแหน่งที่ตั้งของที่ดินเปรียบเทียบกับเอกสารสิทธิ์ และสิทธิ์ทางเข้า-ออกตามกฏหมายแล้ว
        /// </summary>	
        public bool CheckBoxFlag10 { get; set; }

        /// <summary>
        /// การสำรวจและถ่ายภาพประกอบการประเมินมูลค่าฯโดยใช้วันที่ ณ สำรวจ
        /// </summary>	
        public bool CheckBoxFlag11 { get; set; }

        /// <summary>
        /// ผลการตรวจสอบโฉนดที่ตั้งทรัพย์สินที่ประเมินมูลค่า
        /// </summary>	
        public bool CheckBoxFlag12 { get; set; }

        /// <summary>
        /// ไม่พบหลักเขต
        /// </summary>	
        public bool CheckBoxFlag13 { get; set; }

        /// <summary>
        /// พบหลักเขต หมายเลข.......
        /// </summary>	
        public bool CheckBoxFlag14 { get; set; }

        /// <summary>
        /// สอบถามแปลงข้างเคียง โดยระบุแหล่งที่มาของข้อมูลที่ใช้อ้างอิงได้ไว้ในรายงาน
        /// </summary>	
        public bool CheckBoxFlag15 { get; set; }

        /// <summary>
        /// เทียบโฉนดหรือเอกสารสิทธิ์แปลงข้างเคียง โดยระบุแหล่งที่มาของข้อมูลที่ใช้อ้างอิงได้ไว้ในรายงาน
        /// </summary>	
        public bool CheckBoxFlag16 { get; set; }

        /// <summary>
        /// ตรวจสอบแปลงแม่และแปลงคง ที่ให้รายละเอียดสามารถตรวจสอบตำแหน่งที่ตั้งของทรัพย์สินฯได้
        /// </summary>	
        public bool CheckBoxFlag17 { get; set; }

        /// <summary>
        /// มีสัญญาซื้อ-ขาย ฉบับ สนง.ที่ดินซึ่งใช้ประกอบการตรวจสอบตำแหน่งที่ตั้งสิ่งปลุกสร้าง
        /// </summary>	
        public bool CheckBoxFlag18 { get; set; }

        /// <summary>
        /// มีใบอนุญาตก่อสร้างฯอาคารตาม พรบ.ควบคุมฯ พ.ศ.2522 และ/หรือ ใบคำขอเลขที่บ้านซึ่งใช้ประกอบการตรวจสอบตำแหน่งที่ตั้งสิ่งปลูกสร้าง
        /// </summary>	
        public bool CheckBoxFlag19 { get; set; }

        /// <summary>
        /// ตรวจสอบที่ตั้งจากระหว่างจุดโยงยึด ที่ให้รายละเอียดสามารถตรวจสอบตำแหน่งที่ตั้งของทรัพย์สินได้
        /// </summary>	
        public bool CheckBoxFlag20 { get; set; }

        /// <summary>
        /// ตรวจอบข้อจำกัดทางกฏหมาย ที่มีผลกระทบกับการใช้ประโยชน์ของทรัพย์สินตามหลักเกณฑ์ของบริษัทฯแล้ว
        /// </summary>	
        public bool CheckBoxFlag21 { get; set; }

        /// <summary>
        /// ได้ระบุตำแหน่งข้อมูล S และหมายเลขโทรศัพย์ที่สามารถติดต่อได้ ซึ่งได้ลงในแผนที่เรียบร้อยแล้ว
        /// </summary>	
        public bool CheckBoxFlag22 { get; set; }

        /// <summary>
        /// ตรวจสอบข้อมูล (C) ที่มีสภาพใกล้เคียงกับทรัพย์สินในระบบฐานข้อมูลของบริษัทฯที่มีระยะเวลาไม่เกิน 1 ปี จำนวนอย่างน้อย 3 รหัสเรื่องแล้ว(ถ้ามี)
        /// </summary>	
        public bool CheckBoxFlag23 { get; set; }

        /// <summary>
        /// การสรุปค่าทรัพย์สิน และมีการระบุหมายเหตุเงื่อนไขหรือสมมุติฐานที่มีผลกับมูลค่าทรัพย์สิน(ถ้ามี)แล้ว
        /// </summary>	
        public bool CheckBoxFlag24 { get; set; }

        /// <summary>
        /// เป็นงานเร่งด่วนที่ได้รับเพิ่มเติมในภาคสนาม
        /// </summary>	
        public bool CheckBoxFlag25 { get; set; }

        /// <summary>
        /// ตรวจสอบความถูกต้องของรายงานทุกหน้า ตัวพิมพ์ คำสะกดต่างๆ ใช้วลีมาตรฐาน ความสมบูรณ์ของภาพถ่ายทรัพย์สินที่ประเมินตามหลักเกณฑ์ของบริษัทฯ
        /// </summary>	
        public bool CheckBoxFlag26 { get; set; }

        /// <summary>
        /// การลงลายมือชื่อ และตรวจสอบความสมบูรณ์ของรายงานในATIS เอกสารแนบประกอบการประเมิน(กรณีต้อง Scan เพิ่ม)
        /// </summary>	
        public bool CheckBoxFlag27 { get; set; }
    }
}

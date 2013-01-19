using PDFlib_dotnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper
{
    class WS_Task
    {
        public WS_Task()
        {
            string path = Pdfpath.path + "WS_Task.pdf";


            Helper p = new Helper();
            PDFlib page = p.Start_Page(path);
            int tbl = -1;

            int image = page.load_image("auto", "D://applogo.png", "");
            page.fit_image(image, 495, 760, "scale=1");
            page.set_text_pos(25, 795);

            //WS_Model
            p.newline(1);
            p.Textbold("ชื่อลูกค้า",63);
            p.Textnormal("นายxxxxxxx  xxxxxxxxxx", 110);
            p.Textbold("รหัสเรื่อง",365);
            p.Textnormal("5418067-1/1", 410);

            p.newline(3);
            p.Textbold("หน่วยงานธนาคาร");
            p.Textnormal("สาขาบางรัก",110);
            p.Textbold("วันที่สำรวจ",358);
            p.Textnormal("15  มีนาคม  2554", 410);

            p.newline(3);
            p.Textbold("ประเภทงาน", 52);
            p.Textnormal("สินเชื่อที่อยู่อาศัย", 110);
            p.Textbold("ประเภททรัพย์สิน", 334);
            p.Textnormal("สิทธิการเช่า", 410);

            p.newline(4);
            p.Textbold("1.รายละเอียดสัญญาเช่า");

            p.newline(3);
            p.Textbold("ประเภทสัญญาเช่า");
            p.Textnormal("สัญญาเช่าช่วง", 115);
            p.Textbold("วันเริ่มสัญญา", 200);
            p.Textnormal("15  มีนาคม  2554", 265);
            p.Textbold("วันครบกำหนดสัญญา", 370);
            p.Textnormal("15  มีนาคม  2554", 460);

            p.newline(3);
            p.Textbold("เลขที่สัญญา");
            p.Textnormal("HR-1403-L-1", 115);
            p.Textbold("วันที่ทำสัญญา", 200);
            p.Textnormal("3  มกราคม  2554", 265);
            p.Textbold("สัญญาเช่าคงเหลือ", 370);
            p.Textnormal("29", 460);
            p.Textbold("ปี", 475);

            p.newline(5);
            p.Textbold("ระหว่าง");
            p.Textnormal("บริษัท สมหรรษา จำกัด", 125);
            p.Textbold("ผู้ให้เช่า", 250);
            p.Textbold("กับ", 290);
            p.Textnormal("นายพิพรรธ  พิหเคนทร์", 370);
            p.Textbold("ผู้เช่า", 530);
            p.newline(5);

            p.Textbold("ข้อมูลเพิ่มเติม");
            p.Textnormal("อายุสัญญาคงเหลือ 29 ปี 10 เดือน", 95);
            p.makeline(23, 650, 571, 650);
            
            //LB_LocationModel
            p.newline(6);
            p.Textbold("2.ที่ตั้งทรัพย์สิน");
            p.Textflow(35,550, 200, @"หมู่บ้าน");
            p.newline(12);
            p.Textbold("3.ข้อจำกัดการใช้ประโยชน์ตามพ.ร.บ.ผังเมือง:");
            p.Textnormal("สีแดง เป็นเขตที่ดินประเภทพาณิชกรรม", 200);
            p.makeline(23, 570, 571, 570);

            p.newline(4);
            p.Textbold("3.รายละเอียดแสดงกรรมสิทธิห้องชุด");

            //RS_RoomsetModel
            #region ตารางรายละเอียดแสดงกรรมสิทธิ์ห้องชุด
            int normalfont = page.load_font("Tahoma", "unicode", "");
            string optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  colwidth=30 rowheight=14";
            tbl = page.add_table_cell(tbl, 1, 1, "ลำดับ", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  colwidth=80 rowheight=14";
            tbl = page.add_table_cell(tbl, 2, 1, "ห้องชุดเลขที่", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  colwidth=30 rowheight=14";
            tbl = page.add_table_cell(tbl, 3, 1, "ชั้นที่", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  colwidth=80 rowheight=14";
            tbl = page.add_table_cell(tbl, 4, 1, "อาคารเลขที่", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  colwidth=90 rowheight=14";
            tbl = page.add_table_cell(tbl, 5, 1, "ทะเบียนอาคารชุดเลขที่", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  colwidth=120 rowheight=14";
            tbl = page.add_table_cell(tbl, 6, 1, "ชื่ออาคารชุด", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  colwidth=120 rowheight=14";
            tbl = page.add_table_cell(tbl, 7, 1, "เนื้อที่(ตร.ม.)", optlist);

            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  rowheight=14";
            tbl = page.add_table_cell(tbl, 1, 2, "1", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  rowheight=14";
            tbl = page.add_table_cell(tbl, 2, 2, "3/43(1403)", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  rowheight=14";
            tbl = page.add_table_cell(tbl, 3, 2, "14", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  rowheight=14";
            tbl = page.add_table_cell(tbl, 4, 2, "", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  rowheight=14";
            tbl = page.add_table_cell(tbl, 5, 2, "", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  rowheight=14";
            tbl = page.add_table_cell(tbl, 6, 2, "HANSAR HOTEL & RESIDENCE", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position=center}  rowheight=14";
            tbl = page.add_table_cell(tbl, 7, 2, "78.840", optlist);

            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={left center}}  rowspan=4 colspan=2  rowheight=56";
            tbl = page.add_table_cell(tbl, 1, 3, " ", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={left center}}  colspan=2 rowheight=14";
            tbl = page.add_table_cell(tbl, 3, 3, "ตำบล ", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={left center}}  colspan=2 rowheight=14";
            tbl = page.add_table_cell(tbl, 5, 3, "อำเภอ ", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={left center}}  rowheight=14";
            tbl = page.add_table_cell(tbl, 7, 3, "จังหวัด", optlist);

            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={left center}}  colspan=3 rowheight=14";
            tbl = page.add_table_cell(tbl, 3, 4, "บุริมสิทธิ์หรือภาระติดพัน:", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={left center}}  colspan=2 rowheight=14";
            tbl = page.add_table_cell(tbl, 6, 4, "ราคากลางกรมที่ดิน:",optlist);

            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={left center}} colspan=3 rowheight=14";
            tbl = page.add_table_cell(tbl, 3, 5, "ชื่อผู้ทรงสิทธิ์:", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={left center}}  colspan=2 rowheight=14";
            tbl = page.add_table_cell(tbl, 6, 5, "ราคาประเมิน บาท/ตร.ม.:", optlist);

            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={left center}} colspan=3 rowheight=14";
            tbl = page.add_table_cell(tbl, 3, 6, "ผู้ถือกรรมสิทธิ์:", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={left center}}  colspan=2 rowheight=14";
            tbl = page.add_table_cell(tbl, 6, 6, "ราคาประเมินรวม:", optlist);

            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={left center}}  colspan=7 rowheight=14";
            tbl = page.add_table_cell(tbl, 1, 7, "ข้อมูลเพิ่มเติม:"+" ", optlist);
            #endregion



            optlist = "stroke={{line=other}} ";
            string result = page.fit_table(tbl, 23, 550, 571, 100, optlist);//width 571

            p.makeline(23, 350, 571, 350);
            p.newline(43);
            p.Textbold("4.สรุปมูลค่าทรัพย์สิน ประเมินโดย [/] เปรียบเทียบราคาตลาด (Market Approach)");

            tbl = -1;

            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={center center}}   colwidth=200 rowheight=27";
            tbl = page.add_table_cell(tbl, 1, 1, "ประเภททรัพย์สิน", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={center center}}   colwidth=70 rowheight=27";
            tbl = page.add_table_cell(tbl, 2, 1, "จำนวน(หน่วย)", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={center center}}   colwidth=120 rowheight=27";
            tbl = page.add_table_cell(tbl, 3, 1, "เนื้อที่(ตร.ม.)", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={center center}}   colwidth=181 rowheight=27";
            tbl = page.add_table_cell(tbl, 4, 1, "จำนวนเงิน", optlist);

            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={left center}}   colwidth=200 rowheight=17";
            tbl = page.add_table_cell(tbl, 1, 2, "ห้องชุด", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={center center}}   colwidth=70 rowheight=17";
            tbl = page.add_table_cell(tbl, 2, 2, "1", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={right center}}   colwidth=120 rowheight=17";
            tbl = page.add_table_cell(tbl, 3, 2, "72.840", optlist);
            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={right center}}   colwidth=181 rowheight=17";
            tbl = page.add_table_cell(tbl, 4, 2, "6,701,280.00", optlist);

            optlist = "stroke={{line=other}} ";
            result = page.fit_table(tbl, 23, 326, 571, 100, optlist);


            p.newline(15);
            p.Textbold("รวมทั้งสิ้น",35);

            tbl = -1;

            optlist = "fittextline={font=" + normalfont + " fontsize=9 position={center center}}  colwidth=400 rowheight=15";
            tbl = page.add_table_cell(tbl, 1, 1, "หกล้านเจ็ดแสนหนึ่งพันสองร้อยแปดสิบบาทถ้วน", optlist);
            optlist = "stroke={{line=other}} ";
            result = page.fit_table(tbl, 130, 276, 580, 100, optlist);

            p.newline(4);
            p.Textbold("สรุปความเห็นเพิ่มเติมผู้ประเมิน/หมายเหตุ:", 35);

            p.makeline(23, 200, 571, 200);
            p.newline(20);
            p.Textnormal("(  "+"นายนพดล  ลิมปตานนท์"+"  )",120);
            p.newline(3);
            p.Textbold("ผู้ประเมินค่า", 150);

            p.Textbold("ผู้ประเมินหลัก/ผู้รับรองราคา", 385);

            p.makeline(295, 200, 295, 125);
            p.makeline(23, 125, 571, 125);

            p.newline(4);
            p.Textnormal("คณะกรรมการพิจรณา และอนุมัติผลการประเมินค่าของ บมจ. ธนาคารกสิกรไทย ประชุมครั้งที่"+"  "+"วันที่"+"           ", 50);
            p.newline(3);
            p.Textnormal("ความเห็น");
            p.Textnormal("ความเห็น",200); 
            p.Textnormal("ความเห็น", 400);
            p.newline(5);
            p.Textnormal("ลงชื่อ");
            p.Textnormal("ลงชื่อ",200);
            p.Textnormal("ลงชื่อ",400);
            p.newline(3);
            p.Textnormal("ตำแหน่ง");
            p.Textnormal("ตำแหน่ง",200);
            p.Textnormal("ตำแหน่ง",400);
            p.newline(3);
            p.Textnormal("สังกัด");
            p.Textnormal("สังกัด",200);
            p.Textnormal("สังกัด",400);

            p.End_page();

            System.Diagnostics.Process.Start(path);
        }
    }
}

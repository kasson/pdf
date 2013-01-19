using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDFlibHelper.Models;

namespace PDFlibHelper.Engines
{
    public class SheetCreator
    {
        public SheetCreator Page1_16(PDFGenerator pdf, AppraisalArchive header)
        {
            pdf
                .BeginPage("นายจักรกฤษ อำไพจิตร","132313",2,"แบบสำรวจและรายงาน")
                    .TextBold("ประเภทงาน").Tab(3).Text("สินเชื่อทั่วไป").Tab(3).Text("วันที่สำรวจ").NewLine()
                    .TextBold("สาขา") .NewLine(2)
                    .Text("AAAAAAAAAAAAAAAAAAAAAA",200,540).NewLine()
                    .CheckBox("lasdjajdalsjdalsjdlasj",true).NewLine()
                    .CheckBox("lasdjajdalsjdalsjdlasj", false).NewLine()

                    .Guidline()
                .EndPage();


            return this;
        }


        public SheetCreator TEST(PDFGenerator pdf, AppraisalArchive header)
        {
            pdf
                .BeginPage(header.Header.BankDatas.CustName, avoidNull(header.Header.JobNo),0,"7.1 วิธีการประเมินมูลค่าสิทธิการเช่า")
                    .BeginTable()
                        .TableHeader("A",200).TableHeader("B",200).TableNewRow()
                        .TableColumn(@"When we vertically center con-tents of various types in the table cells, they will be positioned with varying distance 
from the borders. In Figure 8.30a, the four text line cells have beenplaced with the fol-lowing option lis",200)
                        .TableColumn(@"The Textflow cell is added withoutany special options. Since we vertically centered the 
text lines, the Benefitline will move down with the height of the Textflow.
Fig. 8.30 Aligning text lines and Textflow in table cells").TableNewRow()
                    .EndTable()
                    .SetLinePosition(580)
                    .Text("สวัสดีครับ").NewLine()
                    .Text("สวัสดีครับ").NewLine()
                    .Text("สวัสดีครับ").NewLine()
                    .Text("สวัสดีครับ").NewLine()
                    .Text("สวัสดีครับ").NewLine()
                    .Guidline()
                .EndPage();
            return this;
        }

        public SheetCreator Page5_19(PDFGenerator pdf, AppraisalArchive header)
        {
            pdf
                .BeginPage(header.Header.BankDatas.CustName, avoidNull(header.Header.JobNo),0,"7.1 วิธีการประเมินมูลค่าสิทธิการเช่า")
                .NewLine()
                .TextBold("วิธีการประเมินมูลค่าสิทธิการเช่า โดยวิธีทางด้านรายได้ Discounted Cash Flow").NewLine(2)
                .Tab(2).Text("โดยทั่วไป การประมูลค่าสิทธิการเช่าจะหมายถึงการหามูลค่าของผู้เช่า ซึ่งมูลค่าสิทธิการเช่าจะมีมูลค่าก็ต่อเมื่อผู้เช่าจ่ายค่าเช่า").NewLine()
                .Text("ต่ำกว่าราคาเช่าตลาด ทำให้ผู้เช่าได้กำไรจากการเสียค่าเช่าในสัญญาต่ำกว่าราคาเช่าในตลาด").NewLine(2)
                .Tab(2).Text("มูลค่าของสิทธิการเช่า").Tab(5).Text("=").Tab().Text("มูลค่าปัจจุบันทั้งหมดของกำไรจากการเช่าตลอดอายุสัญญาที่เหลือ").NewLine()
                .Tab(2).Text("ซึ่งกำไรจากการเช่า").Tab(5).Text("=").Tab().Text("ค่าเช่าในราคาตลาด - ค่าเช่าที่จ่ายตามสัญญา").NewLine()
                .Tab(2).Text("(ผู้เช่าจะได้รับกำไรจากการเช่าก็ต่อเมื่อ)").Tab(9).Text(":").Tab().Text("ค่าเช่าในตลาด > ค่าเช่าที่จ่ายตามในสัญญา").NewLine(2)
                .Tab(2).Text("การหามูลค่ากำไรจากค่าเช่า (ซึ่งกำไรจากการเช่า = ค่าเช่าในราคาตลาด - ค่าเช่าในสัญญา) ทั้งหมดตลอดอายุสัญญาเช่าที่เหลือ").NewLine()
                .Text("ในสัญญา แล้วนำมาหาเป็นมูลค่าปัจจุบัน โดยวิธี Discounted Cash Flow")
                .DrawRectangle(35,590,560,360)
                .DrawRectangle(35, 350, 560, 80)
                //.Guidline()
                .EndPage();
            return this;
        }

        public string avoidNull(string src)
        {
            return src == null ? string.Empty : src;
        }


        
        public SheetCreator Sheet01(PDFGenerator pdf, AppraisalArchive header, LB_WorksheetModel data)
        {
            header = header == null ? new AppraisalArchive() : header;
            data = data == null ? new LB_WorksheetModel() : data;
            header.Header = header.Header == null ? new AppraisalArchiveHeader() : header.Header;
            header.Appointments = header.Appointments == null ? new List<Appointment>() { new Appointment() } : header.Appointments;
            header.Header.Assessors = header.Header.Assessors == null ? new AppraisalArchiveAssessor() : header.Header.Assessors;
            header.Header.BankDatas = header.Header.BankDatas == null ? new AppraisalArchiveBank() : header.Header.BankDatas;

            var employeeName = string.Format("{0}.{1} {2}", header.Header.Assessors.CreatedBy == null ? string.Empty : header.Header.Assessors.CreatedBy, header.Header.Assessors.CreatedBy == null ? string.Empty : header.Header.Assessors.CreatedBy, header.Header.Assessors.CreatedBy == null ? string.Empty : header.Header.Assessors.CreatedBy);
            var time = header.Appointments.Last();
            var appointDate = time.AppointDate == null ? "...................." : string.Format("{0:00}/{1:00}/{2:0000}", time.AppointDate.Value.Day, time.AppointDate.Value.Month, time.AppointDate.Value.Year);
            //var appointTime = time.AppointDate. ?? TimeSpan.Zero;
            var line3 = string.Format("ยืนยันเวลาและสถานที่ในการนัดหมายกับลูกค้า/ผู้สำรวจ( {0} ) (วันที่ {1} น.)", employeeName, appointDate); //เวลานัดหมาย {2} น.)", employeeName, appointDate, appointTime);

            pdf
                //.BeginPage(header.Header.BankDatas.CustName == null ? string.Empty : header.Header.BankDatas.CustName, header.Header.JobNo == null ? string.Empty : header.Header.JobNo,true)
                .BeginPage("AAA","BBBB")
                // ก่อนออกสำรวจ
                    .TextBold("1.WORK SHEET สำหรับออกสำรวจและประเมินมูลค่าทรัพย์สิน").NewLine()
                    .TextBold("ก่อนสำรวจ").NewLine()
                    .Tab().CheckBox("ย่อ/ขยายรูปโฉนด และคำนวน กว้าง-ยาว ของทรัพย์สิน หรือต่อโฉนด(กรณีหลายแปรง)", data.AbridgeImage).NewLine()
                    .Tab().CheckBox("เตรียมความพร้อมของข้อมูล SและC ใกล้เคียง(ถ้ามี)", data.CheckBoxFlag01).NewLine()
                    .Tab().CheckBox(line3, data.CheckBoxFlag02).NewLine()
                    .Tab().CheckBox("เตรียมความพร้อมของอุปรณ์ที่จะใช้ในการสำรวจ", data.CheckBoxFlag03).NewLine()
                    .Tab(2).CheckBox("ชาร์จแบตเตอรี่ กล้องถ่ายรูปและล้าง FILE ใน MEMORY ของกล้อง", data.BatteryCharger).CheckBox("กล้องถ่ายรูป", data.CheckBoxFlag04, 320).NewLine()
                    .Tab(2).CheckBox("กระดาษทำการ", data.CheckBoxFlag05).CheckBox("สายวัด ล้อวัด ไม้บรรทัด", data.CheckBoxFlag06, 220).CheckBox("เข็มทิศ", data.CheckBoxFlag07, 320).NewLine()
                // ระหว่างสำราจ
                    .TextBold("ระหว่างสำราจ").NewLine()
                    .Tab().CheckBox("จับทิศ", data.CheckBoxFlag08).NewLine()
                    .Tab().CheckBox("วัดขนาด", data.CheckBoxFlag09).NewLine()
                    .Tab().CheckBox("ตรวจสอบลักษณะที่ดินเช่น รูปแปลงฯตำแหน่งที่ตั้งของที่ดินเปรียบเทียบกับเอกสารสิทธิ์ และสิทธิ์ทางเข้า-ออกตามกฏหมายแล้ว", data.CheckBoxFlag10).NewLine()
                    .Tab().CheckBox("การสำรวจและถ่ายภาพประกอบการประเมินมูลค่าฯโดยใช้วันที่ ณ สำรวจ", data.CheckBoxFlag11).NewLine()
                    .Tab().CheckBox("ผลการตรวจสอบโฉนดที่ตั้งทรัพย์สินที่ประเมินมูลค่า", data.CheckBoxFlag12).CheckBox("ไม่พบหลักเขต", data.CheckBoxFlag13, 220).CheckBox("พบหลักเขต หมายเลข.......", data.CheckBoxFlag14, 320).NewLine()
                    .Tab().CheckBox("สอบถามแปลงข้างเคียง โดยระบุแหล่งที่มาของข้อมูลที่ใช้อ้างอิงได้ไว้ในรายงาน", data.CheckBoxFlag15).NewLine()
                    .Tab().CheckBox("เทียบโฉนดหรือเอกสารสิทธิ์แปลงข้างเคียง โดยระบุแหล่งที่มาของข้อมูลที่ใช้อ้างอิงได้ไว้ในรายงาน", data.CheckBoxFlag16).NewLine()
                    .Tab().CheckBox("ตรวจสอบแปลงแม่และแปลงคง ที่ให้รายละเอียดสามารถตรวจสอบตำแหน่งที่ตั้งของทรัพย์สินฯได้", data.CheckBoxFlag17).NewLine()
                    .Tab().CheckBox("มีสัญญาซื้อ-ขาย ฉบับ สนง.ที่ดินซึ่งใช้ประกอบการตรวจสอบตำแหน่งที่ตั้งสิ่งปลุกสร้าง", data.CheckBoxFlag18).NewLine()
                    .Tab().CheckBox("มีใบอนุญาตก่อสร้างฯอาคารตาม พรบ.ควบคุมฯ พ.ศ.2522 และ/หรือ ใบคำขอเลขที่บ้านซึ่งใช้ประกอบการตรวจสอบตำแหน่งที่ตั้งสิ่งปลูกสร้าง", data.CheckBoxFlag19).NewLine()
                    .Tab().CheckBox("ตรวจสอบที่ตั้งจากระหว่างจุดโยงยึด ที่ให้รายละเอียดสามารถตรวจสอบตำแหน่งที่ตั้งของทรัพย์สินได้", data.CheckBoxFlag20).NewLine()
                    .Tab().CheckBox("ตรวจอบข้อจำกัดทางกฏหมาย ที่มีผลกระทบกับการใช้ประโยชน์ของทรัพย์สินตามหลักเกณฑ์ของบริษัทฯแล้ว", data.CheckBoxFlag21).NewLine()
                    .Tab().CheckBox("ได้ระบุตำแหน่งข้อมูล S และหมายเลขโทรศัพย์ที่สามารถติดต่อได้ ซึ่งได้ลงในแผนที่เรียบร้อยแล้ว", data.CheckBoxFlag22).NewLine()
                    .Tab().CheckBox("ตรวจสอบข้อมูล (C) ที่มีสภาพใกล้เคียงกับทรัพย์สินในระบบฐานข้อมูลของบริษัทฯที่มีระยะเวลาไม่เกิน 1 ปี จำนวนอย่างน้อย 3 รหัสเรื่องแล้ว(ถ้ามี)", data.CheckBoxFlag23).NewLine()
                    .Tab().Text("ได้แก่ รหัส 5495099 5483158", 50).NewLine()
                    .Tab().CheckBox("การสรุปค่าทรัพย์สิน และมีการระบุหมายเหตุเงื่อนไขหรือสมมุติฐานที่มีผลกับมูลค่าทรัพย์สิน(ถ้ามี)แล้ว", data.CheckBoxFlag24).NewLine()
                    .Tab().CheckBox("เป็นงานเร่งด่วนที่ได้รับเพิ่มเติมในภาคสนาม", data.CheckBoxFlag25).NewLine()
                // ก่อนส่งงานให้ตรวจรับรอง
                    .TextBold("ก่อนส่งงานให้ตรวจรับรอง").NewLine()
                    .Tab().CheckBox("ตรวจสอบความถูกต้องของรายงานทุกหน้า ตัวพิมพ์ คำสะกดต่างๆ ใช้วลีมาตรฐาน ความสมบูรณ์ของภาพถ่ายทรัพย์สินที่ประเมินตามหลักเกณฑ์ของบริษัทฯ", data.CheckBoxFlag26).NewLine()
                    .Tab().Text("และมีเอกสารประกอบการประเมินครบถ้วน", 50).NewLine()
                    .Tab().CheckBox("การลงลายมือชื่อ และตรวจสอบความสมบูรณ์ของรายงานในATIS เอกสารแนบประกอบการประเมิน(กรณีต้อง Scan เพิ่ม)", data.CheckBoxFlag27).NewLine()
                    .Tab().Text("และแนบกระดาษทำการที่ชัดเจนถูกต้องครบถ้วน", 50).NewLine()
                // สรุปมูลค่าประเมิน
                    .TextBold("สรุปมูลค่าประเมิน").NewLine()
                    .BeginTable()
                        .TableHeader("รายการ", 170).TableHeader("จำนวน", 40).TableHeader("เนื้อที่", 80).TableHeader("รวมเป็นเงิน", 120).TableNewRow()
                        .TableColumn(string.Empty, 170).TableColumn(string.Empty, 40).TableColumn(string.Empty, 80).TableColumn(string.Empty, 120).TableNewRow()
                        .TableColumn(string.Empty, 170).TableColumn(string.Empty, 40).TableColumn(string.Empty, 80).TableColumn(string.Empty, 120).TableNewRow()
                        .TableColumn(string.Empty, 170).TableColumn(string.Empty, 40).TableColumn(string.Empty, 80).TableColumn(string.Empty, 120).TableNewRow()
                        .TableColumn(string.Empty, 170).TableColumn(string.Empty, 40).TableColumn(string.Empty, 80).TableColumn(string.Empty, 120).TableNewRow()
                    .EndTable()
                    .TextBold("ขอรองรับว่าข้อความข้างต้นเป็นจริง", 450, 295)
                    .Text("........................................", 455, 280)
                    .Text("(                                        )", 451, 265)
                    .TextBold("เจ้าหน้าที่สำรวจและประเมินราคา", 450, 250)
                    .Text("วันที่....................................", 450, 235)
                // ข้อคิดเห็น
                    .TextBold("ข้อคิดเห็นเกี่ยวกับการสรุปมูลค่าทรัพย์สินฯสำหรับ ผช.ผจศ./ผจศ./ผู้ตรวจและผู้รับรองราคา/ผู้อนุมัติ").NewLine()
                    .BeginTable()
                        .TableColumn("ลำดับ", 35).TableColumn("[ ] เห็นด้วย......................................", 250, PDFGenerator.FontAlignment.Left).TableColumn("[ ]ไม่เห็นด้วยเนื่องจาก.......................................", 300, PDFGenerator.FontAlignment.Left).TableNewRow()
                        .TableColumn("ที่ 1", 35).TableColumn("[ ] ราคา..........................................", 250, PDFGenerator.FontAlignment.Left).TableColumn("    และไม่ขอปรับราคา........................................", 300, PDFGenerator.FontAlignment.Left).TableNewRow()
                        .TableColumn(string.Empty, 35).TableColumn("   ลงชื่อ (                                        )", 250, PDFGenerator.FontAlignment.Left).TableColumn("   ลงชื่อ                                 (                              )", 300, PDFGenerator.FontAlignment.Left).TableNewRow()
                        .TableColumn("ลำดับ", 35).TableColumn("[ ] เห็นด้วย......................................", 250, PDFGenerator.FontAlignment.Left).TableColumn("[ ]ไม่เห็นด้วยเนื่องจาก.......................................", 300, PDFGenerator.FontAlignment.Left).TableNewRow()
                        .TableColumn("ที่ 2", 35).TableColumn("[ ] ราคา..........................................", 250, PDFGenerator.FontAlignment.Left).TableColumn("    และไม่ขอปรับราคา........................................", 300, PDFGenerator.FontAlignment.Left).TableNewRow()
                        .TableColumn(string.Empty, 35).TableColumn("   ลงชื่อ (                                        )", 250, PDFGenerator.FontAlignment.Left).TableColumn("   ลงชื่อ                                 (                              )", 300, PDFGenerator.FontAlignment.Left).TableNewRow()
                        .TableColumn("ลำดับ", 35).TableColumn("[ ] เห็นด้วย.....................................", 250, PDFGenerator.FontAlignment.Left).TableColumn("[ ]ไม่เห็นด้วยเนื่องจาก.......................................", 300, PDFGenerator.FontAlignment.Left).TableNewRow()
                        .TableColumn("ที่ 3", 35).TableColumn("[ ] ราคา.........................................", 250, PDFGenerator.FontAlignment.Left).TableColumn("    และไม่ขอปรับราคา........................................", 300, PDFGenerator.FontAlignment.Left).TableNewRow()
                        .TableColumn(string.Empty, 35).TableColumn("   ลงชื่อ (                                        )", 250, PDFGenerator.FontAlignment.Left).TableColumn("   ลงชื่อ                                 (                              )", 300, PDFGenerator.FontAlignment.Left)
                    .EndTable()
                .EndPage();

            return this;
        }
        /*
        public SheetCreator Sheet02(PDFGenerator pdf, AppraisalArchive header, LB_LocationModel data1, LB_LanddocModel data2, LB_PriceSummaryModel data3)
        {
            header = header == null ? new AppraisalArchive() : header;
            data1 = data1 == null ? new LB_LocationModel() : data1;
            data2 = data2 == null ? new LB_LanddocModel() : data2;
            data3 = data3 == null ? new LB_PriceSummaryModel() : data3;
            header.Header = header.Header == null ? new AppraisalArchiveHeader() : header.Header;
            header.Appointments = header.Appointments == null ? new List<Appointment>() { new Appointment() } : header.Appointments;
            header.Header.Assessors = header.Header.Assessors == null ? new AppraisalArchiveAssessor() : header.Header.Assessors;
            header.Header.BankDatas = header.Header.BankDatas == null ? new AppraisalArchiveBank() : header.Header.BankDatas;

            var time = string.Format("{0:00}/{1:00}/{2:00}", header.Header.JobDate == null ? 0 : header.Header.JobDate.Day, header.Header.JobDate == null ? 0 : header.Header.JobDate.Month, header.Header.JobDate == null ? 0 : header.Header.JobDate.Year);
            var oldTime = header.Header.JobDate == null ? string.Empty : string.Format("{0:00}/{1:00}/{2:00}", header.Header.JobDate.Day, header.Header.JobDate.Month, header.Header.JobDate.Year);
            var creditName = "สินเชื่อทั่วไป(ปค.-ทบทวน)" + header.Header.CreditID == null ? string.Empty : header.Header.CreditID;// TODO: ยังไม่มีประเภทงาน มาทำการจับคู่
            var collatWalk = CollatWalkDataLists.CollatWalks.FirstOrDefault(it => it.CollatWalkID == data1.CollatWalk);
            var collatWalkName = collatWalk == null ? "ไม่พบข้อมูล" : collatWalk.CollatWalkName;
            var collatRestrict = LandUsingLimitDataLists.LandUsingLimits.FirstOrDefault(it => it.LandUsingLimitID == data1.CollatRestrict);
            var collatRestrictName = collatRestrict == null ? "ไม่พบข้อมูล" : collatRestrict.LandUsingLimitName;

            pdf
                 .BeginPage(header.Header.BankDatas.CustName == null ? string.Empty : header.Header.BankDatas.CustName, header.Header.JobNo == null ? string.Empty : header.Header.JobNo,true)
                    .TextBold("หน่วยงานธนาคาร").Text(header.Header.BankBranchID, 100).Tab(5).TextBold("วันที่สำรวจ", 300).Text(time, 400).NewLine()
                    .TextBold("ประเภทงาน").Text(creditName, 100).TextBold("ประเภททรัพย์สิน", 300).Text(header.Header.CollatGrpID, 400).NewLine()
                    .TextBold("รหัสเรื่องเดิม").Text(header.Header.OldJobNo, 100).TextBold("ทบทวนครั้งที่", 220).Text(header.Header.BankDatas.ReworkNo, 280).TextBold("วันที่สำรวจเดิม", 300).Text(oldTime, 400).NewLine(4)
                // 1.ที่ตั้งทรัพย์สิน
                    .TextBold("1.ที่ตั้งทรัพย์สิน").NewLine()
                    .Text("หมู่บ้าน").Text(data1.CollatAddr, 60).Text("ซอย", 200).Text(data1.CollatSoi, 220).Text("ถนน", 360).Text(data1.CollatRoad, 380).NewLine()
                    .Text("รายละเอียดที่ตั้ง").Text(data1.CollatAddrDetail, 100).NewLine()
                    .Text("สิทธิการใช้ทางเข้าออก").Text(collatWalkName, 120).NewLine()
                    .TextBold("2.ข้อจำกัดการใช้ประโยชน์ตามพ.ร.บ ผังเมือง").Text(collatRestrictName, 180).NewLine(4)
                // 3.รายละเอียดหนังสือแสดงกรรมสิทธิ์
                    .TextBold("3.รายละเอียดหนังสือแสดงกรรมสิทธิ์").NewLine(2)
                    .BeginTable()

                        .TableHeader("ลำดับ", 30).TableHeader("ประเภท", 83).TableHeader("หนังสือเลขที่").TableHeader("เลขที่ดิน").TableHeader("หน้าสำรวจ").TableHeader("เล่ม/หน้า").TableHeader("ระวาง", 100).TableHeader("ไร่", 30).TableHeader("งาน", 30).TableHeader("วา", 30).TableNewRow()
                        .TableColumn(string.Empty).TableColumn(string.Empty).TableColumn(string.Empty).TableColumn(string.Empty).TableColumn(string.Empty).TableColumn(string.Empty).TableColumn(string.Empty).TableColumn(string.Empty).TableColumn(string.Empty).TableColumn(string.Empty).TableNewRow()
                        .Table_Column(string.Empty, 1, 1, 1).Table_Column(string.Empty, 2, 2, 1).Table_Column(string.Empty, 4, 3, 1).Table_Column(string.Empty, 7, 4, 1).TableNewRow()
                        .Table_Column("ข้อมูลเพิ่มเติม", 1, 10, 1, 80, PDFGenerator.FontAlignment.Left).TableNewRow()
                        .Table_Column("ราคากลางกรมที่ดิน/ตรว (เดิม)", 1, 10, 1, 80, PDFGenerator.FontAlignment.Left).TableNewRow()
                        .Table_Column("ราคากลางกรมที่ดิน/ตรว (ใหม่)", 1, 10, 1, 80, PDFGenerator.FontAlignment.Left).TableNewRow()

                    .EndTable().NewLine(4)

                // 4.สรุปมูลค่าทรัพย์สิน ประเมินโดยวิธี
                    .TextBold("4.สรุปมูลค่าทรัพย์สิน ประเมินโดยวิธี").Tab(7).CheckBox("เปรียบเทียบราคาตลาด(Market Approach)", true).NewLine(2)
                    .BeginTable()

                        .Table_Header("รายการ", 1, 1, 2, 100).Table_Header("จำนวน", 2, 1, 1, 30).Table_Header("มูลค่าตลาดเดิม", 3, 3, 1, 210).Table_Header("จำนวน", 6, 1, 1, 30).Table_Header("มูลค่าปัจจุบัน", 7, 3, 1, 210).TableNewRow()
                        .Table_Header("(หน่วย)", 2, 1, 1, 30).Table_Header("เนื้อที่", 3, 1, 1, 70).Table_Header("มูลค่าต่อหน่วย", 4, 1, 1, 70).Table_Header("รวมเป็นเงิน", 5, 1, 1, 70).Table_Header("(หน่วย)", 6, 1, 1, 30).Table_Header("เนื้อที่", 7, 1, 1, 70).Table_Header("มูลค่าต่อหน่วย", 8, 1, 1, 70).Table_Header("รวมเป็นเงิน", 9, 1, 1, 70).TableNewRow()

                        .TableColumn("test").TableColumn("เนื้อที่").TableColumn("5").TableColumn("1,500,500.00").TableColumn("5").TableColumn("เนื้อที่").TableColumn("50000").TableColumn("11,000,000.00").TableNewRow()

                        .Table_Column("รวมเป็นเงิน", 1, 4, 1, 30, PDFGenerator.FontAlignment.Right).Table_Column("10,000,000.00", 5, 1, 1, 30, PDFGenerator.FontAlignment.Right).Table_Column("รวมเป็นเงิน", 6, 3, 1, 30, PDFGenerator.FontAlignment.Right).Table_Column("11,000,000.00", 9, 1, 1, 30, PDFGenerator.FontAlignment.Right).TableNewRow()
                        .Table_Column("สรุปค่าตลาดปัจจุบัน", 1, 2, 1, 30, PDFGenerator.FontAlignment.Center).Table_Column("สรุปค่าตลาดปัจจุบัน", 3, 7, 1, 30, PDFGenerator.FontAlignment.Center)

                    .EndTable().NewLine(4)
                // สรุปความเห็นผู้ประเมิณค่า/หมายเหตุ
                    .TextBold("สรุปความเห็นผู้ประเมิณค่า/หมายเหตุ:").NewLine()
                    .Tab().Text("1.ขอรับรองว่าสำเนาเอกสารสิทธิ์ในรายงานการประเมิน มีรายละเอียดข้อความตรงตามเอกสารสิทธิ์ฉบับสำนักงานที่ดิน").NewLine()
                    .Tab().Text("2.2.ในวันสำรวจพบว่าสภาพแวดล้อมมีการเปลี่ยนแปลง มีการขยายตัวของชุมชนและ อุตสาหกรรมเพิ่มมากขึ้นอีกทั้งราคาซื้อ-ขายที่ดิน").NewLine()
                    .Tab().Text("บริเวณใกล้เคียงมีการปรับตัวสูงขึ้น จึงเห็นควรปรับมูลค่าทรัพย์สินเพิ่มขึ้นให้เหมาะสมกับสภาวะตลาดปัจจุบัน พิจารณาเห็นเป็นมูลค่าที่เหมาะสม").NewLine(20)
                    .Text("(                                            )", 80).Text("(                                            )", 380).NewLine()
                    .TextBold("ผู้ประเมินค่า", 120).TextBold("ผู้ประเมิณหลัก/ผู้รับรองราคา", 392).NewLine(6)
                    .Tab().Text("คณะกรรมการพิจารณา และอนุมัติผลการประเมินค่าของ บมจ. ธนาคารกสิกรไทย ประชุมครั้งที่..........วันที่.............................").NewLine()
                    .Text("ความเห็น..........................................").Text("ความเห็น..........................................", 200).Text("ความเห็น..........................................", 400).NewLine()
                    .Text("......................................................").Text("......................................................", 200).Text("......................................................", 400).NewLine()
                    .Text("ลงชื่อ(.............................................)").Text("ลงชื่อ(.............................................)", 200).Text("ลงชื่อ(.............................................)", 400).NewLine()
                    .Text("ตำแหน่ง...........................................").Text("ตำแหน่ง...........................................", 200).Text("ตำแหน่ง...........................................", 400).NewLine()
                    .Text("สังกัด...............................................").Text("สังกัด...............................................", 200).Text("สังกัด...............................................", 400)
                .EndPage();

            return this;
        }
        public SheetCreator Sheet03(PDFGenerator pdf, AppraisalArchive header, LB_BuildingModel data)
        {
            header = header == null ? new AppraisalArchive() : header;
            data = data == null ? new LB_BuildingModel() : data;
            header.Header = header.Header == null ? new AppraisalArchiveHeader() : header.Header;
            header.Appointments = header.Appointments == null ? new List<Appointment>() { new Appointment() } : header.Appointments;
            header.Header.Assessors = header.Header.Assessors == null ? new AppraisalArchiveAssessor() : header.Header.Assessors;
            header.Header.BankDatas = header.Header.BankDatas == null ? new AppraisalArchiveBank() : header.Header.BankDatas;
            data.LandBuildingMaterial = data.LandBuildingMaterial == null ? new List<LB_MaterialModel>() { new LB_MaterialModel() } : data.LandBuildingMaterial;

            var temp = pdf
                 .BeginPage(header.Header.BankDatas.CustName == null ? string.Empty : header.Header.BankDatas.CustName, header.Header.JobNo == null ? string.Empty : header.Header.JobNo,true)
                 .TextBold("สิ่งปลูกสร้างหมายเลข", 22).Text(data.BldgNo == null ? string.Empty : data.BldgNo, 110).TextBold("ลำดับย่อย", 130).Text(data.BldgSubNo.ToString(), 175).TextBold("เลขที่บ้าน", 200).Text(data.BldgAddr, 245).TextBold("ประเภทอาคาร", 310).Text(data.BldgType == null ? string.Empty : data.BldgType.ToString(), 370).NewLine(3)
                 .TextBold("ตั้งอยู่บนเอกสารสิทธิ์เลขที่", 22).Text(data.CollatNo, 125).TextBold("กรรมสิทธิ์ของ", 265).Text(data.BldgOwner == null ? string.Empty : data.BldgOwner, 320).TextBold("จำนวน", 450).Text(data.BldgQty == null ? string.Empty : data.BldgQty.ToString(), 490).TextBold("หน่วย", 520).NewLine(4)
                 .TextBold("สภาพ", 24).TextBold("สร้างมาแล้วประมาณ", 125).Text(data.BldgAgeCalc == null ? string.Empty : data.BldgAgeCalc.ToString(), 205).TextBold("ปี", 225).CheckBox("อยู่ระหว่างก่อสร้างผลงาน", true, 380).NewLine()
                    .CheckBox("เข้าสำรวจไม่ได้", false).Tab(5).CheckBox("ใหม่", false).Tab(3).CheckBox("ค่อนข้างใหม่", false).Tab(5).CheckBox("ปานกลาง", false).Tab(4).CheckBox("ค่อนข้างเก่า", false).Tab(5).CheckBox("เก่า", false).Tab(2).CheckBox("ชำรุด", false).NewLine(4)
                    .TextBold("โครงสร้าง", 35).CheckBox("คสล.", data.BldgStructure, 110).CheckBox("ไม้", data.WoodStructure, 220).CheckBox("เหล็ก", data.SteelStructure, 330).CheckBox("อื่นๆ", data.OtherStructure, 440).NewLine(3)
                    .TextBold("เสา", 35).CheckBox("คสล.", data.BldgPillar, 110).CheckBox("ไม้", data.WoodPillar, 220).CheckBox("เหล็ก", data.SteelPillar, 330).CheckBox("อื่นๆ", data.OtherPillar, 440).NewLine(3)
                    .TextBold("โครงหลังคา", 35).CheckBox("คสล.", data.BldgCover, 110).CheckBox("ไม้", data.WoodCover, 220).CheckBox("เหล็ก", data.SteelCover, 330).CheckBox("อื่นๆ", data.OtherCover, 440).NewLine(3)
                    .TextBold("วัสดุมุง", 35).CheckBox("คสล.", data.BldgRoof, 110).CheckBox("กระเบื้องลอนคู่", data.TwoTileRoof, 220).CheckBox("กระเบื้องซีแพค", data.CpagRoof, 330).CheckBox("กระเบื้องราง", data.RangRoof, 440).NewLine(3)
                    .CheckBox("เหล็กเคลือบบรีดลอน", data.CoateSteelRoof, 110).CheckBox("สังกะสี", data.ZingRoof, 220).CheckBox("วัสดุโปร่งแสง", data.LightRoof, 330).CheckBox("อื่นๆ", data.OtherRoof, 440).NewLine(3)
                    .TextBold("ฝ้าเพดาน", 35).CheckBox("ยิบซั่มบอร์ม", data.GypsumCeiling, 110).CheckBox("กระเบื้องแผ่นเรียบ", data.SmoothCeiling, 220).CheckBox("ไม้อัด", data.PlyWoodCeiling, 330).CheckBox("อื่นๆ", data.OtherCeiling, 440).NewLine(3)
                    .TextBold("ผนังภายนอก", 35).CheckBox("ฉาบปูนเรียบ", data.SmoothExWall, 110).CheckBox("ก่ออิฐ/อิฐบล็อก", data.BlockExWall, 220).CheckBox("โชว์แนว", data.ShowExWall, 330).CheckBox("ไม้", data.WoodExWall, 440).NewLine(3)
                    .CheckBox("ทาสี", data.ColorExWall, 110).CheckBox("ไม่ทาสี", data.NoColorExWall, 220).CheckBox("กรวดล้าง", data.GravelExWall, 330).CheckBox("อื่นๆ", data.OtherExWall, 440).NewLine(3)
                    .TextBold("ผนังภายใน", 35).CheckBox("ฉาบปูนเรียบ", data.SmoothInWall, 110).CheckBox("ไม้อัด", data.WoodInWall, 220).CheckBox("ยิบซั่มบอร์ด", data.GypsumInWall, 330).CheckBox("กระจก", data.MirrorInWall, 440).NewLine(3)
                    .CheckBox("ทาสี", data.ColorInWall, 110).CheckBox("ไม่ทาสี", data.NoColorInWall, 220).CheckBox("วอลล์เปเปอร์", data.WallpaperInWall, 330).CheckBox("อื่นๆ", data.OtherInWall, 440).NewLine(3);
            pdf.TextBold("บันได", 35).CheckBox("คสล.", data.BldgStair, 110).CheckBox("ไม้", data.WoodStair, 220).CheckBox("เหล็ก", data.SteelStair, 330).CheckBox("อื่นๆ", data.OtherStair, 440).NewLine(3)

           .BeginTable()
               .Table_Header("วัสดุตกแต่งพื้น", 1, 2, 1, 250).Table_Header("ขนาด (ตรม.)", 3, 1, 1, 60).Table_Header("หินแกรนิค", 4, 2, 1, 40).Table_Header("หินอ่อน", 6, 2, 1, 40).Table_Header("ไม้", 8, 1, 1, 20).Table_Header("ไม้", 9, 1, 1, 20).Table_Header("ไม้ปาร์เก้", 10, 2, 1, 40).Table_Header("หินขัด", 12, 1, 1, 20).Table_Header("กบเคลือบ", 13, 2, 1, 40).Table_Header("กบ.", 15, 1, 1, 20).Table_Header("คสล.", 16, 1, 1, 20).Table_Header("อิ่นๆ", 17, 1, 1, 120).TableNewRow()
               .Table_Header("ชั้น", 1, 1, 1, 20).Table_Header("ห้อง", 2, 1, 1, 120).Table_Header("กว้่างxยาว", 3, 1, 1, 60).Table_Header("ใหญ่", 4, 1, 1, 20).Table_Header("เล็ก", 5, 1, 1, 20).Table_Header("ใหญ่", 6, 1, 1, 20).Table_Header("เล็ก", 7, 1, 1, 20).Table_Header(string.Empty, 8, 1, 1, 20).Table_Header("เข้าลิ้น", 9, 1, 1, 20).Table_Header("ใหญ่", 10, 1, 1, 20).Table_Header("เล็ก", 11, 1, 1, 20).Table_Header(string.Empty, 12, 1, 1, 20).Table_Header("ใหญ่", 13, 1, 1, 20).Table_Header("เล็ก", 14, 1, 1, 20).Table_Header("ยาง", 15, 1, 1, 20).Table_Header(string.Empty, 16, 1, 1, 20).Table_Header(string.Empty, 17, 1, 1, 120).TableNewRow()

            
            //foreach (LB_MaterialModel item in data.LandBuildingMaterial)
            //{
            //    temp
            //        .TableColumn(item.FloorId)
            //        .TableColumn(item.ConstructName == null ? string.Empty : item.ConstructName)
            //        .TableColumn(string.Format("{0}x{1}", item.RoomWidth,item.RoomLength))
            //        .TableColumn(item.M1 == null ? string.Empty : item.M1)
            //        .TableColumn(item.M2 == null ? string.Empty : item.M2)
            //        .TableColumn(item.M3 == null ? string.Empty : item.M3)
            //        .TableColumn(item.M4 == null ? string.Empty : item.M4)
            //        .TableColumn(item.M5 == null ? string.Empty : item.M5)
            //        .TableColumn(item.M6 == null ? string.Empty : item.M6)
            //        .TableColumn(item.M7 == null ? string.Empty : item.M7)
            //        .TableColumn(item.M8 == null ? string.Empty : item.M8)
            //        .TableColumn(item.M9 == null ? string.Empty : item.M9)
            //        .TableColumn(item.M10 == null ? string.Empty : item.M10)
            //        .TableColumn(item.M11 == null ? string.Empty : item.M11)
            //        .TableColumn(item.M13 == null ? string.Empty : item.M12)
            //        .TableColumn(item.M14 == null ? string.Empty : item.M13)
            //        .TableColumn(item.M15 == null ? string.Empty : item.M14)
            //        .TableNewRow();
            //}
            
            .Table_Column<LB_MaterialModel>(data.LandBuildingMaterial, item =>
            {
                pdf
                    .TableColumn(item.FloorId)
                    .TableColumn(item.ConstructName == null ? string.Empty : item.ConstructName)
                    .TableColumn(string.Format("{0}x{1}", item.RoomWidth,item.RoomLength))
                    .TableColumn(item.M1 == null ? string.Empty : item.M1)
                    .TableColumn(item.M2 == null ? string.Empty : item.M2)
                    .TableColumn(item.M3 == null ? string.Empty : item.M3)
                    .TableColumn(item.M4 == null ? string.Empty : item.M4)
                    .TableColumn(item.M5 == null ? string.Empty : item.M5)
                    .TableColumn(item.M6 == null ? string.Empty : item.M6)
                    .TableColumn(item.M7 == null ? string.Empty : item.M7)
                    .TableColumn(item.M8 == null ? string.Empty : item.M8)
                    .TableColumn(item.M9 == null ? string.Empty : item.M9)
                    .TableColumn(item.M10 == null ? string.Empty : item.M10)
                    .TableColumn(item.M11 == null ? string.Empty : item.M11)
                    .TableColumn(item.M13 == null ? string.Empty : item.M12)
                    .TableColumn(item.M14 == null ? string.Empty : item.M13)
                    .TableColumn(item.M15 == null ? string.Empty : item.M14)
                    .TableNewRow();
            })

            .EndTable()

            .TextBold("ค่าก่อสร้างในปัจจุบัน", 35).TextBold(data.BldgCost.ToString(), 170).TextBold("บาท", 275).TextBold(data.BldgCostM.ToString(), 400).TextBold("บาท/ตรม.-เมตร", 510).NewLine(3)
             .TextBold("ปรับค่าเสื่อมกายภาพปีละ", 35).Text(data.BldgDeprePercent.ToString(), 130).TextBold("%", 152).Text(data.BldgDepreAmt.ToString(), 170).TextBold("บาท", 275).TextBold(data.BldgDepreAmtM.ToString(), 400).TextBold("บาท/ตรม.-เมตร", 510).NewLine(3)
             .TextBold("ปรับค่ารบกวนเนื่องจากสาเหตุอื่น", 35).TextBold(data.BldgAdjAmt.ToString(), 170).TextBold("บาท", 275).TextBold(data.BldgAdjM.ToString(), 400).TextBold("บาท/ตรม.-เมตร", 510).NewLine(4)

             .TextBold("หมายเหตุ", 30).NewLine() // TODO: ยังไม่มี property หมายเหตุ
             .TextBold("มูลค่าอาคาร", 30).TextBold("พื้นที่รวม", 130).TextBold(data.BldgSpace.ToString(), 168).TextBold("ตรม./เมตร", 255).TextBold("เป็นเงิน", 320).TextBold(data.BldgTotalAmt.ToString(), 360).TextBold("บาท", 500).NewLine(3)
             .TextBold("ราคา ตรม./เมตร ละ", 90).Text(data.BldgPriceM.ToString(), 168).TextBold("บาท", 255)

         .EndPage();
            return this;
        }
        public SheetCreator Sheet05(PDFGenerator pdf, AppraisalArchive header, LB_FDetailsModel data)
        {
            header = header == null ? new AppraisalArchive() : header;
            data = data == null ? new LB_FDetailsModel() : data;
            header.Header = header.Header == null ? new AppraisalArchiveHeader() : header.Header;
            header.Appointments = header.Appointments == null ? new List<Appointment>() { new Appointment() } : header.Appointments;
            header.Header.Assessors = header.Header.Assessors == null ? new AppraisalArchiveAssessor() : header.Header.Assessors;
            header.Header.BankDatas = header.Header.BankDatas == null ? new AppraisalArchiveBank() : header.Header.BankDatas;
            pdf
                .BeginPage(header.Header.BankDatas.CustName, header.Header.JobNo,true).NewLine()
                    .Text("วิธีการประเมินที่ใช้ :").NewLine()
                    .Textflow(data.AssessmentNote, 560, 80).NewLine()
                    .Text("S1").Tab().Textflow(data.NoteS1, 560, 80).NewLine().NewLine()
                    .Text("S2").Tab().Textflow(data.NoteS2, 560, 80).NewLine().NewLine()
                    .Text("S3").Tab().Textflow(data.NoteS3, 560, 80).NewLine().NewLine()
                    .Text("สรุป").Tab().Textflow(data.AbstractNote, 560, 80).NewLine().NewLine()
                    .Text("หมายเหตุ").NewLine()
                    .Textflow(data.Note, 560, 80).NewLine()

                    //.Text(data.AssessmentNote).NewLine().NewLine()
                //.Text("S1").Tab().Text(data.NoteS1).NewLine().NewLine()
                //.Text("S2").Tab().Text(data.NoteS2).NewLine().NewLine()
                //.Text("S3").Tab().Text(data.NoteS3).NewLine().NewLine()
                //.Text("สรุป").Tab().Text(data.AbstractNote).NewLine().NewLine()
                //.Text("หมายเหตุ").NewLine()
                //.Text(data.Note).NewLine()
                .EndPage();

            return this;
        }
        */
    }
}

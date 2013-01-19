
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Pdflib;

namespace PDFlibHelper
{
    class Test
    {
        public Test()
        {
            Com.Pdflib.Pdflib p = new Com.Pdflib.Pdflib();
            int font, image;

            // This means we must check return values of load_font() etc.
            //p.set_parameter("errorpolicy", "return");


            p.begin_document("D:\\joker.pdf", "");//Create and start document

            p.set_info("Title", "Hello, world (.NET/C#)!");//Set information

            //#region Page1:Text and Image
            //p.begin_page_ext(0, 0, "width=a4.width height=a4.height");

            //font = p.load_font("Tahoma", "unicode", "embedding fontstyle=bolditalic");
            //p.setfont(font, 8);
            //p.set_text_pos(10, 800);
            //p.setcolor("fill", "rgb", 0, 0, 0.5, 0);
            //p.show("ประเมินมูลค่าทรัพย์สิน");
            //p.setfont(font, 25);


            //p.setcolor("fill", "rgb", 0, 0, 0, 0);
            //font = p.load_font("Tahoma", "unicode", "");
            //p.setfont(font, 9);
            //p.continue_text("___________________________________________________________________________________________________________________");


            ////p.fill_textblock(1, "announcement", "f3e3t4t\nf33", "");


            //image = p.load_image("auto", "D:\\lion.jpg", "");
            //p.fit_image(image, 10, 500, "scale=0.10");

            //image = p.load_image("auto", "D:\\lion.jpg", "");
            //p.fit_image(image, 10, 0, "scale=0.20");

            //p.end_page_ext("");
            //#endregion

            //#region Page2:Create Table
            //p.begin_page_ext(0, 0, "width=a4.width height=a4.height");
            //int i, row, col, tf = -1, tbl = -1;
            //int rowmax = 50, colmax = 5;


            //double llx = 50, lly = 50, urx = 550, ury = 800;
            //string result;
            //string optlist;



            //optlist =
            //        "fittextline={font=" + font + " fontsize=10}";
            //tbl = p.add_table_cell(tbl, 1, 1, "เลขที่สัญญา", optlist);
            //tbl = p.add_table_cell(tbl, 2, 1, "รหัสลูกค้า", optlist);

            //row = 1; col = 1;
            //font = p.load_font("Times-Bold", "unicode", "");
            //for (row++; row <= rowmax; row++)
            //{
            //    for (col = 1; col <= colmax; col++)
            //    {
            //        String num;

            //        num = "Col " + col + "/Row " + row;
            //        //optlist ="colwidth=20% fittextline={font=" + num + " fontsize=10}";
            //        tbl = p.add_table_cell(tbl, col, row, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", optlist);

            //    }
            //}

            ///* ---------- Place the table on one or more pages ---------- */

            ///*
            // * Loop until all of the table is placed; create new pages
            // * as long as more table instances need to be placed.
            // */

            //optlist =
            //        "header=1 fill={{area=rowodd fillcolor={gray 0.9}}} " +
            //        "stroke={{line=other}} ";

            ///* Place the table instance */
            //result = p.fit_table(tbl, llx, lly, urx, ury, optlist);


            ///* This will also delete Textflow handles used in the table */

            //p.end_page_ext("");
            //#endregion

            #region Page3:Create Table with colspan
            p.begin_page_ext(0, 0, "width=a4.width height=a4.height");

            double llx = 40, lly = 0, urx = 580, ury = 800; // coordinates of the table
            int c1 = 90, c2 = 120, c3 = 90, tbl = -1; // widths of the three table columns
            int boldfont = p.load_font("Cordia New,Bold", "unicode", "");
            int normalfont = p.load_font("Cordia New", "unicode", "");

            string optlist = "fittextline={font=" + boldfont + " fontsize=12 position=center} " +
"margin=4 colspan=3 colwidth=" + c1;
            tbl = p.add_table_cell(tbl, 1, 1, "Our Paper Plane Models", optlist);


            optlist = "fittextline={position={left top} font=" + boldfont +
" fontsize={capheight=6}} rowheight=14 colwidth=" + c1 +
" margin=4 colspan=2";
            tbl = p.add_table_cell(tbl, 1, 2, "1 Giant Wing", optlist);

            optlist = "fittextline={position={left top} font=" + normalfont +
" fontsize={capheight=6}} rowheight=14 colwidth=" + c1 + " margin=4";
            tbl = p.add_table_cell(tbl, 1, 3, "Material", optlist);

            tbl = p.add_table_cell(tbl, 1, 4, "Benefit", optlist);

            optlist = "fittextline={position={left top} font=" + normalfont +
            " fontsize={capheight=6}} rowheight=14 colwidth=" + c2 + " margin=4";
            tbl = p.add_table_cell(tbl, 2, 3, "Offset print paper 220g/sqm", optlist);

            string tftext =
@"1. การรักและไม่ได้รับรักตอบ เป็นทุกข์ แต่สิ่งที่ทุกข์ยิ่งกว่า คือการรักใครสักคน แต่ไม่มีความกล้าพอที่จะบอกให้คนคนนั้นรู้ และต้องมาเสียใจภายหลัง 

2. พระเจ้าอาจจะต้องการให้เราพบคนที่ไม่ใช่..ก่อนที่จะมาพบคนที่ใช่ เพื่อเวลาเราพบคนคนนั้นแล้ว เราจะได้รู้สึกซาบซึ้งถึงพรที่ท่าน ประทานมา 

3. ความรักคือความรู้สึกที่คุณยังห่วงใยใครสักคนอยู่ แม้จะแยกความ รู้สึก ความลุ่มหลง และความสัมพันธ์แบบรักใคร่ออกไปแล้ว 

4. สิ่งที่น่าเศร้าในชีวิต คือการพบคนที่มีความหมายอย่างมากสำหรับเรา แต่มาค้นพบภายหลังว่าเราไม่ได้ถูกกำหนดมาเพื่อสิ่งนั้น และจะต้องปล่อยให้ผ่านพ้นไป 

5. เมื่อประตูแห่งความสุขปิดลงประตูแห่งความสุขบานอื่นก็จะเปิดขึ้นแต่เราก็มัวแต่มองประตูที่ปิดลงไปแล้วเนิ่นนานจนกระทั่งเรามองไม่เห็นประตูที่เปิดไว้รอ 

6. เพื่อนที่ดีที่สุดคือคนที่คุณสามารถนั่งอยู่ริมระเบียงด้วยกันโดยไม่พูดอะไรกันสักคำ แต่สามารถเดินจากไปด้วยความรู้สึกเหมือนได้คุยกัน อย่างประทับใจที่สุด 

7. เป็นความจริงที่เราไม่สามารถรู้เลยว่าเรามีอะไรอยู่จนกว่าเราจะสูญเสียมันไป แต่ก็จริงอีกเช่นกันที่เราไม่รู้ว่าเราพลาดอะไรไปบ้างจนกระทั่งสิ่งนั้นเข้ามาหาเรา 

8. การมอบความรักทั้งหมดให้ใครสักคนไม่ได้เป็นหลักประกันว่าเขาจะรักเราตอบ อย่าหวังที่จะได้รักตอบ แต่จงรอให้มันงอกงามขึ้นในหัวใจเขา แต่ถ้ามันไม่ได้เป็นเช่นนั้น ให้พอใจว่าอย่างน้อยมันก็ได้งอกงามขึ้นในใจของเราเอง 

9.มีสิ่งที่คุณต้องการจะได้ยิน แต่คุณจะไม่ได้ยินมันจากปากของคนที่คุณอยากได้ยิน แต่อย่าทำตัวเป็นคนหูหนวกโดยไม่รับฟังสิ่งนั้นจากคนที่เขาบอกกับคุณจากหัวใจ 

10. อย่าบอกลาถ้าคุณยังต้องการจะพยายามต่อไป อย่าท้อใจถ้าคุณยังรู้สึกว่าคุณไปไหว อย่าพูดว่าคุณไม่รักคนคนนั้นอีกแล้ว ถ้าคุณไม่สามารถทำใจ";

            optlist = "font=" + normalfont + " fontsize={capheight=6} leading=110%";
            int tf = p.add_textflow(-1, tftext, optlist);

            optlist = "textflow=" + tf + " fittextflow={firstlinedist=capheight} " +
"colwidth=" + c2 + " margin=4";
            tbl = p.add_table_cell(tbl, 2, 4, "", optlist);
            optlist = "fittextline={font=" + boldfont + " fontsize=9 position={center center}}  colwidth=" + c3 + " rowspan=3 margin=4";
            tbl = p.add_table_cell(tbl, 3, 2, "Amazingly robust!", optlist);

            optlist = "stroke={{line=other}} ";
            /* Place the table instance */
            string result = p.fit_table(tbl, llx, lly, urx, ury, optlist);
            p.delete_table(tbl, "");
            tbl = -1;
            optlist = "fittextline={position={left top} font=" + normalfont +
            " fontsize={capheight=6}} rowheight=14 colwidth=" + c2 + " margin=4";
            tbl = p.add_table_cell(tbl, 1, 1, "1 Giant Wing", optlist);
            optlist = "stroke={{line=other}} ";
            result = p.fit_table(tbl, 40, 0, 380, 310, optlist);

            p.setlinewidth(1.1);
            p.setcolor("stroke", "rgb", 0.0, 0.5, 0.5, 0.0);
            p.rect(40, 0, 540, 700);

            /* Stroke the path using the current line width and stroke color, and
             * clear it
             */
            p.stroke();

            p.end_page_ext("");
            #endregion

            p.end_document("");//End page


            System.Diagnostics.Process.Start(@"D:\joker.pdf");

        }
    }
}

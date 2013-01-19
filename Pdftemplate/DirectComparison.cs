using PDFlib_dotnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper
{
    class DirectComparison
    {
        public DirectComparison()
        {
            string path = Pdfpath.path + "DirectComparison.pdf";

            Helper p = new Helper();
            PDFlib page = p.Start_Page(path);

            p.Set_Header("ตารางเปรียบเทียบข้อมูล (Direct Comparison)");

            p.Textbold("ชื่อลูกค้า");
            p.Textbold("วันที่สำรวจ",235);
            p.Textbold("รหัสเรื่อง",380);

            p.End_page();

            System.Diagnostics.Process.Start(path);
        }
    }
}

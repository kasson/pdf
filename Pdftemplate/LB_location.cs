using PDFlib_dotnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper
{
    class LB_location
    {
        public LB_location()
        {
            string path = Pdfpath.path + "LB_location.pdf";

            Helper p = new Helper();
            PDFlib page = p.Start_Page(path);

            p.Set_Header("แผนที่ตั้งทรัพย์สิน");

            p.Textbold("ชื่อลูกค้า");
            p.Textbold("รหัสเรื่อง",380);

            p.End_page();

            System.Diagnostics.Process.Start(path);
        }
    }
}

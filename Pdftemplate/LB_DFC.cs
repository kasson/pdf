using PDFlib_dotnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper
{
    class LB_DFC
    {
        public LB_DFC()
        {
            string path = Pdfpath.path + "LB_DFC.pdf";

            Helper p = new Helper();
            PDFlib page = p.Start_Page(path);

            p.Set_Header("รายละเอียดสัญญาเช่าเพิ่มเติม");

            p.Textbold("ชื่อลูกค้า");
            p.Textbold("รหัสเรื่อง",380);

            p.End_page();

            System.Diagnostics.Process.Start(path);
        }
    }
}

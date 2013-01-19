using PDFlib_dotnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper
{
    class LB_Remark
    {
        public LB_Remark()
        {
            string path = Pdfpath.path + "LB_Remark.pdf";

            Helper p = new Helper();
            PDFlib page = p.Start_Page(path);

            p.Set_Header("รายละเอียดเพิ่มเติม");

            p.Textbold("ชื่อลูกค้า");
            p.Textbold("รหัสเรื่อง",380);

            p.End_page();

            System.Diagnostics.Process.Start(path);
        }
    }
}

using PDFlib_dotnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper
{
    class BuildingDetail
    {
        public BuildingDetail()
        {
            string path = Pdfpath.path + "BuildingDetail.pdf";

            Helper p = new Helper();
            PDFlib page = p.Start_Page(path);

            p.Set_Header("รายละเอียดสิ่งปลูกสร้าง");
            
            p.Textbold("ชื่อลูกค้า");
            p.Textbold("รหัสเรื่อง",380);

            p.End_page();

            System.Diagnostics.Process.Start(path);
        }
    }
}

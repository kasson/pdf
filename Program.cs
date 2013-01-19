using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PDFlib_dotnet;
using PDFlibHelper.Engines;

namespace PDFlibHelper
{
    static class Program
    {
        static void Main()
        {
            var pdf = new PDFGenerator("Test");

            var sheet = new SheetCreator();


            sheet
                .Page1_16(pdf, _Mock.AppraisalArchive)
                //.TEST(pdf, _Mock.AppraisalArchive)
                //.Page5_19(pdf,_Mock.AppraisalArchive)
                //.Sheet01(pdf, _Mock.AppraisalArchive, _Mock.LB_WorksheetModel)
                //.Sheet02(pdf, _Mock.AppraisalArchive, _Mock.LB_LocationModel, _Mock.LB_LanddocModel, _Mock.LB_PriceSummaryModel)
                //.Sheet03(pdf, _Mock.AppraisalArchive, _Mock.LB_BuildingModel)
                //.Sheet05(pdf, _Mock.AppraisalArchive, _Mock.LB_FDetailsModel)
            ;
            pdf.Finished();
            System.Diagnostics.Process.Start(@"D:\Test.pdf");
        }
    }
}

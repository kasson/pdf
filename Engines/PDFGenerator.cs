using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDFlib_dotnet;

namespace PDFlibHelper
{
    /// <summary>
    /// ตัวช่วยในการสร้าไฟล์ PDF
    /// </summary>
    public class PDFGenerator
    {
        #region Fields

        private const int LeftMargin = 20;
        private const int RightMargin = 575;
        private const int StartPosition = 28;
        private const int PageHeight = 800;
        private const double DefaultLineThick = 1;
        private const double BoldLineThick = 1.5;
        private const double DefaultFontSize = 9.5;
        private const double BoldFontSize = 10;
        private const double HeaderFontSize = 12;
        private double _currentCursorY;
        private double _currentCursorX;
        //private int _textFlow = -1;
        private const int FirstRowValue = 1;
        private const int FirstColumnValue = 1;
        private const int DefaultTableLineSpace = 15;
        private double _table;
        private int _row;
        private int _column;
        private int _textFlow;
        private double _tableHeightBuffer;
        private double _tableWidthBuffer;
        private double _maximumTableHeightBuffer;

        #endregion Fields

        #region Properties

        /// <summary>
        /// ตัวเขียนไฟล์เอกสาร
        /// </summary>
        public PDFlib Writer { get; private set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// กำหนดข้อมูลในการสร้างไฟล์ PDF เบื้องต้น
        /// </summary>
        /// <param name="createFileName">ชื่อไฟล์เอกสารที่จะทำการสร้าง</param>
        public PDFGenerator(string createFileName)
            : this()
        {
            Writer = new PDFlib();
            Writer.set_parameter("SearchPath", string.Empty);
            Writer.begin_document(string.Format(@"d:\{0}.pdf", createFileName), string.Empty);
        }

        /// <summary>
        /// กำหนดข้อมูลในการสร้างไฟล์ PDF เบื้องต้น
        /// </summary>
        /// <param name="writer">ตัวเขียนไฟล์เอกสาร</param>
        public PDFGenerator(PDFlib writer)
            : this()
        {
            Writer = writer;
        }

        /// <summary>
        /// กำหนดข้อมูลในการสร้างไฟล์ PDF เบื้องต้น
        /// </summary>
        private PDFGenerator()
        {
            _currentCursorY = PageHeight;
            _currentCursorX = StartPosition;
        }

        #endregion Constructors

        #region Methods

        ///// <summary>
        ///// เริ่มหน้าเพจใหม่
        ///// </summary>
        ///// <returns>this</returns>
        //public PDFGenerator BeginPage()
        //{
        //    resetPage();

        //    Writer.setfont(defaultFont(), 9);
        //    Writer.setlinewidth(1.1);
        //    Writer.setcolor("stroke", "rgb", 0.0, 0.0, 0.0, 0.0);
        //    Writer.rect(22, 30, 550, 780);
        //    Writer.stroke();
        //    return this;
        //}

        /// <summary>
        /// เริ่มหน้าเพจใหม่ โดยมีข้อมูลลูกค้า
        /// </summary>
        /// <param name="customerName">ชื่อลูกค้า</param>
        /// <param name="pageCode">รหัสเรื่อง</param>
        /// <param name="lineSpaceCount">จำนวนบรรทัดที่จะเว้นว่าง</param>
        /// <param name="title">หัวเรื่อง</param>
        /// <returns>this</returns>
        public PDFGenerator BeginPage(string customerName, string pageCode, int lineSpaceCount = 0, string title = null)
        {
            resetPage();

            var dotPosition = 783;
            var imagePosition = 776;
            var lineWidth = 755;
            if (!string.IsNullOrEmpty(title))
            {
                TextBold(title, 20, -1, HeaderFontSize).NewLine();
            }
            else
            {
                dotPosition += 15;
                lineWidth += 30;
                imagePosition += 15;
                lineSpaceCount++;
            }

            TextBold("ชื่อลูกค้า", LeftMargin)
                .Text("..................................................................................", 60, dotPosition)
                .Text(customerName, 60)
                .TextBold("รหัสเรื่อง", 300)
                .Text(".........................................................",340,dotPosition)
                .Text(pageCode, 340)
                .DrawImage("applogo.png", 500, imagePosition)
                .NewLine();

            Writer.setfont(defaultFont(), 9);
            Writer.setlinewidth(BoldLineThick);
            Writer.setcolor("stroke", "rgb", 0.0, 0.0, 0.0, 0.0);

            lineWidth -= 15 * lineSpaceCount;
            Writer.rect(LeftMargin, 20, 555, lineWidth);
            Writer.stroke();

            Writer.setlinewidth(DefaultLineThick);
            return this;
        }

        /// <summary>
        /// จบหน้าเพจที่กำลังสร้าง
        /// </summary>
        /// <returns></returns>
        public PDFGenerator EndPage()
        {
            Writer.end_page_ext(string.Empty);
            return this;
        }

        /// <summary>
        /// จบการสร้างไฟล์
        /// </summary>
        public void Finished()
        {
            Writer.end_document(string.Empty);
        }

        /// <summary>
        /// ขึ้นบรรทัดใหม่
        /// </summary>
        /// <returns>this</returns>
        public PDFGenerator NewLine()
        {
            const int LineSpace = 3;
            return newLine(LineSpace).resetTab();
        }
        /// <summary>
        /// ขึ้นบรรทัดใหม่
        /// </summary>
        /// <param name="line">จำนวนบรรทัดที่ทำการเว้น</param>
        /// <returns>this</returns>
        public PDFGenerator NewLine(int line)
        {
            int LineSpace = 3;
            return newLine(LineSpace * line).resetTab();
        }

        /// <summary>
        /// แสดงข้อความปรกติ
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <returns>this</returns>
        public PDFGenerator Text(string text)
        {
            createText(text, _currentCursorX);
            return this;
        }
        /// <summary>
        /// แสดงข้อความปรกติ
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="distanceX">ระยะห่างแกน x</param>
        /// <returns>this</returns>
        public PDFGenerator Text(string text, double distanceX)
        {
            createText(text, distanceX);
            return this;
        }
        /// <summary>
        /// แสดงข้อความปรกติ
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="distanceX">ระยะห่างแกน x</param>
        /// <param name="distanceY">ระยะห่างแกน y</param>
        /// <returns>this</returns>
        public PDFGenerator Text(string text, double distanceX, double distanceY)
        {
            createText(text, distanceX, distanceY);
            return this;
        }
        /// <summary>
        /// แสดงข้อความปรกติ
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="distanceX">ระยะห่างแกน x</param>
        /// <param name="distanceY">ระยะห่างแกน y</param>
        /// <param name="fontSize">ขนาดตัวอักษร</param>
        /// <returns>this</returns>
        public PDFGenerator Text(string text, double distanceX, double distanceY, double fontSize)
        {
            createText(text, distanceX, distanceY, fontSize);
            return this;
        }

        /// <summary>
        /// แสดงข้อความหนา
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <returns>this</returns>
        public PDFGenerator TextBold(string text)
        {
            return createText(text, isBold: true);
        }
        /// <summary>
        /// แสดงข้อความหนา
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="distanceX">ระยะห่างแกน x</param>
        /// <returns>this</returns>
        public PDFGenerator TextBold(string text, double distanceX)
        {
            return createText(text, distanceX, isBold: true);
        }
        /// <summary>
        /// แสดงข้อความหนา
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="distanceX">ระยะห่างแกน x</param>
        /// <param name="distanceY">ระยะห่างแกน y</param>
        /// <returns>this</returns>
        public PDFGenerator TextBold(string text, double distanceX, double distanceY)
        {
            return createText(text, distanceX, distanceY, isBold: true);
        }
        /// <summary>
        /// แสดงข้อความหนา
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="distanceX">ระยะห่างแกน x</param>
        /// <param name="distanceY">ระยะห่างแกน y</param>
        /// <param name="fontSize">ขนาดตัวอักษร</param>
        /// <returns>this</returns>
        public PDFGenerator TextBold(string text, double distanceX, double distanceY, double fontSize)
        {
            return createText(text, distanceX, distanceY, fontSize, true);
        }

        /// <summary>
        /// แสดงข้อความหลายบรรทัด
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="width">ความกว้างของข้อความ</param>
        /// <param name="height">ความสูงของข้อความ</param>
        /// <returns>this</returns>
        public PDFGenerator Textflow(string text, double width, double height)
        {
            _textFlow = -1;
            _textFlow = Writer.add_textflow(_textFlow, text, "fontname=Tahoma fontsize=9 encoding=unicode fillcolor={rgb 0.2 0.2 0.2} charref");
            Writer.fit_textflow(_textFlow, _currentCursorX, _currentCursorY, width, height, string.Empty);
            _currentCursorY -= (int)height;
            return this;
        }

        ///// <summary>
        ///// แสดงข้อความเอียง
        ///// </summary>
        ///// <param name="text">ข้อความ</param>
        ///// <param name="fontSize">ขนาดตัวอักษร</param>
        ///// <returns>this</returns>
        //public PDFGenerator TextItalic(string text, double fontSize = 9)
        //{
        //    _font = Writer.load_font("Tahoma,Italic", "unicode", string.Empty);
        //    Writer.setfont(_font, fontSize);
        //    Writer.show(text);
        //    return this;
        //}

        ///// <summary>
        ///// พิมพ์ข้อความลอย
        ///// </summary>
        ///// <param name="distanceX">ระยะห่างแกน x</param>
        ///// <param name="width">ความกว้าง</param>
        ///// <param name="height">ความสูง</param>
        ///// <param name="text">ข้อความ</param>
        ///// <returns>this</returns>
        //public PDFGenerator TextFlow(int distanceX, double width, double height, string text)
        //{
        //    _textFlow = Writer.add_textflow(_textFlow, text, string.Format("fontname=Tahoma fontsize=9 encoding=unicode fillcolor={rgb 0.2 0.2 0.2} charref"));
        //    string result = Writer.fit_textflow(_textFlow, distanceX, _currentCursorY, width, height, string.Empty);
        //    return this;
        //}

        /// <summary>
        /// ตรวจสอบพิกัด
        /// </summary>
        /// <returns>this</returns>
        public PDFGenerator Guidline()
        {
            NewLine();
            // X
            for (int position = 20; position < 580; position += 20)
            {
                Writer.set_text_pos(0, _currentCursorY);
                Writer.setfont(defaultFont(), DefaultFontSize);
                Writer.fit_textline(position.ToString(), position, _currentCursorY, "fillcolor={rgb 0.25 0.25 0.25}");
            }
            for (int position = 0; position < 830; position += 10)
            {
                Writer.set_text_pos(0, _currentCursorY);
                Writer.setfont(defaultFont(), DefaultFontSize);
                Writer.fit_textline(string.Format("{0:000}", position), 5, position, "fillcolor={rgb 0.25 0.25 0.25}");
            }
            NewLine();
            return this;
        }

        /// <summary>
        /// ขีดเส้นใต้
        /// </summary>
        /// <returns>this</returns>
        public PDFGenerator DrawLine()
        {
            Writer.setlinewidth(BoldLineThick);
            Writer.moveto(LeftMargin, _currentCursorY);
            Writer.lineto(RightMargin, _currentCursorY);
            Writer.stroke();
            Writer.setlinewidth(DefaultLineThick);
            return NewLine();
        }

        ///// <summary>
        ///// เขียนเส้น
        ///// </summary>
        ///// <param name="beginX">จุดเริ่มต้นในแนวนอน</param>
        ///// <param name="beginY">จุดเริ่มต้นในแนวตั้ง</param>
        ///// <param name="toX">จุดสิ้นสุดในแนวนอน</param>
        ///// <param name="toY">จุดสิ้นสุดในแนวนอน</param>
        ///// <returns>this</returns>
        //public PDFGenerator DrawLine(int beginX, int beginY, int toX, int toY)
        //{
        //    Writer.moveto(beginX, beginY);
        //    Writer.lineto(toX, toY);
        //    Writer.stroke();
        //    return this;
        //}

        /// <summary>
        /// แสดงผลรูป
        /// </summary>
        /// <param name="filePath">ตำแหน่งไฟล์รูป</param>
        /// <param name="positionX">จุดที่จะทำการแสดงผลแกนนอน</param>
        /// <param name="positionY">จุดที่จะทำการแสดงผลแกนตั้ง</param>
        /// <returns>this</returns>
        public PDFGenerator DrawImage(string filePath, int positionX, int positionY)
        {
            var image = Writer.load_image("auto", string.Format(@"d:\{0}", filePath), string.Empty);
            Writer.fit_image(image, positionX, positionY, "scale=1");
            return this;
        }

        public PDFGenerator DrawRectangle(double startPointX, double startPointY, double endPointX, double endPointY)
        {
            var width = Math.Abs(startPointX - endPointX);
            var height = Math.Abs(startPointY - endPointY);
            startPointY = Math.Abs(startPointY - height);
            Writer.rect(startPointX, startPointY, width, height);
            Writer.stroke();
            return this;
        }

        /// <summary>
        /// สร้างกล่องตรวจเช็ค
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="isChecked">สถานะของกล่อง</param>
        /// <returns>this</returns>
        public PDFGenerator CheckBox(string text, bool isChecked)
        {
            Text(createCheckBox(text, isChecked), _currentCursorX);
            return this;
        }
        /// <summary>
        /// สร้างกล่องตรวจเช็ค
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="isChecked">สถานะของกล่อง</param>
        /// <param name="distanceX">ระยะห่างแกน x</param>
        /// <returns>this</returns>
        public PDFGenerator CheckBox(string text, bool isChecked, double distanceX)
        {
            Text(createCheckBox(text, isChecked), distanceX);
            return this;
        }
        /// <summary>
        /// สร้างกล่องตรวจเช็ค
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="isChecked">สถานะของกล่อง</param>
        /// <param name="distanceX">ระยะห่างแกน x</param>
        /// <param name="fontSize">ขนาดตัวอักษร</param>
        /// <returns>this</returns>
        public PDFGenerator CheckBox(string text, bool isChecked, double distanceX, double fontSize)
        {
            const int IgnoreDistanceY = -1;
            Text(createCheckBox(text, isChecked), distanceX, IgnoreDistanceY, fontSize);
            return this;
        }

        /// <summary>
        /// สร้างกล่องข้อความตรวจเช็ค (คู่)
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="leftIsChecked">สถานะของกล่องซ้าย</param>
        /// <param name="rightIsChecked">สถานะของกล่องขวา</param>
        /// <returns>this</returns>
        public PDFGenerator DoubleCheckBox(string text, bool leftIsChecked, bool rightIsChecked)
        {
            var left = createCheckBox(string.Empty, leftIsChecked);
            Text(createCheckBox(string.Format("{0}{1}", left, text), rightIsChecked));
            return this;
        }
        /// <summary>
        /// สร้างกล่องข้อความตรวจเช็ค (คู่)
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="leftIsChecked">สถานะของกล่องซ้าย</param>
        /// <param name="rightIsChecked">สถานะของกล่องขวา</param>
        /// <param name="distanceX">ระยะห่างแกน x</param>
        /// <returns>this</returns>
        public PDFGenerator DoubleCheckBox(string text, bool leftIsChecked, bool rightIsChecked, double distanceX)
        {
            var left = createCheckBox(string.Empty, leftIsChecked);
            Text(createCheckBox(string.Format("{0}{1}", left, text), rightIsChecked), distanceX);
            return this;
        }
        /// <summary>
        /// สร้างกล่องข้อความตรวจเช็ค (คู่)
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="leftIsChecked">สถานะของกล่องซ้าย</param>
        /// <param name="rightIsChecked">สถานะของกล่องขวา</param>
        /// <param name="distanceX">ระยะห่างแกน x</param>
        /// <param name="fontSize">ขนาดตัวอักษร</param>
        /// <returns>this</returns>
        public PDFGenerator DoubleCheckBox(string text, bool leftIsChecked, bool rightIsChecked, double distanceX, double fontSize)
        {
            const int IgnoreDistanceY = -1;
            var left = createCheckBox(string.Empty, leftIsChecked);
            Text(createCheckBox(string.Format("{0}{1}", left, text), rightIsChecked), distanceX, IgnoreDistanceY, fontSize);
            return this;
        }

        /// <summary>
        /// เว้นระยะห่าง
        /// </summary>
        /// <returns>this</returns>
        public PDFGenerator Tab()
        {
            const int TabCount = 1;
            return Tab(TabCount);
        }
        /// <summary>
        /// เว้นระยะห่าง
        /// </summary>
        /// <param name="tab">จำนวนครั้งในการเว้นระยะ</param>
        /// <returns>this</returns>
        public PDFGenerator Tab(int tab)
        {
            const int TabDistance = 20;
            _currentCursorX = _currentCursorX <= StartPosition ? 20 : _currentCursorX;
            _currentCursorX += TabDistance * tab;
            return this;
        }

        /// <summary>
        /// เริ่มการสร้างตารางใหม่
        /// </summary>
        /// <returns>this</returns>
        public PDFGenerator BeginTable()
        {
            const int InitializeTable = -1;
            _table = InitializeTable;
            _row = FirstRowValue;
            _column = FirstColumnValue;

            return this;
        }

        /// <summary>
        /// จบการสร้างตาราง
        /// </summary>
        /// <returns>this</returns>
        public PDFGenerator EndTable()
        {
            return endTable();
        }
        /// <summary>
        /// จบการสร้างตาราง
        /// </summary>
        /// <param name="distanceX">ระยะห่าง</param>
        /// <returns>this</returns>
        public PDFGenerator EndTable(double distanceX)
        {
            return endTable(distanceX);
        }

        /// <summary>
        /// เขียนหัวตาราง
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="alignment">การวางตำแหน่งข้อความ</param>
        /// <returns>this</returns>
        public PDFGenerator TableHeader(string text, FontAlignment alignment = FontAlignment.Center)
        {
            return createTable(text, isHeader: true, alignment: alignment);
        }
        /// <summary>
        /// เขียนหัวตาราง
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="width">ความยาว</param>
        /// <param name="alignment">การวางตำแหน่งข้อความ</param>
        /// <returns>this</returns>
        public PDFGenerator TableHeader(string text, double width, FontAlignment alignment = FontAlignment.Center)
        {
            return createTable(text, width, isHeader: true, alignment: alignment);
        }
        /// <summary>
        /// เขียนหัวตาราง
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="width">ความยาว</param>
        /// <param name="height">ความสูง</param>
        /// <param name="alignment">การวางตำแหน่งข้อความ</param>
        /// <returns>this</returns>
        public PDFGenerator TableHeader(string text, double width, double height, FontAlignment alignment = FontAlignment.Center)
        {
            return createTable(text, width, height, isHeader: true, alignment: alignment);
        }
        /// <summary>
        /// เขียนหัวตาราง
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="width">ความยาว</param>
        /// <param name="height">ความสูง</param>
        /// <param name="fontSize">ขนาดตัวอักษร</param>
        /// <param name="alignment">การวางตำแหน่งข้อความ</param>
        /// <returns>this</returns>
        public PDFGenerator TableHeader(string text, double width, double height, double fontSize, FontAlignment alignment = FontAlignment.Center)
        {
            return createTable(text, width, height, fontSize, isHeader: true, alignment: alignment);
        }

        /// <summary>
        /// เขียนตาราง
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="alignment">การวางตำแหน่งข้อความ</param>
        /// <returns>this</returns>
        public PDFGenerator TableColumn(string text, FontAlignment alignment = FontAlignment.Center)
        {
            return createTable(text, alignment: alignment);
        }
        /// <summary>
        /// เขียนตาราง
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="width">ความกว้าง</param>
        /// <param name="alignment">การวางตำแหน่งข้อความ</param>
        /// <returns>this</returns>
        public PDFGenerator TableColumn(string text, double width, FontAlignment alignment = FontAlignment.Center)
        {
            return createTable(text, width, alignment: alignment);
        }

        /// <summary>
        /// เขียนตาราง
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="width">ความกว้าง</param>
        /// <param name="height">ความสูง</param>
        /// <param name="alignment">การวางตำแหน่งข้อความ</param>
        /// <returns>this</returns>
        public PDFGenerator TableColumn(string text, double width, double height, FontAlignment alignment = FontAlignment.Center)
        {
            return createTable(text, width, height, alignment: alignment);
        }
        /// <summary>
        /// เขียนตาราง
        /// </summary>
        /// <param name="text">ข้อความ</param>
        /// <param name="width">ความกว้าง</param>
        /// <param name="height">ความสูง</param>
        /// <param name="fontSize">ขนาดตัวอักษร</param>
        /// <param name="alignment">การวางตำแหน่งข้อความ</param>
        /// <returns>this</returns>
        public PDFGenerator TableColumn(string text, double width, double height, double fontSize, FontAlignment alignment = FontAlignment.Center)
        {
            return createTable(text, width, height, fontSize, alignment: alignment);
        }

        /// <summary>
        /// ขึ้นแถวใหม่
        /// </summary>
        /// <returns>this</returns>
        public PDFGenerator TableNewRow()
        {
            const int EmptyLine = 0;
            _tableHeightBuffer += _maximumTableHeightBuffer == EmptyLine ? DefaultTableLineSpace : _maximumTableHeightBuffer;
            _maximumTableHeightBuffer = EmptyLine;
            _row++;
            _column = FirstColumnValue;
            return this;
        }

        public PDFGenerator SetLinePosition(double positionY)
        {
            _currentCursorY = positionY;
            Writer.set_text_pos(StartPosition, _currentCursorY);
            return this;
        }

        // สร้างตาราง
        private PDFGenerator createTable(string text, double width = 60, double height = 15, double fontSize = 9, bool isHeader = false, FontAlignment alignment = FontAlignment.Center)
        {
            if (isHeader)
            {
                _tableWidthBuffer += width;
            }

            string fontAlignment = string.Empty;
            switch (alignment)
            {
                case FontAlignment.Left:
                    fontAlignment = "{left center}}";
                    break;
                case FontAlignment.Center:
                    fontAlignment = "center}";
                    break;
                case FontAlignment.Right:
                    fontAlignment = "{right center}}";
                    break;
            }

            var header = isHeader ? "matchbox={fillcolor={gray 0.92}}" : string.Empty;

            //var option = string.Format("{0}{1} fontsize={2} position={3}  colwidth={4} rowheight={5} {6}",
            //    "fittextline={font=", defaultFont(), fontSize, fontAlignment, width, height, header);

            _maximumTableHeightBuffer = _maximumTableHeightBuffer < height ? height : _maximumTableHeightBuffer;

            //_table = Writer.add_table_cell((int)_table, _column++, _row, text, option);


            var option = string.Format("{0}{1} fontsize={2} position={3}  colwidth={4} rowheight={5} {6}",
                "textflow={font=", defaultFont(), fontSize, fontAlignment, width, height, header);
            _textFlow = -1;
            var xxx = "font=" + defaultFont() + " fontsize=8";
            _textFlow = Writer.add_textflow(_textFlow, text, xxx);
            _table = Writer.add_table_cell((int)_table, _column++, _row, "", "textflow=" + _textFlow + " margin=4 colwidth=" + width + " rowheight=" + height);

            return this;
        }

        // จบการสร้างตาราง
        private PDFGenerator endTable(double distanceX = 25)
        {
            Writer.fit_table((int)_table, distanceX, _currentCursorY, 572, 0, "stroke={{line=other}}");
            _currentCursorY -= (_tableHeightBuffer + DefaultTableLineSpace + 5);
            return this;
        }

        // รีเซ็ตระยะห่าง
        private PDFGenerator resetTab()
        {
            _currentCursorX = StartPosition;
            return this;
        }

        // แสดงผลตัวอักษร
        private PDFGenerator createText(string text, double distance = 28, double lineCursor = -1, double fontSize = DefaultFontSize, bool isBold = false)
        {
            const int IgnoreLine = -1;
            var cursor = lineCursor <= IgnoreLine ? _currentCursorY : lineCursor;
            fontSize = fontSize == DefaultFontSize ? (isBold ? BoldFontSize : DefaultFontSize) : fontSize;

            Writer.set_text_pos(distance, cursor);
            Writer.setfont(defaultFont(), isBold ? BoldFontSize : fontSize);
            Writer.fit_textline(text, distance, cursor,
                isBold ? "fillcolor={rgb 0.0 0.0 0.0}" : "fillcolor={rgb 0.25 0.25 0.25}");
            return this;
        }

        // สร้างรูปแบบกล่องตรวจเช็ค
        private string createCheckBox(string text, bool isChecked)
        {
            return string.Format("[{1}] {0}", text, isChecked ? "/" : " ");
        }

        // ขนาดตัวอักษรปรกติ
        private int defaultFont()
        {
            return Writer.load_font("Tahoma", "unicode", string.Empty);
        }

        // เริ่มเพจใหม่
        private void resetPage()
        {
            _currentCursorY = PageHeight;
            Writer.begin_page_ext(0, 0, "width=a4.width height=a4.height");
        }

        // ขึ้นบรรทัดใหม่
        private PDFGenerator newLine(int lineCount)
        {
            const int LineSpace = 5;
            _currentCursorY -= LineSpace * lineCount;
            const int FontSize = 9;
            Writer.setfont(defaultFont(), FontSize);
            Writer.set_text_pos(StartPosition, _currentCursorY);
            Writer.show(string.Empty);
            return this;
        }

        //// สร้าง option ของตาราง
        //private string createTableOption(FontAlignment aligment, int width, int height, double fontSize, bool isHeader)
        //{
        //    string fontAlignment = string.Empty;
        //    switch (aligment)
        //    {
        //        case FontAlignment.Left:
        //            fontAlignment = "{left center}}";
        //            break;
        //        case FontAlignment.Center:
        //            fontAlignment = "center}";
        //            break;
        //        case FontAlignment.Right:
        //            fontAlignment = "{right center}}";
        //            break;
        //    }

        //    var header = isHeader ? "matchbox={fillcolor={gray 0.92}}" : string.Empty;
        //    return string.Format("{0}{1} fontsize={2} position={3}  colwidth={4} rowheight={5} {6}",
        //        "fittextline={font=", defaultFont(), fontSize, fontAlignment, width, height, header);
        //}

        #endregion Methods

        #region Internal classes

        /// <summary>
        /// ตำแหน่งข้อความ
        /// </summary>
        public enum FontAlignment
        {
            /// <summary>
            /// ชิดซ้าย
            /// </summary>
            Left,

            /// <summary>
            /// กึ่งกลาง
            /// </summary>
            Center,

            /// <summary>
            /// ชิดขวา
            /// </summary>
            Right
        }

        #endregion Internal classes

        public PDFGenerator Table_Column<T>(IEnumerable<T> src, Action<T> action)
        {
            foreach (var item in src)
            {
                action(item);
            }
            return this;
        }
        public PDFGenerator Table_Header(string text, double Column, double colspan = 1, double rowspan = 1, double width = 80)
        {
            if (true)
            {
                _tableWidthBuffer += width;
            }

            string fontAlignment = fontAlignment = "center}";

            var header = "matchbox={fillcolor={gray 0.92}}";
            var option = string.Format("{0}{1} fontsize={2} position={3}  colwidth={4} rowheight={5} {6} colspan={7} rowspan={8}",
            "fittextline={font=", defaultFont(), 9, fontAlignment, width, 14, header, colspan, rowspan);
            _table = Writer.add_table_cell((int)_table, (int)Column, _row, text, option);
            _column++;
            return this;
        }
        public PDFGenerator Table_Column(string text, double Column, double colspan = 1, double rowspan = 1, double width = 80, FontAlignment alignment = FontAlignment.Center)
        {
            if (true)
            {
                _tableWidthBuffer += width;
            }
            string fontAlignment = string.Empty;
            switch (alignment)
            {
                case FontAlignment.Left:
                    fontAlignment = "{left center}}";
                    break;
                case FontAlignment.Center:
                    fontAlignment = "center}";
                    break;
                case FontAlignment.Right:
                    fontAlignment = "{right center}}";
                    break;
            }

            var header = "matchbox={fillcolor={gray 0.92}}";
            var option = string.Format("{0}{1} fontsize={2} position={3}  colwidth={4} rowheight={5}  colspan={6} rowspan={7}",
            "fittextline={font=", defaultFont(), 9, fontAlignment, width, 14, colspan, rowspan);
            _table = Writer.add_table_cell((int)_table, (int)Column, _row, text, option);
            _column++;
            return this;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class Menu_CSofflineModel
    {

        /// <summary>
        /// ทรัพย์สิน
        /// </summary>
        public String CollatCSType { get; set; }
        /// <summary>
        /// ประเภททรัพย์สิน
        /// </summary>
        public String CollatGrp { get; set; }
        /// <summary>
        /// วันที่สำรวจ
        /// </summary>
        public DateTime DateSurvey { get; set; }
        /// <summary>
        /// ราคาประเมิน
        /// </summary>
        public Double AssessmentPrice { get; set; }
        /// <summary>
        /// เลขที่บ้าน
        /// </summary>
        public String AddrNum { get; set; }
        /// <summary>
        /// ชื่อหมู่บ้าน
        /// </summary>
        public String VillageName { get; set; }
        /// <summary>
        /// ชื่อถนน
        /// </summary>
        public String RoadName { get; set; }
        /// <summary>
        /// ซอย
        /// </summary>
        public String Soi { get; set; }

        /// <summary>
        /// แขวง/ตำบล
        /// </summary>
        public string Tambol { get; set; }
        /// <summary>
        /// รหัสอำเภอ
        /// </summary>
        public string Amphur { get; set; }
        /// <summary>
        /// รหัสจังหวัด
        /// </summary>
        public string Province { get; set; }
        //public ThaiLocation Location { get; set; }


        /// <summary>
        /// ค่าพิกัด X
        /// </summary>
        public Double CoordinateX { get; set; }
        /// <summary>
        /// ค่าพิกัด Y
        /// </summary>
        public Double CoordinateY { get; set; }
        /// <summary>
        /// ระวางที่ดิน
        /// </summary>
        public String LandRavang { get; set; }
        /// <summary>
        /// วิธีการค้นหา
        /// </summary>
        public String SearchType { get; set; }
        /// <summary>
        /// สถานะการเก็บอ้างอิง
        /// </summary>
        public int AddStatus { get; set; }
        /// <summary>
        /// ค้นหาข้อมูลจากแหล่งไหน
        /// </summary>
        public String SearchSRC { get; set; }
        /// <summary>
        /// รัศมีที่ค้นหา
        /// </summary>
        public Double RadiusSearch { get; set; }
    }
}

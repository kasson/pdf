using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class CollatWalkDataLists
    {
        /// <summary>
        /// รหัสสิทธิการใช้ทางเข้า-ออก
        /// </summary>
        public int CollatWalkID { get; set; }
        /// <summary>
        /// ชื่อสิทธิการใช้ทางเข้า-ออก
        /// </summary>
        public String CollatWalkName { get; set; }

        public object GetID()
        {
            return CollatWalkID;
        }

        public static readonly IEnumerable<CollatWalkDataLists> CollatWalks = new List<CollatWalkDataLists>()  {
            new CollatWalkDataLists{
                CollatWalkID = 1,
                CollatWalkName = "ที่จัดสรร",
            },
            new CollatWalkDataLists{
                CollatWalkID = 2,
                CollatWalkName = "ทางสาธารณประโยชน์",
            },
            new CollatWalkDataLists{
                CollatWalkID = 3,
                CollatWalkName = "ทางส่วนบุคคล",
            },
            new CollatWalkDataLists{
                CollatWalkID = 4,
                CollatWalkName = "ทางจดภาระจำยอมแล้ว",
            },
            new CollatWalkDataLists{
                CollatWalkID = 5,
                CollatWalkName = "ทางที่ใช้มากกว่า 10 ปี",
            },
            new CollatWalkDataLists{
                CollatWalkID = 6,
                CollatWalkName = "ทางร่วม",
            },
            new CollatWalkDataLists{
                CollatWalkID = 7,
                CollatWalkName = "ทางจำเป็น",
            },
            new CollatWalkDataLists{
                CollatWalkID = 8,
                CollatWalkName = "เข้า - ออกผ่านแปลงแม่",
            },
            new CollatWalkDataLists{
                CollatWalkID = 9,
                CollatWalkName = "ไม่มีทางเข้า - ออก",
            },
            new CollatWalkDataLists{
                CollatWalkID = 10,
                CollatWalkName = "เดินตามคันนา",
            },
            new CollatWalkDataLists{
                CollatWalkID = 11,
                CollatWalkName = "เข้า - ออก ทางน้ำ",
            },
            new CollatWalkDataLists{
                CollatWalkID = 12,
                CollatWalkName = "อื่น ๆ",
            },
        };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class LandUsingLimitDataLists
    {
        /// <summary>
        /// รหัสการใช้ประโยชน์ที่ดินตามพรบ.ผังเมือง
        /// </summary>
        public int LandUsingLimitID { get; set; }
        /// <summary>
        /// ชื่อการใช้ประโยชน์ที่ดินตามพรบ.ผังเมือง
        /// </summary>
        public String LandUsingLimitName { get; set; }

        public object GetID()
        {
            return LandUsingLimitID;
        }

        public static readonly IEnumerable<LandUsingLimitDataLists> LandUsingLimits = new List<LandUsingLimitDataLists>() {
            new LandUsingLimitDataLists{
                LandUsingLimitID = 1,
                LandUsingLimitName = "เคยประกาศบังคับใช้ผังเมือง ปัจจุบันสิ้นสุดผลการบังคับใช้แล้ว",
            },
            new LandUsingLimitDataLists{
                LandUsingLimitID = 2,
                LandUsingLimitName = "สีชมพู เป็นเขตที่ดินประเภทชุมชน",
            },
            new LandUsingLimitDataLists{
                LandUsingLimitID = 3,
                LandUsingLimitName = "สีเหลือง เป็นเขตที่ดินประเภทที่อยู่อาศัยหนาแน่นน้อย",
            },
            new LandUsingLimitDataLists{
                LandUsingLimitID = 4,
                LandUsingLimitName = "ไม่เคยประกาศบังคับใช้ผังเมือง",
            },
            new LandUsingLimitDataLists{
                LandUsingLimitID = 5,
                LandUsingLimitName = "สีแดง เป็นเขตที่ดินประเภทพาณิชกรรม",
            },
            new LandUsingLimitDataLists{
                LandUsingLimitID = 6,
                LandUsingLimitName = "สีส้ม เป็นเขตที่ดินประเภทที่อยู่อาศัยหนาแน่นปานกลาง",
            },
            new LandUsingLimitDataLists{
                LandUsingLimitID = 7,
                LandUsingLimitName = "สีเขียว เป็นเขตที่ดินประเภทชนบท และเกษตรกรรม",
            },
        };
    }
}

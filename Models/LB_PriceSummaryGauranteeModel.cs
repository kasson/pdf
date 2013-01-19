using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class LB_PriceSummaryGauranteeModel
    {
        public int OrderNo { get; set; }
        public PriceSummaryGrouping RefGroup { get; set; }
        //public LB_LanddocModel RefLand { get; set; }
        //public LB_BuildingModel RefBuilding { get; set; }
        public Guid? LandTabletID { get; set; }
        public Guid? BuildingTabletID { get; set; }

        // ข้อมูลหนังสือกรรมสิทธิ์และข้อมูลสิ่งปลูกสร้าง ----------------------------------------------------
        /// <summary>
        /// กลุ่มที่
        /// </summary>
        public int GauranteeGroupNo { get; set; }
        /// <summary>
        /// ลำดับหลักประกัน
        /// </summary>
        public int GauranteeOrderNo { get; set; }
        /// <summary>
        /// ลำดับทรัพย์สินใน
        /// </summary>
        public int PageNo { get; set; }
        /// <summary>
        /// รหัสประเภทหนังสือสำคัญ (CAT0012)
        /// </summary>
        public String DoctypeID { get; set; }
        /// <summary>
        /// ชื่อประเภทหนังสือกรรมสิทธิ์ หรือชื่อประเภทสิ่งปลูกสร้าง
        /// </summary>
        public String DoctypeName { get; set; }
        /// <summary>
        /// เอกสาร เลขที่หนังสือสำคัญ (เลขที่โฉนด เลขที่ นส3 etc.) หรือ บ้านเลขที่
        /// </summary>
        public String CollatDocNo { get; set; }
        /// <summary>
        /// อ้างอิง (หน้าสรุปราคา)
        /// </summary>
        public String Refference { get; set; }
        /// <summary>
        /// พื้นที่ ไร่-งาน-วา หรือพื้นที่ สป.
        /// </summary>
        public String PriceSpace { get; set; }

        // รายการรายละเอียด หลังจัดกลุ่มแล้ว -----------------------------------------
        /// <summary>
        /// จำนวนทรัพย์สิน
        /// </summary>
        public Double CollatQty { get; set; }
        /// <summary>
        /// ราคาต่อหน่วย
        /// </summary>
        public Double PriceUnit { get; set; }
        /// <summary>
        /// จำนวน
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// ราคาประเมินรายแปลง
        /// </summary>
        public Double AssetPrice { get; set; }
        /// <summary>
        /// จำนวนรวม
        /// </summary>
        public int SumCollatQty { get; set; }
        /// <summary>
        /// ราคาประเมินรายแปลงรวม
        /// </summary>
        public Double GauranteeGroupPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class LB_OldPriceSummaryGauranteeDetailModel
    {
        /// <summary>
        /// กลุ่มหลักประกัน
        /// </summary>
        public int PriceGroupNo { get; set; }
        /// <summary>
        /// รายละเอียดหลักประกันใหม่
        /// </summary>
        public int GauranteeOrderNo { get; set; }
        /// <summary>
        /// รหัสประเภทหนังสือสำคัญ
        /// </summary>
        public int DoctypeID { get; set; }
        /// <summary>
        /// พื้นที่(ตร.ว./ตร.ม.)
        /// </summary>
        public String PriceSpace { get; set; }
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
    }
}

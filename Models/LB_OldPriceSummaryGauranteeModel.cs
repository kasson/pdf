using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class LB_OldPriceSummaryGauranteeModel
    {
        /// <summary>
        /// กลุ่มหลักประกัน
        /// </summary>
        public int GauranteeGroupNo { get; set; }
        /// <summary>
        /// รหัสรายละเอียดกลุ่มหลักประกัน(ราคาประเมิน)
        /// </summary>
        public String PriceGroupCode { get; set; }
        /// <summary>
        /// รหัสราคาประเมิน
        /// </summary>
        public String PriceCode { get; set; }
        /// <summary>
        /// พื้นที่รวมจากจัดกลุ่ม
        /// </summary>
        public String GauranteeSpace { get; set; }
        /// <summary>
        /// ราคาต่อหน่วย
        /// </summary>
        public Double GauranteePriceUnit { get; set; }
        /// <summary>
        /// จำนวน
        /// </summary>
        public int GauranteeAmount { get; set; }
        /// <summary>
        /// ราคากลุ่มหลักประกัน
        /// </summary>
        public Double GauranteeGroupPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public class LB_PriceSummaryModel
    {
        /// <summary>
        /// รวมราคาหลักประกัน(หลักประกันใหม่)
        /// </summary>
        public Double GauranteeTotalPrice
        {
            get
            {
                if (Gaurantees != null)
                {
                    return Gaurantees.Where(it => it.GauranteeGroupNo > 0).Sum(it => it.AssetPrice);
                }
                return 0;
            }
        }

        /// <summary>
        /// ผลรวมจำนวน (หลักประกันใหม่)
        /// </summary>
        public Double GaranteeDetailTotalAmount
        {
            get
            {
                if (Gaurantees != null)
                {
                    return Gaurantees.Where(it => it.GauranteeGroupNo > 0).Sum(it => it.CollatQty);
                }
                return 0;
            }
        }

        /// <summary>
        /// รวมราคาหลักประกัน(หลักประกันเดิม)
        /// </summary>
        public Double OldGauranteeTotalPrice { get; set; }


        /// <summary>
        /// ผลรวมจำนวน (หลักประกันเดิม)
        /// </summary>
        public Double OldGaranteeDetailTotalAmount { get; set; }

        /// <summary>
        /// รวมราคาประเมิน
        /// </summary>
        //public Double GaranteeDetailTotalPrice 
        //{
        //    get 
        //    {
        //        if (PriceSummaryGauranteeDetails != null)
        //        {
        //            return PriceSummaryGauranteeDetails.Sum(it => it.AssetPrice);
        //        }
        //        return 0;
        //    }
        //    set { } 
        //}

        //public IEnumerable<LB_PriceSummaryGauranteeDetailModel> PriceSummaryGauranteeDetails { get; set; }

        public IEnumerable<LB_PriceSummaryGauranteeModel> NoGaurantees { get; set; }

        public IEnumerable<LB_PriceSummaryGauranteeModel> Gaurantees { get; set; }






        //public IEnumerable<LB_PriceSummaryBuildingModel> Buildings { get; set; }

        //public IEnumerable<LB_PriceSummaryLanddocModel> Landdocs { get; set; }

        public IEnumerable<LB_OldPriceSummaryGauranteeDetailModel> OldPriceSummaryGauranteeDetails { get; set; }

        public IEnumerable<LB_OldPriceSummaryGauranteeModel> OldGaurantees { get; set; }
    }
}

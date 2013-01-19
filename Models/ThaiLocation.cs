using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDFlibHelper.Models
{
    public struct ThaiLocation
    {

        public int ProvinceID { get; set; }
        public int AmphurID { get; set; }
        public int TambolID { get; set; }


        //////NpaModel//////
        ///// <summary>
        ///// ตำบล
        ///// </summary>
        //[BindTo(Resource.Id.TambolID, ElementType = typeof(TambolDataLists))]
        //public int TambolTh { get; set; }
        ///// <summary>
        ///// อำเถอ
        ///// </summary>
        //[BindTo(Resource.Id.AmphurID, ElementType = typeof(AmphurDataLists))]
        //public int AmphurTh { get; set; }
        ///// <summary>
        ///// จังหวัด
        ///// </summary>
        //[BindTo(Resource.Id.ProvinceID, ElementType = typeof(ProvinceDataLists))]
        //public int ProvinceTh { get; set; }
        //[BindTo(Resource.Id.LocationProvinceIdTh, ElementType = typeof(ProvinceDataLists))]
        //public int LocationProvinceIdTh { get; set; }
        //[BindTo(Resource.Id.LocationAmphurIdTh, ElementType = typeof(AmphurDataLists))]
        //public int LocationAmphurIdTh { get; set; }
        //[BindTo(Resource.Id.LocationTambolIdTh, ElementType = typeof(TambolDataLists))]
        //public int LocationTambolIdTh { get; set; }



        //////LB_locationModel///////
        //[BindTo(Resource.Id.ProvinceID, ElementType = typeof(ProvinceDataLists))]
        //public int ProvinceID { get; set; }
        //[BindTo(Resource.Id.AmphurID, ElementType = typeof(AmphurDataLists))]
        //public int AmphurID { get; set; }
        //[BindTo(Resource.Id.TambolID, ElementType = typeof(TambolDataLists))]
        //public int TambolID { get; set; }



        //////INS_LocationModel///////
        //[BindTo(Resource.Id.ProvinceID, ElementType = typeof(ProvinceDataLists))] //Spinner//
        //public int ProvinceID { get; set; }
        //[BindTo(Resource.Id.AmphurID, ElementType = typeof(AmphurDataLists))] //Spinner//
        //public int AmphurID { get; set; }
        //[BindTo(Resource.Id.TambolID, ElementType = typeof(TambolDataLists))] //Spinner//
        //public int TambolID { get; set; }



        //////Menu_CSofflineModel///////
        //[BindTo(Resource.Id.TambolID)]
        //public int TambolID { get; set; }
        //[BindTo(Resource.Id.AmphurID)]
        //public int AmphurID { get; set; }
        //[BindTo(Resource.Id.ProvinceID)]
        //public int ProvinceID { get; set; }



        ///////WS_TasksModel///////
        //[BindTo(Resource.Id.TambolID)]
        //public int TambolID { get; set; }
        //[BindTo(Resource.Id.AmphurID)]
        //public int AmphurID { get; set; }
        //[BindTo(Resource.Id.ProvinceID)]
        //public int ProvinceID { get; set; }
    }
}

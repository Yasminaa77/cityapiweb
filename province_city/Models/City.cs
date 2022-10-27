using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace province_city.Models {
    public class City{

      
        public int CityId{ get; set;}

        public string CityName{ get; set;}

        public int Population{ get; set;}

        public string Province{ get; set;}



    }

}
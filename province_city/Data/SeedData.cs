
using Microsoft.EntityFrameworkCore;
using province_city.Models;
using System.Collections.Generic;

public static class SeedData {
  // this is an extension method to the ModelBuilder class
    
    
    public static void Seed (this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData (
            GetProvinces ()
        );
        modelBuilder.Entity<City>().HasData (
            GetCities ()
        );
    }




    public static List<Province> GetProvinces () {
            List<Province> provnices = new List<Province>() {

            new Province () {           //1
            ProvinceCode = "1",
            ProvinceName = "BC",
            },

             new Province () {           //2
            ProvinceCode = "2",
            ProvinceName = "Quebec",
            },

             new Province () {           //3
            ProvinceCode = "3",
            ProvinceName = "Ontario",
            },

             new Province () {           //4
            ProvinceCode = "4",
            ProvinceName = "Alberta",
            },
        };

        return provnices;

    }
    



    public static List<City> GetCities () {

        List<City> cities = new List<City>() {
            
            new City () {              //1
            CityId = 1,   
            CityName = "Vancouver",
            Population = 12000,
            Province = "BC",

            },
             new City () {              //2
            CityId = 2,   
            CityName = "Toronto",
            Population = 12000,
            Province = "Ontario",

            },


            new City () {              //3
            CityId = 3,   
            CityName = "Quebec City",
            Population = 12000,
            Province = "Quebec",

            }

      
        };

        return cities;



    }
}


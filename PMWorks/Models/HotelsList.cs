using System.Collections.Generic;

namespace PMWorks.Models
{
    public class HotelsList
    {
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public List<HotelsList> ListOfHotels()
        {
            List<HotelsList> hotelsLists = new List<HotelsList>()
            {
                new HotelsList{HotelName="Maitland Homewood Suites",HotelAddress="New York"},
                new HotelsList{HotelName="Gild Hall",HotelAddress="New York"},
                new HotelsList{HotelName="James NewYork",HotelAddress="New York"},
                new HotelsList{HotelName="Hotel pennyslyvania",HotelAddress="New York"},
                new HotelsList{HotelName="Maitland Homewood Suites",HotelAddress="New York"},
                new HotelsList{HotelName="Gild Hall",HotelAddress="New York"},
                new HotelsList{HotelName="James NewYork",HotelAddress="New York"},
                new HotelsList{HotelName="Hotel pennyslyvania",HotelAddress="New York"}
            };
            return hotelsLists;
        }
    }
}

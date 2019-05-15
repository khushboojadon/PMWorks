using System;
using System.Collections.Generic;

namespace PMWorks.Models
{
    public class CatogriesList
    {
        public string ItemName { get; set; }

        public List<CatogriesList> ListOfCategory()
        {
            List<CatogriesList> catogries = new List<CatogriesList>()
            {
            new CatogriesList{ItemName="Mark All"},
            new CatogriesList{ItemName="Beer Dispenser"},
            new CatogriesList{ItemName="Pool" },
            new CatogriesList{ItemName="Restrooms" },
            new CatogriesList{ItemName="Electrical Rooms"},
            new CatogriesList{ItemName="Dryer"},
            new CatogriesList{ItemName="Ice Machines" }


        };
            return catogries;
        }
    }
}

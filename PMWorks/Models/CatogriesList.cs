using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PMWorks.Models
{
    public class CatogriesList
    {
        public string ItemName { get; set; }
        public ObservableCollection<CatogriesList> ListOfCategory()
        //public List<CatogriesList> ListOfCategory()
        {
            //List<CatogriesList> catogries = new List<CatogriesList>()
            ObservableCollection<CatogriesList> catogries = new ObservableCollection<CatogriesList>()
{
new CatogriesList{ItemName="Beer Dispenser"},
new CatogriesList{ItemName="Pool" },
new CatogriesList{ItemName="Restrooms" },
new CatogriesList{ItemName="Electrical Rooms"},
new CatogriesList{ItemName="Dryer"},
new CatogriesList{ItemName="Ice Machines" },
new CatogriesList{ItemName="Electrical Rooms"},
new CatogriesList{ItemName="Dryer"},
new CatogriesList{ItemName="Ice Machines" }
};
            return catogries;
        }
    }
}
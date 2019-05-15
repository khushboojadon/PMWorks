using System;
using System.Collections.Generic;

namespace PMWorks.Models
{
    public class MaintenanceOrderList
    {
        public String MaintenanceOrder { get; set; }
        public String CreatedOn { get; set; }
        public String Procedure { get; set; }
        public String Equipment { get; set; }
        public List<MaintenanceOrderList> ListOfMaintenanceOrder()
        {
            List<MaintenanceOrderList> maintenanceOrderLists = new List<MaintenanceOrderList>()
            {
            new MaintenanceOrderList{MaintenanceOrder="IHM#84902",CreatedOn="03/11/2019",Procedure="Beer Dispenser PM-QTR",Equipment="Kitchen"},
            new MaintenanceOrderList{MaintenanceOrder="IHM#84902",CreatedOn="03/11/2019",Procedure="Beer Dispenser PM-QTR",Equipment="Kitchen"},
            new MaintenanceOrderList{MaintenanceOrder="IHM#84902",CreatedOn="03/11/2019",Procedure="Beer Dispenser PM-QTR",Equipment="Kitchen"},
            new MaintenanceOrderList{MaintenanceOrder="IHM#84902",CreatedOn="03/11/2019",Procedure="Beer Dispenser PM-QTR",Equipment="Kitchen"},
            new MaintenanceOrderList{MaintenanceOrder="IHM#84902",CreatedOn="03/11/2019",Procedure="Beer Dispenser PM-QTR",Equipment="Kitchen"},
            new MaintenanceOrderList{MaintenanceOrder="IHM#84902",CreatedOn="03/11/2019",Procedure="Beer Dispenser PM-QTR",Equipment="Kitchen"},
            new MaintenanceOrderList{MaintenanceOrder="IHM#84902",CreatedOn="03/11/2019",Procedure="Beer Dispenser PM-QTR",Equipment="Kitchen"},
            new MaintenanceOrderList{MaintenanceOrder="IHM#84902",CreatedOn="03/11/2019",Procedure="Beer Dispenser PM-QTR",Equipment="Kitchen"},
            new MaintenanceOrderList{MaintenanceOrder="IHM#84902",CreatedOn="03/11/2019",Procedure="Beer Dispenser PM-QTR",Equipment="Kitchen"},
            new MaintenanceOrderList{MaintenanceOrder="IHM#84902",CreatedOn="03/11/2019",Procedure="Beer Dispenser PM-QTR",Equipment="Kitchen"},
            new MaintenanceOrderList{MaintenanceOrder="IHM#84902",CreatedOn="03/11/2019",Procedure="Beer Dispenser PM-QTR",Equipment="Kitchen"}
        };
            return maintenanceOrderLists;
        }
    }
}
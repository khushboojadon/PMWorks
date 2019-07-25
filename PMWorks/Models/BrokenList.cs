using System;
using System.Collections.Generic;

namespace PMWorks.Models
{
    public class BrokenList
    {
        public class Brokenlist
        {
            public string ItemName { get; set; }

            public List<Brokenlist> ListOfItems()
            {
                List<Brokenlist> Items = new List<Brokenlist>()
{
new Brokenlist{ItemName="Check condensate pan"},
new Brokenlist{ItemName="Clean Entire Outside"},
new Brokenlist{ItemName="Clean Condenser Coil" },
new Brokenlist{ItemName="Check condensate pan"},
new Brokenlist{ItemName="Clean Entire Outside"},
new Brokenlist{ItemName="Clean Condenser Coil" },


new Brokenlist{ItemName="Check condensate pan"},
new Brokenlist{ItemName="Clean Entire Outside"},


};
                return Items;
            }
        }
    }
}
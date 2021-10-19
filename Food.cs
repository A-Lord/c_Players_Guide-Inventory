using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Players_Guide_Inventory
{
    public class Food : InventoryItem
    {

        public Food() : base(1,0.5)
        {
            Name = "Food";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Players_Guide_Inventory
{
    public class Water : InventoryItem
    {

        public Water() : base(2,3)
        {
            Name = "Water";
        }
    }
}

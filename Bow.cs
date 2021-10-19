using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Players_Guide_Inventory
{
    public class Bow : InventoryItem
    {

        public Bow() : base(1,4)
        {
            Name = "Bow";
        }

    }
}

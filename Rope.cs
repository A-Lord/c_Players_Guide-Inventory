using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Players_Guide_Inventory
{
    public class Rope : InventoryItem
    {

        public Rope() : base(1,1.5)
        {
            Name = "Rope";
        }

    }
}

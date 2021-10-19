using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Players_Guide_Inventory
{
    public class Arrow : InventoryItem
    {

        public Arrow() : base( 0.1, 0.05)
        {
            Name = "Arrow";
        }

    }
}

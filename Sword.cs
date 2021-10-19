using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Players_Guide_Inventory
{
    public class Sword : InventoryItem
    {

        public Sword() : base(5,3)
        {
            Name = "Sword";
        }
    }
}

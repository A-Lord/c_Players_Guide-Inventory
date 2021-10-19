using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Players_Guide_Inventory
{
    public abstract class InventoryItem
    {
        protected double _weight { get; set; }
        protected double _volume { get; set; }
        public string Name { get; set; }

        protected InventoryItem(double wei, double vol)
        {
            _volume = vol;
            _weight = wei;
        }
        public (double,double) GetVolumeAndWeight()
        {
            return (_volume, _weight);
        }
        public override string ToString()
        {
            return Name;
        }


    }
}

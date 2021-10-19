using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_Players_Guide_Inventory
{
    public class Pack
    {
        private int _maxWeight { get; }
        private List<InventoryItem> Items = new List<InventoryItem>();
        private int _maxVolume { get;}
        private int _totalItems { get; }
        private double _curentWeight = 0;
        private double _CurentVolume = 0;

        public double CurentWeight { get { return _curentWeight; } set { _curentWeight = value; } }
        public double CurentVolume { get { return _CurentVolume; } set { _curentWeight = value; } }
        public int AmountOfItems { get { return Items.Count; } }

        public Pack(int maxW,int maxV,int tItems)
        {
            _maxWeight = maxW;
            _maxVolume = maxW;
            _totalItems = tItems;
        }
        public void ShowPack()
        {
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }
        public override string ToString()
        {
            string formatedReturnString = "";
            if (Items.Count > 0)
            {
                formatedReturnString = "Pack Containing ";
                foreach (var item in Items)
                {
                    formatedReturnString += item.ToString() + " ";
                }
            }
            else
            {
                formatedReturnString = "No items in pack";
            }
            return formatedReturnString;
        }
        public bool AddOne(InventoryItem item)
        {
            var WeightVolume = item.GetVolumeAndWeight();
            if (Items.Count + 1 > _totalItems | WeightVolume.Item1 + CurentWeight > _maxWeight || WeightVolume.Item2 + CurentVolume > _maxVolume)
            {
                return false;
            }
            else
            {
                Items.Add(item);
                CurentWeight += WeightVolume.Item2;
                CurentVolume += WeightVolume.Item1;
                return true;
            }
        }


    }
}

using System;
using ComputerStore_WPF.Interfaces;

namespace ComputerStore_WPF.ComputerShop.Storage
{
    class M2NVMe : iStorage
    {
        private int capacity = 250; //Default Value of 250 (250GB of Storage Space
        public string GetDescription()
        {
            if (capacity < 250)
            {
                return "* " + capacity + " TB M.2 NVMe SSD";

            }
            else { return "* " + capacity + " GB M.2 NVMe SSD"; }
            

        }

        public void SetCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        public decimal GetPrice()
        {
            return 150;
        }
    }
}

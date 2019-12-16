using System;
using ComputerStore_WPF.Interfaces;

namespace ComputerStore_WPF.ComputerShop.Storage
{
    class SATA : iStorage
    {
        private int capacity = 2; //default value 2 (2TB Storage)
        public string GetDescription()
        {
            if (capacity < 250)
            {
                return "* " + capacity + " TB Hard Drive Disk SATA";

            }
            else { return "* " + capacity + " GB Hard Drive Disk SATA"; }

        }

        public void SetCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        public decimal GetPrice()
        {
            return 50;
        }
    }
}

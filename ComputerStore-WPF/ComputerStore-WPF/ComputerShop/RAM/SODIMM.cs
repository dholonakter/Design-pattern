using System;
using ComputerStore_WPF.Interfaces;

namespace ComputerStore_WPF.ComputerShop.RAM
{
    class SODIMM : iRAM
    {
        private int capacity = 4; //Default Value 4 (4GB RAM)
        public string GetDescription()
        {
            return "* " + capacity + " GB DDR4 2133MHz SODIMM";
        }

        public void SetCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        public decimal GetPrice()
        {
            return 100;
        }
    }
}

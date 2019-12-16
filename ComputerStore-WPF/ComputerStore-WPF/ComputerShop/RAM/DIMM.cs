using ComputerStore_WPF.Interfaces;

namespace ComputerStore_WPF.ComputerShop.RAM
{
    class DIMM : iRAM
    {
        private int capacity = 4; //Default Value of 4 (4GB RAM)
        public string GetDescription()
        {
            return "* " + capacity + " GB DDR4 2133MHz DIMM";
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

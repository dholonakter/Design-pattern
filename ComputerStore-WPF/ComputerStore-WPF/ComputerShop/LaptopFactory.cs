using ComputerStore_WPF.ComputerShop.Computer;
using ComputerStore_WPF.ComputerShop.RAM;
using ComputerStore_WPF.ComputerShop.Storage;
using ComputerStore_WPF.Interfaces;

namespace ComputerShop
{
    class LaptopFactory : iComputerFactory
    {
        public iComputer CreateComputer()
        {
            return new Laptop();
        }

        public iRAM CreateRAM()
        {
            return new SODIMM();
        }

        public iStorage CreateStorage()
        {
            return new M2NVMe();
        }
    }
}

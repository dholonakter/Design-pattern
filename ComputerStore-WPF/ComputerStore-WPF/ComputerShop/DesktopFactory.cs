using ComputerStore_WPF.ComputerShop.Computer;
using ComputerStore_WPF.ComputerShop.RAM;
using ComputerStore_WPF.ComputerShop.Storage;
using ComputerStore_WPF.Interfaces;

namespace ComputerShop
{
    public class DesktopFactory : iComputerFactory
    {
        public iComputer CreateComputer()
        {
            return new Desktop();
        }

        public iRAM CreateRAM()
        {
            return new DIMM();
        }

        public iStorage CreateStorage()
        {
            return new SATA();
        }

    }
}

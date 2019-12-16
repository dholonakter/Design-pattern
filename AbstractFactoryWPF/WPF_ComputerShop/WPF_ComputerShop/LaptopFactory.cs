using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ComputerShop
{
    class LaptopFactory : iComputerFactory
    {
        private Laptop laptop;
        public iComputer CreateComputer()
        {
            laptop = new Laptop("Dell", "Precision 7740");
            return laptop;
        }

        public iRAM CreateRAM()
        {
            
            throw new NotImplementedException();
        }

        public iStorage CreateStorage()
        {
            throw new NotImplementedException();
        }
    }
}

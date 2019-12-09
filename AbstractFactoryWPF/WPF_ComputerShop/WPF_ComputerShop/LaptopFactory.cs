using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ComputerShop
{
    class LaptopFactory : iComputerFactory
    {
        public iComputer CreateComputer()
        {
            throw new NotImplementedException();
        }

        public iRAM CreateRAM()
        {
            throw new NotImplementedException();
        }

        public iStorage CreateIStorage()
        {
            throw new NotImplementedException();
        }
    }
}

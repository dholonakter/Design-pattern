using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ComputerShop
{
    interface iComputerFactory
    {
        iComputer CreateComputer();
        iRAM CreateRAM();
        iStorage CreateStorage();
    }
}

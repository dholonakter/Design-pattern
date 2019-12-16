using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ComputerShop
{
    abstract class iRAM
    {
        public double Price;
        public int Capacity;

        protected iRAM(int capacity)
        {
            Capacity = capacity;
        }
    }
}

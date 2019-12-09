using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ComputerShop
{
    abstract class iStorage
    {
        public double Price;
        public int Capacity;

        protected iStorage(int capacity)
        {
            Capacity = capacity;
        }
    }
}

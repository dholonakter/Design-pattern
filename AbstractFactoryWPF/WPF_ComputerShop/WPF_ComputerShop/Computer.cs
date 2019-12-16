using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ComputerShop
{
    #region Laptop CLass
    class Laptop : iComputer
    {
        public Laptop(string brand, string model) : base(brand, model)
        {
            Brand = brand;
            Model = model;
        }
    }
    #endregion


    #region Desktop Class

    class Desktop : iComputer
    {
        public Desktop(string brand, string model) : base(brand, model)
        {
            Brand = brand;
            Model = model;
        }
    }
    #endregion
}

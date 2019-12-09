using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ComputerShop
{
    #region RAM

    #region Laptop RAM Class

    class SODIMM : iRAM
    {
        public SODIMM(int capcity) : base(capcity)
        {
        }
    }
    #endregion

    #region Desktop RAM Class

    class DIMM : iRAM
    {
        public DIMM(int capcity) : base(capcity)
        {
        }
    }
    #endregion

    #endregion

    #region Storage

    #region Laptop STorage Class

    class mSATA : iStorage
    {
        public mSATA(int capacity) : base(capacity)
        {
        }
    }
    #endregion

    #region Desktop STorage Class

    class SATA : iStorage
    {
        public SATA(int capacity) : base(capacity)
        {
        }
    }
    #endregion
    #endregion
}

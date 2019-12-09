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

    }
    #endregion

    #region Desktop RAM Class

    class DIMM : iRAM
    {

    }
    #endregion

    #endregion

    #region Storage

    #region Laptop STorage Class

    class mSATA : iStorage
    {

    }
    #endregion

    #region Desktop STorage Class

    class SATA : iStorage
    {

    }
    #endregion
    #endregion
}

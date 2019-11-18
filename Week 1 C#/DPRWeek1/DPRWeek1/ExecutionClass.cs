using System;
using System.Collections.Generic;

namespace DPRWeek1
{
    internal abstract class ExecutionClass
    {
        private protected int listLength = 20;
        private protected List<int> intList = new List<int>();
        private protected ISchedular schedular;

        #region Create int List
        private protected void createList()
        {
            Random rdm = new Random();
            for (int i = 0; i < listLength; i++)
            {
                int rdmInt = rdm.Next(0, 100);
                intList.Add(rdmInt);
                for (int j = 0; j < intList.Count; j++)
                {
                    if (intList[i] == intList[j])
                    {
                        rdmInt = rdm.Next(0, 100);
                        intList[i] = rdmInt;
                        j = 0;
                    }
                }
            }
        }
        #endregion

        #region
        
        #endregion
    }
}

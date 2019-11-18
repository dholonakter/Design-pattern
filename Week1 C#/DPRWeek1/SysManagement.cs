using System;
using static System.Math;
using static System.Int32;
using System.Collections.Generic;


namespace DPRWeek1
{
    #region Class First Come Fisrt Serve
    class FCFS : ISchedular
    {
        public List<int> Schedule(List<int> intList)
        {
            return intList;
        }
    }
    #endregion

    #region Class Shortest Seek Time First
    #region Internal Classes Shortest Seek Time First
    internal class node
    {
        // represent difference between
        // head position and track number
        internal int distance = 0;

        // true if track has been accessed
        internal Boolean accessed = false;
    }
    internal class sstf
    {
        // Calculates difference of each
        // track number with the head position
        internal static void calculateDifference(List<int> queue, int head, List<node> diff)
        {
            for(int i = 0; i < diff.Count; i++) { diff[i].distance = Abs(queue[i] - head); }
        }
        //Find unaccessed track
        //which is at minimum distance from head
        internal static int findMin(List<node> diff)
        {
            int index = -1, minimum = MaxValue;
            for(int i = 0; i < diff.Count; i++)
            {
                if (!diff[i].accessed && minimum > diff[i].distance)
                {
                    minimum = diff[i].distance;
                    index = i;
                }
            }
            return index;
        }
        internal static List<int> sstfmethod(List<int> request)
        {
            Random rdmHead = new Random();
            int head = rdmHead.Next(0, 100);
            //Create list of objects with class node
            List<node> diff = new List<node>(request.Count);
            //initialize list
            for(int i = 0; i < diff.Count; i++) { diff[i] = new node(); }
            //Count number of seek operations
            int seek_count = 0;
            //store sequence in which disk access is done
            List<int> seek_sequence = new List<int>(request.Count + 1);
            for(int i = 0; i < request.Count; i++)
            {
                seek_sequence[i] = head;
                calculateDifference(request, head, diff);
                int index = findMin(diff);
                diff[index].accessed = true;
                //increase the total count
                seek_count += diff[index].distance;
                //accessed track is now new head
                head = request[index];
            }
            //for last accessed track
            seek_sequence[seek_sequence.Count - 1] = head;
            return seek_sequence;
        }
    }
    #endregion
    class SSTF : ISchedular
    {
        public List<int> Schedule(List<int> intList)
        {
            return sstf.sstfmethod(intList);
        }
    }
    #endregion

    #region Class Scan Disk Scheduling
    class SDS : ISchedular
    {
        public List<int> Schedule(List<int> intList)
        {
            List<int> tmpList = new List<int>();
            Random rdmLoc = new Random();
            int i, j, n;
            int disk;       //Location of head
            int temp;
            int dloc = -1;       //Location of Disk in Array
            //int sum = 0, max;
            n = intList.Count;          //Number of elements
            disk = rdmLoc.Next(0, n);   //Set Random Position
            intList[n] = disk;
            n += 1;
            for(i = 0; i < n; i++)
            {
                for(j = i; j < n; j++)
                {
                    if (intList[i] > intList[j])
                    {
                        temp = intList[i];
                        intList[i] = intList[j];
                        intList[j] = temp;
                    }
                }
            }
            //max = intList[n - 1];
            for (i = 0; i < n; i++)
            {
                if (disk == intList[i]) { dloc = i; break; }
            }
            for (i = dloc; i > 0; i--)
            {
                tmpList.Add(intList[i]);
            }
            for (i = dloc + 1; i < n; i++)
            {
                tmpList.Add(intList[i]);
            }
            return tmpList;
        }
    }
    #endregion
}

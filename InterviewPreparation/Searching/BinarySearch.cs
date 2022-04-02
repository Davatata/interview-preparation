using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Searching
{
    public static class BinarySearch
    {
        public static int Search(int [] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return -1;
        }

        public static int MySqrt(int x)
        {
            int low = 0;
            int high = 50000;

            if (x < 50000)
                high = x;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                // To avoid int overflow
                uint sqrd = (uint)mid * (uint)mid;
                if (sqrd == x)
                    return mid;
                else if (sqrd < x)
                {
                    if (low == high)
                        return mid;
                    low = mid + 1;
                }
                else
                    high = mid - 1;
            }

            return high;
        }

    }
}

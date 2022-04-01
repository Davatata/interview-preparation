using System;

namespace DataStructures.Arrays
{
    public static class ArrayMethods
    {
        public static int[] SortedSquares(int[] nums)
        {
            var i = 0;
            var j = nums.Length - 1;
            var ans = new int[nums.Length];

            for (var max = j; max >= 0; max--)
            {
                if (Math.Abs(nums[i]) >= Math.Abs(nums[j]))
                {
                    ans[max] = nums[i] * nums[i];
                    i++;
                }
                else
                {
                    ans[max] = nums[j] * nums[j];
                    j--;
                }
            }

            return ans;
        }
    }
}

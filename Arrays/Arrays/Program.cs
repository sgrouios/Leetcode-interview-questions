
using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length > 1)
            {
                var count = 1;
                for (var i = 1; i < nums.Length; i++)
                {
                    if (nums[i - 1] != nums[i])
                    {
                        nums[count] = nums[i];
                        count++;
                    }
                }
                return count;
            }
            else
            {
                return nums.Length;
            }
        }

        public static int MaxProfit(int[] prices)
        {
            var profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }
            return profit;
        }


        /// <summary>
        /// Rotate each int in "nums" forward by "k"
        /// </summary>
        /// <param name="nums"> Array of integers</param>
        /// <param name="k"> Value to rotate each number forward by</param>
        /// <returns> Rotated array</returns>
        public static int[] RotateBrute(int[] nums, int k)
        {
            int len = nums.Length;
            int[] copy = new int[len];
            for (int i = 0; i < len; i++)
            {
                copy[(i + k) % len] = nums[i];
            }
            for (int i = 0; i < len; i++)
            {
                nums[i] = copy[i];
            }
            return nums;
        }

        public static bool ContainsDuplicateHashSet(int[] nums)
        {
            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numbers.Contains(nums[i]))
                    return true;
                numbers.Add(nums[i]);
            }
            return false;
        }

        public static bool ContainsDuplicateSort(int[] nums)
        {
            System.Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    return true;
                }
            }
            return false;
        }

        public static int SingleNumberLinq(int[] nums)
        {
            List<int> numList = new List<int>(nums);
            for (int i = 0; i < numList.Count; i++)
            {
                if (numList.Count(x => x == i) == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int SingleNumberXOR(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }
}

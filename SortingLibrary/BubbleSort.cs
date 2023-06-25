using System;
using System.Collections.Generic;

namespace SortingLibrary
{
    public class BubbleSort : ISortingAlgorithm
    {
        public static IList<int> Sort(IList<int> nums)
        {
            while (true)
            {
                var sorted = true;

                for (var i = 0; i < nums.Count - 1; i++)
                {
                    if (nums[i] <= nums[i + 1])
                    {
                        continue;
                    }

                    sorted = false;
                    (nums[i], nums[i+1]) = (nums[i+1], nums[i]);
                }

                Console.WriteLine(string.Join(' ', nums));

                if (sorted)
                {
                    break;
                }
            }

            return nums;
        }
    }
}
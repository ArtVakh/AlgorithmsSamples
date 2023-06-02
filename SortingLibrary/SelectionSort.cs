using System;
using System.Collections.Generic;

namespace SortingLibrary
{
    public class SelectionSort : ISortingAlgorithm
    {
        public IList<int> Sort(IList<int> nums)
        {
            for (var i = 0; i < nums.Count - 1; i++)
            {
                var min = nums[i];
                var minIdx = i;

                for (var j = i + 1; j < nums.Count; j++)
                {
                    if (nums[j] >= min)
                    {
                        continue;
                    }

                    min = nums[j];
                    minIdx = j;
                }

                (nums[i], nums[minIdx]) = (nums[minIdx], nums[i]);

                Console.WriteLine(string.Join(' ', nums));
            }

            return nums;
        }
    }
}
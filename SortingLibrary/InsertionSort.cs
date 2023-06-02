using System;
using System.Collections.Generic;

namespace SortingLibrary
{
    public class InsertionSort : ISortingAlgorithm
    {
        public IList<int> Sort(IList<int> nums)
        {
            for (var i = nums.Count - 2; i >= 0; i--)
            {
                var taken = nums[i];

                var j = i + 1;
                while (j < nums.Count && taken > nums[j])
                {
                    nums[j - 1] = nums[j];
                    j++;
                }

                nums[j - 1] = taken;

                Console.WriteLine(string.Join(' ', nums));
            }

            return nums;
        }
    }
}
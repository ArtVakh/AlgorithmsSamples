using System.Collections.Generic;

namespace SortingLibrary;

public class QuickSort : ISortingAlgorithm
{
    public static IList<int> Sort(IList<int> nums)
    {
        InnerSort(nums, 0, nums.Count - 1);

        return nums;
    }

    private static void InnerSort(IList<int> nums, int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        var dividerIndex = PlaceDivider(nums, start, end);

        InnerSort(nums, start, dividerIndex - 1);
        InnerSort(nums, dividerIndex + 1, end);
    }

    private static int PlaceDivider(IList<int> nums, int low, int high)
    {
        var divider = nums[high];

        while (low < high)
        {
            while (low < high)
            {
                if (nums[low] > divider)
                {
                    nums[high] = nums[low];
                    break;
                }

                low++;
            }

            while (low < high)
            {
                if (nums[high] < divider)
                {
                    nums[low] = nums[high];
                    break;
                }

                high--;
            }
        }

        nums[low] = divider;

        return low;
    }
}
using System.Collections.Generic;

namespace SortingLibrary
{
    public static class SortingExtension
    {
        public static IList<int> Sort<TAlg>(this IList<int> nums)
            where TAlg : ISortingAlgorithm => TAlg.Sort(nums);
    }
}
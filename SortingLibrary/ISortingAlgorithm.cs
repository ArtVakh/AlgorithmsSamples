using System.Collections.Generic;

namespace SortingLibrary
{
    public interface ISortingAlgorithm
    {
        IList<int> Sort(IList<int> nums);
    }
}
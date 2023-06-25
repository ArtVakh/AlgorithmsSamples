using System.Collections.Generic;

namespace SortingLibrary
{
    public interface ISortingAlgorithm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2252:This API requires opting into preview features", Justification = "<Pending>")]
        static abstract IList<int> Sort(IList<int> nums);
    }
}
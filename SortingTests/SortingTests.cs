using System.Linq;

using FluentAssertions;

using SortingLibrary;

using Xunit;

namespace SortingTests;

public class SortingTests
{
    [Fact]
    public void BubbleSortTest()
    {
        var arr = Utils.InitArray(10, 1);
        var copy = arr.ToArray();

        arr.Sort<BubbleSort>();

        arr.Should().BeEquivalentTo(copy);
        arr.Should().BeInAscendingOrder();
    }

    [Fact]
    public void QuickSortTest()
    {
        var arr = Utils.InitArray(10, 1);
        var copy = arr.ToArray();

        arr.Sort<QuickSort>();

        arr.Should().BeEquivalentTo(copy);
        arr.Should().BeInAscendingOrder();
    }
}
using FluentAssertions;

using SortingLibrary;

namespace SortingTests;

public class SortingTests
{
    [Fact]
    public void BubbleTest()
    {
        var arr = Utils.InitArray(10);
        var copy = arr.ToArray();

        arr.Sort();

        arr.Should().BeEquivalentTo(copy);
        arr.Should().BeInAscendingOrder();
    }
}
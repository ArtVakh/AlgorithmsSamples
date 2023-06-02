using LeetCode;

namespace LeetCodeTests;

public class KataTests
{
    [Fact]
    public void ArrayDiffTest()
    {
        Assert.Equal(new int[] {2},       Kata.ArrayDiff(new int[] {1, 2},    new int[] {1}));
        Assert.Equal(new int[] {2, 2},    Kata.ArrayDiff(new int[] {1, 2, 2}, new int[] {1}));
        Assert.Equal(new int[] {1},       Kata.ArrayDiff(new int[] {1, 2, 2}, new int[] {2}));
        Assert.Equal(new int[] {1, 2, 2}, Kata.ArrayDiff(new int[] {1, 2, 2}, new int[] {}));
        Assert.Equal(new int[] {},        Kata.ArrayDiff(new int[] {},        new int[] {1, 2}));
        Assert.Equal(new int[] {3}, Kata.ArrayDiff(new int[] {1, 2, 3}, new int[] {1, 2}));
    }

    [Fact]
    public void ArrayDiffTest2()
    {
        Assert.Equal(new int[] {2},       Kata.ArrayDiff2(new int[] {1, 2},    new int[] {1}));
        Assert.Equal(new int[] {2, 2},    Kata.ArrayDiff2(new int[] {1, 2, 2}, new int[] {1}));
        Assert.Equal(new int[] {1},       Kata.ArrayDiff2(new int[] {1, 2, 2}, new int[] {2}));
        Assert.Equal(new int[] {1, 2, 2}, Kata.ArrayDiff2(new int[] {1, 2, 2}, new int[] {}));
        Assert.Equal(new int[] {},        Kata.ArrayDiff2(new int[] {},        new int[] {1, 2}));
        Assert.Equal(new int[] {3}, Kata.ArrayDiff2(new int[] {1, 2, 3}, new int[] {1, 2}));
    }
}
using LeetCode;

namespace LeetCodeTests
{
    public class LeetTest
    {
        [Fact]
        public void MergeSortedArrayTest1()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            var m = 3;

            int[] nums2 = { 2,5,6 };
            var n = 3;

            Class1.Merge(nums1, m, nums2, n);

            int[] expected = { 1,2,2,3,5,6 };
            Assert.Equal(expected, nums1);
        }

        [Fact]
        public void MergeSortedArrayTest2()
        {
            int[] nums1 = { 1 };
            var m = 1;

            int[] nums2 = { };
            var n = 0;

            Class1.Merge(nums1, m, nums2, n);

            int[] expected = { 1 };
            Assert.Equal(expected, nums1);
        }

        [Fact]
        public void MergeSortedArrayTest3()
        {
            int[] nums1 = { 0 };
            var m = 0;

            int[] nums2 = { 1 };
            var n = 1;

            Class1.Merge(nums1, m, nums2, n);

            int[] expected = { 1 };
            Assert.Equal(expected, nums1);
        }
    }
}
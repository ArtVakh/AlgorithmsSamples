using System.Linq;

namespace LeetCode
{
    public class Class1
    {
        //1342. Number of Steps to Reduce a Number to Zero
        public int NumberOfSteps(int num) 
        {
            var steps = 0;
            while(num > 0)
            {
                
                num = num % 2 == 0 ? num / 2 : num - 1;
                steps++;
            }
            
            return steps;
        }

        //88. Merge Sorted Array
        //https://leetcode.com/problems/merge-sorted-array/?envType=study-plan-v2&id=top-interview-150
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var lastIndex = m + n - 1;
            var p1 = m - 1;
            var p2 = n - 1;

            while (lastIndex > -1)
            {
                if (p2 < 0 || (p1 > -1 && nums1[p1] > nums2[p2]))
                {
                    nums1[lastIndex] = nums1[p1];
                    p1--;
                } 
                else if(p1 < 0 || nums2[p2] >= nums1[p1])
                {    
                    nums1[lastIndex] = nums2[p2];
                    p2--;
                }

                lastIndex--;
            }
        }

        //https://leetcode.com/problems/valid-palindrome
        public static bool IsPalindrome(string s)
        {
            var normalized = s.ToLower().Where(char.IsLetterOrDigit).ToArray();

            for (int i = 0, j = normalized.Length - 1; i < j; i++, j--)
            {
                if (normalized[i] != normalized[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

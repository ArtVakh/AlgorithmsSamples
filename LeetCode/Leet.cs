using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Leet
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

        //https://leetcode.com/problems/copy-list-with-random-pointer/description/
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }

            var dict = new Dictionary<Node, Node>();
            var newHead = new Node {val = head.val};
            dict.Add(head, newHead);

            var cur = head.next;
            var curNew = newHead;
            while (cur != null)
            {
                var nextNewNode = new Node
                {
                    val = cur.val,
                    prev = curNew
                };

                dict.Add(cur, nextNewNode);

                curNew.next = nextNewNode;
                curNew = curNew.next;
                cur = cur.next;
            }

            cur = head;
            curNew = newHead;
            while (cur != null)
            {
                if (cur.random != null)
                {
                    curNew.random = dict[cur.random];
                }

                cur = cur.next;
                curNew = curNew.next;
            }

            return newHead;
        }

        //https://leetcode.com/problems/richest-customer-wealth
        public int MaximumWealth(int[][] accounts)
        {
            return accounts.Select(bankAccounts => bankAccounts.Sum()).Max();
        }

        //https://leetcode.com/problems/running-sum-of-1d-array/
        public int[] RunningSum(int[] nums)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                nums[i + 1] += nums[i];
            }

            return nums;
        }
    }
}

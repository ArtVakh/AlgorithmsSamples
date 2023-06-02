using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            // Your brilliant solution goes here
            // It's possible to pass random tests in about a second ;)

            var hashSet = new HashSet<int>(a.Length);
            var result = new List<int>(a.Length);

            foreach (var i in b)
            {
                hashSet.Add(i);
            }

            result.AddRange(a.Where(i => !hashSet.Contains(i)));

            result.TrimExcess();

            return result.ToArray();
        }

        public static int[] ArrayDiff2(int[] a, int[] b)
        {
            var arrayDiff2 = a.Except(b).ToArray();
            return arrayDiff2;
        }
    }
}

using System;

namespace SortingLibrary
{
    public static class Utils
    {
        public static int[] InitArray(int elementsNumber, int seed)
        {
            var arr = new int[elementsNumber];
            var rand = new Random(seed);

            for (var i = 0; i < elementsNumber; i++)
            {
                arr[i] = rand.Next(10);
            }

            return arr;
        }
    }
}
using SortingLibrary;

namespace ConsoleApp
{
    public class Program
    {
        private const int ElementsNumber = 10;
        private const int Seed = 1;

        public static void Main()
        {
            var arr = Utils.InitArray(ElementsNumber, Seed);
            PrintArray(arr);

            arr.Sort<QuickSort>();

            PrintArray(arr);
            Console.ReadLine();
        }

        private static void PrintArray(IList<int> arr)
        {
            Console.WriteLine(string.Join(' ', arr));
            Console.WriteLine();
        }
    }
}
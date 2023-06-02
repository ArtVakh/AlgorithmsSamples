using SortingLibrary;

namespace ConsoleApp
{
    public class Program
    {
        private const int ElementsNumber = 10;

        public static void Main()
        {
            var arr = Utils.InitArray(ElementsNumber);
            PrintArray(arr);

            arr.Sort();

            Console.ReadLine();
        }

        private static void PrintArray(IList<int> arr)
        {
            Console.WriteLine(string.Join(' ', arr));
            Console.WriteLine();
        }
    }
}
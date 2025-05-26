namespace Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 11, 2, 3, 4, 4 };
            HashSet<int> set = new HashSet<int>(arr);
            foreach (var item in set)
            {
                Console.WriteLine(item);
                
            }
        }
    }
}

    
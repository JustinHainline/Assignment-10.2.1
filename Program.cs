using System.Globalization;

namespace Assignment_10._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] posArray = { 2, -1, 3, -3, 10, -200 };

            var numQuery = from num in posArray where num > 0 select num;
            foreach ( int num in numQuery )
            {
                Console.Write(num + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number N for search factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the number M for search other factorial");
            int m = Convert.ToInt32(Console.ReadLine());
            int factN = 1;
            int factM = 1;
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }
            for (int i = 1; i <= m; i++)
            {
                factM *= i;
            }
            Console.WriteLine("N! - M! = " + (factN - factM));
            Console.ReadKey();
        }
    }
}

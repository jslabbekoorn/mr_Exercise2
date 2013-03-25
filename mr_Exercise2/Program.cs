using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int intRegel;

            Console.WriteLine("Geef 5 zinnen in. \n");

            string[] stringArray = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Zin" + (i + 1) + ": ");
                stringArray[i] = Console.ReadLine();
            }

            Console.WriteLine("Welke regel wil je oprvragen?");
            intRegel = Int32.Parse(Console.ReadLine());
            intRegel = intRegel - 1;

            Console.WriteLine(stringArray[intRegel]);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign1_Assessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            string input = Console.ReadLine();
            int result = int.Parse(input);
            Console.WriteLine("Parsed integer: " + result);

            Console.WriteLine("Enter an integer: ");
            string inpu = Console.ReadLine();
            int resul = Convert.ToInt32(inpu);
            Console.WriteLine("Converted integer: " + resul);

            Console.WriteLine("Enter an integer: ");
            string inpt = Console.ReadLine();
            int reslt;
            if (int.TryParse(inpt, out reslt))
            {
                Console.WriteLine("Try Parsed integer: " + reslt);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}

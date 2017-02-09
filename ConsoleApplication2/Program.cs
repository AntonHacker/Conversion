using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string Google;
                int A;
                Console.WriteLine("Введите любое целое число");
                Google = Console.ReadLine();
                Int32.TryParse(Google, out A);
                A = A * A;
                Console.WriteLine("Sqare is" + A);

            }
            
        } 
    }
}

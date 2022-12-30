using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers_Pro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end, conter;
            Console.Write("Enter your first number : ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter your last number: ");
            end=int.Parse(Console.ReadLine());


            for (; start < end; start++)
            {
                for (conter = 2; conter < start; conter++)
                {
                    if (start % conter == 0)
                    {
                        break;
                    }
                }
                if (start == conter)
                {
                    Console.WriteLine(start);
                }
            }
            Console.ReadKey();
        }
    }
}

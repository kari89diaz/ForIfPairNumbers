using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIf
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 0; num < 11; num++) //no me dejo poner num = 10
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num + "Es par");
                }
                else
                {
                    Console.WriteLine(num + "Es impar");
                }
            }
        }
    }
}

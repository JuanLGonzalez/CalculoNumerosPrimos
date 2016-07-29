using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eduardo_Caian_LucasBauer_2003
{
    class List
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque um Número");
            int a = Convert.ToInt32(Console.ReadLine());
            bool Prime = true;
            for (int i = 1; i <= a; i++)
            {
                for (int j = 2; j <= a; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
                if (Prime)
                {
                    Console.WriteLine("Números Primos:    " + i);
                }
                
                Prime = true;
            }
            Console.ReadLine();
        }
    }
}

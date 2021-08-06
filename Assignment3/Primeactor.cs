using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class PrimeaFactor
   
        {

            public static void Factor(int a)
            {
                int z;
                for (z = 1; z<= a; z++)
                {
                    if (a % z == 0)
                    {
                        Console.WriteLine(z + " is a factor of " + a);
                    }
                }
            }
        }
    
}


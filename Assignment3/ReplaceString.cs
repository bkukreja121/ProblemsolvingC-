using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class ReplaceString
    {
        public static void Replace()
        {


            Console.WriteLine("Enter your name:");
            string str1 = Console.ReadLine();
            Console.WriteLine("'{0}' length : {1}", str1, str1.Length);
            if (str1.Length > 3)
            {
                Console.WriteLine($"Hello {str1} How are you?");
            }
            else
            {
                Console.WriteLine("Enter your name with more than 3 char");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class FizzBuzz
    {
        
        public static string GetFizzyBuzz(int n)
        {
            if (n % 5 == 0 && n % 9 == 0)
            {
                return "La La Land";
            }
            else if (n % 5 == 0)
            {
                return "La La";
            }
            else if (n % 9 == 0)
            {
                return "Land";
            }
            else
            {
                return "Not Found";
            }
        }

        static void Main()
        {
            int n = 15;
            string result = FizzBuzz.GetFizzyBuzz(n);
            Console.WriteLine(result);
        }
    }

}


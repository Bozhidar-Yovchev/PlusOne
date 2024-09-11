using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array:");
            int[] digits = Console.ReadLine().Split().Select(int.Parse).ToArray();
            PlusOne(digits);
        }

        public static void PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    Console.WriteLine("Result: " + string.Join(", ", digits));
                    return;
                }
                digits[i] = 0;
            }

            
            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = 1; 
            Console.WriteLine("Result: " + string.Join(", ", newDigits));
        }

    }
}

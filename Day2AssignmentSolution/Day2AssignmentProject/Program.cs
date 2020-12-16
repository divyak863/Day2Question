using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2AssignmentProject
{
    class Program
    {
        static bool FindPrimeOrNot(int num)
        {
            bool bResult = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    bResult = false;
                    break;
                }
            }
            return bResult;
        }
        static void PrintPrimeNumbers()
        {
            int min, max;
            Console.WriteLine("Please enter the minimum number");
            min= int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the maximum number");
            max= int.Parse(Console.ReadLine());
            while (min <= max)
            {
                if (FindPrimeOrNot(min) == true)
                    Console.WriteLine(min);
                min++;
            }
           
           
        }
        static void Main(string[] args)
        {
            PrintPrimeNumbers();
            Console.ReadKey();
               
        }
    }
}

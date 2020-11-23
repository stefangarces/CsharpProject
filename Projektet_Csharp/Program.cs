using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektet_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');

            if (input.Contains("plus"))
            {
                char num1 = input[0];
                char num2 = input[2];
                string x = num1.ToString();
                string y = num2.ToString();
                result = int.Parse(x) + int.Parse(y);
                Console.WriteLine(result);
            }
            else if (input.Contains("minus"))
            {
                Console.WriteLine("Yes, minus");
            }
            else if (input.Contains("times"))
            {
                Console.WriteLine("Yes, times brother");
            }

            Console.ReadLine();

            /*
            int num1;
            int num2;
            while (true)
            {
                Console.Write("Enter the First Number : ");
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    break;
                }
                Console.WriteLine("Please enter an integer value!");
            }

            /*
            string string1 = "1000";
            string string2 = "500";

            int number1;
            // int number2;
            number1 = int.Parse(string1) + int.Parse(string2);
            // number2 = 

            Console.WriteLine(number1);
            Console.ReadLine();
            */
        }
    }
}

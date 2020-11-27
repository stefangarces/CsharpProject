using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektet_Csharp
{
    public class Parse
    {
        public static void Parser()
        {
            Console.WriteLine("Input a value");
            string input = Console.ReadLine().ToLower();
            string[] tokens = input.Split(' ');

            try
            {
                // If statement to find the operators "plus", "minus" and "times"
                // and also to send the user to "Invalid Format", if the user doesn't
                // use the right format ("four minus one" e.g.)
                if (input.Contains("plus"))
                {
                    var num1 = Wordtovalue.wordvalue[tokens[0]];
                    var num2 = Wordtovalue.wordvalue[tokens[2]];

                    Console.WriteLine(num1 + num2);
                }
                else if (input.Contains("minus"))
                {
                    var num1 = Wordtovalue.wordvalue[tokens[0]];
                    var num2 = Wordtovalue.wordvalue[tokens[2]];

                    Console.WriteLine(num1 - num2);
                }
                else if (input.Contains("times"))
                {
                    var num1 = Wordtovalue.wordvalue[tokens[0]];
                    var num2 = Wordtovalue.wordvalue[tokens[2]];

                    Console.WriteLine(num1 * num2);
                }
                else
                {
                    Console.WriteLine("Invalid format. Try again.");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid format. Try again.");
            }
        }
    }
    public class Wordtovalue
    {
        // Turns words into value
        public static Dictionary<string, int> wordvalue = new Dictionary<string, int>()
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 },
            { "ten", 10 }
        };
    }
}

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
            /* DEBUGGING: I tired for a very long time (too long), to do a "Int32.Parse(input)"
            * to convert the input directly to a number inside the if statement. I didn't understand
            * why it wouldn't work, then after a long time I did step into debugging, and realised
            * that OF COURSE I can't Parse a "two" string the same way as a string "2".
            * Then I made the Dictionary instead and got the value from string to int.
            */
            Console.WriteLine("Write an mathematical expression. (Like 'one plus four'):");
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

                    Console.WriteLine(Operators.Add(num1, num2));
                    
                }
                else if (input.Contains("minus"))
                {
                    var num1 = Wordtovalue.wordvalue[tokens[0]];
                    var num2 = Wordtovalue.wordvalue[tokens[2]];

                    Console.WriteLine(Operators.Sub(num1, num2));
                }
                else if (input.Contains("times"))
                {
                    var num1 = Wordtovalue.wordvalue[tokens[0]];
                    var num2 = Wordtovalue.wordvalue[tokens[2]];

                    Console.WriteLine(Operators.Tim(num1, num2));
                }
                else
                {
                    // Sends the user to this output if the input format wasn't the right format.
                    Console.WriteLine("Invalid format. Try again.");
                }
            }
            catch (Exception)
            {
                // Sends the user to this output if the input format wasn't the right format.
                Console.WriteLine("Invalid format. Try again.");
            }
        }
    }
    public class Wordtovalue
    {
        // Turns words into value that I can use inside the if statement.
        public static Dictionary<string, int> wordvalue = new Dictionary<string, int>
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

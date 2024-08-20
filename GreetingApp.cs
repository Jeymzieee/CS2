using System;
using System.Linq;

class Program
{
    public class WordsOnlyException : Exception
    {
        public WordsOnlyException(string message) : base(message)
        {
        }
    }

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to the Fun Enrollment System STIer!\n");
        Console.ResetColor();

        while (true)
        {
            try
            {                                                                            //User's Information//
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Enter your First Name: ");
                Console.ResetColor();
                
                string name = Console.ReadLine();

                
                if (Approved(name))                                                       //error if user not input name/words//
                {
                    throw new WordsOnlyException("Oops! Invalid input\n");                 
                }

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Enter the total number of your enrolled courses: ");         //User's Information//
                Console.ResetColor();
                
                int input = Convert.ToInt32(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkBlue;                            //User's Information//
                Console.Write("Enter the price of your favorite book: ");
                Console.ResetColor();
                
                double price = Convert.ToDouble(Console.ReadLine());

                
                Console.ForegroundColor = ConsoleColor.Cyan;
                string all = $"\nFantastic, {name}! Here's the information\n" +             //Output//
                             $"--> Total Enrolled Courses: {input}\n" +
                             $"--> Price of your Favorite Book: Php.{price:0.00}\n";
                Console.WriteLine(all);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Press any key to exit... and keep on learning!");        //Ending of code//
                Console.ResetColor();
                Console.ReadKey();
                break;
            }
            catch (FormatException)                                                         //if user input not desired data type//
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oops! Invalid input!\n");
                Console.ResetColor();
            }
            catch (WordsOnlyException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }

    static bool Approved(string name)
    {
        return string.IsNullOrWhiteSpace(name) || !name.All(char.IsLetter);                 //Space,Empty, and whitespace is not accepted in name//
    }
}
using System;
using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StringFormatting

            // String Formatting Example
            int x = 2, y = 4;

            // 1. String Concatenation
            string messageConcat = "Equation: " + x + " + " + y + " = " + (x + y);
            Console.WriteLine(messageConcat);

            // 2. String Format
            string messageFormat = string.Format("Equation: {0} + {1} = {2}", x, y, x + y);
            Console.WriteLine(messageFormat);

            // 3. String Interpolation
            string messageInterpolation = $"Equation: {x} + {y} = {x + y}";
            Console.WriteLine(messageInterpolation);

            #endregion

            #region ControlStatement

            // Control Statements
            Console.WriteLine("Hello World"); // Example output for demonstration
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");

            #endregion

            #region IF-Switch

            // Conditional Control Statements Example
            Console.Write("Enter Number of Month in The 1st Quarter (1-3): ");
            int monthNumber;

            if (int.TryParse(Console.ReadLine(), out monthNumber))
            {
                // If-Else Example
                if (monthNumber == 1)
                    Console.WriteLine("January");
                else if (monthNumber == 2)
                    Console.WriteLine("February");
                else if (monthNumber == 3)
                    Console.WriteLine("March");
                else
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 3.");

                // Switch-Case Example
                switch (monthNumber)
                {
                    case 1:
                        Console.WriteLine("Switch: January");
                        break;
                    case 2:
                        Console.WriteLine("Switch: February");
                        break;
                    case 3:
                        Console.WriteLine("Switch: March");
                        break;
                    default:
                        Console.WriteLine("Switch: Invalid input! Please enter a number between 1 and 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }

            #endregion

            #region Video5

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            switch (name.ToLower())
            {
                case "ahmed":
                    Console.WriteLine("Hi Ahmed");
                    break;
                case "omar":
                    Console.WriteLine("Hi Omar");
                    break;
                case "ali":
                    Console.WriteLine("Hi Ali");
                    break;
                case "mariam":
                    Console.WriteLine("Hi Mariam");
                    break;
                default:
                    Console.WriteLine("Hi, I don't recognize your name.");
                    break;
            }

            #endregion

            #region EX2

            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age > 18)
                    Console.WriteLine("Welcome :)");
                else if (age < 18)
                    Console.WriteLine("Bye Bye :(");
                else
                    Console.WriteLine("Equal!!");

                switch (age)
                {
                    case > 18:
                        Console.WriteLine("Switch: Welcome :)");
                        break;
                    case < 18:
                        Console.WriteLine("Switch: Bye Bye :(");
                        break;
                    default:
                        Console.WriteLine("Switch: Equal!!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }

            #endregion

            #region V7

            object obj = new object();
            obj = "Ahmed";
            obj = 1;

            switch (obj)
            {
                case int X when X > -12:
                    Console.WriteLine("Int Object");
                    break;
                case string X when X.Length > 5:
                    Console.WriteLine("String Object > 5");
                    break;
                case string X when X.Length <= 5:
                    Console.WriteLine("String Object <= 5");
                    break;
                default:
                    Console.WriteLine("Unknown Object");
                    break;
            }

            #endregion

            #region V8

            Console.Write("Enter an option (1-3): ");
            string input = Console.ReadLine();

            Console.WriteLine(input switch
            {
                "1" => "Option 1",
                "2" => "Option 2",
                "3" => "Option 3",
                _ => "Unsupported Option !!"
            });

            #endregion

            #region LoopStatement

            // For Loop Example
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Hello World");
            }

            // Foreach Loop Example
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            #endregion

            #region WhileandDoWhile

            // While loop example
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine("Hello World");
                j++;
            }

            // Do-While loop example
            int k = 1;
            do
            {
                Console.WriteLine("Hello World in Do-While loop");
                k++;
            } while (k <= 10);

            // Do-While with Even Number check
            int number;
            bool validInput;
            do
            {
                Console.Write("Enter an even number: ");
                validInput = int.TryParse(Console.ReadLine(), out number) && number % 2 == 0;
                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a valid even number.");
                }
            } while (!validInput);

            Console.WriteLine($"You entered the even number: {number}");

            #endregion

            #region String
            // String : Reference type : Heap 

            string s01 = "Ahmed"; // Syntax Sugar
            Console.WriteLine(s01.GetHashCode()); // Print the hash code of the string

            s01 = "Ali"; // Reassign to a new string
            Console.WriteLine(s01.GetHashCode()); // Print the new hash code

            s01 = "Yassmin"; // Reassign again
            Console.WriteLine(s01.GetHashCode()); // Print the new hash code

            string message = "Hello";
            Console.WriteLine("Message: " + message);
            Console.WriteLine("HashCode: " + message.GetHashCode());
            Console.WriteLine();
            message += " Ahmed";
            Console.WriteLine("Message: " + message);
            Console.WriteLine("HashCode: " + message.GetHashCode());
            #endregion

            #region StringBuilder

            // StringBuilder: Class (Reference Type): HEAP
            // Mutable Datatype: Can Change its Value After Creation
            StringBuilder sb = new StringBuilder("Hello ");
            Console.WriteLine("StringBuilder: " + sb);
            Console.WriteLine("StringBuilder HashCode: " + sb.GetHashCode());

            sb.Append("Ahmed");
            Console.WriteLine("StringBuilder After Append: " + sb);
            Console.WriteLine("StringBuilder HashCode After Append: " + sb.GetHashCode());

            #endregion

            #region String Methods

            string S01 = "Hello World";
            int indexOfE = S01.IndexOf('e'); // Find the first occurrence of 'e'
            Console.WriteLine("Index of 'e': " + indexOfE);

            string upperCaseS01 = S01.ToUpper(); // Convert string to uppercase
            Console.WriteLine("Uppercase: " + upperCaseS01);

            string lowerCaseS01 = S01.ToLower(); // Convert string to lowercase
            Console.WriteLine("Lowercase: " + lowerCaseS01);

            bool startsWithH = S01.StartsWith("H"); // Check if the string starts with "H"
            Console.WriteLine("Starts with 'H': " + startsWithH);

            bool endsWithWorld = S01.EndsWith("World"); // Check if the string ends with "World"
            Console.WriteLine("Ends with 'World': " + endsWithWorld);

            string replacedS01 = S01.Replace("World", "Everyone"); // Replace part of the string
            Console.WriteLine("Replaced: " + replacedS01);

            string substringS01 = S01.Substring(6, 5); // Extract a substring from the string
            Console.WriteLine("Substring: " + substringS01);

            string trimmedS01 = S01.Trim(); // Trim leading and trailing whitespaces
            Console.WriteLine("Trimmed: " + trimmedS01);

            #endregion
        }
    }
}

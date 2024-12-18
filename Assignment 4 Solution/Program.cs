namespace Assignment_4_Solution
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                // Question 1
                #region Divisible by 3 and 4
                Console.Write("Enter a number: ");
                int num1 = int.Parse(Console.ReadLine());
                if (num1 % 3 == 0 && num1 % 4 == 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
                #endregion

                // Question 2
                #region Positive or Negative
                Console.Write("Enter an integer: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num2 < 0 ? "negative" : "positive");
                #endregion

                // Question 3
                #region Max and Min
                Console.Write("Enter three integers separated by space: ");
                string[] nums = Console.ReadLine().Split(' ');
                int a = int.Parse(nums[0]), b = int.Parse(nums[1]), c = int.Parse(nums[2]);
                Console.WriteLine($"Max element = {Math.Max(a, Math.Max(b, c))}");
                Console.WriteLine($"Min element = {Math.Min(a, Math.Min(b, c))}");
                #endregion

                // Question 4
                #region Even or Odd
                Console.Write("Enter an integer: ");
                int num4 = int.Parse(Console.ReadLine());
                Console.WriteLine(num4 % 2 == 0 ? "Even" : "Odd");
                #endregion

                // Question 5
                #region Vowel or Consonant
                Console.Write("Enter a character: ");
                char ch = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine("\n" + ("aeiou".Contains(ch) ? "vowel" : "consonant"));
                #endregion

                // Question 6
                #region Numbers from 1 to N
                Console.Write("Enter an integer: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                    Console.Write(i + (i < n ? ", " : "\n"));
                #endregion

                // Question 7
                #region Multiplication Table
                Console.Write("Enter a number: ");
                int num7 = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 12; i++)
                    Console.Write($"{num7 * i} ");
                Console.WriteLine();
                #endregion

                // Question 8
                #region Even Numbers from 1 to N
                Console.Write("Enter an integer: ");
                int num8 = int.Parse(Console.ReadLine());
                for (int i = 2; i <= num8; i += 2)
                    Console.Write(i + (i < num8 - 1 ? " " : "\n"));
                #endregion

                // Question 9
                #region Power Calculation
                Console.Write("Enter base and exponent separated by space: ");
                string[] powerInput = Console.ReadLine().Split(' ');
                int baseNum = int.Parse(powerInput[0]);
                int exponent = int.Parse(powerInput[1]);
                Console.WriteLine(Math.Pow(baseNum, exponent));
                #endregion

                // Question 10
                #region Total, Average, and Percentage
                Console.WriteLine("Enter marks of five subjects separated by space:");
                string[] marks = Console.ReadLine().Split(' ');
                int total = 0;
                foreach (string mark in marks)
                    total += int.Parse(mark);
                double average = total / 5.0;
                Console.WriteLine($"Total marks = {total}");
                Console.WriteLine($"Average Marks = {average}");
                Console.WriteLine($"Percentage = {average}%");
                #endregion

                // Question 11
                #region Days in Month
                Console.Write("Enter month number: ");
                int month = int.Parse(Console.ReadLine());
                int days = DateTime.DaysInMonth(2024, month); // Use 2024 for leap year test
                Console.WriteLine($"Days in Month: {days}");
                #endregion

                // Question 12
                #region Simple Calculator
                Console.Write("Enter two numbers and an operator (+, -, *, /): ");
                string[] calcInput = Console.ReadLine().Split(' ');
                double numA = double.Parse(calcInput[0]);
                double numB = double.Parse(calcInput[1]);
                char op = char.Parse(calcInput[2]);
                double result = op switch
                {
                    '+' => numA + numB,
                    '-' => numA - numB,
                    '*' => numA * numB,
                    '/' => numB != 0 ? numA / numB : double.NaN,
                    _ => double.NaN
                };
                Console.WriteLine($"Result: {result}");
                #endregion

                // Question 13
                #region Reverse a String
                Console.Write("Enter a string: ");
                string inputStr = Console.ReadLine();
                char[] reversedStr = inputStr.ToCharArray();
                Array.Reverse(reversedStr);
                Console.WriteLine(new string(reversedStr));
                #endregion

                // Question 14
                #region Reverse an Integer
                Console.Write("Enter an integer: ");
                string inputInt = Console.ReadLine();
                char[] reversedInt = inputInt.ToCharArray();
                Array.Reverse(reversedInt);
                Console.WriteLine(new string(reversedInt));
                #endregion

                // Question 15
                #region Prime Numbers in a Range
                Console.Write("Enter starting and ending range separated by space: ");
                string[] range = Console.ReadLine().Split(' ');
                int start = int.Parse(range[0]);
                int end = int.Parse(range[1]);
                for (int i = start; i <= end; i++)
                {
                    if (IsPrime(i)) Console.Write(i + " ");
                }
                Console.WriteLine();
                #endregion

                // Question 16
                #region Decimal to Binary
                Console.Write("Enter a number to convert to binary: ");
                int decimalNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Binary: " + Convert.ToString(decimalNum, 2));
                #endregion

                // Question 17
                #region Points on a Line
                Console.Write("Enter three points (x1, y1), (x2, y2), (x3, y3): ");
                string[] points = Console.ReadLine().Split(' ');
                double slope1 = (double.Parse(points[3]) - double.Parse(points[1])) / (double.Parse(points[2]) - double.Parse(points[0]));
                double slope2 = (double.Parse(points[5]) - double.Parse(points[3])) / (double.Parse(points[4]) - double.Parse(points[2]));
                Console.WriteLine(slope1 == slope2 ? "Points are collinear" : "Points are not collinear");
                #endregion

                // Question 18
                #region Worker Efficiency
                Console.Write("Enter the time taken by the worker (in hours): ");
                double time = double.Parse(Console.ReadLine());
                if (time >= 2 && time < 3)
                    Console.WriteLine("Highly efficient");
                else if (time >= 3 && time < 4)
                    Console.WriteLine("Increase speed");
                else if (time >= 4 && time <= 5)
                    Console.WriteLine("Training required");
                else
                    Console.WriteLine("Leave the company");
                #endregion
            }

            static bool IsPrime(int num)
            {
                if (num < 2) return false;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                    if (num % i == 0) return false;
                return true;
            }
        }

    }


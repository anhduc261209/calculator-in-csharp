using System;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			double num1 = 0;
			double num2 = 0;
			double result = 0;
			String op;
			bool useAgain = true;

			Console.ForegroundColor = ConsoleColor.Green;
			Console.Title = "Calculator by Anh Đức";

			do
			{
				Console.WriteLine("------------------");
				Console.WriteLine("Calculator Program");
				Console.WriteLine("------------------");

				
				Console.Write("Enter number #1: ");
				num1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine();
				Console.Write("Enter number #2: ");
				num2 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine();
				Console.Write("Enter operator (+, -, x, :): ");
				op = Console.ReadLine();

				switch (op)
				{
					case "+":
						result = num1 + num2;
						break;
					case "-":
						result = num1 - num2;
						break;
					case "x":
						result = num1 * num2;
						break;
					case ":":
						result = num1 / num2;
						break;
				}

				Console.WriteLine("The result is: " + result);

				Console.WriteLine("Do you want to calculate again? (y/n)");
			} while (Console.ReadLine().ToLower() == "y");

			Console.WriteLine("Good bye!");
			Console.ReadKey();
		}
	}
}
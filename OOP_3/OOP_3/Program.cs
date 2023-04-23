namespace OOP_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int s = 0;
			while (s != 2)
			{
				Console.WriteLine("");
				Console.WriteLine($"If you want solve equation press 1 \nIf you want exit press 2 ");


				s = int.Parse(Console.ReadLine());

				switch (s)
				{
					case 1:
						Console.WriteLine("Quadratic Equation: a*x^2 + b*x + c = 0");
						Console.WriteLine();
						Console.WriteLine("Write a");
						double a = double.Parse(Console.ReadLine());
						Console.WriteLine();
						Console.WriteLine("Write b");
						double b = double.Parse(Console.ReadLine());
						Console.WriteLine();
						Console.WriteLine("Write c");
						double c = double.Parse(Console.ReadLine());

						var result = QuadraticEquationSolver.Solve(a, b, c);
						result.Printing();
						break;

					case 2:
						return;

					default:
						Console.WriteLine("\r\nChoose the correct value");
						break;
				}
			}

			//var result1 = QuadraticEquationSolver.Solve(1, 5, 3);
			//var result2 = QuadraticEquationSolver.Solve(2, 3, 5);
			//var result3 = QuadraticEquationSolver.Solve(1, 2, 1);
			//result1.Printing();
			//result2.Printing();
			//result3.Printing();
		}
	}

}
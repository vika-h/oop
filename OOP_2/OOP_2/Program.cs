using OOP_2;
using System;

namespace Lab_2

{
	internal class Program
	{
		static void Main(string[] args)
		{

			int s = 0;
			while (s != 7)
			{
				Console.WriteLine("");
				Console.WriteLine("Choose task");
				Console.WriteLine("1 - Task 1.1");
				Console.WriteLine("2 - Task 1.2");
				Console.WriteLine("3 - Task 1.3");
				Console.WriteLine("4 - Task 2.1");
				Console.WriteLine("5 - Task 2.2");
				Console.WriteLine("6 - Task 2.3");

				s = int.Parse(Console.ReadLine());
				switch (s)
				{
					case 1:
						Arrays.Task11();

						break;
					case 2:
						Arrays.Task12();

						break;
					case 3:
						Arrays.Task13();

						break;
					case 4:
						Matrix.Task21();
						break;
					case 5:
						Matrix.Task22();

						break;
					case 6:
						Matrix.Task23();

						break;
					case 7:

						return;
					default:
						Console.WriteLine("\r\nChoose the correct value");
						break;
				}
			}
		}
	}
}
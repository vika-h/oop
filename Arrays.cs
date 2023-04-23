using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
	internal class Arrays
	{
		public static void Task11()
		{
			//Дано n дійсних чисел. Знайти найбільше серед від’ємних
			Console.WriteLine("Task 1.1");
			double[] numbers = Helper.RandomArrayFill11();
			double maxNegative = double.MinValue;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] < 0 && numbers[i] > maxNegative)
				{
					maxNegative = numbers[i];
				}
			}
			if (maxNegative == double.MinValue)
			{
				Console.WriteLine("There are no negative numbers");
			}
			else
			{
				Console.WriteLine("The largest negative number: " + maxNegative);
			}
		}
		public static void Task12()
		{
			//Дано два вектори x, y. Знайти косинус кута між ними.
			Console.WriteLine("Task 1.2");

			double[] x = Helper.RandomArrayFill11();

			double[] y = Helper.RandomArrayFill11();


			double dotProduct = 0;
			for (int i = 0; i < x.Length; i++)
			{
				dotProduct += x[i] * y[i];
			}

			double xLength = Math.Sqrt(x.Select(c => c * c).Sum());
			double yLength = Math.Sqrt(y.Select(c => c * c).Sum());

			double cosine = dotProduct / (xLength * yLength);

			Console.WriteLine($"The cosine of the angle between vectors x and y:  {cosine}");
		}
		public static void Task13()
		{
			//Стиснути масив, вилучивши з нього всі елементи, модуль яких знаходиться в інтервалі [a, b], місце яке звільнилось в кінці масиву заповнити нулями.
			Console.WriteLine("Task 1.3");

			int[] arr = Helper.RandomArrayFill();

			Console.Write($"Enter the value of first border ");
			int a = int.Parse(Console.ReadLine());

			Console.Write($"Enter the value of second border ");
			int b = int.Parse(Console.ReadLine());

			int writeIndex = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				if (Math.Abs(arr[i]) < a || Math.Abs(arr[i]) > b)
				{
					arr[writeIndex++] = arr[i];
				}
			}
			while (writeIndex < arr.Length)
			{
				arr[writeIndex++] = 0;
			}

			Helper.PrintArr(arr);

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
	internal class Helper
	{
		public static bool Validation(int rows)
		{
			if (rows <= 0) return false;
			else return true;
		}
		public static bool Validation(int rows, int cols)
		{
			if (rows <= 0 || cols <= 0) return false;
			else return true;
		}
		public static int[] FillArr()
		{
			Console.Write($"Enter the amount of elements ");
			int num = int.Parse(Console.ReadLine());
			while (!Helper.Validation(num))
			{
				Console.Write($"Enter the amount of element elements ");
				num = int.Parse(Console.ReadLine());
			}
			int[] array = new int[num];
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"Enter the value for element [{i}]: ");
				int input = int.Parse(Console.ReadLine());
				array[i] = input;
			}
			return array;
		}
		public static double[] FillArr11()
		{
			Console.Write($"Enter the amount of elements ");
			int num = int.Parse(Console.ReadLine());
			while (!Helper.Validation(num))
			{
				Console.Write($"Enter the amount of element elements ");
				num = int.Parse(Console.ReadLine());
			}
			double[] array = new double[num];
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"Enter the value for element [{i}]: ");
				double input = double.Parse(Console.ReadLine());
				array[i] = input;
			}
			Helper.PrintArr(array);

			return array;
		}
		public static int[,] FillMatrix()
		{
			Console.Write($"Enter the value for element rows ");
			int rows = int.Parse(Console.ReadLine());
			Console.Write($"Enter the value for element cols ");
			int cols = int.Parse(Console.ReadLine());

			while (!Helper.Validation(rows, cols))
			{
				Console.Write($"Enter the value for element rows ");
				rows = int.Parse(Console.ReadLine());
				Console.Write($"Enter the value for element cols ");
				cols = int.Parse(Console.ReadLine());
			}

			int[,] matrix = new int[rows, cols];
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write($"Enter the value for element [{i},{j}]: ");
					int input = int.Parse(Console.ReadLine());
					matrix[i, j] = input;
				}
			}
			return matrix;
		}

		public static int[] RandomArrayFill()
		{
			Console.Write($"Enter the amount of elements ");
			int num = int.Parse(Console.ReadLine());
			while (!Helper.Validation(num))
			{
				Console.Write($"Enter the amount of element elements ");
				num = int.Parse(Console.ReadLine());
			}

			int[] array = new int[num];
			Random random = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = random.Next(-50, 101); 
			}
			Helper.PrintArr(array);

			return array;
		}
		public static double[] RandomArrayFill11()
		{
			Console.Write($"Enter the amount of elements ");
			int num = int.Parse(Console.ReadLine());
			while (!Helper.Validation(num))
			{
				Console.Write($"Enter the amount of element elements ");
				num = int.Parse(Console.ReadLine());
			}

			double[] array = new double[num];
			Random random = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (random.NextDouble()-0.5)*200;
			}
			Helper.PrintArr(array);

			return array;
		}


		public static int[,] RandomMatrixFill()
		{
			Console.Write($"Enter the value for element rows ");
			int rows = int.Parse(Console.ReadLine());
			Console.Write($"Enter the value for element cols ");
			int cols = int.Parse(Console.ReadLine());

			while (!Helper.Validation(rows, cols))
			{
				Console.Write($"Enter the value for element rows ");
				rows = int.Parse(Console.ReadLine());
				Console.Write($"Enter the value for element cols ");
				cols = int.Parse(Console.ReadLine());
			}

			Random random = new Random();

			int[,] matrix = new int[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					matrix[i, j] = random.Next(-50, 101);
				}
			}
			Helper.PrintMatrix(matrix);
			return matrix;
		}
		public static int[,] RandomMatrixFillTask23()
		{
			Console.Write($"Enter the value for element in rows and cols");
			int rows = int.Parse(Console.ReadLine());
			while (!Helper.Validation(rows, rows))
			{
				Console.Write($"Enter the value for element in rows and cols");
				rows = int.Parse(Console.ReadLine());
	
			}

			Random random = new Random();

			int[,] matrix = new int[rows, rows];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < rows; j++)
				{
					matrix[i, j] = random.Next(-50, 101);
				}
			}
			Helper.PrintMatrix(matrix);
			return matrix;
		}
		public static void PrintArr(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i]} ");

			}
			Console.WriteLine();
		}
		public static void PrintArr(double[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i]} ");

			}
			Console.WriteLine();
		}
		public static void PrintMatrix(int[,] matrix)
		{
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			for (int i = 0; i < rows; i ++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write($"{matrix[i, j]} ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

		}
	}
}

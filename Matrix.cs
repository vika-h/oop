using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
	internal class Matrix
	{
		public static void Task21()
		{
			var matrix = Helper.RandomMatrixFill();
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);
			for (int i = 1; i < rows; i += 2)
			{
				int[] currentRow = new int[cols];
				for (int j = 0; j < cols; j++)
				{
					currentRow[j] = matrix[i, j];
				}

				for (int j = 0; j < cols - 1; j++)
				{
					for (int k = j + 1; k < cols; k++)
					{
						if (currentRow[j] < currentRow[k])
						{
							int temp = currentRow[j];
							currentRow[j] = currentRow[k];
							currentRow[k] = temp;
						}
					}
				}

				for (int j = 0; j < cols; j++)
				{
					matrix[i, j] = currentRow[j];
				}
			}
			Helper.PrintMatrix(matrix);
		}
		public static void Task22()
		{
			//Дана цілочислова квадратна матриця. Визначити суму елементів в тих стовпцях, які не містять від’ємних елементів.

			Console.WriteLine("Task 2.2");

			var matrix = Helper.RandomMatrixFillTask23();

			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);
			int sum = 0;
			for (int j = 0; j < cols; j++)
			{
				bool hasNegative = false;
				for (int i = 0; i < rows; i++)
				{
					if (matrix[i, j] < 0)
					{
						hasNegative = true;
						break;
					}
				}
				if (!hasNegative)
				{
					for (int i = 0; i < rows; i++)
					{
						sum += matrix[i, j];
					}
				}
			}
			Console.WriteLine($"The sum of elements in those columns that are not\r\ncontain negative elements: {sum}");

		}
		public static void Task23()
		{
			//Дана цілочислова квадратна матриця. Визначити мінімум серед сум модулів елементів діагоналей, паралельних побічній діагоналі матриці.
			Console.WriteLine("Task 2.3");

			var matrix = Helper.RandomMatrixFillTask23();

			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			int minSum = int.MaxValue;
			for (int k = 1 - rows; k < cols; k++)
			{
				int sum = 0;
				for (int i = 0; i < rows; i++)
				{
					int j = i - k;
					if (j < 0 || j >= cols)
					{
						continue;
					}
					sum += Math.Abs(matrix[i, j]);
				}
				if (sum < minSum)
				{
					minSum = sum;
				}
			}
			Console.WriteLine($"The minimum among the sums of the modules of the elements\r\ndiagonals parallel to the side diagonal of the matrix: {minSum}");
		}
	}
}

namespace Lab_2
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int s = 0;
			while (s != 7)
			{

				Console.WriteLine("Choose task");
				s = int.Parse(Console.ReadLine());
				switch (s)
				{

					case 1:
						Task11();

						break;
					case 2:
						Task12();

						break;
					case 3:
						Task13();

						break;
					case 4:
						Task21();
						break;
					case 5:
						Task22();

						break;
					case 6:
						Task23();

						break;
					case 7:

						return;
					default:
						Console.WriteLine("Виберiть коректне значення");
						break;



				}

				Task11();
				Task12();
				Task13();
				Task21();
				Console.WriteLine(Task22());
				Console.WriteLine(Task23());
			}
			static int[] FillArr()
			{
				Console.Write($"Enter the value of elements ");
				int num = int.Parse(Console.ReadLine());

				int[] array = new int[num];
				for (int i = 0; i < array.Length; i++)
				{
					Console.Write($"Enter the value for element [{i}]: ");
					int input = int.Parse(Console.ReadLine());
					array[i] = input;
				}
				return array;
			}
			static void Task11()
			{

				Console.WriteLine("Task 1.1");




				int[] numbers = FillArr();
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
					Console.WriteLine("Відсутні від'ємні числа");
				}
				else
				{
					Console.WriteLine("Найбільше від'ємне число: " + maxNegative);
				}
			}
			static void Task12()
			{
				Console.WriteLine("Task 1.2");

				int[] x = FillArr();

				int[] y = FillArr();


				double dotProduct = 0;
				for (int i = 0; i < x.Length; i++)
				{
					dotProduct += x[i] * y[i];
				}

				double xLength = Math.Sqrt(x.Select(c => c * c).Sum());
				double yLength = Math.Sqrt(y.Select(c => c * c).Sum());

				double cosine = dotProduct / (xLength * yLength);

				Console.WriteLine($"Косинус кута між векторами x та y: {cosine}");
			}
			static void Task13()
			{
				Console.WriteLine("Task 1.3");

				int[] arr = FillArr();

				Console.Write($"Enter the value for element rows ");
				int a = int.Parse(Console.ReadLine());

				Console.Write($"Enter the value for element rows ");
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
				for (int i = 0; i < arr.Length; i++)
				{
					Console.Write($"{arr[i]} ");

				}
				Console.WriteLine();

			}
			static int[,] FiilMatrix()
			{
				Console.Write($"Enter the value for element rows ");
				int rows = int.Parse(Console.ReadLine());
				Console.Write($"Enter the value for element cols ");
				int cols = int.Parse(Console.ReadLine());

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
			static void Task21()
			{
				var matrix = FiilMatrix();
				int rows = matrix.GetLength(0);
				int cols = matrix.GetLength(1);
				for (int i = 1; i < rows; i += 2)
				{
					int[] row = new int[cols];
					for (int j = 0; j < cols; j++)
					{
						row[j] = matrix[i, j];
					}
					Array.Sort(row);
					Array.Reverse(row);
					for (int j = 0; j < cols; j++)
					{
						matrix[i, j] = row[j];
					}
				}

				for (int i = 0; i < rows; i += 2)
				{
					for (int j = 0; j < cols; j++)
					{
						Console.Write($"{matrix[i, j]} ");
					}
					Console.WriteLine();
				}

			}
			static int Task22()
			{
				Console.WriteLine("Task 2.2");

				var matrix = FiilMatrix();


				int rows = matrix.GetLength(0);
				int cols = matrix.GetLength(1);
				int sum = 0;
				for (int j = 0; j < cols; j++)
				{
					bool hasNegativeElement = false;
					for (int i = 0; i < rows; i++)
					{
						if (matrix[i, j] < 0)
						{
							hasNegativeElement = true;
							break;
						}
						sum += matrix[i, j];
					}
					if (hasNegativeElement)
					{
						continue;
					}
				}
				return sum;
			}
			static int Task23()
			{
				Console.WriteLine("Task 2.3");

				var matrix = FiilMatrix();


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
				return minSum;
			}
		}
	}
}
using System;

namespace OOP4
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = File.ReadAllText("TextFile.txt");
			string[] matrixStrings = text.Split(';');
			LinkedList<LinkedList<double>> matrix1 = ParseMatrix(matrixStrings[0]);
			LinkedList<LinkedList<double>> matrix2 = ParseMatrix(matrixStrings[1]);

			var result = MultiplyMatrices(matrix1, matrix2);

			PrintMatrix(result);
		}

		static LinkedList<LinkedList<double>> ParseMatrix(string matrixString)
		{
			string[] rowStrings = matrixString.Split('\n', '\r', '\t');
			LinkedList<LinkedList<double>> rows = new LinkedList<LinkedList<double>>();
			foreach (string rowString in rowStrings)
			{
				if (!string.IsNullOrWhiteSpace(rowString))
				{
					string[] elementStrings = rowString.Trim().Split(' ');
					LinkedList<double> elelements = new LinkedList<double>();
					for (int i = 0; i < elementStrings.Length; i++)
					{
						elelements.AddLast(double.Parse(elementStrings[i]));
					}
					rows.AddLast(elelements);
				}
			}
			return rows;
		}

		public static LinkedList<LinkedList<double>> MultiplyMatrices(LinkedList<LinkedList<double>> matrix1, LinkedList<LinkedList<double>> matrix2)
		{
			int rows1 = matrix1.Count;
			int cols1 = matrix1.First.Value.Count;
			int rows2 = matrix2.Count;
			int cols2 = matrix2.First.Value.Count;

			if (cols1 != rows2)
			{
				return null;
			}

			var result = new LinkedList<LinkedList<double>>();

			for (int i = 0; i < rows1; i++)
			{
				var row = new LinkedList<double>();
				for (int j = 0; j < cols2; j++)
				{
					double sum = 0;
					for (int k = 0; k < cols1; k++)
					{
						sum += matrix1.ElementAt(i).ElementAt(k) * matrix2.ElementAt(k).ElementAt(j);
					}
					row.AddLast(sum);
				}
				result.AddLast(row);
			}

			return result;
		}

		static void PrintMatrix<T>(LinkedList<LinkedList<T>> matrix)
		{
			if (matrix != null)
			{
				foreach (LinkedList<T> row in matrix)
				{
					foreach (T element in row)
					{
						Console.Write("{0,5}", element);
					}
					Console.WriteLine();
				}
			}
			else Console.WriteLine("Can`t multiple matrix. Count of colums in first matrix should equal to count of rows in second martix!");
		}
	}
}
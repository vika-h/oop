using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
	public class RealEqualRootsResult : IQuadraticEquationResult
	{
		private readonly double root;

		public RealEqualRootsResult(double root)
		{
			this.root = root;
		}

		public void Printing()
		{
			Console.WriteLine($"x1 = x2 = {root}");
		}
	}
}

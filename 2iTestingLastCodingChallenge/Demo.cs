using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2iTestingLastCodingChallenge
{
	public class Demo
	{

		public static void main(String[] args)
		{
			
			int A = 3, X = 9;
			PrintingMultiples.printMultiples(A, X);
			PrintingMultiples.printMultiples(A + 1, X + 1);
			PrintingMultiples.printMultiples(0, 8);
			PrintingMultiples.printMultiples(-1, -9);
			PrintingMultiples.printMultiples(2, 18);

		}

	}
}

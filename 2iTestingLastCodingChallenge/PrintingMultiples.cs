using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2iTestingLastCodingChallenge
{
  


	public class PrintingMultiples
	{

		public static void printMultiples(int A, int X)
		{
			if (A == 0 || A < 0 || X == 0 || X < 0)
			{
				Console.Write("Please pass the valid input for A " + A + " and X as " + X);
			}
			else
			{
				int i = 2;
				int Number = A;
				while (Number <= X)
				{
					Console.Write(Number + "\t");
					Number = A * i;
					i++;
				}
				
			}
		}
	}







}

using System;
using NUnit.Framework;
namespace Topcoder
{
	public class MaxSubMatrix
	{
		public static int Minimum(int i, int j, int t)
		{
			return Math.Min(i, Math.Min(j, t));
		}

		public int FindMaxSubMatrixSize(int[,] matrix, int N)
		{
			int[,] maxSizes = new int[N, N];
			for (int i = 0; i < N; i++)
			{
				maxSizes[i, 0] = matrix[i, 0];
			}

			for (int j = 0; j < N; j++)
			{
				maxSizes[0, j] = matrix[0, j];
			}

			int maxDimension = 0;
			for (int i = 1; i < N; i++)
			{
				for (int j = 1; j < N; j++)
				{
					if (matrix[i, j] == 0)
					{
						maxSizes[i, j] = 0;
					}
					else {
						maxSizes[i, j] = Minimum(matrix[i - 1, j], matrix[i, j - 1], matrix[i - 1, j - 1]) + 1;
						if (maxSizes[i, j] > maxDimension)
						{
							maxDimension = maxSizes[i, j];
						}
					}

				}
			}

			return maxDimension;
		}
	}
}


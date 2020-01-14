// Cracking the coding interview - interview questions 1.8
// if an element in NxM matrix is 0, set its entire row and column to 0

namespace org.pv.AlgoPlayground.ArraysAndStrings.ZeroMatrix
{
	public class Solution
	{
		public static int[,] SetColRowToZero(int[,] z)
		{
			//locate possitions of all zeros, store only col and raws
			var c = z.GetLength(0);
			var cols = new int[z.GetLength(1)];
			var rows = new int[z.GetLength(0)];

			for(int i = 0; i < z.GetLength(0); i++)
				for (int j = 0; j < z.GetLength(1); j++)
					if(z[i, j] == 0)
					{
						cols[j] = 1;
						rows[i] = 1;
					}

			//reset cols
			for(int i = 0; i < cols.Length; i++)
			{
				if(cols[i] == 1)
					for(int j = 0; j < z.GetLength(0); j++)
						z[j, i] = 0;
			}

			//reset rows
			for (int i = 0; i < rows.Length; i++)
			{
				if (rows[i] == 1)
					for (int j = 0; j < z.GetLength(1); j++)
						z[i, j] = 0;
			}

			// then set columns and rows to 0 
			return z;
		}
	}
}
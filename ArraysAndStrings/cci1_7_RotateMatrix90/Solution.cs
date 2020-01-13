// Cracking the coding interview - interview questions 1.7
// Check if string contains only unique characters. What if additional datastructure cannot be used?

namespace org.pv.AlgoPlayground.ArraysAndStrings.RotateMatrix90
{
	public class Solution
	{
		//O(N^2) if we consider NxN is M number of elements then we could say this is O(M) complexity
		public static int[,] RotateBrute(int[,] X)
		{
			// first idea, do matrix transpose then invert each row
			/*
				    1 2 3			 1 4 7					7 4 1 
				X = 4 5 6  - t(X) -> 2 5 8 - invRows(X) -> 	8 5 2
				    7 8 9 			 3 6 9					9 6 3
			*/

			//transpose matrix
			for(int i = 0; i < X.GetLength(0); i++)
			{
				for (int j = i; j < X.GetLength(0); j++)
				{
					if(i != j)
					{
						var c = X[i, j];
						X[i, j] = X[j, i];
						X[j, i] = c;
					}
				}
			}

			// invert rows
			for(int i = 0; i < X.GetLength(0); i++)
			{
				for (int j = 0; j < X.GetLength(0) / 2; j++)
				{
					var c = X[i, j];
					X[i, j] = X[i, X.GetLength(0) -1-j];
					X[i, X.GetLength(0) - 1 - j] = c;
				}
			}

			return X;
		}

		public static int[,] Rotate(int[,] X)
		{
			// move N-1 elements per ring (pealing matrix :)
			for(int r = 0; r < X.GetLength(0) / 2; r++)
			{
				var u = X.GetLength(0) - r - 1; // u stands for Upper bound
				for(int i = r; i < u; i++)
				{
					/*
					4 elements should rotate values in each pass
					corner elements first and then by one along each ring side
					e1 = X[r, r+i]; 
					e2 = X[r+i, u];
					e3 = X[u, u-i];
					e4 = X[u-i, r];
					e1 = e4; e4 = e3; e3 = e2; e2 = t;
					
							e1 ->	 e2
							1  2  3  4 |
							5  6  7  8 v
							9  1  2  3
						  ^ 4  5  6  7
						  | e4	  <- e3

					*/

					var t = X[r, r + i];
					
					X[r, r + i] = X[u - i, r]; // e1 = e4
					X[u - i, r] = X[u, u - i]; // e4 = e3
					X[u, u - i] = X[r + i, u]; // e3 = e2
					X[r + i, u] = t;		   // e2 = t
				}
			}
			return X;
		}
	}
}
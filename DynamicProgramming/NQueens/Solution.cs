/*
	Place N chess queens on an N×N chessboard so that no two queens attack each other.
*/

//TODO: try using bit representation and bitwise solution (http://www.ic-net.or.jp/home/takaken/e/queen/)

using System;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.DynamicProgramming.NQueens
{
	public class Solution
	{
		public static List<int[]> SolveNQuens(int N)
		{
			var solutions = new List<int[]>(); // we do not know number of solutions so far so no dimension is defined

			var rowIndex = 0;
			var queenPosPerRow = new int[N];
			InitializeQueenPosPerRow(queenPosPerRow);

			SolveNthRow(solutions, N, rowIndex, queenPosPerRow);

			return solutions;
		}

		private static void InitializeQueenPosPerRow(int[] queenPosPerRow)
		{
			for(int i = 0; i < queenPosPerRow.Length; i++)
				queenPosPerRow[i] = -1;
		}

		//Main method
		private static void SolveNthRow(List<int[]> solutions, int N, int rowIndex, int[] queenPosPerRow)
		{
			if(rowIndex == N)
			{
				solutions.Add((int[])queenPosPerRow.Clone());
				return;
			}

			for(int c=0; c <N; c++)
			{
				queenPosPerRow[rowIndex] = c;
				if(IsNoAttack(queenPosPerRow, rowIndex, c))
				{
					SolveNthRow(solutions,N, rowIndex+1, queenPosPerRow);
				}
				queenPosPerRow[rowIndex] = -1;
			}
		}

		private static bool IsNoAttack(int[] queenPosPerRow, int rowIndex, int columnIndex)
		{
			if(rowIndex == 0)
				return true;

			// check straight rows and columns
			for(int ii = 0; ii < rowIndex; ii++)
			{
				if(queenPosPerRow[ii] == columnIndex)
					return false;
			}

			//check diagonal up right
			var i = columnIndex+1; var j = rowIndex-1;
			while(i < queenPosPerRow.Length && j > -1)
			{
				if(queenPosPerRow[j] == i)
					return false;
				i++; j--;
			}

			//check diagonal up left
			i = columnIndex-1; j = rowIndex-1;
			while(i > -1 && j > -1)
			{
				if(queenPosPerRow[j] == i)
					return false;
				i--; j--;
			}

			return true; /// hugh, finally we made it to the end, no queen is under atack :)
		}
	}
}
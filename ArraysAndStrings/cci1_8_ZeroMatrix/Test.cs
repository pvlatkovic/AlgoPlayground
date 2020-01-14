using System.Collections.Generic;
using Xunit;

namespace org.pv.AlgoPlayground.ArraysAndStrings.ZeroMatrix
{
	public class Test
	{
		[Theory]
		[MemberData(nameof(Data))]
		public void TestZeroMatrix(int[,] z, int[,] resultExpected)
		{
			//Given matrix z
			
			//When
			var result = Solution.SetColRowToZero(z);

			//Then
			var isMatrixMatch = true;
			
			for(int i = 0; i < resultExpected.GetLength(0); i++)	
			{
				for (int j = 0; j < resultExpected.GetLength(1); j++)
				{
					if(result[i,j] != resultExpected[i,j])
					{
						isMatrixMatch = false;
						break;
					}
				}

				if(!isMatrixMatch)
					break;
			}

			Assert.True(isMatrixMatch);
		}

		public static IEnumerable<object[]> Data =>
			new List<object[]>
			{
				new object[] 
				{
					new int[3, 4]
					{
						{1, 2, 3, 4},
						{5, 0, 7, 0},
						{9, 1, 2, 3},
					},
					new int[3, 4]
					{
						{1, 0, 3, 0},
						{0, 0, 0, 0},
						{9, 0, 2, 0},
					}
				},
				new object[] 
				{
					new int[6, 5]
					{
						{1, 2, 3, 4, 5},
						{5, 0, 7, 9, 7},
						{9, 1, 2, 3, 2},
						{6, 8, 2, 0, 1},
						{9, 1, 2, 3, 2},
						{9, 2, 3, 4, 0},
					},
					new int[6, 5]
					{
						{1, 0, 3, 0, 0},
						{0, 0, 0, 0, 0},
						{9, 0, 2, 0, 0},
						{0, 0, 0, 0, 0},
						{9, 0, 2, 0, 0},
						{0, 0, 0, 0, 0},
					},
				}
			};
	}
}
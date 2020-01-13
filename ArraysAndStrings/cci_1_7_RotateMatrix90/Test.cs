using System.Collections.Generic;
using Xunit;

namespace org.pv.AlgoPlayground.ArraysAndStrings.RotateMatrix90
{
	public class Test
	{
		[Theory]
		[MemberData(nameof(Data))]
		public void TestRotateMatrix(int[,] X, int[,] resExpected)
		{
			//Given
			// var X = new int[3,3] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
			// var resExpected = new int[3, 3] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } };
			

			//When
			//var res = Solution.RotateBrute(X);
			var res2 = Solution.Rotate(X);

			//Then
			//test elements equality
			var isAllEqual = true;
			for(int i = 0; i < X.GetLength(0); i++)
				for (int j = 0; j < X.GetLength(0); j++)
				{
					if(X[i, j] != resExpected[i, j])
					{
						isAllEqual = false;
						break;
					}
				}

			Assert.True(isAllEqual);
		}

		public static IEnumerable<object[]> Data =>
		new List<object[]>
		{
				new object[] { new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, new int[3, 3] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } } },
				new object[] { new int[2, 2] { { 1, 2 }, { 3, 4 } }, new int[2, 2] { { 3, 1 }, { 4, 2 } } },
				new object[] { new int[1, 1] { { 1 } }, new int[1, 1] { { 1 } } },
				new object[] { new int[4, 4] { { 1, 2, 3, 4 }, {5, 6, 7, 8}, {9, 1, 2, 3}, {4, 5, 6, 7} }, new int[4, 4] { {4, 9, 5, 1 }, {5, 1, 6, 2}, {6, 2, 7, 3}, {7, 3, 8, 4} } },
		};
	}


}
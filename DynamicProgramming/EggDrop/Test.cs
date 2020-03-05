using System.Collections.Generic;
using Xunit;

namespace org.pv.AlgoPlayground.DynamicProgramming.EggDrop
{
	public class Test
	{
		[Theory]
		[MemberData(nameof(Data))]
		public void TestEggDrop(int eggs, int floors, int resultExpected)
		{
			//Given eggs = 3 and floors = 6

			//When
			var result = Solution.FindEggDropsRecursive(eggs, floors);

			//Then 
			Assert.Equal(resultExpected, result);
		}


		public static IEnumerable<object[]> Data =>
		new List<object[]>
		{
				new object[] { 2, 3, 2},
				new object[] { 4, 7, 3},
				new object[] { 3, 15, 5},
				new object[] { 7, 50, 6},
				new object[] { 2, 100, 14},
				new object[] { 5, 200, 8},
		};
	}
}

/*
					Eggs
		building	1	2	3	4	5	6	7	8	9	10 
		1 floor		1	1	1	1	1	1	1	1	1	1
		2 floors	2	2	2	2	2	2	2	2	2	2
		3 floors	3	2	2	2	2	2	2	2	2	2
		4 floors	4	3	3	3	3	3	3	3	3	3
		5 floors	5	3	3	3	3	3	3	3	3	3
		6 floors	6	3	3	3	3	3	3	3	3	3
		7 floors	7	4	3	3	3	3	3	3	3	3
		8 floors	8	4	4	4	4	4	4	4	4	4
		9 floors	9	4	4	4	4	4	4	4	4	4
		10 floors	10	4	4	4	4	4	4	4	4	4
		11 floors	11	5	4	4	4	4	4	4	4	4
		12 floors	12	5	4	4	4	4	4	4	4	4
		13 floors	13	5	4	4	4	4	4	4	4	4
		14 floors	14	5	4	4	4	4	4	4	4	4
		15 floors	15	5	5	4	4	4	4	4	4	4
		16 floors	16	6	5	5	5	5	5	5	5	5
		17 floors	17	6	5	5	5	5	5	5	5	5
		18 floors	18	6	5	5	5	5	5	5	5	5
		19 floors	19	6	5	5	5	5	5	5	5	5
		20 floors	20	6	5	5	5	5	5	5	5	5
		21 floors	21	6	5	5	5	5	5	5	5	5
		22 floors	22	7	5	5	5	5	5	5	5	5
		23 floors	23	7	5	5	5	5	5	5	5	5
		24 floors	24	7	5	5	5	5	5	5	5	5
		25 floors	25	7	5	5	5	5	5	5	5	5
		30 floors	30	8	6	5	5	5	5	5	5	5
		35 floors	35	8	6	6	6	6	6	6	6	6
		40 floors	40	9	6	6	6	6	6	6	6	6
		45 floors	45	9	7	6	6	6	6	6	6	6
		50 floors	50	10	7	6	6	6	6	6	6	6
		100 floors	100	14	9	8	7	7	7	7	7	7
		200 floors	200	20	11	9	8	8	8	8	8	8
		300 floors	300	24	13	10	9	9	9	9	9	9
		400 floors	400	28	14	11	10	9	9	9	9	9
		500 floors	500	32	15	11	10	10	9	9	9	9
		1k floors	1k	45	19	13	11	11	11	10	10	10

*/
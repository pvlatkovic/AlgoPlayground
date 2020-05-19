// https://www.youtube.com/watch?v=il_t1WVLNxk
// problem Kindle library dependencies


using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.AP.LibraryDependencies
{
	public class Test
	{
		[Fact]
		public void TestSortDependencies()
		{
			//GIVEN
			var dependencies = new int[,] {{0, 1}, {2, 1}, {2, 3}, {2, 4}};

			//WHEN
			var result = Solution.SortDependencies(dependencies, 5);
			
			Assert.True(result.SequenceEqual(new int[] {0, 2, 1, 3, 4}));
		}
	}
}
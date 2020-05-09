// Given a list of points on the 2-D plane and an integer K. 
// The task is to find K closest points to the origin and print them.

using System;
using System.Diagnostics.CodeAnalysis;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.TreesAndGraphs.KClosestPointsToTheOrigin
{
	public class Solution
	{
		public static double[,] FindKClosestPoints(double[,] points, int k)
		{
			var minHeap = new MinHeap<PointAndDestination>();
			var destination = 0.0;

			for(int i = 0; i < points.GetUpperBound(0) + 1; i++)
			{
				destination = Math.Sqrt(Math.Pow(points[i, 0], 2) + Math.Pow(points[i, 1], 2));
				var pd = new PointAndDestination()
				{
					Point = (points[i, 0], points[i, 1]),
					Destination = destination
				};
				minHeap.Add(pd);
			}
			
			var result = new double[k, 2];
			for(int i=0; i < k; i++)
			{
				var pointAndDestination = minHeap.Poll();
				result[i, 0] = pointAndDestination.Point.Item1;
				result[i, 1] = pointAndDestination.Point.Item2;
			}
			return result;
		}
	}

	internal class PointAndDestination : IComparable
	{
		public double Destination { get; set; }
		public (double, double) Point {get; set; }

		public int CompareTo(object obj)
		{
			var pd = (PointAndDestination)obj;
			if(pd.Destination < Destination)
				return 1;
			if(pd.Destination > Destination)
				return -1;
			return 0;
		}
	}
}



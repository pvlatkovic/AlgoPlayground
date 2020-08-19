// Given a string implement a compression algorithm. 

/*
Given an array of characters, compress it in-place.
The length after compression must always be smaller than or equal to the original array.
Every element of the array should be a character (not int) of length 1.
After you are done modifying the input array in-place, return the new length of the array.
*/

using System;

namespace org.pv.AlgoPlayground.MSP.CompressString
{
	public class Solution
	{
		public static (char[], int) Execute(char[] input)
		{
			if(input.Length < 2)
				return (input, 1);

			var cc = input[0]; // cc stands for current char
			var insertIndex = 0;
			var ccl = 1; // current char len
			for(int i = 1; i < input.Length; i++)
			{
				if(cc == input[i])
				{
					ccl++;
				}
				else
				{
					insertIndex = InsertCompressed(input, insertIndex, cc, ccl);
					// reset
					cc = input[i];
					ccl = 1;
				}
			}

			insertIndex = InsertCompressed(input, insertIndex, cc, ccl);

			// clean rest of the input
			for(int i = insertIndex; i < input.Length; i++)
				input[i] = (char) 0;

			return (input, insertIndex);
		}

		private static int InsertCompressed(char[] input, int insertIndex, char cc, int ccl)
		{
			input[insertIndex] = cc;
			if(ccl > 1)
			{
				char[] lenToCharArray = LenToCharArray(ccl);
				for(int i=0; i < lenToCharArray.Length; i++ )
					input[insertIndex + 1 + i] = lenToCharArray[i];
				return insertIndex + 1 + lenToCharArray.Length; 
			}

			return insertIndex + 1;
		}

		private static char[] LenToCharArray(int ccl)
		{
			var s = ccl.ToString();
			return s.ToCharArray();
		}
	}
}
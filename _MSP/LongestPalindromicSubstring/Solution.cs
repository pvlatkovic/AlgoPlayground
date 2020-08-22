/*
Longest Palindromic Substring 
Given a string, find the longest substring which is palindrome.

Input: Given string :"forgeeksskeegfor", 
Output: "geeksskeeg"

Input: Given string :"Geeks", 
Output: "ee"
*/

/*
brute force 1 - not good :p 

take first char *, 
get each char from the end x, 
if match take second from begining and second from x if equal continue moving until indexes overlap.
We have one palindrom , then repeat from second character whole process *.

find longest of all palindromes found
O(N^2)
n + n -2 + n - 4 + n - 6 .... 1, n + 2(n/2 - 1 + n/2 -2 + n/2 -3)...) = n + 2((n/2*(n/2+1))/2) = n + (a*a(+1)/2) = O(a^2) since a = n/2 -> O(N^2)

forgeeksskeegfor

brute force 2

take first element, check if next is same, if yes then consider it as a first palindrom. then check if left and right elements of it are same if yes set new palindrom boundaries, if no take second element
					^ if not check if left and right are the same, if yes check if left and right are same, if yes then set new palindrom boundaries if not take second element

*/

namespace org.pv.AlgoPlayground.MSP.LongestPalindromicSubstring
{
	public class Solution
	{
		public static string ExecuteBrute2(string input)
		{
			var aMax = 0; var bMax = 0;
			for (int i = 0; i < input.Length; i++)
			{
				var a = 0; var b = 0;
				var isSearchable = false;
				if (i + 1 < input.Length && input[i] == input[i + 1])
				{
					a = i;
					b = i + 1;
					isSearchable = true;
				}
				else if (i - 1 > -1 && i + 1 < input.Length && input[i - 1] == input[i + 1])
				{
					a = i;
					b = i;
					isSearchable = true;
				}

				if (isSearchable)
				{
					var ta = a - 1;
					var tb = b + 1;
					// search wider
					while (ta > -1 && tb < input.Length && input[ta] == input[tb])
					{
						a = ta;
						b = tb;

						ta = ta - 1;
						tb = tb + 1;
					}
					if (bMax - aMax < b - a)
					{
						aMax = a; bMax = b;
					}
				}
			}

			return input.Substring(aMax, bMax - aMax + 1);
		}
	}
}
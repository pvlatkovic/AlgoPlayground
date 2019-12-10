using System;
namespace org.pv.AlgoPlayground.Base62Hash
{
	public class Base62Hash
	{
		private static string base62Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"; 
		private static int numberOf62Characters = 62;
		// converts integer to base62 hash string
		public static string GetBase62(int i)
		{
			var hash = "";
			while (i > 0)
			{
				hash = base62Chars[(int)(i % numberOf62Characters)] + hash;
				i /= numberOf62Characters;
			}
			return hash;
		}
	}
}
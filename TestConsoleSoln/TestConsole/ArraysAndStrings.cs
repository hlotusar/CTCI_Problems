using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class ArraysAndStrings
    {

		/// <summary>
		/// 1.1 - Check if all are unique characters in a word
		/// sort the array and check - O(NlogN)
		/// </summary>
		/// <param name="inputString"></param>
		/// <returns></returns>
		public string IsUnique(string inputString)
		{
			if (inputString.Length == 0)
				return "empty string";
			else if (inputString.Length == 1)
				return "unique character";
			else
			{
				char[] inputCharArray = inputString.ToCharArray();
				Array.Sort(inputCharArray);
				for (int i = 1; i < inputCharArray.Length; i++)
				{
					if (inputCharArray[i] == inputCharArray[i - 1])
					{
						return "not all unique characters";
					}
				}
				return "all unique characters";
			}
		}

		/// <summary>
		/// 1.2-question to check if a string is permutation of the other
		/// sort and compare both O(NlogN)
		/// </summary>
		/// <param name="actualString"></param>
		/// <param name="secondString"></param>
		/// <returns></returns>
		public bool CheckPermutation(string actualString, string secondString)
        {
			var inputString1 = actualString.ToCharArray();
			var inputString2 = secondString.ToCharArray();
			Array.Sort(inputString1);
			Array.Sort(inputString2);
			if (inputString1.Length == inputString2.Length)
			{
				for (int i = 0; i < inputString2.Length; i++)
				{
					if (inputString1[i] != inputString2[i])
					{
						return false;
					}
				}
				return true;
			}
			else return false;
		}
	}
}

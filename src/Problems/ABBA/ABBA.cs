﻿//Problem Statement
//One day, Jamie noticed that many English words only use the letters A and B. Examples of such words include "AB" (short for abdominal), "BAA" (the noise a sheep makes), "AA" (a type of lava), and "ABBA" (a Swedish pop sensation).
//
//
//Inspired by this observation, Jamie created a simple game. You are given two s: initial and target. The goal of the game is to find a sequence of valid moves that will change initial into target. There are two types of valid moves:
//
//Add the letter A to the end of the string.
//Reverse the string and then add the letter B to the end of the string.
//Return "Possible" (quotes for clarity) if there is a sequence of valid moves that will change initial into target. Otherwise, return "Impossible".
//
//	Definition
//	Class: ABBA
//	Method: canObtain
//	Parameters: string, string
//	Returns: string
//	Method signature: string canObtain(string initial, string target)
//	(be sure your method is public)
//	Limits
//	Time limit (s): 2.000
//	Memory limit (MB): 256
//	Constraints
//	- The length of initial will be between 1 and 999, inclusive.
//	- The length of target will be between 2 and 1000, inclusive.
//	- target will be longer than initial.
//	- Each character in initial and each character in target will be either 'A' or 'B'.
//	Examples
//	0)
//	"B"
//	"ABBA"
//	Returns: "Possible"
//	Jamie can perform the following moves:
//	Initially, the string is "B".
//	Jamie adds an 'A' to the end of the string. Now the string is "BA".
//	Jamie reverses the string and then adds a 'B' to the end of the string. Now the string is "ABB".
//	Jamie adds an 'A' to the end of the string. Now the string is "ABBA".
//	Since there is a sequence of moves which starts with "B" and creates the string "ABBA", the answer is "Possible".
//	1)
//	"AB"
//	"ABB"
//	Returns: "Impossible"
//	The only strings of length 3 Jamie can create are "ABA" and "BAB".
//	2)
//	"BBAB"
//	"ABABABABB"
//	Returns: "Impossible"
//	3)
//	"BBBBABABBBBBBA"
//	"BBBBABABBABBBBBBABABBBBBBBBABAABBBAA"
//	Returns: "Possible"
//	4)
//	"A"
//	"BB"
//	Returns: "Impossible"
//	This problem statement is the exclusive and proprietary property of TopCoder, Inc. Any unauthorized use or reproduction of this information without the prior written consent of TopCoder, Inc. is strictly prohibited. (c)2003, TopCoder, Inc. All rights reserved.
//
using System;
using NUnit.Framework;
namespace Topcoder
{
	[TestFixture]
	public class ABBA
	{
		string possible = "Possible";
		string impossible = "Impossible";

		[Test()]
		[TestCase("B", "ABBA", ExpectedResult="Possible")]
		[TestCase("BBBBABABBBBBBA", "BBBBABABBABBBBBBABABBBBBBBBABAABBBAA", ExpectedResult="Possible")]
		[TestCase("A", "BB", ExpectedResult= "Impossible")]
		public string canObtain(string initial, string target)
		{
			if (initial.Length > target.Length) {
				return impossible;
			}

			if (initial.Length == target.Length) {
				return initial == target ? possible : impossible;
			}

			if (target.EndsWith ("A")) {
				return canObtain (initial, ReverseOp1 (target));
			} else {
				return canObtain (initial, ReverseOp2 (target));
			}

		}

		private string ReverseOp1(string str){
			return str.Remove (str.Length - 1);
		}

		private string ReverseOp2(string str){
			var temp = str.Remove (str.Length - 1);
			char[] charArray = temp.ToCharArray();
			Array.Reverse( charArray );
			return new string( charArray ); 
		}
	}
}


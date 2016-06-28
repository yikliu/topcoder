using System;
using System.Collections.Generic;
using NUnit.Framework;
namespace Topcoder
{
	[TestFixture]
	public class BalancedParanthesis
	{
		[TestCase("}][}}(}][))]", ExpectedResult=false, TestName="BalancedParanthesis1")]
		[TestCase("[](){()}", ExpectedResult=true, TestName="BalancedParanthesis2")]
		[TestCase("()", ExpectedResult=true, TestName="BalancedParanthesis3")]
		[TestCase("({}([][]))[]()", ExpectedResult=true, TestName="BalancedParanthesis3")]
		[TestCase("{)[](}]}]}))}(())(", ExpectedResult=false, TestName="BalancedParanthesis3")]
		public bool Balanced (string str)
		{
			char[] strs = str.ToCharArray();
			Stack<char> parans = new Stack<char> ();
			bool quit = false;
			foreach(char ch in strs){
				if(ch.Equals('{') || ch.Equals('[') || ch.Equals('(')){
					parans.Push(ch);
				}else{
					if(parans.Count <= 0){
						return false;
					}
					char popped = parans.Pop();

					if(popped.Equals('(') && !ch.Equals(')')){
						return false;
					}
					if(popped.Equals('[') && !ch.Equals(']')){
						return false;
					}
					if(popped.Equals('{') && !ch.Equals('}')){
						return false;
					}
				}
			}
			if(!quit){
				if(parans.Count > 0 ){
					return false;
				}else{
					return true;
				}
			}
			return true;
		}
	}
}


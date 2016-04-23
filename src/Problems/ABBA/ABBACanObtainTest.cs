using System;
using NUnit.Framework;

namespace Topcoder
{
	[TestFixture()]
	public class ABBACanObtainTest
	{

        private ABBA ab = new ABBA();
        
        [Test()]
        [TestCase("B", "ABBA", ExpectedResult="Possible")]
        [TestCase("BBBBABABBBBBBA", "BBBBABABBABBBBBBABABBBBBBBBABAABBBAA", ExpectedResult="Possible")]
        [TestCase("A", "BB", ExpectedResult= "Impossible")]
        public string CanObtainTest (string from, string to)
		{
			return ab.canObtain(from, to);           
		}
	}
}


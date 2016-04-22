using System;

namespace Topcoder
{
	public class ABBA
	{
		string possible = "Possible";
		string impossible = "Impossible";

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


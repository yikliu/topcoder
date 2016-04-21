using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topcoder
{
    public class Lexer
    {
        public string[] tokenize(string[] tokens, string input)
        {
            Array.Sort(tokens, delegate (string left, string right) {
                return 0 - left.Length.CompareTo(right.Length);
            });

            bool IsStartWithToken;
            List<string> consumed = new List<string>();
            while (input.Length > 0)
            {
                IsStartWithToken = false;
                foreach (string t in tokens)
                {
                    if (input.StartsWith(t))
                    {
                        if (input.Length <= t.Length)
                        {
                            input = "";
                        }
                        else
                        {
                            input = input.Remove(0, t.Length);
                        }

                        consumed.Add(t);
                        IsStartWithToken = true;
                        break;
                    }
                }

                if (!IsStartWithToken)
                {
                    input = input.Remove(0, 1);
                }
            }

            return consumed.ToArray();
        }
    }
}

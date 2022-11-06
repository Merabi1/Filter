using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FilterOfFIlter
{
    public class ComparerAfterString : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            var matches = Regex.Matches(x, @"\d+");
            var matches1 = Regex.Matches(y, @"\d+");

            if (matches.Count == 0 || matches1.Count == 0)
            {
                return x.CompareTo(y);
            }

            for (int i = 0; i < matches.Count; i++)
            {
                try
                {
                    // check if they are both numbers
                    if (matches[i].Success && matches1[i].Success)
                    {
                        if (int.Parse(matches[i].Value) == int.Parse(matches1[i].Value))
                        {
                            continue;
                        }
                        else
                        {
                            return int.Parse(matches[i].Value).CompareTo(int.Parse(matches1[i].Value));
                        }
                    }
                }
                catch (Exception ex)
                {
                    return x.CompareTo(y);
                }
            }
            // otherwise return as string comparison
            return x.CompareTo(y);
        }
    }
}

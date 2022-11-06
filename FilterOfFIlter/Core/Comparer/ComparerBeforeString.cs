using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FilterOfFIlter
{
    public class ComparerBeforeString : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            var regex = new Regex("^([0-9]+)");

            // run the regex on both strings
            var xRegexResult = regex.Match(x);
            var yRegexResult = regex.Match(y);

            // check if they are both numbers
            if (xRegexResult.Success && yRegexResult.Success)
            {
                return int.Parse(xRegexResult.Groups[1].Value).CompareTo(int.Parse(yRegexResult.Groups[1].Value));
            }

            // otherwise return as string comparison
            return x.CompareTo(y);
        }
    }
}

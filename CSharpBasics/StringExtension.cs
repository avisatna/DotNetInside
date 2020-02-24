using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{    
    public static class StringExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int CharCount(this string str)
        {
            return str.ToCharArray().Length;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionsLibrary
{
    // Class must be static for extension methods
    public static class StringExtensions
    {
        // Extension method must also be static and use 'this' keyword before type
        public static bool StartsWithUpper(this string str)
        {
            // Checks if the input is null or empty
            if (string.IsNullOrEmpty(str))
                return false;

            // Check if the first character is uppercase
            char ch = str[0];
            return char.IsUpper(ch);
        }
    }
}

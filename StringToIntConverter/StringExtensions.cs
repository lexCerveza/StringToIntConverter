using System;
using System.Text.RegularExpressions;

namespace StringToIntConverter
{
    public static class StringExtensions
    {
        public static int ConvertToInt(this string input)
        {
            if (!IsStringValid(input))
            {
                throw new ArgumentException("String is not matches number");
            }

            var result = 0;
            for (var i = 0; i < input.Length; i++)
            {
                var currentChar = ConvertCharToInt(input[i]);
                var decimalNumber = GetDecimalNumber(input.Length, currentChar, i);

                result += decimalNumber;
            }
            
            return result;
        }

        private static int GetDecimalNumber(int @base, int numberLength, int offset)
        {
            return @base * GetDecimalBase((numberLength - 1) - offset);
        }

        private static bool IsStringValid(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        private static int GetDecimalBase(int exponent)
        {
            return (int) Math.Pow(10, exponent);
        }

        private static int ConvertCharToInt(char charNumber)
        {
            return charNumber - 48;
        }
    }
}

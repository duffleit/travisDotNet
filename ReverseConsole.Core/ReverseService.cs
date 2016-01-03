using System;
using ReverseConsole.Common;

namespace ReverseConsole.Core
{
    public class ReverseService : IReverseService
    {
        public string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
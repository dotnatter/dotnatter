﻿namespace Dotnatter.HashgraphImpl
{
    public class Key
    {
        public static string New(string x, string y)
        {
            return $"{{{x}, {y}}}";
        }
    }
}
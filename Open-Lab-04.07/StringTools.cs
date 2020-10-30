using System;
using System.Linq;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] a = new char[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                a[i] = original[i];
            }
            Array.Reverse(a);
            string vysl = string.Join("", a);
            return vysl;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StaticPractice.Utils
{
    public static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0)
                return true;

            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
                return true;

            return false;
        }
        public static bool IsContainsDigit(this string str)
        {
            foreach (char item in str)
            {
                if(char.IsNumber(item))
                    return true;
            }

            return false;
        }

        //public static string ToCapitalize(this string str)
        //{
        //    return str.Substring(0, 1).ToUpper() + str.Substring(1); //salam Salam
        //}

        //public  static string ToCapitalize(this string str)
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    char firstChar = char.ToUpper(str[0]); //salam Salam S
        //    stringBuilder.Append(firstChar);
        //    for (int i = 1; i < str.Length; i++)
        //    {
        //        stringBuilder.Append(str[i]);
        //    }

        //    return stringBuilder.ToString();
        //}

        public static int[] GetValueIndexes(this string str, char c) //salam a
        {
            int[] indexes = new int[0];
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == c)
                {
                    Array.Resize(ref indexes, indexes.Length + 1); //arr = new arr[2] {1,3}
                    indexes[indexes.Length - 1] = i; //indexes[2-1]//indexes[1]=3
                }
            }

            return indexes;
        }
    }

}

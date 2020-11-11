using System;
namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            int[,] a = new int[str1.Length + 1, str2.Length + 1];
            int b = 0;
            int c = 0;

            for (int i = 0; i < str1.Length; i++)
                for (int k = 0; k < str2.Length; k++)
                    if (str1[i] == str2[k])
                    {
                        int d = a[i + 1, k + 1] = a[i, k] + 1;
                        if (d > a[b, c])
                        {
                            b = i + 1;
                            c = k + 1;
                        }
                    }

            return str1.Substring(b - a[b, c], a[b, c]);
        }
    }
}

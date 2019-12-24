using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public static class Levenstein
    {
        public static int Distance(string str1, string str2)
        {
            int str1Len = str1.Length;
            int str2Len = str2.Length;

            if ((str1 == null) || (str2 == null)) return -1; 
            if ((str1Len == 0) && (str2Len == 0)) return 0; 
            if (str1Len == 0) return str2Len; 
            if (str2Len == 0) return str1Len;

            str1.ToUpper();
            str2.ToUpper();

            int[,] matr = new int[str1Len + 1, str2Len + 1]; 
            for (int i = 0; i <= str1Len; i++) matr[i, 0] = i; 
            for (int j = 0; j <= str2Len; j++) matr[0, j] = j;
            for(int i = 1; i <= str1Len; i++) 
            { 
                for (int j = 1; j <= str2Len; j++)
                {
                    //Левенштайн
                    int sEq = ((str1.Substring(i - 1, 1) == str2.Substring(j - 1, 1)) ? 0 : 1);
                    int ins = matr[i, j - 1] + 1; //добавление
                    int del = matr[i - 1, j] + 1; //удаление
                    int subst = matr[i - 1, j - 1] + sEq;
                    matr[i, j] = Math.Min(Math.Min(ins, del), subst); //выбор минимальной длины
                
                    if((i > 1) && (j > 1) && (str1.Substring(i - 1, 1) == str2.Substring(j - 2, 1)) &&
                    (str1.Substring(i - 2, 1) == str2.Substring(j - 1, 1)))
                    {
                        matr[i, j] = Math.Min(matr[i, j],
                        matr[i - 2, j - 2] + sEq);
                    }
                }
            }
            return matr[str1Len, str2Len]; 
        }
    }
}
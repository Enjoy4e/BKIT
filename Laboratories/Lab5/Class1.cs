using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public static class Levenstein
    {
        /// <summary>
        /// Вычисление расстояния Дамерау-Левенштейна
        /// </summary>
        public static int Distance(string s1, string s2)
        {
            int len1 = s1.Length;
            int len2 = s2.Length;
            if (len1 == 0 || len2 == 0)
            return Math.Max(len1, len2);
            //Приведение строк к верхнему регистру
            string tmp1 = s1.ToUpper();
            string tmp2 = s2.ToUpper();

            int[,] matrix = new int[len1 + 1, len2 + 1];
            //Инициализация нулевой строки и нулевого столбца матрицы
            for (int i = 0; i <= len1; ++i) matrix[i, 0] = i;
            for (int j = 0; j <= len2; ++j) matrix[0, j] = j;

            for (int i = 1; i <= len1; ++i)
                for (int j = 1; j <= len2; ++j)
                {
                    int indicator = (tmp1[i - 1] == tmp2[j - 1]) ? 0 : 1;

                    matrix[i, j] = Math.Min(
                    matrix[i - 1, j] + 1,
                    Math.Min(matrix[i, j - 1] + 1,
                    matrix[i - 1, j - 1] + indicator)
                    );
                }
            return matrix[len1, len2];
        }

        //Вычисление расстояния Дамерау-Левенштейна
        public static int levdist(string s1, string s2)
        {
            int len1 = s1.Length, len2 = s2.Length;
            if (len1 == 0 || len2 == 0)
                return Math.Max(len1, len2);
            string tmp1 = s1.ToUpper();
            string tmp2 = s2.ToUpper();

            int[,] matrix = new int[len1 + 1, len2 + 1];
            for (int i = 0; i <= len1; ++i) matrix[i, 0] = i;
            for (int j = 0; j <= len2; ++j) matrix[0, j] = j;

            for (int i = 1; i <= len1; ++i)
                for (int j = 1; j <= len2; ++j)
                {
                    int indicator = (tmp1[i - 1] == tmp2[j - 1]) ? 0 : 1;

                    matrix[i, j] = Math.Min(
                    matrix[i, j - 1] + 1,
                    Math.Min(matrix[i - 1, j] + 1,matrix[i - 1, j - 1] + indicator));
                    //Дополнение Дамерау по перестановке соседних символов
                    if (i > 1 && j > 1 && tmp1[i - 1] == tmp2[j - 2] && tmp1[i - 2] == tmp2[j - 1])
                        matrix[i, j] = Math.Min(matrix[i, j], matrix[i - 2, j - 2] + indicator);
                }
            //Возвращается нижний правый элемент матрицы
            return matrix[len1, len2];
        }
    }
}
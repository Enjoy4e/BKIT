using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class SubArrayList
    {
        public static List<MiniMax> DivideSubArrays(int beginIndex, int endIndex, int subArraysCount)
        {
            List<MiniMax> result = new List<MiniMax>();
            if ((endIndex - beginIndex) <= subArraysCount)
            {
                result.Add(new MiniMax(0, (endIndex - beginIndex)));
            }
            else
            {
                int delta = (endIndex - beginIndex) / subArraysCount;
                int currentBegin = beginIndex;
                while ((endIndex - currentBegin) >= 2 * delta)
                {
                    result.Add(new MiniMax(currentBegin, currentBegin + delta));
                    currentBegin += delta;
                }
                result.Add(new MiniMax(currentBegin, endIndex));
            }
            return result;
        }
    }
}

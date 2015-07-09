using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    class BubbleSorter
    {
        public static void sort<T>(IList<T> sortArray, Func<T, T, bool> comparison)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Count() - 1; ++i)
                {
                    // 这里也可以使用 运算符重载，问题就是必须成对，即 < >，且 T 必须是定义了运算符重载，这里的问题是IList没有重载，只有定义自己的接口，因此过程就复杂了，所有使用委托
                    // if (sortArray[i] < sortArray[i + 1])
                    if (!comparison(sortArray[i], sortArray[i + 1]))
                    {
                        T temp = sortArray[i + 1];
                        sortArray[i + 1] = sortArray[i];
                        sortArray[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }
}

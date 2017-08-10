using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托Lambda表达式和事件
{
    public class BubbleSorter
    {
        /// <summary>
        /// 委托的作用，该方法主要用于排序，但是不知道用于int类型排序还是其他排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sortArray"></param>
        /// <param name="comparsion"></param>
        public static void Sort<T>(IList<T> sortArray,Func<T,T,bool> comparsion)
        { 
            
        }





        /// <summary>
        /// 利用Sort为其排序
        /// </summary>
        /// <param name="SortArry"></param>
        public static void SortInt(List<int> SortArry)
        {
            SortArry.Sort();
            foreach (int item in SortArry)
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> Sort(List<int> sortAyyr)
        {
            int temp;
            for (int i = 0; i < sortAyyr.Count; i++)
            {
                for (int j = i + 1; j < sortAyyr.Count; j++)
                {
                    Console.WriteLine("i值:{0},j值{1}", sortAyyr[i], sortAyyr[j]);
                    if (sortAyyr[i] > sortAyyr[j])
                    {
                        temp = sortAyyr[j];
                        sortAyyr[j] = sortAyyr[i];
                        sortAyyr[i] = temp;
                    }
                }
            }
            return sortAyyr;
        }

        //冒泡排序
        public static int[] IntSortBu()
        {
            int[] list = { 0, 4, 2, 7, 6, 3, 8, 1, 9 };
            int number;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] > list[j])
                    {
                        number = list[j];
                        list[j] = list[i];
                        list[i] = number;
                    }
                }
            }
            return list;
        }



    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单数组预定义数组
            int[] myArray = { 1, 2, 3, 4, 5 };

            //自定义数组
            person[] myPerson = { new person("Ayrto","Senna"),new 
                                person("Nichael","Schumacher")};

            //多维数组(二维数组)
            int[,] twodim = { 
                            { 0, 1 }, 
                            { 0, 2 }, 
                            { 0, 3 }, 
                            { 0, 4 }, 
                            { 1, 1 }, 
                            { 1, 2 }, 
                            { 1, 3 }, 
                            { 1, 4 } 
                            };
            //三维数组
            int[, ,] threedim = { 
                                { 
                                { 0, 1 }, 
                                { 0, 2 }, 
                                { 0, 3 } 
                                }, 
                                { 
                                { 1, 1 }, 
                                { 1, 2 }, 
                                { 1, 3 } 
                                }, 
                                { 
                                { 2, 1 }, 
                                { 2, 2 }, 
                                { 2, 3 } 
                                } 
                                };

            //锯齿数据int[][]前一个括号表示数组长度，后一个[]表示数组长度
            Console.WriteLine("**** 锯齿数组 ****");
            int[][] jaggad = new int[3][];
            jaggad[0] = new int[2] { 1, 2 };
            jaggad[1] = new int[6] { 3, 4, 5, 6, 7, 8 };
            jaggad[2] = new int[3] { 9, 10, 11 };
            for (int i = 0; i < jaggad.Length; i++)
            {
                for (int j = 0; j < jaggad[i].Length; j++)
                {
                    Console.WriteLine("第一个[]的值:{0},第二个[]的值:{1}", i, jaggad[i][j]);
                }
            }

            //Array类，他是一个抽象类，所以不能使用构造函数来创建数组，但可以使用CreateInstance()创建数组
            //创建一个类型为int，长度为5de 数组
            Console.WriteLine("***** 利用代码创建数组 *****");
            Array intArray1 = Array.CreateInstance(typeof(int), 5);
            for (int i = 0; i < 5; i++)
            {
                Random ran = new Random();
                int ranint = ran.Next(100);
                intArray1.SetValue(ranint, i);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intArray1.GetValue(i));
            }

            //for和foreach执行速度根据数据类型不同而改变
            Console.WriteLine("**** 复制数组 ****");
            int[] intarry2 = { 1, 2, 3, 4, 5, 6 };
            int[] intarray3 = (int[])intarry2.Clone();
            foreach (int item in intarray3)
            {
                Console.WriteLine(item);
            }

            //排序，Array类使用QuickSort算法对数组中的元素进行排序，Sort方法需要数组中的元素事项IComparable接口
            Console.WriteLine("*****string数组使用Sort排序*****");
            string[] names = { "BBB", "AAAAA", "ZZZZZ", "FFFF" };
            Array.Sort(names);
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****int数组使用Sort排序*****");
            int[] intname = { 9, 20, 49, 93, 10, 40, 56 };
            Array.Sort(intname);
            foreach (int item in intname)
            {
                Console.WriteLine(item);
            }
            //数组可以作为参数


            //结构ArraySegment<T>表示数组的一段，如果需要使用不同的方法处理某个大型数组的不同部分，那么可以把相应的数组部分复制到各个方法中
            Console.WriteLine("****ArraySegment<T>分段，然后计算***");
            int[] ar1 = { 1, 4, 5, 11, 13, 18 };
            int[] ar2 = { 3, 4, 5, 18, 21, 27, 33 };

            var segments = new ArraySegment<int>[2]{
                //new ArraySegment<int>(ar1,0,3)表示该数组从下标几开始取几位
                new ArraySegment<int>(ar1,0,3),
                new ArraySegment<int>(ar2,3,3)
            };

            var sum = SumOfSegments(segments);
            Console.WriteLine(sum);

            Console.WriteLine("***** yield功能 *****");

            foreach (string item in GetEnumerator())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static IEnumerable GetEnumerator()
        {
            yield return "Hello";
            yield return "World";
        }


        public static int SumOfSegments(ArraySegment<int>[] segments)
        {
            int sum = 0;
            foreach (var item in segments)
            {
                for (int i = item.Offset; i < item.Offset + item.Count; i++)
                {
                    sum += item.Array[i];
                }
            }
            return sum;
        }
    }


    public class person
    {
        public person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("{0},{1}", FirstName, LastName);
        }
    }


}

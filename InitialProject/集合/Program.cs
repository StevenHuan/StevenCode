using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>是与数组相当的集合类
            //大多数集合类都可在System.Collection和System.Collection.Generic名称空间中找到，
            //泛型集合类位于System.Collections.Generic名称空间中：
            //专用于特定类型的集合类位于System.Collections.Specialized名称空间中，
            //线程安全的集合位于Syste.Collection.Concurrent名称空间中，
            //不可变的集合类在System.Collections.Immutable名称空间中


            //泛型类List<T>,这个类实现了IList、ICollection、IEnumerbale、IList<T>、ICollection<T>和IEnumerable<T>接口

            //使用List.Capacity可以设置和获取集合的容量,不设置容量时初始容量时4，超过后以原来2倍递增

            List<int> listint = new List<int>();
            //插入元素，
            listint.Insert(0,1);//第一个元素为下标，第二个为值
            listint.Add(2);
            listint.Add(12);
            listint.Add(534);
            listint.Add(833);
            listint.Add(65);
            listint.Add(37);
            //删除元素
            listint.RemoveAt(3);//参数为下标
            //搜索
            int index1=listint.IndexOf(10);//找到就返回该元素索引，如果没找到就返回-1
            Console.WriteLine(index1);
            //listint.find(r=r.index == 3)//查找匹配想
            
            //排序
            listint.Sort();
            foreach (int item in listint)
            {
                Console.WriteLine(item);
            }

            //有序列表
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("大话设计模式",0);
            dictionary.Add("C#高级模式", 1);
            dictionary.Add("C#基础", 2);
            dictionary.Add("WPF", 3);
            dictionary.Add("MVC", 4);
            dictionary.Add("HTML", 5);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            //字典
            Dictionary<int, Shcool> diSchool = new Dictionary<int, Shcool>();
            diSchool.Add(0,new Shcool(12,"老马","123"));
            diSchool.Add(1, new Shcool(13, "老刘", "1234"));
            diSchool.Add(2, new Shcool(14, "老王", "1235"));
            diSchool.Add(3, new Shcool(15, "老等", "1236"));
            diSchool.Remove(2);

            foreach (var item in diSchool)
            {
                Console.WriteLine(item.Value.Name);
            }

            HashSet<string> SS = new HashSet<string>();
            Console.ReadLine();
        }
    }

    public class Shcool
    {
        public Shcool(int id,string name,string pwd)
        {
            this.Id = id;
            this.Name = name;
            this.Pwd = pwd;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Pwd { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    public class School : ISchool
    {
        public T GetAllT<T>(string name,int age)
        {
            List<Schoolssss> list = new List<Schoolssss>();
            list.Add(new Schoolssss("张三", 12));
            list.Add(new Schoolssss("李四", 22));
            list.Add(new Schoolssss("王五", 32));
            object schoolsss = list.Where(p => p.Age > age && p.Name == name).FirstOrDefault();
            return (T)schoolsss;
        }

        public T GetAllTByT<T, S, U>(S s, U u)
        {
            List<Schoolssss> list = new List<Schoolssss>();
            list.Add(new Schoolssss("张三", 12));
            list.Add(new Schoolssss("李四", 22));
            list.Add(new Schoolssss("王五", 32));
            object schoolsss = list.Where(p => p.Age > Convert.ToInt32(u) && p.Name == s.ToString()).FirstOrDefault();
            return (T)schoolsss;
        }
    }

    public class Schoolssss
    {
        public Schoolssss(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }

        public int Age { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 实现自己的ORM
{
    class Program
    {
        //指示应用程序的COM线程模型是单线程单元
        [STAThread]
        static void Main(string[] args)
        {
            //实现自己的ORM其实就是反射以及Attribute在ORM的应用
            //反射：他是可以在运行时动态获取对象信息的方法，比如获取对象额属性和方法等
            //反射作用：他不但可以在运行时获取对象的信息，还提供运行时动态调用对象方法以及动态设置、获取属性的能力
            //ORM是通过自定义Attribute的方式进行映射规则的描述
            //我们通过Attribute来定义隐射规则，，然后在通过反射来动态获取这些映射规则


            #region 反射的作用
            //Person person = new Person();
            //person.Name = "张珊";
            //person.Age = 5;
            //person.Sex = "male";

            //PropertyInfo[] infos = person.GetType().GetProperties();
            //Console.WriteLine("打印属性");
            //foreach (PropertyInfo item in infos)
            //{
            //    //GetValue获取属性
            //    Console.WriteLine(item.Name+":"+item.GetValue(person)); 
            //}
            //Console.WriteLine("设置Person.Name=Hellokitty");
            //foreach (PropertyInfo item in infos)
            //{
            //    if (item.Name == "Name")
            //    {
            //        //SetValue设置属性
            //        item.SetValue(person,"Hellokitty",null);
            //    }
            //}
            //Console.WriteLine("打印修改后的属性");
            //foreach (PropertyInfo item in infos)
            //{
            //    Console.WriteLine(item.Name + ":" + item.GetValue(person));
            //} 
            #endregion


            //Attribute它和对象的属性是不同的，他是在运行时对对象或者对象属性、方法、委托等等进行描述的类，用于在运行时描述你的代码或则运行时影响你的程序的行为
            #region 反射和Attribute的结合使用
            //Console.WriteLine("*********反射和Attribute的联合使用********");
            //Person person = new Person();
            //person.Name = "Snoopy";
            //person.Age = 5;
            //person.Sex = "male";

            //PropertyInfo[] infos = person.GetType().GetProperties();
            //object[] objDataFieldAttribute = null;
            //foreach (PropertyInfo item in infos)
            //{
            //    objDataFieldAttribute = item.GetCustomAttributes(typeof(DataFieldAttribute),false);
            //    if(objDataFieldAttribute !=null){
            //        Console.WriteLine(item.Name +"--->数据库字段："+ ((DataFieldAttribute)objDataFieldAttribute[0]).FieldName);
            //    }
            //} 
            #endregion

            //实现自己的ORM,笨例采用的是ONE_INHERIT_TREE_ONE_CLASS(一个几成熟对应于一个表)的结构，这种结构会导致数据冗余，凡是结构比较简单


            Console.Read();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DasetModels;

namespace 反射
{
    class Program
    {
        static void Main(string[] args)
        {
            //这里是自定义特性和反射：自定义特性允许把自定义元数据与程序元素关联起来，这些元素都是在编译过程中创建的，并嵌入到程序集中；

            //反射:描述了在运行过程中检查和处理程序元素的功能,他可以完成以下任务:
            //枚举类型的成员，实例化新对象，执行对象的成员，查找类型的信息，查找程序集的信息，检查应用于某种类型的自定义特性，创建和编译新程序集;

            //反射提供一种编程的方式，让程序员可以在运行期获得这几个组成部分的相关信息
            //.NET程序由以下几个部分组成"程序集(Assembly)","模块(Module)","类型(Class)"
            //Assembly类可以获得正在运行的装配件信息，也可以动态的加载装配件，以及在装配件中查找类型信息，并创建该类型的实例
            //Type类可以获得对象的类型信息，此信息包含对象的所有要素，包括:方法、构造器、属性等等，通过Type类可以的到这些要素的信息，并且调用
            //MethodInfo包含方法的信息，通过这个类可以得到方法的名称、参数、返回值等


            //特性：
            //AttributeUsage特性：主要用来标识自定义特性可以应用到哪些类型的元素上，这些信息由它的第一个参数给出，该参数是必选的，其类型是枚举类型AttributeTargets.枚举成员如下：All、Assembly(程序集)、Class(类)、Constructor(构造函数)、Delegate(委托)、Enum(枚举)、Interface(接口)、Method、Module(模块)、Parameter、Property、ReturnValue、Struct


            //----------------------------反射---------------------------
            //反射就是为了让方法属性动态化System.Reflection重要
            //反射原理：
            //System.Type类，通过这个类可以访问关于任何数据类型的信息
            //System.Reflection.Assembly类，可以用于访问给定程序集的相关信息，或者把这个程序集加载到程序中
            //Type的属性：Name,数据类型名，FullName:数据类型的完全限定名(包括名称空间名)，Namespace：在其定义数据类型名称空间名
            //Assembly类在System.Reflection名称空间中定义，他循序访问给定程序集的元数据，它包含可以加载和执行程序集的方法
            Console.WriteLine("************反射************");
            IDBHelper IDbhelper = new DBHelper();
            IDbhelper.Query();

            //反射的入口，可以动态的加载dll,这些信息都存在在元数据中
            Assembly assembly = Assembly.Load("DasetModels");
            Console.WriteLine("-------GetModules()--------");
            foreach (Module item in assembly.GetModules())
            {
                Console.WriteLine("名称{0}",item.FullyQualifiedName);
            }
            Console.WriteLine("---------GetType----------");

            foreach (Type item in assembly.GetTypes())
            {
                Console.WriteLine("类型:{0}",item.FullName);
            }

            Console.WriteLine("----------------非常重要，实现访问类相当于访问数据库的基础-----------------");
            Console.WriteLine("------创建对象-------");
            //基于类的完整名称找出类型,Dbhelper获取传入的对象名
            //将这一步配置到资源文件中app.config
            Type dbhelper = assembly.GetType("DasetModels.School");
            
            //或这样写 Type type=typeOf(School);
            foreach (MethodInfo item in dbhelper.GetMethods())
            {
                Console.WriteLine("GetMethods:"+ item);
            }

            //obj获取传入对象名的属性
            Object obj = Activator.CreateInstance(dbhelper);

            Console.WriteLine("***********获取类的属性************");
            foreach (PropertyInfo item in dbhelper.GetProperties())
            {
                Console.WriteLine("属性名称：{0};值是{1}",item.Name,item.GetValue(obj));
            }
            School school = (School)obj;
            school.Address = "吉安";
            school.ID = "1";
            school.Name = "邓文翰";
            Console.WriteLine("编号：{0},城市：{1},姓名：{2}",school.ID,school.Address,school.Name);


            
            Console.ReadKey();
        }
    }
}

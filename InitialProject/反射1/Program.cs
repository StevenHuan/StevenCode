using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.Text;

namespace 反射1
{
    class Program
    {
        static void Main(string[] args)
        {
            //反射是.NET中的重要机制，通过反射，可以在运行时获得程序或程序集中每一个类型(包括类、结构、委托和枚举等)的程序和成员的信息，有了反射，即可以对每一个类型了如指掌，另外我还可以直接创建对象，即使这个对象的类型在编译时还不知道
            //反射的用途：
            //1、使用Assembly定义和加载程序集，加载在程序集清单中列出模块，以及从此程序集中查找类型并创建该类型的实例
            //2、使用Module了解包含模块的程序集以及模块中的类等，还可以获取在模块上定义的所有全局方法或其他特定的非全局方法
            //3、使用ConstructorInfo了解构造函数的名称、参数、访问修饰符(public或private)和实现详细信息(如abstract或virtual)等
            //4、使用MethodInfo了解方法的名称、返回类型、参数、访问修饰符和实现详细信息等
            //5、使用FiedInfo了解字段的名称、访问修饰符和实现详细信息等并获取或设置字段值
            //6、使用EventInfo了解事件的名称、事件处理程序数据类型、自定义属性、声明类型和反射类型等，添加或移除事件处理程序
            //7、使用PropertyInfo了解属性的名称、数据类型、声明类型、反射类型和只读或可写状态等，获取或设置属性值
            //8、使用ParameterInfo了解参数的名称、数据类型、是输入参数还是输出参数，以及参数在方法签名中的位置等
            //反射用到的命名空间：
            //1、System.Reflection、
            //2、System.Type、
            //3、System.Reflection.Assembly
            //反射用到的主要类：
            //1、System.Type类：通过这个类可以访问任何给定数据类型的信息,这个类对于反射起着核心的作用，但它是一个抽象的基类，Type有与每种数据类型对应的派生类，我们使用这个派生类的对象的方法、字段、属性来查找有关类型的所有信息
            //2、System.Reflection.Assembly类：这个类可以访问给定程序集的信息，或者把这个程序集加载到程序中
            //获取给定类型的Type方法
            //第一种方法
            Type t1=typeof(string);
            //第二种方法
            string s="hello";
            Type t2=s.GetType();
            //第三种方法
            Type t3=Type.GetType("System.String");
            //Type类的属性
            //Name:数据类型名
            //FullName:数据类型的完全限定名(包括命名空间)
            //NameSpace:定义数据类型的命名空间名
            //IsAbstract:指示该类型是否是抽象类型
            //IsArray:指示该类型是否是数组
            //IsClass:指示该类型是否是类
            //IsEnum:指示该类型是否是枚举
            //IsInterface:指示该类型是否是接口
            //IsPublic:指示该类型是否是公有
            //IsSealed:指示该类型是否是密封类
            //IsValueType:指示该类型是否是值类型

            //Type类的方法
            //GetConstructr(),GetConstrcutors():返回ConstructorInfo类型，用于取得该类的构造函数的信息
            //GetEvent()、GetEvents():返回EventInfo类型，用于取得该类的事件的信息
            //GetField()、GetFields():返回FieldInfo类型，取得该类的字段(成员变量的信息)
            //GetInterface()、GetInterfaces():返回InterfaceInfo类型，用于取得该类实现的接口信息
            //GetMember()、GetMembers():返回MethodInfo类型,用于取得该类的的所有成员的信息
            //GetMethod()、GetMethods():返回MethodInfo类型，用于取得该类的方法的信息
            //GetProperty()、GetProperties():返回PropertyInfo类型，用于取得该类的属性的信息

            
            //反射是一个运行库类型发现的过程，通过反射可以得到一个给定程序集所包含的所有类型的列表，这个列表包括给定类型中定义的方法、字段、属性和事件。也可以动态的发现一组给定支持的接口、方法的参数和其他相关信息如基类、明明空间、数据清单等
            //System.Reflection命名空间内的各类型
            //Assembly:通过它可以加载、了解和操纵一个程序集
            //AssemblyName:通过它可以找到大量隐藏在程序集的身份中的信息，如版本信息、区域信息等
            //EventInfo:事件的信息
            //FieldInfo:字段的信息
            //MethodInfo:方法的信息
            //ParameterInfo:参数的信息
            //PropertyInfo:属性的信息
            //MemberInfo是抽象基类，为EventInfo、FieldInfo、MethodInfo、PropertyInfo等类型定义了公共的行为
            //Module用来访问带有多文件程序集的给定模块

            //System.Type类
            //System.Type支持的成员可以分为这样几类
            //Is***:用来检查一个类型的元数据,如IsAbstract、IsClass、IsValueType等
            //Get**:用来从类型得到指定项目，如GetEvent()得到类型的一个指定事件，另外这些方法都有一个单数版本和一个复数版本，如GetEvent()对应有一个复数版本GetEvents(),该方法返回一个相关的EventInfo数组
            //FindMembers():根据查询条件返回一个MemberInfo类型的数组
            //GetType():该静态方法根据一个字符串名称返回一个Type实例
            //InvokeMember():给定项目进行晚期绑定

            Console.WriteLine("----------------------------------------------");
            //Person类的完全限定名为"反射1.Person"
            Type t = Type.GetType("反射1.Person");
            //反射其他一些信息
            ListOtherInfo(t);
            //反射字段
            ListFields(t);
            //反射属性
            ListProperties(t);
            //反射接口
            ListInterFaces(t);
            //反射时间
            ListEvents(t);
            //反射一个特定方法的详细信息
            ListMethodDetail(t, "ChangeNameAndAddAge");
            //反射方法
            ListMethods(t);
            //6214830172992769
            Console.ReadLine();
        }

        #region 构建自定义元数据查看器
        //显示传入类型拥有的方法类型
        public static void ListMethods(Type t)
        {
            Console.WriteLine("\n该类型的所有方法:");
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo item in mi)
            {
                Console.WriteLine("\t方法名:{0}",item.Name);
            }
        }
        //显示一个方法的所有参数信息
        public static void ListParameters(MethodInfo m)
        {
            ParameterInfo[] pi = m.GetParameters();
            foreach (ParameterInfo item in pi)
            {
                Console.WriteLine("参数名:{0}\t参数类型:{1}",item.Name,item.ParameterType);
            }
        }

        //显示一个特定方法的详细情况
        public static void ListMethodDetail(Type t,string MethodName)
        {
            MethodInfo m = t.GetMethod(MethodName);
            Console.WriteLine("\n显示方法详情\n方法名称:{0}",MethodName);
            Console.WriteLine("方法返回值类型:{0}",m.ReturnType.FullName);
            ListParameters(m);
        }

        //显示传入类型拥有字段名称
        public static void ListFields(Type t)
        {
            Console.WriteLine("\n该类型的所有字段：");
            FieldInfo[] fi = t.GetFields();
            foreach (FieldInfo item in fi)
            {
                Console.WriteLine("\n字段名:{0}",item.Name);
            }
        }
        //显示传入类型拥有的属性名称
        public static void ListProperties(Type t)
        {
            Console.WriteLine("\n该类型的所有属性:");
            PropertyInfo[] pi = t.GetProperties();
            foreach (PropertyInfo item in pi)
            {
                Console.WriteLine("\t属性名:{0}",item.Name);
            }
        }
        //显示传入类型拥有的基类名称
        public static void ListInterFaces(Type t)
        {
            Console.WriteLine("\n该类型的所实现的接口:");
            //对GetInterfaces()的调用返回一个Type类型的数组(说明其实接口也是一种类型)
            Type[] ii = t.GetInterfaces();
            foreach (Type item in ii)
            {
                Console.WriteLine("\t接口名:{0}",item.Name);
            }          
        }

        //显示传入类型拥有的属性名称
        public static void ListEvents(Type t)
        {
            Console.WriteLine("\n该类型的所有事件名:");
            EventInfo[] ei = t.GetEvents();
            foreach (EventInfo item in ei)
            {
                Console.WriteLine("\n属性名:{0}",item.Name);
            }
        }
        //各种其他信息
        public static void ListOtherInfo(Type t)
        {
            Console.WriteLine("基类名称:{0}",t.BaseType);
            Console.WriteLine("基类的基类的名称:{0}",t.BaseType.BaseType);
            Console.WriteLine("是一个类吗？:{0}",t.IsClass);
            Console.WriteLine("是一个抽象类吗？{0}",t.IsAbstract);
        }
        #endregion
    }
}

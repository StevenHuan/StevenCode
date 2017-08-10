using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //在.NET数据访问中使用中使用的类和接口
            //System.Date:所有数据访问泛型类
            //System.Data.Common:各个数据提供程序共享的类
            //System.Data.EntityClient:Entity Framework类
            //System.Data.Linq.SqlClient:LINQ to SQL提供程序类
            //System.Data.Odbc:ODBC提供程序的类
            //System.Data.OleDb:OLEDB提供程序的类
            //System.Data.ProviderBase:新的基类和链接工厂类
            //System.Data.Sql:用于SQL Server数据访问的新泛型接口和类
            //System.Data.SqlClient:SqlServer提供程序的类
            //System.Data.SqlType:SqlServer数据类型

            //共享类
            //DataSet:主要用于断开链接，他可以包含一组DaaTable,以及这些表之间的关系
            //DataTable:数据的一个容器，DataTable由一个或多个DataColumn组成，每个DataColumn由一个或多个包含数据的DataRow组成
            //DataCloumn:该对象包含列的定义，如名称和数据类型
            //DataRelation:DataSet类中两个DataTable类之间的链接，用于外检和主从关系
            //Constraint:为DataCloumn类定义规则，如唯一值
            //DataColumnMapping:将数据库中的列名映射到DataTable中的列名
            //DataTableMapping:将数据库中的表名映射到DataSet中的DataTable

            //数据库专用类
            //SqlCommand.OleObCommand、ODBCCommand:用作SQL语句或存储过程调用的包装器
            //SqlCommandBuilder、OleobCommandBuilder、ODBCCommandBuilder：用于从一条SELECT语句中生成SQL命令(如INSERT,UPDATE,DELETE)
            //SqlConnection,OleDbConnection,ODBCConnection用于链接数据库，类似于ADO链接，
            //SqlDataAdapter,OleObDataAdapter,ODBCDataAdapter:用用于存储SELECT、INSERT、UPDATE、DELETE命令的类，因此可以用于填充DataSet和跟新数据库，
            //SqlDataReader,OleobDataReader,ODBCDataReader:用作只想钱的数据读取器
            //SqlParameter,OleDbParameter,ODBCParameter,用于为存储过程定义一个参数，
            //SqlTransaction,OleobTransaction,ODBCTranscation:用于数据库事务，包装在一个对象中

            //--------------------------分割线--------------------------------
            //ADO.NET类最重要的功能是：他们是以断开链接的方式工作
            //执行命令
            //ExecuteNonQuery()方法：这个方法一般用于UPDATE、INSERT、DELETE语句，其中唯一的返回值就是受影响的记录的个数
            //ExecuteReader()方法：根据使用的提供程序返回一个类型化的DataReader对象，返回的对象可以用于便利返回的记录
            //ExecuteScalar()方法：从SQL语句中返回一个结果，如给定表中的记录数，或者服务器上当前日期/时间,这个方法适用于这些场合
            //ExecuteXmlReader()方法：只用于SqlClient提供程序，这个方法执行SQL语句，给调用者返回一个XmlReader对象(不做过多讲述)

            //调用无返回值存储过程
            //SqlCommand cmd = new SqlCommand("存储过程名","数据库链接名");
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("存储过程参数名","参数");
            //cmd.ExcuteNonQuery();
            //这样写要好一点
            //cmd.Parameters.Add(new SqlParameter("存储过程参数名","数据类型","第几个参数","传入参数名"));
            //cmd.Parameters["存储过程参数名"].Value = 值;
            //cmd.ExecuteNonQuery();
            //调用有返回值的存储过程


            //----------------------数据读取器--------------------------
            //数据读取器DataReader是从数据源中选择某些数据的最简单快捷的方法，但是也是功能最弱的方法，他不能直接实例化数据阅读器，即调用ExecuteReader()方法后从相应数据库的命令对象中返回的实例
            //SqlCommand cmd=new SqlCommand("语句","数据库链接字符串");
            //SqlDataReader aReader = cmd.ExecuteReader();

            //---------------------异步数据访问Task和await-------------------------
            //异步请求数据的主要方式是使用SqlCommand类，因为这些类包含了使用APM的方法，APM提供了BeginExecuteReader和EndExecuteReader方法   
            //使用线面Task类访问数据是他包含了2个任务：第一个任务是选择对象，第二个任务是吧该对象转换为整数  ；使用这个他可以转换为一个对象实例列表
            //在C#中添加async和await关键字，可以简化任务的异步提示，如下代码

            //--------------------DataSet类-------------------------
            //DataSet类是数据的脱机容器，是用来存储数据的，他的数据不一定源于数据库，
            //DataSet类是由一组数据表组成，每个表都有一组数据列和数据行,DataSet和相关类基本伤悲Entity Framework代替

            //------------------------构成DataSet的数据表DataTable------------------------------
            //属性Columns,是DataColumn的集合，表示DataTable中列的集合da.Columns[0]
            //属性Rows是DataRow的集合,表示DataTable中行的集合da.Rows[0][0],第一行第一列
            //属性Constraints是Constraint的集合，表示DataTable约束的集合
            //属性ExtendedProperties,获取自定义用户信息的集合
            DataSet da = new DataSet();
            //foreach (DataRow item in da.Tables[""].Rows)
            //{
            //    Console.WriteLine(item[0]);
            //}

            //foreach (DataColumn item in da.Tables[""].Columns)
            //{
            //    Console.WriteLine("列名"+item.ColumnName+"值"+item);
            //}

            //-------------------架构的生成-------------------
            //为DataTable创建架构有3中方式
            //1、让运行库来完成，2、编写代码来创建表，3、使用XML架构生成器
            //1、运行库生成的架构
            string str = "Select * from SC.Complaint";
            SqlDataAdapter daAdaprer = new SqlDataAdapter(str, GetDatabaseConnection());
            DataSet ds = new DataSet();
            daAdaprer.Fill(ds, "Complaint");
            
            Console.WriteLine("**********Rows***********");
            foreach (DataRow item in ds.Tables["Complaint"].Rows)
            {
                Console.WriteLine("列名ID:{0}",item[4]);
            }
            Console.WriteLine("***************Cloumns************");
            foreach (DataColumn item in ds.Tables["Complaint"].Columns)
            {
                Console.WriteLine("第一列:{0}",item);
            }
            
            //2、手工编码的架构

            //3、XML架构，用XSD生成代码
            //现在在对象之间远程传递数据的格式是XML

            //填充DataSet类
            //1、使用数据适配器  SqlDataAdapter daAdaprer = new SqlDataAdapter(str, GetDatabaseConnection());
            //2、XML填充DataSet类
            //ds.ReadXml(".\\MyData.xml");

            //------------------持久化DataSet类的修改-------------------
            ///持久化Daset类的修改：常见的示例就是：从数据库中选择数据，展示给用户，把这些跟新返回给数据库
            //通过数据适配器更新
            //SqlDataAdapter类包含SelectCommand、InsertCommand、UpdateCommand、DeleteCommand,这些对象适用于相应提供程序的命令对象
            SqlDataAdapter SqlAdapter = new SqlDataAdapter();
            SqlAdapter.Update(ds,"类");
            //通过写入XML输出结果


            //--------------------使用ADO.NET------------------------
            Console.ReadKey();
        }

        #region Task类访问数据
        public Task<int> GetEmployeeCount()
        {
            using (SqlConnection conn = new SqlConnection(GetDatabaseConnection()))
            {
                string str = "select * from 表名";
                SqlCommand cmd = new SqlCommand(str, conn);
                conn.Open();
                return cmd.ExecuteScalarAsync().ContinueWith(t => Convert.ToInt32(t.Result));
            }
        }

        public static string GetDatabaseConnection()
        {
            string MobilePartnerPlatform = ConfigurationManager.ConnectionStrings["MobilePartnerPlatform"].ToString();
            return MobilePartnerPlatform;
        }
        #endregion

        #region async和await的使用
        public async static Task<int> GetEpmolyeeCountAsync()
        {

            using (SqlConnection conn = new SqlConnection(GetDatabaseConnection()))
            {
                string str = "select * from 表名";
                SqlCommand cmd = new SqlCommand(str, conn);
                conn.Open();
                return await cmd.ExecuteScalarAsync().ContinueWith(t => Convert.ToInt32(t.Result));
            }
        }
        #endregion
    }
}

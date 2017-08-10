using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事务
{
    class Program
    {
        static void Main(string[] args)
        {
            //事务的特点：任务要么全部完成，要么都不完成
            //C#中利用System.Transactions名称空间中的类，可以对不稳定、基于内存的对象执行事务处理
            //事务分为3个阶段：1、激活阶段 2、准备阶段 3、提交阶段
            //事务的特征：原子性，在事务中工作单元要么成功完成，要么都不完成。一致性：事务开始前的状态和事务完成后的状态必须有效；隔离性：表示在并发进行的事务独立于状态，而状态在事务处理过程中可能发生变化；持久性：在事务完成后，他必须以可持久的方式和存储起来。
            //在ADO.NET中，如果没有手动创建事务，每条SQL语句就都有一个事务，如果多条语句参与到同一个事务处理中，就必须手动创建一个事务
            //开始事务：BeginTransaction();
            //结束事务：CommitTransaction();
            //回滚事务：RollbackTransaction();
        }
    }
}

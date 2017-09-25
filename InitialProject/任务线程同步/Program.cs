using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 任务线程同步
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用线程需要注意：如果使用线程需要访问相同的数据，容易出问题，必须实现同步机制
            //用到的命名空间主要是System.Threading和System.Threading.Tasks
            //并行性代码：任务并行性和数据并行性，对于任务并行性，使用CPU的代码被并行化，CPU的多个核心会被利用起来，更快速地完成包含多个任务的活动，而不是在一个核心中按顺序一个一个的执行任务；对于数据并行性，则使用了数据集合，在集合上执行的工作被划分为多个任务，他们两个可以混合起来
            //Paraller类是对线程的一个很好的抽象，它位于System.Threading.Tasks名称空间中，提供了数据和任务并行性
            //Paraller.For方法循环类似于for循环，也是多次执行一个任务，使用Paraller方法可以并行运行迭代，迭代的顺序没有定义；在For()方法中，前2个参数定义了循环的开头和结束
            Parallel.For(0, 10, i =>
                {
                    Console.WriteLine(i);
                });

            ParallelLoopResult result = Parallel.For(0, 10, i =>
                {
                    Console.WriteLine("{0},task:{1},thread:{2}",i,Task.CurrentId,Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(10);
                });
            Console.WriteLine("线程是否运行完成：{0}",result.IsCompleted);

            //在任何时间，一个应用程序域内都可能有多个线程，而且一个特性的线程在他的生命周期内不一定被限定在一个应用程序中；但是一个线程在同一时间只能在一个应用程序中
            //得到正在执行这个方法线程 Thread currThread=Thread.CurrentThread

            //多线程程序本身是相当不稳定的，因为在同一个时间，多个线程都能运行共享的功能块，为了保护应用程序的资源不被破坏，.NET开发者必须使用线程的各种原语(比如:lock,monitor和[Synchronization]特性或语言关键字支持)来控制线程对他们的访问
            Console.Read();
        }
    }
}

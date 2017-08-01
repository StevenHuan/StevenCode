using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MagicEightBallServiceLib;

namespace MagicEightBallServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Console Based WCF Host ********");
            //ServiceHost类型中的一部分成员
            //Authorization:改属性获取被承载服务的授权级别
            //AddDefaultEndpoints():该方法使用框架提供的预置终结点，以编程方法配置WCF服务宿主
            //AddServiceEndpoint()该方法允许你通过编程的方式在宿主中注册一个终结点
            //BaseAddresses该属性获取已经在当前服务中注册的基本地址列表
            //BeginOpen()和BeginClose()这两个方法允许你使用标准的异步.NET委托句法去异步打开和关闭一个ServiceHost对象
            //CloseTimeout:该属性允许你设置和获取服务关闭的允许时间
            //Credentials:该属性获取去当前服务所使用的安全凭证
            //EndOpen和EndClose():该方法与上边BeginOpeng()和BeginClose()是相对应的
            //OpenTimeout:该属性允许你设置和获取服务启动的允许时间
            //State:该属性获取一个现实通信对象当前状态的CommunicationState枚举值(opend,close,created等)
            using(ServiceHost serviceHost=new ServiceHost(typeof(MagicEightBallService))){
                ///打开宿主并且开启对传入消息的监听
                serviceHost.Open();

                DisplayHostInfo(serviceHost);
                ///使服务保持运行状态，直到Enter键被按下
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="host"></param>
        public static void DisplayHostInfo(ServiceHost host) {
            Console.WriteLine("***************");
            Console.WriteLine("*****Host Info*****");
            foreach (System.ServiceModel.Description.ServiceEndpoint item in host.Description.Endpoints)
            {
                Console.WriteLine("Address：{0}",item.Address);
                Console.WriteLine("Binding：{0}",item.Binding);
                Console.WriteLine("Contract：{0}",item.Contract);
            }
            Console.WriteLine("********************");
        }
    }
}

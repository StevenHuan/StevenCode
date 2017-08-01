using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MagicEightBallServiceLib
{
    /// <summary>
    /// [ServiceContract]的属性([ServiceContract(属性)])，CallbackContract:对于双向信息交换，如果服务契约需要具有回调功能，则需要设置此属性，ConfigurationName:该名称用来在应用程序配置文件中定位服务元素，默认为实现服务的类的名称，ProtectionLevel:允许你为公开该契约的中街店指定契约绑定所需的安全级别，是要加密，需数字签名，或既要加密有需数字签名，SessionMode:允许你设定服务契约是支持会话，不支持会话，还是必须使用会话，Namespace:控制XML的命名空间，Name:控制服务类型的名称
    /// </summary>
    [ServiceContract]
     public  interface IEighhtBall
    {
        /// <summary>
        /// [OperactionContract]的属性,AsyncPattern:指明操作是否使用Begin/End方法对来异步执行，这能让服务吧处理转到另一个服务器端线程上，这和客户端异步调用方法没有关系,IsInitiating:指定该操作能否作为一个绘画中的初始操作,IsOneWay:指明该操作是否只是由单个输入消息组成(而没有相关的输出),IsTerminating:指定WCF运行库在操作完成后是否应该尝试去结束当前会话
        /// </summary>
        /// <param name="userQuestion"></param>
        /// <returns></returns>
        [OperationContract]
        string ObtainAnswerToQuestion(string userQuestion);
    }
}

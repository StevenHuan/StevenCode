using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 程序设计原则
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#设计原则
            //开放封闭原则、单一职责原则、里氏替换原则、依赖倒置原则、接口隔离原则
            Console.WriteLine("***********开放封闭原则**********");
            //开闭原则的核心：对扩展开放、对修改关闭，保证程序的可复用性、可维护性；如果需求变更，我们通常是修改原来的代码，然而修改已经存在的源代码是存在风险的，为了避免这种风险我们需要对修改关闭
            //通过扩展去应对需求变化，要求我们必须面向接口编程，或者说面向抽象编程，所有的参数类型、引用类型传递的对象必须使用抽象类或接口的方式定义
            //例子说明：比如几年前我们用邮件发送祝福，后面发展到手机，微信，后面还不知道有什么，这个情况就是用开闭，通过继承接口
            ISendable oEmailHelper = new EmailMessage();
            MessageService messageService = new MessageService(oEmailHelper);
            messageService.Greeting("邓文翰");

            Console.WriteLine("************依赖倒置原则***************");
            //依赖倒置的好处，使架构更加稳定，更加灵活，更好应对需求变化，实际体现了“松耦合”概念
            //依赖倒置原则主要包含两个意思：
            //1、高层模块不应该直接依赖于底层模块的具体实现，而应该依赖于底层的抽象，也就是模块之间的依赖是通过抽象发生的，实现类之间不发生直接的依赖关系，其依赖关系是通过接口或抽象类产生的；
            //2、接口和抽象类不应该依赖于实现类，而实现类依赖接口或抽象类(这一点体现为面向接口编程)
            //体现：在3层架构中负责逻辑实现的BLL层，UI继承IBLL层，BLL层实现IBLL层，具体的业务逻辑定义在BLL中，就算我们BLL中改变，只要我们接口行为不变，UI层也不会改变
            Console.Read();
        }
    }

    public class MessageService
    {
        private ISendable m_oSendable = null;

        public MessageService(ISendable moSendable)
        {
            this.m_oSendable = moSendable;
        }

        public void Greeting(string strMsg)
        {
            m_oSendable.SendMessage(strMsg);
        }
    }
}

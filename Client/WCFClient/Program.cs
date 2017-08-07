using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****开始*****");
            using(EighhtBallClient client=new EighhtBallClient()){
                string quertion = "121";
                string ansyname = client.ObtainAnswerToQuestion(quertion);
                Console.WriteLine("返回值:{0}", ansyname);
                Console.WriteLine("******第二个接口******");
                string login = Console.ReadLine();
                MagicEightBallServiceLib.User user = new MagicEightBallServiceLib.User();
                user = client.UserAll(login);
                Console.WriteLine("姓名:{0},密码:{1},年龄:{2}",user.Login,user.Pwd,user.Age);

                Console.WriteLine("*****传入返回都是类****");
                user.Login = Console.ReadLine();
                user = client.GetUser(user);
                Console.WriteLine("姓名:{0},密码:{1},年龄:{2}", user.Login, user.Pwd, user.Age);

                Console.ReadLine();
            }
        }

    }
}

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
               
                string ansyname = client.ObtainAnswerToQuestion(quertion);
                Console.WriteLine("返回值:{0}", ansyname);
                Console.ReadLine();
            }
        }
    }
}

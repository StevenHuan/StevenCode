using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MagicEightBallServiceLib
{
    public class MagicEightBallService:IEighhtBall
    {
        public MagicEightBallService()
        {
            Console.WriteLine("The 8-Ball awaits your question....");
        }

        public string ObtainAnswerToQuestion(string userQuestion)
        {
            string[] answers = { "速通","ETC","南天","水杯"};
            //Random随机数生成器
            Random rand = new Random();
            return answers[rand.Next(answers.Length)];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

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

        public User UserAll(string login)
        {
            List<User> list = new List<User>();
            list.Add(new User("邓文翰","123",24));
            list.Add(new User("老马","123a",25));
            list.Add(new User("老刘", "1243", 25));
            User user = list.Where( p =>p.Login==login).FirstOrDefault();
            return user;
        }

        /// <summary>
        /// 返回类，注意返回为泛型是先将返回的类转为object，然后在转换为泛型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="u"></param>
        /// <returns></returns>
        public User GetUser(User userclient)
        {
            List<User> list = new List<User>();
            list.Add(new User("邓文翰", "123", 24));
            list.Add(new User("老马", "123a", 25));
            list.Add(new User("老刘", "1243", 25));
            User user = list.Where(p => p.Login == userclient.Login).FirstOrDefault();
            return user;
        }
    }

    [DataContract]
    public class User
    {
        public User(string login, string pwd, int age) {
            this.Login = login;
            this.Pwd = pwd;
            this.Age = age;
        }

        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Pwd { get; set; }

        [DataMember]
        public int Age { get; set; }
    }
}

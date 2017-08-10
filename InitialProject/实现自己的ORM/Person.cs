using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实现自己的ORM
{
    public class Person
    {
        [DataFieldAttribute("Name","nvarchar")]
        public string Name { get; set; }

         [DataFieldAttribute("Age", "int")]
        public int Age { get; set; }

         [DataFieldAttribute("Sex", "nvarchar")]
        public string Sex { get; set; }
    }
}

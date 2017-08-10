using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托Lambda表达式和事件
{
    struct Currenncy
    {
        /// <summary>
        /// implicit关键字用于声明隐式的用户定义类型转换运算符，通常前面用static后面用operator,explcit用于显式的
        /// 隐式转换可以通过消除不必要的类型转换来提高源代码的可读性
        /// </summary>
        public int Dollars;

        public short Cents;

        public Currenncy(int dollars, short cents)
        {
            this.Cents = cents;
            this.Dollars = dollars;
        }

        public override string ToString()
        {
            return string.Format("{0},{2}",Dollars,Cents);
        }

        public static string GetCurrencyUint() {
            return "Dollar";
        }

        public static explicit operator Currenncy(float value)
        {
            checked
            {
                int dollars = (int)value;
                short cents = (short)((value - dollars) * 100);
                return new Currenncy(dollars,cents);
            }
        }

        public static implicit operator float(Currenncy value)
        {
            return value.Dollars + (value.Cents / 100.0f);
        }

        public static implicit operator Currenncy(int value)
        {
            return new Currenncy(value,0);
        }

        public static implicit operator int(Currenncy value){
            return value.Dollars;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class SimpleMath
    {
        public double x, y;
        //相当于
        //public double x;
        // public double y;

        public string op;

        public static void Add(double x,double y)
        {
            Console.WriteLine(x + "+" + y + "=" + (x + y));
        }

        public static void Sub(double x,double y)
        {
            Console.WriteLine(x + "-" + y + "=" + (x - y));
        }
        /// <summary>
        /// 乘法
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void Mul(double x, double y)
        {
            Console.WriteLine(x + "*" + y + "=" + (x * y));
        }

        public static void Div(double x, double y)
        {
            Console.WriteLine(x + "/" + y + "=" + (x / y));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //实现一个简单的数学运算类。要求如下。
            //定义一个类SimpleMath，为类编写静态方法，分别完成加、减、乘、除、运算。
            //定义三个字段，分别代表两个操作数和一个操作符。
            //定义几个普通方法，来完成加、减、乘、除等运算。
            //可以可以判断是否继续(y / n)？y 就重新让用户输入一次，n就退出程序
            //while /do..while
            //注意使用新功能-下载
            do
            {
                //实例化-方便赋值
                SimpleMath simpleMath = new SimpleMath();
                //接受输入的两个参数
                //try
                Console.WriteLine("\n 请输入两个数:");
                simpleMath.x = Convert.ToDouble(Console.ReadLine());
                simpleMath.y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                //接受使用的操作符
                Console.WriteLine("请输入运算方式: 加法:+  减法:- 乘法:* 除法:/");

                //操作符接收
                simpleMath.op = Console.ReadLine();

                Console.WriteLine("选择:" + simpleMath.op);

                switch (simpleMath.op)
                {
                    case "+":
                        SimpleMath.Add(simpleMath.x, simpleMath.y);
                        break;
                    case "-":
                        SimpleMath.Sub(simpleMath.x, simpleMath.y);
                        break;
                    case "*":
                        SimpleMath.Mul(simpleMath.x, simpleMath.y);
                        break;
                    case "/":
                        SimpleMath.Div(simpleMath.x, simpleMath.y);
                        break;
                }
                Console.Write("继续(y/n):");
            } while (Console.ReadLine()=="y");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Test
{
    public class Rectangle
    {
        public double width;
        public double height;

        private double width1;
        private double height1;

        protected double width2;
        protected double height2;

        internal double width3;
        internal double height3;

        public double GetArea()
        {
            return width * height;
        }

        public void Acceptdetails()
        {
            Console.WriteLine("input width1:");
            width1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input height1:");
            height1 = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea1()
        {
            return width1 * height1;
        }

        double GetArea2()
        {
            return width3 * height3;
        }

        public void Display()
        {
            Console.WriteLine("internal GetArea2() -> {0}", GetArea2());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.width = 19.99;
            r.height = 29.99;

            Console.WriteLine("GetArea() -> {0}", r.GetArea());

            Rectangle r1 = new Rectangle();
            r1.Acceptdetails();
            Console.WriteLine("GetArea1() -> {0}", r1.GetArea1());

            Rectangle r2 = new Rectangle();
            r2.width3 = 99;
            r2.height3 = 88;
            r2.Display();

            // method参数的传递方式
            // 值传递
            // 引用参数传递
            // 

            int x = 29;
            int y = 35;

            Console.WriteLine("x => {0} y => {1}", x, y);

            void exchange(ref int x1, ref int y1)
            {
                int temp = x1;
                x1 = y1;
                y1 = temp;
            }

            exchange(ref x, ref y);

            Console.WriteLine("exchange x -> {0} y -> {1}", x, y);

            // 可空类型
            // Nullable Type ？用于针对int double , bool无法赋值的null的数据类型进行null赋值
            //
            int? i=null;
            int? i2 = i ?? 99;
            Console.WriteLine("i -> {0}", i2);

            Console.ReadKey();
        }
    }
}

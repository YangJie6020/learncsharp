using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// using 使用System空间

namespace SyntaxApp
{
    class Rectangle
    {
        double length;
        double width;

        public void Acceptdetails()
        {
            length = 5.5;
            width = 4.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syntax Test!!!");

            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();


            // C#数据类型, Data Type
            // 值类型 Values Types
            // 引用类型 Reference Types
            // 指针类型 Pointer Types

            // Values Types
            // bool : true or false
            // byte : 0 - 255
            // char :
            // decimal
            // double
            // float
            // int
            // long
            // sbyte
            // short
            // unit
            // ulong 
            // ushort
            Console.WriteLine("\n------------ Values Types -------------------\n");
            Console.WriteLine("sizeof(bool) {0}", sizeof(bool));
            Console.WriteLine("sizeof(byte) {0}", sizeof(byte));
            Console.WriteLine("sizeof(char) {0}", sizeof(char));
            Console.WriteLine("sizeof(devimal) {0}", sizeof(decimal));
            Console.WriteLine("sizeof(double) {0}", sizeof(double));
            Console.WriteLine("sizeof(float) {0}", sizeof(float));
            Console.WriteLine("sizeof(int) {0}", sizeof(int));
            Console.WriteLine("sizeof(long) {0}", sizeof(long));
            Console.WriteLine("sizeof(sbyte) {0}", sizeof(sbyte));
            Console.WriteLine("sizeof(short) {0}", sizeof(short));
            Console.WriteLine("sizeof(uint) {0}", sizeof(uint));
            Console.WriteLine("sizeof(ulong) {0}", sizeof(ulong));
            Console.WriteLine("sizeof(ushort) {0}", sizeof(ushort));

            Console.WriteLine("\n ----------------------- Type Change -----------------------------------\n");
            double d = 5789.11;
            int d1 = (int)d;
            Console.WriteLine("d -> d1 => {0}", d1);
            //
            // Type Change Method
            // ToBoolean
            // ToByte
            // ToChar
            // ToDateTime
            // ToDecimal
            // ToDouble
            // ToInt16
            // ToInt32
            // ToInt64
            // ToSbyte
            // ToSingle
            // ToString
            // ToType
            // ToUInt16
            // ToUInt32
            // ToUInt64

            Console.WriteLine("d to String {0}", d.ToString());

            Console.ReadKey();
        }
    }
}

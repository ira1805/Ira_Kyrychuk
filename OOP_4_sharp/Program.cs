using System;

namespace ConsoleApp6
{

    class MyVector
    {
        private int x, y;
        private double length;
        public MyVector()
        {
        }
        public MyVector(int x, int y)
        {
            this.x = x;
            this.y = y;
            length = Math.Sqrt(x ^ 2 + y ^ 2);
        }
        public MyVector(MyVector other)
        {
            this.x = other.x;
            this.y = other.x;
            length = Math.Sqrt(x ^ 2 + y ^ 2);
        }

        public double GetLength()
        {
            return length;
        }
        public int X()
        {
            return x;
        }
        public int Y()
        {
            return y;
        }

        public static MyVector operator +(MyVector L1, MyVector L2)
        {
            MyVector rez = new MyVector();
            rez.length = L1.length + L2.length;
            return rez;
        }
        public static MyVector operator *(MyVector L1, double n)
        {
            L1.length = L1.length * n;
            return L1;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyVector L1 = new MyVector(2, 5);
            Console.WriteLine("L1 length=" + L1.GetLength() + " x=" + L1.X() + " " + "y=" + L1.Y());
            L1 = L1 * 2;
            Console.WriteLine("L1 length=" + L1.GetLength());
            MyVector L2 = new MyVector(3, 8);
            Console.WriteLine("L2 length=" + L2.GetLength() + " x=" + L2.X() + " " + "y=" + L2.Y());
            MyVector L3 = L1 + L2;
            Console.WriteLine("L3 length=" + L3.GetLength());





            Console.ReadLine();
        }
    }

}
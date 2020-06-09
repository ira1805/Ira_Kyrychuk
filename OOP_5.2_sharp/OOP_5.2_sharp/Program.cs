using System;

namespace OOP_5._2_sharp
{  
    class Program
    {
        abstract class Figure
        {
            public abstract string Square();
            public abstract string Perimeter();

        }
        class Rectangle : Figure
        {
            private int x1, x2, x3, x4, y1, y2, y3, y4;
            public Rectangle(int x1, int x2, int x3, int x4,int y1,int y2,int y3,int y4 )
            {
                this.x1 = x1;
                this.x2 = x2;
                this.x3 = x3;
                this.x4 = x4;
                this.y1 = y1;
                this.y2 = y2;
                this.y3 = y3;
                this.y4 = y4;
                
            }
            public double Length(int x1,int x2,int y1,int y2)
            { double l = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
                return l;
            }
            public  bool Check()
            {   double l1 = Length(x1, x2, y1, y2);
                double l2 = Length(x2, x3, y2, y3);
                double l3 = Length(x3, x4, y3, y4);
                double l4 = Length(x4, x1, y4, y1);
                double l5 = Length(x1, x3, y1, y3);
                double l6 = Length(x2, x4, y2, y4);
                double a1 = l1 + l2 - l5;
                double a2 = l3 + l2 - l6;
                double a3 = l3 + l4 - l5;
                double a4 = l1 + l4 - l6;


                if (a1==0 && a2 == 0 && a3 == 0 && a4 == 0)
                    return true;
                else
                    return false;
            }
            public override string Square()
            {
                if (Check()==true)
                {
                    double s = Math.Sqrt(Length(x1, x2, y1, y2) * Length(x2, x3, y2, y3));
                    return s.ToString();
                }
                else
                    return"There is no rectangle";
            }
            public override string Perimeter()
            {
                if (Check()==true)
                {
                    double p = 2*Math.Sqrt(Length(x1, x2, y1, y2)) +2*Math.Sqrt(Length(x2, x3, y2, y3));
                    return p.ToString();
                }
                else
                    return "There is no rectangle";
            }



        }
        class Circle : Figure
        {
            private double r;
            public Circle(double r)
            {
                this.r = r;
            }
            public override string Square()
            {
                double s = Math.PI * r * r;
                return s.ToString();
            }
            public override string Perimeter()
            {
                double l = 2 * Math.PI * r;
                return l.ToString() ;
            }
        }
        static void Main(string[] args)
        {
            Circle c= new Circle(3);
            Rectangle r = new Rectangle(1, 1, 3, 3, 1, 2, 2, 1);
            Console.WriteLine(c.Perimeter());
            Console.WriteLine(c.Square());
            Console.WriteLine(r.Perimeter());
            Console.WriteLine(r.Square());



        }
    }
}

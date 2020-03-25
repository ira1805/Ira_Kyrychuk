using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{

    class Indexers
    {
        private int[,] a = new int[5, 5];
        private double average_value;
        public Indexers()
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = rand.Next(1, 20);

                }

        }

        public void Print()
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                    System.Console.Write(String.Format("{0,4}", a[row, col]));
                System.Console.WriteLine();
            }
        }
        private bool Check(int column)
        {
            if (column >= 5)
                return false;
            else
                return true;

        }
        public int this[int column]
        {

            get
            {
                int tmp = 1;
                if (Check(column))
                {
                    for (int row = 0; row < 5; row++)
                        tmp *= a[row, column];
                }
                else
                    tmp = 0;
                return tmp;
            }
        }
        public void Average()
        {
            double sum = 0;

            for (int row = 0; row < 5; row++)
                for (int col = 0; col < 5; col++)
                    sum += a[row, col];

            average_value = sum / 25;
        }
        public double AverageValue
        {
            get { return average_value; }
        }

    }

    class Program
    {
            static void Main(string[] args)
            {
                Indexers Array = new Indexers();
                Array.Print();
                Console.WriteLine("Enter column");
                int index = Convert.ToInt32(Console.ReadLine());
                int product = Array[index];
                Console.WriteLine("the product of the numbers in the column {0} is equal to - {1}", index, product);
                Console.WriteLine("---------------------------");
                Array.Average();
                Console.WriteLine("Average value= - {0}", Array.AverageValue);






            System.Console.ReadKey();
            }
       
    }
}
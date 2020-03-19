using System;

namespace Лаба_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введiть число x");
            int x = Int32.Parse(Console.ReadLine());
            Reduction(ref x);
            Console.Write(x);


            Console.WriteLine("\nВведiть числа для порiвняння");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            bool res = Compare(a, b);
            if (res == true)
                Console.WriteLine("x<y ");
            else
                Console.WriteLine("x>y ");

        }
        static void Reduction(ref int x)
        {
            {
                    int b;
                    for (int j = 0; j < sizeof(int) * 8 - 1; j++)
                    {
                        b = x & (1 << j);
                        if (b > 0)
                        {
                            for (int i = 0; i < j + 1; i++)
                                x = x ^ (1 << i);
                            break;
                        }
                    }
                
                
            }
        }
        static bool Compare(int a, int b)
        {
            int bitA = (a >> sizeof(int) * 8 - 1) & 1, bitB = (b >> sizeof(int) * 8 - 1) & 1;
            if (bitA < bitB)
                return false;
            else if (bitA > bitB)
                return true;
            else
                for (int i = 30; i >= 0; i--)
                {
                    bitA = (a >> i) & 1;
                    bitB = (b >> i) & 1;
                    if (bitA != bitB && bitA == 0)
                        return true;
                    else if (bitA != bitB && bitA == 1)
                        return false;
                }
            return false;
        }
    }
}
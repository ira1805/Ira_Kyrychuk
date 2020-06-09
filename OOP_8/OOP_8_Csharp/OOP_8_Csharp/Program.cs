using OOP_8_Csharp;
using System;

namespace Laba7
{
    internal class Program
    {
      
        private static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void Main(string[] args)
        {
            Bank account = new Bank(200);
            account.RegisterHandler(PrintMessage);
            account.Add(100);
            account.Withddraw(100);
            account.Withddraw(100);
            account.Add(100);  // Overflow
        }

    }
}
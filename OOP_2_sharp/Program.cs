using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_2
{
    class SString_
    {
        List<Char> s = new List<char>();

        public SString_()
        {

        }
        public SString_(char[] str)
        {
            foreach (char i in str)
            {
                s.Add(i);
            }
            s.Add('\n');
        }
        ~SString_()
        {

        }
        public void SetStr(char[] str)
        {
            foreach (char i in str)
            {
                s.Add(i);
            }
            s.Add('\n');
        }
        public void ClearLine()
        {
            while (s.Count() != 0)
                s.Clear();
        }


        public void Print()
        {
            foreach (char i in s)
                Console.Write(i);
        }

        public int GetSize()
        {

            return s.Count;
        }
        public char GetChar(int n)
        {
            return s[n];
        }
        public void Up()
        {
            for (int i = 0; i < s.Count(); i++)
            {
                s[i] = Char.ToUpper(s[i]);
               
            }
        }
        public bool Cmp(SString_ str)
        {

            if (str.GetSize() != s.Count()) return false;
            for (int i = 0; i < s.Count(); i++)
            {
                if (s[i] != str.GetChar(i)) return false;
            }

            return true;
        }

    }
    class Text
    {
        List<SString_> T = new List<SString_>();
        public Text()
        {
        }

        public void Init(List<SString_> Vec)
        {
            for (int i = 0; i < Vec.Count(); i++)
                T.Add(Vec[i]);
        }
        public void AddLine(SString_ S)
        {
            T.Add(S);
        }
        public void Delete(int n)
        {
            if(n<T.Count())
                 T[n].ClearLine();
            


        }
        public void Print()
        {
            for (int i = 0; i < T.Count(); i++)
                T[i].Print();
        }
        public void Upper()
        {
            for (int i = 0; i < T.Count(); i++)
                T[i].Up();
        }
        public int Cmp2(SString_ S)
        {
            int count = 0;
            for (int i = 0; i < T.Count(); i++)
            {

                if (T[i].Cmp(S))
                {
                    count++;
                }

            }
            return count;
        }
        public void Delete2(int n)
        {
            for (int i = 0; i < T.Count(); i++)
            {
                int size = T[i].GetSize() - 1;
                if (n == size)
                {
                    T[n].ClearLine();
                }

            }
        }
       public void ClearAll()
        {
            for (int i = 0; i < T.Count(); i++)
                T[i].ClearLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char[][] text = { "1.erewqr".ToCharArray(), "2.fgdfsg".ToCharArray(),
                "3.fdssgdf".ToCharArray(), "4.fsdtg".ToCharArray(),"5.tgfcfdgxv".ToCharArray() };
            List<SString_> Z = new List<SString_>();
            for (int i = 0; i < 5; i++)
            {
                SString_ X = new SString_(text[i]);
                Z.Add(X);
            }
            Text Q = new Text();
            Q.Init(Z);
            Console.WriteLine("Text");
            Q.Print();
            Console.WriteLine("---------------");
            Console.WriteLine("1.Add line");
            char[] addline = "6.bcdnhbedj".ToCharArray();
            SString_ newLine = new SString_(addline);
            Q.AddLine(newLine);
            Q.Print();
            Console.WriteLine("-----------------" );
            Console.WriteLine("2.Delete line");
            Console.WriteLine("Enter number of line");
            int number = Console.Read();
            Q.Delete(number);
            Console.WriteLine ("Text after change");
            Q.Print();
            Console.WriteLine("-----------------");
            Console.WriteLine("3.Bring the characters to uppercase");
            Q.Upper();
            Q.Print();
            Console.WriteLine( "------------------");
            char[] line = "2.FGDFSG".ToCharArray();
            SString_ newLine1 = new SString_(line);
            Console.WriteLine("4.The number of identical rows");
            Console.WriteLine("Cmp =" + Q.Cmp2(newLine1));
            Console.WriteLine("---------------" );
            Console.WriteLine("5.Delete line of a certain length ");
            Console.WriteLine("Enter size");
            int n = Console.Read();
            Q.Delete2(n);
            Q.Print();
            Console.WriteLine("------------");
            Console.WriteLine("6.Clear text" );
            Q.ClearAll();
            Q.Print();
            Console.WriteLine("\nClear text");
           




        }

    }
}
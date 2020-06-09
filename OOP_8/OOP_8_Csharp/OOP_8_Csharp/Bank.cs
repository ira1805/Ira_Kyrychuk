using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_8_Csharp
{
    public class Bank
    {
        
        private int max_sum;
        private double sum;

        public Bank(int max_sum)
        {
            if (max_sum>0)
            {
                this.max_sum = max_sum;
            }
            else
            { throw new ArgumentException("Wrong amount of sum"); }
        }
        // Create delegate for checking for overflow
        public delegate void OverdraftHandler(string msg);
        private OverdraftHandler _del;
        public void RegisterHandler(OverdraftHandler del) => _del = del;

        public void Add(double addsum)
        {
            if (addsum > 0) { sum += addsum; }
            else { throw new ArgumentException("Wrong sign of amount of money to add"); }
            if (_del != null)
            {
                if (max_sum < sum)
                { _del("Overdraft"); }
            }
        }
        public void Withddraw(int withdraw_money)
        {
            if (withdraw_money > 0)
            { sum -= withdraw_money; }
            else
            { throw new ArgumentException("Wrong sign of amount of money to add"); }
        }


    }
}

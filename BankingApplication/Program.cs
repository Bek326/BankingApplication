using System;

namespace BankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            calculator.CalculateInterest(new Account());
        }
    }
}
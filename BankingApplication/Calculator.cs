namespace BankingApplication
{
    public class Calculator
    {
        // Метод для расчета процентной ставки
        public void CalculateInterest(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}
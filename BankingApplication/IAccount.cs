namespace BankingApplication
{
    public interface IAccount
    {
        // тип учетной записи
        string Type { get; }
  
        // баланс учетной записи
        double Balance { get; }
  
        // процентная ставка
        double Interest { get; }
        
        void CalculateInterest();
    }
}
namespace BankingApplication
{
    public class Account : IAccount
    {
        // тип учетной записи
        public string Type { get; set; }
  
        // баланс учетной записи
        public double Balance { get; set; }
  
        // процентная ставка
        public double Interest { get; set; }
        
        public void CalculateInterest()
        {
            if (Type == "Обычный") 
            { 
                // расчет процентной ставки обычного аккаунта по правилам банка
                Interest = Balance * 0.4;
 
                if (Balance < 1000)
                    Interest -= Balance * 0.2;
              
                if (Balance < 50000)
                    Interest -= Balance * 0.4;
            } 
            else if(Type == "Зарплатный") 
            { 
                // расчет процентной ставк зарплатного аккаунта по правилам банка
                Interest = Balance * 0.5;
            } 
        }
    }
}
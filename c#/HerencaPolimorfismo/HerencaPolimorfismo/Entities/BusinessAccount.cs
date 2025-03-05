namespace HerencaPolimorfismo.Entities
{
     sealed class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loandLimit) : base(number, holder, balance)
        {
            LoanLimit = loandLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}

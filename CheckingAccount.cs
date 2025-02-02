namespace Lecture5Task1
{
    internal class CheckingAccount : Account
    {
        public double Fee { get; set; }
        public CheckingAccount(string Name = "Unnamed Account", double Balance = 0.0, double fee = 1.5) : base(Name, Balance)
        {
           Fee = fee;
        }

        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount+Fee);
        }

       
    }
}
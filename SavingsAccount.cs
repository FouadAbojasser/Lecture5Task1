namespace Lecture5Task1
{
    internal class SavingsAccount : Account
    {
        public double IntrestRate { get; set; }
        public SavingsAccount(string Name = "Unnamed Account", double Balance = 0.0, double intrestRate = 0.0) : base(Name,Balance)
        {
            IntrestRate = intrestRate;
        }

    
    }
}
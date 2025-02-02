using System.ComponentModel.Design;

namespace Lecture5Task1
{
    internal class TrustAccount : SavingsAccount
    {

        public List<DateTime> UserLog { get; set; }

        public TrustAccount(string Name = "Unnamed Account", double Balance = 0.0, double intrestRate = 0.0, List<DateTime> userLog = null) : base(Name, Balance)
        {
            userLog = new List<DateTime>();
            UserLog = userLog;
        }

        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
                return base.Deposit(amount + 50);
            else
                return base.Deposit(amount);
        }

        public override bool Withdraw(double amount)
        {
            if (amount < 0.2 * Balance && amount > 0) // && amount > 0 prevent logging 0 withdraw
            {
                if (UserLog.Count >= 3)
                {
                    for (int i = UserLog.Count-1; i >= UserLog.Count-3; i--)
                    {
                        if (UserLog[i].Year != DateTime.Now.Year)
                        {
                            // Make the withdraw and log it
                            UserLog.Add(DateTime.Now);
                            return base.Withdraw(amount);
                        }
                    }
                    return false;
                }
                else
                {
                    // Make the withdraw and log it
                    UserLog.Add(DateTime.Now);
                    return base.Withdraw(amount);
                }
            }
            else
            return false;
        }

    }
}
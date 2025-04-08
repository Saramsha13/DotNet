using DotNetLab;

internal class Program
{
    private static void Main(string[] args)
    {
        Account test1 = new Account();
        test1.SetAccountDetails("1", "Savings", 1000, "Harry", "UK", "9811100033", "ok@123.com");
        test1.ShowInfo();
        test1.Deposit(500);
        test1.ShowBalance();
        test1.Withdraw(200);
        test1.ShowBalance();
        test1.Withdraw(1700);

    }
}
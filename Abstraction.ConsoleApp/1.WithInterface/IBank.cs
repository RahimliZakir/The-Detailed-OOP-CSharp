namespace Abstraction.ConsoleApp._1.WithInterface
{
    interface IBank
    {
        // Implementation Details Hiding
        string ValidateCard();
        string WithdrawMoney();
        string CheckBalanace();
        string BankTransfer();
        string MiniStatement();
    }
}

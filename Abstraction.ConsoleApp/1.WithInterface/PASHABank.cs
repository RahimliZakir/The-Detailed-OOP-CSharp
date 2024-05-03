namespace Abstraction.ConsoleApp._1.WithInterface
{
    class PASHABank : IBank
    {
        public string BankTransfer()
        {
            return "PASHA Bank Bank Transfer";
        }

        public string CheckBalanace()
        {
            return "PASHA Bank Check Balance";
        }

        public string MiniStatement()
        {
            return "PASHA Bank Mini Statement";
        }

        public string ValidateCard()
        {
            return "PASHA Bank Validate Card";
        }

        public string WithdrawMoney()
        {
            return "PASHA Bank Withdraw Money";
        }
    }
}

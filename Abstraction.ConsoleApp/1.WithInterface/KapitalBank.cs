namespace Abstraction.ConsoleApp._1.WithInterface
{
    class KapitalBank : IBank
    {
        public string BankTransfer()
        {
            return "Kapital Bank Bank Transfer";
        }

        public string CheckBalanace()
        {
            return "Kapital Bank Check Balance";
        }

        public string MiniStatement()
        {
            return "Kapital Bank Mini Statement";
        }

        public string ValidateCard()
        {
            return "Kapital Bank Validate Card";
        }

        public string WithdrawMoney()
        {
            return "Kapital Bank Withdraw Money";
        }
    }
}

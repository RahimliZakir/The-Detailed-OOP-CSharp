namespace Abstraction.ConsoleApp._2.WithAbstractClass
{
    class YeloBank : BaseBank
    {
        override public string BankTransfer()
        {
            return "Yelo Bank Bank Transfer";
        }

        override public string CheckBalanace()
        {
            return "Yelo Bank Check Balance";
        }

        override public string MiniStatement()
        {
            return "Yelo Bank Mini Statement";
        }

        override public string ValidateCard()
        {
            return "Yelo Bank Validate Card";
        }

        override public string WithdrawMoney()
        {
            return "Yelo Bank Withdraw Money";
        }
    }
}

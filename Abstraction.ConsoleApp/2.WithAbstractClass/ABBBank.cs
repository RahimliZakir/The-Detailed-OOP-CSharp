namespace Abstraction.ConsoleApp._2.WithAbstractClass
{
    class ABBBank : BaseBank
    {
        // We must use 'override' keyword, for usign 'abstract' methods!
        override public string BankTransfer()
        {
            return "ABB Bank Bank Transfer";
        }

        override public string CheckBalanace()
        {
            return "ABB Bank Check Balance";
        }

        override public string MiniStatement()
        {
            return "ABB Bank Mini Statement";
        }

        override public string ValidateCard()
        {
            return "ABB Bank Validate Card";
        }

        override public string WithdrawMoney()
        {
            return "ABB Bank Withdraw Money";
        }
    }
}

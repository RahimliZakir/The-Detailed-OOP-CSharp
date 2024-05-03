namespace Abstraction.ConsoleApp._2.WithAbstractClass
{
    // In 'Abstract' Class we can define 'non-abstract' members or methods!
    abstract class BaseBank
    {
        // Implementation Details Hiding
        public abstract string ValidateCard();
        public abstract string WithdrawMoney();
        public abstract string CheckBalanace();
        public abstract string BankTransfer();
        public abstract string MiniStatement();
    }
}

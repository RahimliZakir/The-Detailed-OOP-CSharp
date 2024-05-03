namespace Inheritance.ConsoleApp._4.MultipleInheritance
{
    class Unibank : Bank, ILisence
    {
        public string GetLisenceCode()
        {
            return "U13239377";
        }
    }
}

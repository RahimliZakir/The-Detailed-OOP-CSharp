namespace Polymorphism.ConsoleApp._1.CompileTimePolymorphism.b.OperatorOverloading
{
    class OperatorOverloader
    {
        // Some operators in C# behave differently with different operands.
        // + operator is overloaded to perform numeric addition as well as string concatenation.
        // 1. Adding two numbers,
        public int Sum(int a, int b)
        {
            return a + b;
        }

        // 2. Concatenating two strings,
        public string Concatenate(string first, string second)
        {
            return first + second;
        }
    }
}

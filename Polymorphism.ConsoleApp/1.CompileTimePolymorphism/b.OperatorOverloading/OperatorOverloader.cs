namespace Polymorphism.ConsoleApp._1.CompileTimePolymorphism.b.OperatorOverloading
{
    class OperatorOverloader(int first, int second)
    {
        public int First { get; set; } = first;
        public int Second { get; set; } = second;

        public OperatorOverloader() : this(default, default) { }

        // Some operators in C# behave differently with different operands.
        // + operator is overloaded to perform numeric addition as well as string concatenation.
        // 1. Adding two numbers,
        public int Sum(int first, int second)
        {
            return first + second;
        }

        // 2. Concatenating two strings,
        public string Concatenate(string first, string second)
        {
            return first + second;
        }

        // 3. Overload An Operator 
        // In C#, it is possible to make operators work with user-defined data types like classes.
        // That means C# has the ability to provide the operators with a special meaning for a data
        // type, this ability is known as operator overloading. For example, we can overload the + operator
        // in a class like String so that we can concatenate two strings by just using +.

        // Using operator overloading in C# we can specify more than one meaning for an operator in one
        // scope. The purpose of operator overloading is to provide a special meaning of an operator for a
        // user-defined data type.
        public static OperatorOverloader Add(OperatorOverloader o1, OperatorOverloader o2)
        {
            OperatorOverloader temp = new()
            {
                First = o1.First + o2.First,
                Second = o1.Second + o2.Second
            };

            return temp;
        }

        //  Now let us look at the complete program for operator overloading in C#.
        public static OperatorOverloader operator +(OperatorOverloader o1, OperatorOverloader o2)
        {
            OperatorOverloader temp = new()
            {
                First = o1.First + o2.First,
                Second = o1.Second + o2.Second
            };

            return temp;
        }

        public override string ToString()
        {
            return $"First: {First}, Second: {Second}.";
        }
    }
}

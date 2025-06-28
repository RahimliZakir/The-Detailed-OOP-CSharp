namespace Polymorphism.ConsoleApp._2.RuntimePolymorphism.MethodOverriding
{
    class Dog : Animal
    {
        public override string MakeSound()
        {
            return "Dog barks.";
        }
    }
}

namespace Polymorphism.ConsoleApp._1.CompileTimePolymorphism.c.MethodHidingOrMethodShadowing
{
    // - Method hiding is a concept where a derived class defines a new method with the same name as a method in the base class, effectively hiding the base class method.
    //   • The base class method doesn't marked as virtual to be hidden by the derived class method.
    //   • The derived class method must have the same name as the base class method, but it can have different return type or method signature.
    class Headphones
    {
        public string Use()
        {
            return "I'm using headphones";
        }

        public string TurnOff()
        {
            return "I'm turning off headphones";
        }
    }
}

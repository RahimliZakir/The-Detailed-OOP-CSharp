using Polymorphism.ConsoleApp._2.RuntimePolymorphism.a.MethodOverriding;

namespace Polymorphism.ConsoleApp._2.RuntimePolymorphism.b.MethodHiding
{
    // - Method hiding is a concept where a derived class defines a new method with the same name as a method in the base class, effectively hiding the base class method.
    //   • Method hiding is achieved by using the new keyword in the derived class method.
    //   • The base class method should be marked as virtual to be hidden by the derived class method.
    //   • The derived class method must have the same name as the base class method, but it can have a different return type or method signature.
    class Headphones
    {
        public virtual string Use()
        {
            return "I'm using headphones";
        }
    }
}

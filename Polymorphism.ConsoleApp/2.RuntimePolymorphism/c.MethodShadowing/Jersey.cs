using System.Runtime.Intrinsics.X86;

namespace Polymorphism.ConsoleApp._2.RuntimePolymorphism.c.MethodShadowing
{
    // - Method Shadowing
    //   • Method shadowing is similar to method hiding, where a derived class defines a new method with the same name as a method in the base class.
    //   • However, in method shadowing, the base class method is not marked as virtual , and the derived class method does not use the new keyword.
    //   • This can lead to unexpected behavior as the base class method may still be invoked when calling the method on an object of the derived class.
    class Jersey
    {
        public string Wear()
        {
            return "I'm wearing a jersey";
        }
    }
}

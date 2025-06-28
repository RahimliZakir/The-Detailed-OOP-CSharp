namespace Polymorphism.ConsoleApp._1.CompileTimePolymorphism.c.MethodHidingOrMethodShadowing
{
    class JBL : Headphones
    {
        // The new keyword in C# tells the compiler explicitly:
        // "Hey, I know there's a method with the same name in the base class, but I intend to hide it here, not override it."
        new public string Use()
        {
            //return base.Use();
            return "I'm using JBL headphones";
        }

        // - What does that mean practically?
        // • If you use new, the compiler understands you’re doing method hiding intentionally.
        // • If you omit new, the compiler thinks you might have forgotten about the base method and warns you — because it assumes you might want to override or avoid confusion.
        // • The new keyword prevents the compiler warning and clarifies your intent.
        public string TurnOff()
        {
            return "I'm turning off JBL headphones";
        }
    }
}

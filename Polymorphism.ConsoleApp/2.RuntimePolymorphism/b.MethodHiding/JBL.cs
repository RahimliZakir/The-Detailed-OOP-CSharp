namespace Polymorphism.ConsoleApp._2.RuntimePolymorphism.b.MethodHiding
{
    class JBL : Headphones
    {
        new public string Use()
        {
            //return base.Use();
            return "I'm using JBL headphones";
        }
    }
}

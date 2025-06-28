using Polymorphism.ConsoleApp._1.CompileTimePolymorphism.a.MethodOverloading;
using Polymorphism.ConsoleApp._1.CompileTimePolymorphism.b.OperatorOverloading;
using Polymorphism.ConsoleApp._1.CompileTimePolymorphism.c.MethodHidingOrMethodShadowing;
using Polymorphism.ConsoleApp._2.RuntimePolymorphism.MethodOverriding;

// 1. Compile Time Polymorphism
// a. Method Overloading
GeometryFiguresArea geometryFiguresArea = new();
// For Square
Console.WriteLine(geometryFiguresArea.CalculateArea(4));
// For Rectangle
Console.WriteLine(geometryFiguresArea.CalculateArea(6, 17));
// For Circle
Console.WriteLine(geometryFiguresArea.CalculateArea(23D));

// b. Operator Overloading
// - Adding numbers
OperatorOverloader operatorOverloader = new();
int x = 7;
int y = 5;
int sum = operatorOverloader.Sum(x, y);
Console.WriteLine(sum);
// - Concatenating strings
string firstString = "Michy";
string secondString = "Batshuayi";
string concatenatedString = operatorOverloader.Concatenate(firstString, secondString);
Console.WriteLine(concatenatedString);
// - Overload An Operator 
OperatorOverloader firstOperatorOverloader = new(10, 13);
OperatorOverloader secondOperatorOverloader = new(20, 23);
//  Without Operator Overloading
OperatorOverloader tempOperatorOverloader = OperatorOverloader.Add(firstOperatorOverloader, secondOperatorOverloader);
Console.WriteLine(tempOperatorOverloader);
//  With Operator Overloading
tempOperatorOverloader = firstOperatorOverloader + secondOperatorOverloader;
Console.WriteLine(tempOperatorOverloader);

// c. Method Hiding / Method Shadowing
Headphones headphones = new();
Console.WriteLine(headphones.Use());
Headphones jbl = new JBL();
// It'll return same value as 'Headphones' Class
Console.WriteLine(jbl.Use());
Console.WriteLine(jbl.TurnOff());
JBL jbl2 = new();
// It'll return its unique value
Console.WriteLine(jbl2.Use());
Console.WriteLine(jbl2.TurnOff());

// 2. Runtime Polymorphism
// a. Method Overriding
Animal animal = new();
Console.WriteLine(animal.MakeSound());
Animal dog = new Dog();
Console.WriteLine(dog.MakeSound());
Animal cat = new Cat();
Console.WriteLine(cat.MakeSound());

Console.ReadKey();
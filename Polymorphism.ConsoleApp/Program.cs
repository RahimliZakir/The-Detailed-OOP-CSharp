using Polymorphism.ConsoleApp._1.CompileTimePolymorphism.a.MethodOverloading;
using Polymorphism.ConsoleApp._1.CompileTimePolymorphism.b.OperatorOverloading;
using Polymorphism.ConsoleApp._2.RuntimePolymorphism.a.MethodOverriding;
using Polymorphism.ConsoleApp._2.RuntimePolymorphism.b.MethodHiding;
using Polymorphism.ConsoleApp._2.RuntimePolymorphism.c.MethodShadowing;

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

// 2. Runtime Polymorphism
// a. Method Overriding
Animal animal = new();
Console.WriteLine(animal.MakeSound());
Animal dog = new Dog();
Console.WriteLine(dog.MakeSound());
Animal cat = new Cat();
Console.WriteLine(cat.MakeSound());

// b. Method Hiding
Headphones headphones = new();
Console.WriteLine(headphones.Use());
Headphones jbl = new JBL();
// It'll return same value as 'Headphones' Class
Console.WriteLine(jbl.Use());
JBL jbl2 = new();
// It'll return its unique value
Console.WriteLine(jbl2.Use());

// c. Method Shadowing
Jersey jersey = new();
Console.WriteLine(jersey.Wear());
// It'll return same value as 'Jersey' Class
Jersey qarabagJersey = new QarabagJersey();
Console.WriteLine(qarabagJersey.Wear());
// It'll return its unique value
QarabagJersey qarabagJersey2 = new QarabagJersey();
Console.WriteLine(qarabagJersey2.Wear());

Console.ReadKey();
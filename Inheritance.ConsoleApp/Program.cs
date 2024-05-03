using Inheritance.ConsoleApp._1.SingleInheritance;
using Inheritance.ConsoleApp._2.MultilevelInheritance;
using Inheritance.ConsoleApp._3.HierarchicalInheritance;
using Inheritance.ConsoleApp._4.MultipleInheritance;
using Inheritance.ConsoleApp._5.HybridInheritance;

// 1) Single Inheritance
Dog dog = new();
// From 'Animal' Class.
Console.WriteLine(dog.Eat());

// 2) Multilevel Inheritance
Fenerbahce fenerbahce = new();
// From 'TurkishFootbalLeagueTeam' Class.
Console.WriteLine(fenerbahce.PlayInTurkey());
// From 'TrendyolSuperLeagueTeam' Class.
Console.WriteLine(fenerbahce.PlayInSuperLeague());

// 3) Hierarchical Inheritance
// From 'Fruit' Class. 
Orange orange = new();
Console.WriteLine(orange.CanEat());
// Also from 'Fruit' Class.
Grape grape = new();
Console.WriteLine(grape.CanEat());

// 4) Multiple Inheritance
Unibank unibank = new();
// From 'Bank' Class.
Console.WriteLine(unibank.Purpose());
// From 'ILisence' Interface.
Console.WriteLine(unibank.GetLisenceCode());

// 5) Hybrid Inheritance
iPhone iphone = new();
// From 'AppleInc' Class.
Console.WriteLine(iphone.GetPurposeOfAppleInc());
// From 'TechCompany' Class.
Console.WriteLine(iphone.GetPurposeOfTechCompany());

iPad ipad = new();
// Also from 'AppleInc' Class.
Console.WriteLine(ipad.GetPurposeOfAppleInc());
// Also from 'TechCompany' Class.
Console.WriteLine(ipad.GetPurposeOfTechCompany());

Console.ReadKey();
using Abstraction.ConsoleApp._1.WithInterface;
using Abstraction.ConsoleApp._2.WithAbstractClass;

// 1) With Interface
// From 'IBank' Interface
KapitalBank kapitalBank = new();
Console.WriteLine(kapitalBank.BankTransfer());
Console.WriteLine(kapitalBank.CheckBalanace());
Console.WriteLine(kapitalBank.MiniStatement());
Console.WriteLine(kapitalBank.ValidateCard());
Console.WriteLine(kapitalBank.WithdrawMoney());

// Also from 'IBank' Interface
PASHABank pashaBank = new();
Console.WriteLine(pashaBank.BankTransfer());
Console.WriteLine(pashaBank.CheckBalanace());
Console.WriteLine(pashaBank.MiniStatement());
Console.WriteLine(pashaBank.ValidateCard());
Console.WriteLine(pashaBank.WithdrawMoney());

// 2) With Abstract Class
// From 'BaseBank' Abstract Class
ABBBank abbBank = new();
Console.WriteLine(abbBank.BankTransfer());
Console.WriteLine(abbBank.CheckBalanace());
Console.WriteLine(abbBank.MiniStatement());
Console.WriteLine(abbBank.ValidateCard());
Console.WriteLine(abbBank.WithdrawMoney());

// Also from 'BaseBank' Abstract Class
YeloBank yeloBank = new();
Console.WriteLine(yeloBank.BankTransfer());
Console.WriteLine(yeloBank.CheckBalanace());
Console.WriteLine(yeloBank.MiniStatement());
Console.WriteLine(yeloBank.ValidateCard());
Console.WriteLine(yeloBank.WithdrawMoney());

Console.ReadKey();

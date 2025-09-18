// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Lida Shubitidze");
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Magenta;

Console.WriteLine("Please input your text here:");
string inputFromUser = Console.ReadLine();
Console.WriteLine($"You input was: {inputFromUser}");

Console.WriteLine("Bye, bye for now.");
*/
using Homework2;

#region Exercise 1
var TXT = new Txt("txt");
TXT.Read();
Console.WriteLine(TXT.MaxSize);
TXT.Write();
#endregion

#region Exercise 2
var Bank = new Bank();
Console.WriteLine(Bank.CalculateLoanPercent(5,100));
var MicroFinance  = new MicroFinance();
if (MicroFinance.CheckUserHistory())
{
   Console.WriteLine(MicroFinance.CalculateLoanPercent(5,100));
}else
{
    Console.WriteLine("We have received a false, so we cannot check the history");
}
#endregion
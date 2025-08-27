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

#region Exercise 1
Console.WriteLine("Please enter your number:");
var userInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(userInput % 5 == 0 ?"Yes":"No");
#endregion

#region Exercise 2
Console.WriteLine("Please enter first number:");
var number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter second number:");
var number2 = Convert.ToInt32(Console.ReadLine());

var addition = number1 + number2;
Console.WriteLine($"{number1} + {number2} = {addition}");

var multiplication = number1 * number2;
Console.WriteLine($"{number1} * {number2} = {multiplication}");

var biggerNumber = Math.Max(number1, number2);
var smallerNumber = Math.Min(number1, number2);

var substraction = biggerNumber - smallerNumber;
Console.WriteLine($"{biggerNumber} - {smallerNumber} = {substraction}");

if (smallerNumber != 0){
    var division = biggerNumber / smallerNumber;
    Console.WriteLine($"{biggerNumber} / {smallerNumber} = {division}");
}
else{
    Console.WriteLine("Not allowed to divide by zero.");
}
#endregion



#region Exercise 3
var x = 5;
var y = 12;

var z = x;
x = y;
y = z;
Console.WriteLine(x);
Console.WriteLine(y);
#endregion


#region Exercise 4
Console.WriteLine("Please enter your number:");
var userInput2 = Convert.ToInt32(Console.ReadLine());

for(var i =1; i <= 9; i++)
{
    Console.WriteLine($"{userInput2}*{i}={userInput2 * i}");
}
#endregion

#region Exercise 5
Console.WriteLine("Please enter your number:");
var userInput3 = Convert.ToInt32(Console.ReadLine());

for (var i = 1; i < userInput3; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i * i);
    }
}
#endregion
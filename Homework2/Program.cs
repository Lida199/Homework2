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
using System.Text.Json;
using System.Xml.Linq;

#region Exercise 1
string filePath = @"C:\Users\lidashubitidze\source\repos\Homeworks\Homework2\exercise1.txt";

Console.WriteLine("How many inputs do you want to enter?");
int lineCount;
string userInput = Console.ReadLine();
bool isInt = int.TryParse(userInput, out lineCount);

if (isInt && lineCount > 0)
{
    for (int i = 0; i < lineCount; i++)
    {
        Console.WriteLine($"Line {i + 1}");
        File.AppendAllText(filePath, $"{Console.ReadLine()}\n");
    }
}
else
{
    Console.WriteLine("Invalid number!");
}

Console.WriteLine("Which line would you like to retrieve?");
int lineToBeRetrieved;
string userInput2 = Console.ReadLine();
bool isInt2 = int.TryParse(userInput2, out lineToBeRetrieved);

if (isInt2 && lineToBeRetrieved > 0)
{
    if (lineCount >= lineToBeRetrieved)
    {
        var lines = File.ReadAllLines(filePath);
        Console.WriteLine($"Line {lineToBeRetrieved}: {lines[lineToBeRetrieved - 1]}");
    }
    else
    {
        Console.WriteLine("Number is more than the lines count.");
    }
}
else
{
    Console.WriteLine("Invalid number!");
}
#endregion


#region Exercise 2
string filePath2 = @"C:\Users\lidashubitidze\source\repos\Homeworks\Homework2\exercise2.txt";
int numberFromUser;
string inputFromUser = Console.ReadLine();
bool isInteger = int.TryParse(inputFromUser, out numberFromUser);

if (isInteger && numberFromUser > 0)
{
    for (int i = 1; i < 10; i++)
    {
        File.AppendAllText(filePath2, $"{numberFromUser} x {i} = {numberFromUser * i}\n");
    }
}
else
{
    Console.WriteLine("Invalid number!");
}
#endregion

#region Exercise 3

string filePath3 = @"C:\Users\lidashubitidze\source\repos\Homeworks\Homework2\exercise3.xml";
string stringToDivide = "Hello from the c application.".Replace(" ", "_");
int divideIntoParts = 3;
int partLength = stringToDivide.Length / divideIntoParts;

var root = new XElement("Strings");
var xmlDocument = new XDocument(root);

for (int i = 1; i <= divideIntoParts; i++)
{
    int startIndex = i == 1 ? 0 : (i - 1) * partLength - 1;
    var subString = i == divideIntoParts ? stringToDivide.Substring(startIndex) : stringToDivide.Substring(startIndex, partLength);
    root.Add(new XElement(subString, $"String {i}"));
}

xmlDocument.Save(filePath3);
#endregion

#region Exercise 4

string filePath4 = @"C:\Users\lidashubitidze\source\repos\Homeworks\Homework2\birtdays.json";
string json = File.ReadAllText(filePath4);
var data = JsonSerializer.Deserialize<BirthdayData>(json);

var currentDate = DateTime.Parse(data?.currentDate);
var birthday = DateTime.Parse(data.birthday);
int reminderDays = (birthday - currentDate).Days;

if (reminderDays > 0)
{
    Console.WriteLine($"Birtday will be in {reminderDays} days.");
}
else if (reminderDays == 0)
{
    Console.WriteLine("Birtday is today.");
}
else
{
    Console.WriteLine("Birtday date already passed.");
}
#endregion


#region Exercise 5
string caesarString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
int placesToMove = 7;

string CaesarCipher(string text, int move)
{
    if(move == text.Length || text.Length == 0 )
    {
        return text;
    }

    int finalMove = move;
    if (move > text.Length)
    {
        finalMove -= text.Length;
    }

    return text.Substring(move) + text.Substring(0, move);
}

Console.WriteLine(CaesarCipher(caesarString, placesToMove));
#endregion
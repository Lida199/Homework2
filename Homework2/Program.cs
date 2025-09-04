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
using System.Collections.Immutable;

int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] ints = new int[arrayLength];

for(int i = 0; i < arrayLength; i++)
{
    ints[i]= i + 1;
}

int evenNumbersLength = ints.Length % 2 == 0 ? ints.Length / 2 : (ints.Length - 1) / 2;
int[] evenNumbers = new int[evenNumbersLength];

for (int i = 0; i < arrayLength; i++)
{
    if (ints[i] % 2 == 0)
    {
        evenNumbers[i / 2] = ints[i];
    }
}


int oddNumbersLength = ints.Length % 2 != 0 ? (ints.Length + 1) / 2 : ints.Length / 2;
int[] oddNumbers = new int[oddNumbersLength];

for (int i = 0; i < arrayLength; i++)
{
    if (ints[i] % 2 != 0)
    {
        int indexedAt = i >= 2 ? i / 2 : 0;
        oddNumbers[indexedAt] = ints[i];
    }
}
#endregion

#region Exercise 2
Dictionary<string, string> contacts = new Dictionary<string, string>();

void addContact(Dictionary<string, string> dict, string key, string value)
{
    dict.Add(key, value);
}

void removeContact(Dictionary<string, string> dict, string key)
{
    if (dict.ContainsKey(key)){
        dict.Remove(key);
    }
}

void editContact(Dictionary<string, string> dict, string key, string newValue)
{
    if (dict.ContainsKey(key))
    {
        dict[key] = newValue;
    }
}

addContact(contacts, "Natia", "555555555");
addContact(contacts, "Naili", "555555995");
editContact(contacts, "Naili", "999999999");
removeContact(contacts, "Naili");
#endregion

#region Exercise 3
int[] numbers = [ 2, 2, 2, 1, 1, 444, 32, 4 ];
var numberCount = numbers
    .GroupBy(number => number)
    .Select(number => new
    {
        Number = number.Key,
        Count = number.Count(),
        Sum = number.Sum()
    })
    .OrderBy(number => number.Number);  

foreach (var count in numberCount)
{
    Console.WriteLine($"{count.Number} appears {count.Count} times sum {count.Sum}");
}
#endregion

#region Exercise 4
int[] numbers2 = [1, 2, 3, 4, 5, 10, 6, 7, 8, 9];
var topAmount = Convert.ToInt32(Console.ReadLine());

var topResults = numbers2.OrderBy(number => number).TakeLast(topAmount);

foreach (var num in topResults)
{
    Console.WriteLine(num);
}
#endregion
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Collections.Generic;
using System.Reflection;

static int CheckTheInterval(int a, int b, int n)
{
    var result = 0;
    for (int i = a; i<= b; i++)
    {
        if(Math.Pow(i, 1.0/n) % 1 == 0)
        {
            result++;
        }
    }

    return result;
}

Console.WriteLine("EXERCISE 1----");
Console.WriteLine(CheckTheInterval(49, 71, 2));
Console.WriteLine(CheckTheInterval(2, 27, 4));
#endregion

#region Exercise 2
static int CheckCount(string a)
{
    var counts = a
           .GroupBy(item => item)
           .Where(item => item.Count() >= 2)
           .Sum(item => item.Count() / 2);

    return counts;
}

Console.WriteLine("EXERCISE 2----");
Console.WriteLine(CheckCount("AA"));
Console.WriteLine(CheckCount("AABBCC"));
Console.WriteLine(CheckCount("AABBC"));
Console.WriteLine(CheckCount("ABABC"));
Console.WriteLine(CheckCount("AAABB"));
#endregion

#region Exercise 3
static string CheckTheSameParts(string a, string b)
{
    var reversedA = a.Reverse().ToArray();
    var reversedB = b.Reverse().ToArray();
    int minLength = Math.Min(reversedA.Length, reversedB.Length);
    string result = "";

    for(int i=0; i<minLength; i++)
    {
        if (reversedA[i]== reversedB[i])
        {
            result = $"{reversedA[i]}{result}";
        }
        else
        {
            break;
        }
    }

    return result;
}

Console.WriteLine("EXERCISE 3----");
Console.WriteLine(CheckTheSameParts("multiplication","substraction"));
Console.WriteLine(CheckTheSameParts("It is some random text", "some random text"));
#endregion

#region Exercise 4
static void GenericMethod<T>(List<T> items)
{
    if (items[0] is string)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item.ToString().ToUpper());
        }
    }
    else if (items[0] is int)
    {
        int sum = 0;
        foreach (var item in items)
        {
            sum += Convert.ToInt32(item);
        }
        Console.WriteLine(sum);
    }
    else if (items[0] is bool)
    {
        int middleIndex = items.Count / 2;
        Console.WriteLine($"First element is {items[0]}");
        Console.WriteLine($"First element is {items[items.Count-1]}");
        Console.WriteLine($"First element is {items[middleIndex]}");

    }
} 

Console.WriteLine("EXERCISE 3----");
GenericMethod<int>([1,2,3,4,5]);
GenericMethod<bool>([true, true,false,true,false,false, false]);
GenericMethod<string>(["hello", "world"]);
#endregion

#region Exercise 5
static string ExampleOfRecursion(int num)
{
    if (num < 10)
    {
        return num.ToString();
    }
    int lastDigit = num % 10;
    int rest = num / 10;
    return ExampleOfRecursion(rest) + "-" + lastDigit;
}

Console.WriteLine("EXERCISE 5----");
Console.WriteLine(ExampleOfRecursion(12345));
#endregion

#region Exercise 6
static bool ContainsDuplicates(int[] a)
{
    var counts = a.GroupBy(item => item).Count() != a.Length;
    return counts;
}

Console.WriteLine("EXERCISE 6----");
Console.WriteLine(ContainsDuplicates([1,2,3,1]));
Console.WriteLine(ContainsDuplicates([1, 2, 3, 4]));
#endregion
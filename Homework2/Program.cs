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
void theDifferenceBetweenAreas(int radius){
   var diameter = 2 * radius;
   var areaOfABiggerSquare = Math.Pow(diameter, 2);
   var areaOfASmallerSquare = diameter * diameter / 2;
   Console.WriteLine(areaOfABiggerSquare - areaOfASmallerSquare);
}
theDifferenceBetweenAreas(5);
#endregion

#region Exercise 2
string jackpot(string[] results) {
    return results.All(x => x == results[0]) ? "Yes" : "No";
    // ვარიანტი 2
    //return results.Distinct().Count() == 1 ? "Yes" : "No";
}

string[] ticket1 = ["1", "1", "1", "1"];
string[] ticket2 = ["%", "1", "1", "1"];

Console.WriteLine(jackpot(ticket1));
Console.WriteLine(jackpot(ticket2));
#endregion

#region Exercise 3
void calculateTotal(int win, int lose, int draw)
{
    const int winPoints = 3;
    const int drawPoints = 1;
    const int losePoints = 0;
    var total = win * winPoints + lose * losePoints + draw * drawPoints;
    Console.WriteLine(total);
}

calculateTotal(3, 1, 1);
#endregion

#region Exercise 4
void countWeeklyTotal(int[] weeklyHours)
{
    int weekdayWage = 10;
    int totalForAWeek = 0;
   for(int i=0; i < weeklyHours.Length; i++)
    {
        totalForAWeek += ((i < 5) ? 1 : 2 )*(weeklyHours[i] * weekdayWage + (weeklyHours[i] > 8 ? (weeklyHours[i] - 8) * weekdayWage / 2 : 0));  
    }

    Console.WriteLine(totalForAWeek);
}
countWeeklyTotal([8, 8, 8, 8, 8, 0, 0]);
countWeeklyTotal([8, 8, 8, 8, 8, 8, 0]);
countWeeklyTotal([4, 4, 4, 4, 4, 0, 4]);
countWeeklyTotal([5, 8, 8, 8, 8, 8, 8]);

#endregion

#region Exercise 5
int[] dailyResults = [1,2,2,3,1,4];
int[] dailyResults2 = [ 2, 2, 2, 2];

void printImprovementDays(int[] dailyResults) {
    var improvements = 0;
    for (int i = 1; i < dailyResults.Length; i++)
    {
        if (dailyResults[i] > dailyResults[i - 1])
        {
            improvements++;
        }
    }
    // LINQ ვერსია
    //var improvements = dailyResults
    //       .Skip(1)
    //       .Where((value, i) => value > dailyResults[i])
    //       .Count(); 
    Console.WriteLine(improvements);
}

printImprovementDays(dailyResults);
printImprovementDays(dailyResults2);
#endregion

#region Exercise 6
string[] elements = ["%ddd", "1", "1", "1"];

void lengthIsEqual(int length, string[] array)
{
    var filtered =  array.Where(item => item.Length == length);
    var textToPrint = filtered.Any() ? string.Join(", ", filtered) : "No elements found";
    Console.WriteLine(textToPrint);
 
}

lengthIsEqual(3, elements);
#endregion
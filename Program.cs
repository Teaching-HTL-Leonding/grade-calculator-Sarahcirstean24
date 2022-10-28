// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hast du bei der ersten Prüfung teilgenommen? ja/nein");
string grade = Console.ReadLine()!;

double points = 0;
double possiblePoints = 0;

if (grade == "ja")
{
    Console.WriteLine("Wie viele Punkte hast du geschafft? (0-20)");
    points += int.Parse(Console.ReadLine()!);
    possiblePoints += 20;
}

Console.WriteLine("Hast du bei der zweiten Prüfung teilgenommen? ja/nein");
grade = Console.ReadLine()!;


if (grade == "ja")
{
    Console.WriteLine("Wie viele Punkte hast du geschafft? (0-20) ");
    points += int.Parse(Console.ReadLine()!);
    possiblePoints += 20;
}

int note = 0;

double percentage = (points / possiblePoints * 100);
if (percentage < 50)
{
    note = 5;
}
else if (percentage < 63)
{
    note = 4;
}
else if (percentage < 76)
{
    note = 3;
}
else if (percentage < 89){
    note = 2;
}
if (percentage >= 89)
{
    note = 1;
}
Console.WriteLine("du bekommst die Note" +note);
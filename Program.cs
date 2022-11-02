Console.WriteLine("Did you participate the first exam? yes/no");
string grade = Console.ReadLine()!;

double points = 0;
double possiblePoints = 0;

if (grade == "yes")
{
    Console.WriteLine("How many points did you get for the first exam (0-20)?");
    points += int.Parse(Console.ReadLine()!);
    possiblePoints += 20;
}

Console.WriteLine("Did you participate the second exam? yes/no");
grade = Console.ReadLine()!;


if (grade == "yes")
{
    Console.WriteLine("How many points did you get for the second exam (0-20)? ");
    points += int.Parse(Console.ReadLine()!);
    possiblePoints += 20;
}

{
    Console.WriteLine("How many points did you get because of homework (0-20)? ");
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
else if (percentage < 89)
{
    note = 2;
}
else if (percentage >= 89)
{
    note = 1;
}
{
Console.WriteLine("du bekommst die Note" + note);
}
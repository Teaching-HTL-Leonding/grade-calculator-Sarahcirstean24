﻿Console.WriteLine("Did you participate the first exam? yes/no");
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
    double pointshomework = double.Parse(Console.ReadLine()!);
    possiblePoints += 20;
}

Console.WriteLine("Have you done an oral exam yes/no ?");
grade = Console.ReadLine()!;


if (grade == "yes")
{
    Console.WriteLine("How many points did you get for your oral exam (0-20)? ");
    points += int.Parse(Console.ReadLine()!);
    possiblePoints += 20;}
   
    double percentage = points/ possiblePoints * 100;
    double percentage2 = (points + 20)/possiblePoints * 100;

if (percentage < 50)
{
    Console.WriteLine("5");
}

 else if (percentage < 63)
{
    Console.WriteLine("4");
}

else if (percentage < 76)
{
    Console.WriteLine("3");
}

else if (percentage < 89)
{
    Console.WriteLine("2");
}

else if (percentage2 >= 89)
{
   Console.WriteLine("1");
}
if (percentage2 < 50)
{
    Console.WriteLine("your grade is 5");
}

 else if (percentage2 < 63)
{
    Console.WriteLine("your grade is 4");
}

else if (percentage2 < 76)
{
    Console.WriteLine("your grade is 3");
}

else if (percentage2 < 89)
{
    Console.WriteLine("your grade is 2");
}

else if (percentage2 >= 89)
{
   Console.WriteLine("your grade 1");
}
if (percentage2 > percentage)
{Console.WriteLine("If you would get all the points for homework (percentage2), then you would get a better grade. ");}




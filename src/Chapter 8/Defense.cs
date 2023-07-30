using System;

int row = 0;
int column = 0;

Console.Title = "Defense of Consolas";
Console.Write("Target Row? ");
row = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
column = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Beep();
Console.WriteLine("Deploy to:");
Console.WriteLine($"({row}, {column - 1})");
Console.WriteLine($"({row - 1}, {column})");
Console.WriteLine($"({row}, {column + 1})");
Console.WriteLine($"({row + 1}, {column})");
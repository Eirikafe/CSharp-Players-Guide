using System;

int xNum = 0;
int yNum = 0;
string coordinates = "";

Console.Write("Input the x number: ");
xNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the y number: ");
yNum = Convert.ToInt32(Console.ReadLine());

if (xNum < 0)
{
    if (yNum < 0)
    {
        coordinates = "SW";
    }
    else if (yNum > 0)
    {
        coordinates = "NW";
    }
    else
    {
        coordinates = "W";
    }
}
if (xNum == 0)
{
    if (yNum < 0)
    {
        coordinates = "S";
    }
    else if (yNum > 0)
    {
        coordinates = "N";
    }
    else
    {
        coordinates = "!";
    }
}
if (xNum > 0)
{
    if (yNum < 0)
    {
        coordinates = "SE";
    }
    else if (yNum > 0)
    {
        coordinates = "NE";
    }
    else
    {
        coordinates = "E";
    }
}
Console.WriteLine(coordinates);
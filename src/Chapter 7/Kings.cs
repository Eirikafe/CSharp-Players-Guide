using System;

int estate;
int duchy;
int province;
int points;
bool running = true;
char choice = ' ';


while (running)
{
    Console.WriteLine("Hello, How many estates do you have?");
    estate = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("And how many duchies?");
    duchy = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("And how many provinces?");
    province = Convert.ToInt32(Console.ReadLine());
    points = estate + (duchy * 3) + (province * 6);
    Console.WriteLine("You have " + points + " points");
    Console.WriteLine("Again? Y/N");
    choice = Convert.ToChar(Console.ReadLine());
    switch (choice)
    {
        case 'Y':
            running = true;
            break;
        case 'N':
            running = false;
            break;
    }
}

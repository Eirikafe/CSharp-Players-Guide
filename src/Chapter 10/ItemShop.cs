// See https://aka.ms/new-console-template for more information

int choice = 0;
int price = 0;

Console.WriteLine("Hello! The following items are available: ");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.WriteLine("What do you want to see the price of?");
choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        price = 10;
        break;
    case 2:
        price = 16;
        break;
    case 3:
        price = 24;
        break;
    case 4:
        price = 2;
        break;
    case 5:
        price = 20;
        break;
    case 6:
        price = 200;
        break;
    case 7:
        price = 2;
        break;
}
Console.WriteLine("That costs " + price + " gold pieces!");

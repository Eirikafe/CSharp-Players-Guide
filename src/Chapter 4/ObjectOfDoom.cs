using System;

Console.WriteLine("What kind of thing are we talking about?");
//The object in the sentence
string a = Console.ReadLine();
//Descriptors of the object
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();
//adding random mumbo jumbo
string c = "of Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");


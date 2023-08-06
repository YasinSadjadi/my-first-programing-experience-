
using System.ComponentModel.Design;
using System.Xml.Serialization;

Console.SetCursorPosition(0, 0);
Console.SetWindowSize(100, 30);




Console.WriteLine("hello user , if you want to use this app please choose one of this");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("1. detail");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("2. summary");

char A = char.Parse(Console.ReadLine());
Console.Clear();

if (A == '1')
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    Console.Title = "detailed info";
    Console.SetCursorPosition(1, 1);
    Console.SetWindowSize(46, 30);



    Console.Write("first name : ");
    Console.ResetColor();
    Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("______________________________________________");

    Console.Write("last name : ");
    Console.ResetColor();
    Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("______________________________________________");
    Console.Write("father's name : ");
    Console.ResetColor();
    Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("______________________________________________");

    Console.Write("hight : ");
    Console.ResetColor();
    Console.ReadLine();

    Console.ForegroundColor= ConsoleColor.DarkGreen;
    Console.WriteLine("______________________________________________");

    Console.Write("date of born : ");
    Console.ResetColor();

    int BornDate = int.Parse(Console.ReadLine());
    var Age = 2023 - BornDate;
    Console.WriteLine(); //just for giving space
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("youre age is  ");
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.WriteLine(Age);
    Console.WriteLine();

    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("press any key to exit");
    Console.ReadKey();
    Console.Clear();

}
else if (A == '2')
{
    Console.Title = "summary info";
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.SetCursorPosition(1, 1);
    Console.Write("first name : ");

    Console.ResetColor();
    Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("______________________________________________");

    Console.Write("last name : ");

    Console.ResetColor();
    Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("______________________________________________");
    Console.Write("age : ");

    Console.ResetColor();
    Console.ReadLine();

}
else
{
    Console.WriteLine("you have been choosen the wrong path");
    Console.WriteLine("press any key to Continue");
    Console.ReadLine();
}









   



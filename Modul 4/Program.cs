using System;

class MainClass
{
    public static void Main(string[] args)
    {
        #region Задание 4.1.4
        //string A;
        //string B;
        //bool c = A != B;
        #endregion

        #region Задание 4.1.5
        //int A;
        //int B;
        //double X;
        //double Y;
        //bool C = A < B || X > Y;
        #endregion

        #region Задание 4.1.16

        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

        var color = Console.ReadLine();

        if (color == "red")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is red!");
        }

        else if (color == "green")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is green!");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is cyan!");
        }


        #endregion
    }
}
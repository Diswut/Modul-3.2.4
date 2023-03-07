internal class Program
{
    //enum DaysOfWeek : byte
    //{
    //    Monday = 1,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday,

    //}


    private static void Main(string[] args)
    {
        Console.Write("What is yoyr name? ");

        var name = Console.ReadLine();

        Console.WriteLine($"\nHello {name}");

        Console.Write("\nHow old are you? ");

        var age = int.Parse(Console.ReadLine());

        Console.Write("\nWhat is your favorite day of week? ");

        var day = (Console.ReadLine());

        Console.Write($"\n{name}, and when is your birthday? ");

        var birthday = Console.ReadLine();

        Console.WriteLine($"\nSo, your name is {name}, you were born on {birthday}, you are {age} years old and your favorite day is {day}!");



    }
}
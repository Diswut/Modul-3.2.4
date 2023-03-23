internal class Program
{

    static (string Name, string LastName, int age, string pet) EnterUser()
    {
        (string Name, string LastName, int age, string pet) User;
        Console.WriteLine("Как вас зовут?");
        User.Name = Console.ReadLine();

        Console.WriteLine("Какая у вас фамилия?");
        User.LastName = Console.ReadLine();

        bool chek;
        do
        {
            Console.WriteLine("Сколько вам лет?");

            chek = int.TryParse(Console.ReadLine(), out User.age);

        } while (ChekPars(chek, User.age));

        Console.WriteLine($"{User.Name}, у вас есть питомец? (Вариант ответа Да/Нет)");

        User.pet = Console.ReadLine().ToLower();

        int Count = 0;
        if (User.pet == "да")
        {

            do
            {
                Console.WriteLine("Сколько у вас питомцев?");
                chek = int.TryParse(Console.ReadLine(), out Count);

            } while (ChekPars(chek, Count));

        }
        ChekPet(Count);

        do
        {

            Console.WriteLine("Сколько у вас любимых цветов?");
            chek = int.TryParse(Console.ReadLine(), out Count);

        } while (ChekPars(chek, Count));
        favcolors(Count);

        return User;
    }

    static bool ChekPars(bool chek, int number)
    {
        if (number > 0)
        {
            return false;
        }
        else
        {
            Console.WriteLine("Не коректные данные, попробуйте еще раз");
            return true;
        }


    }

    static string[] ChekPet(int count)
    {
        string[] array = new string[count];

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Как зовут питомца номер {i + 1}");
            array[i] = Console.ReadLine();
        }
        return array;
    }

    static string[] favcolors(int count)
    {
        string[] colors = new string[count];

        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine($"Ваш любимый цвет номер {i + 1} ");
            colors[i] = Console.ReadLine();
        }
        return colors;
    }

    private static void Main(string[] args)
    {
        EnterUser();
    }

}
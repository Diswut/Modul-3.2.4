using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;


class MainClass
{

    static string ShowColor(string username, int userage)
    {
        Console.WriteLine($"{username} {userage} \nНапишите свой любимый цвет на английском с маленькой буквы");
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }
        return color;
    }

    static int[] GetArrayFromConsole(int num = 5)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;

    }

    static void ShowColors(string username = "jane", params string[] favcolors)
    {
        Console.WriteLine("Ваши любимые цвета:");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }
    }

    static void SortArray(in int[] Array, out int[] sortArrayAsk, out int[] sortArrayDesc)
    {
        sortArrayAsk = SortArrayAsk(Array);

        sortArrayDesc = SortArrayDesc(Array);

    }

    //static void ShowArray(int[] array, bool chek = false)
    //{
    //    var temp = array;

    //    if (true)
    //    {
    //        temp = SortArray(array);
    //    }

    //    foreach (var item in temp) 
    //    {
    //        Console.WriteLine(item);
    //    }
    //}

    static void GetName(ref string name)
    {
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();

    }

    static void BigDataOperation(int[] arr, int a)
    {
        a = 111;
        arr[0] = 4;
    }

    static int[] SortArrayDesc(int[] Array)
    {
        var temp = 0;

        for (int i = 0; i < Array.Length; i++)
        {
            for (int j = i + 1; j < Array.Length; j++)
            {
                if (Array[i] < Array[j])
                {
                    temp = Array[i];
                    Array[i] = Array[j];
                    Array[j] = temp;
                }
            }
        }
        return Array;
    }

    static int[] SortArrayAsk(int[] Array)
    {
        var temp = 0;

        for (int i = 0; i < Array.Length; i++)
        {
            for (int j = i + 1; j < Array.Length; j++)
            {
                if (Array[i] > Array[j])
                {
                    temp = Array[i];
                    Array[i] = Array[j];
                    Array[j] = temp;
                }
            }
        }
        return Array;
    }

    static void Echo(string saidworld, int deep)
    {
        var modif = saidworld;

        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
            
        }

        Console.BackgroundColor= (ConsoleColor)deep;
        Console.WriteLine("..." + modif);

        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }
    }

    static void Main(string[] args)
    {
        

        


    }

    
}


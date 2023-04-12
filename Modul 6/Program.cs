using System.Drawing;
using System.Runtime.CompilerServices;

internal class Program
{


    public static void Main(string[] args)
    {
        int num1 = 3;
        int num2 = 58;
        Helper.Swap(ref num1, ref num2);
        Console.WriteLine(num1);
        Console.WriteLine(num2);

    }


    class Obj
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;


        static Obj()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;

        }
    }

    class Helper 
    { 
        public static void Swap (ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
    }
    class Int { }

    static class intExstension 
    {
        public static int GetNegative(this Int a)
        {
            if (a > 0)
            {
                return b;
            }
        }

    }

    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
        {

        }
    }

    abstract class Engine { }

    class ElectricEngine : Engine { }

    class GasEngine { }

    class Battery { }

    class Differential { }

    class Wheel { }

    abstract class CarPart { }

    class ElectricCar : Car<ElectricEngine> 
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }

    class GasCar : Car<GasEngine>  
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }



class A 
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }

    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }

    class D : B
    {
        public new void Display()
        {
            Console.WriteLine("D");
        }
    }


    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("E");
        }
    }




    //class Obj
    //{
    //    public string name;
    //    private string owner;
    //    private int length;
    //    private int count;

    //    public Obj(string name, string ownerName, int objLength, int count)
    //    {
    //        this.name = name;
    //    }
    //}
    class BaseClass
    {

        public virtual int Counter
        {
            get;
            set;
        }

        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }


        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }

        public DerivedClass(string name, string Description, int counter) : this (name, Description) 
        {
            Counter= counter;
        }
    }


}


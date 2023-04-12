using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person("Вася", "Лебовски");
        Cash cash = new Cash() { sum = 0};
        person.Pay(cash);
        Delivery<string> delivery = new Delivery<string>();
        delivery.WhereCourier();
    }



    abstract class PaymentMethod
    {


        public abstract void Pay();
        
    }

    class Cash : PaymentMethod
    {
        private int Sum;

        public int sum
        {
            get 
            {
                return Sum;
            }
            set 
            { if(value > 0)
                {
                    Sum = value;
                }
                else
                {
                    Console.WriteLine("Не хватает, где деньги Лебовски");
                }
                
            }
        }

        public override void Pay()
        {
            Console.WriteLine($"Я оплатил наличными {sum}");
        }
    }

    class CreditCard : PaymentMethod
    {

        public override void Pay()
        {
            Console.WriteLine($"Я оплатил картой");
        }
    }

    class Person
    {
        public void Pay(PaymentMethod payment)
        {
            payment.Pay();
        }
        public Person(string name, string lastname)
        {
            FirstName= name;
            LastName= lastname;
        }
        static string FirstName { get; set; }
        static string LastName { get; set; }

    }

    class Product
    {
        public string Name { get; set; }
    }
    class Delivery<T>
    {
        public T Adress { get; set; }
         
        public virtual void Method(T address, int date)
        {
            Console.WriteLine($"Буду на месте в {date} , по адресу{address}");
        }
        private bool courier;

        private void CourierMovement()
        {
            Console.WriteLine("Курьер еще не выехал, собирает заказ");

            courier = true;

            Console.WriteLine("Взял заказ, выезжаю");
        }

        public virtual void WhereCourier()
        {
            if (courier)
            {
                Console.WriteLine(" Курьер в пути ");
            }
            else
            {
                CourierMovement();
            }
        }
    }

    class HomeDelivery : Delivery<string>
    {
        public override void Method(string address, int date)
        {
            Console.WriteLine($"Буду у вас дома в {date} , по адресу{address}");
        }
    }

    class PickPointDelivery : Delivery<string>
    {
        public override void Method(string address, int date)
        {
            Console.WriteLine($"Доставка в точку выдачи заказов в {date} , по адресу{address}");
        }
    }

    class ShopDelivery : Delivery<string>
    {
        public new void Method(string address, int date)
        {
            Console.WriteLine($"Доставка в {date} , по адресу{address}");
        }
    }


}
using System.Data;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
namespace Modul_9;

internal class Program
{
    #region Задание 1

    static void Main(string[] args)
    {
        Exception[] exceptions = new Exception[5];
        exceptions[0] = new DivideByZeroException();
        exceptions[1] = new AggregateException();
        exceptions[2] = new MyException();
        exceptions[3] = new ApplicationException();
        exceptions[4] = new InvalidOperationException();
        
        foreach (var exception in exceptions)
        {
            try
            {
                throw exception;
            }
            catch (Exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
        #endregion

        #region Задание 2
        List<string> list = new List<string> 
        {
            "Васин",
            "Дуров",
            "Медведев",
            "Шнуров",
            "Ионов",
        };

        list.Sort();
        foreach (var exception in list) { Console.WriteLine(exception); }
        list.Reverse();
        foreach (var exception in list) { Console.WriteLine(exception); }

    }

        #endregion

}
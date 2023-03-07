internal class Program
{
    private static void Main(string[] args)
    {
        DaysOfWeek MyFavoritDay = DaysOfWeek.Friday;


        Console.WriteLine(MyFavoritDay);
        Console.WriteLine(Semaphore.Green);
        double result = 10.0 * 2.0 / 5.0;
       
    }
        
        enum DaysOfWeek : byte
        {

            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300,

    }


}
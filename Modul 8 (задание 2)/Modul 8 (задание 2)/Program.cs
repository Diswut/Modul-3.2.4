internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"D:\foto";
        long i = 0;
        i = GetDirSize(path);
        Console.WriteLine(i);
    }
    public static long GetDirSize(string path)
    {
        DirectoryInfo directoryInfo;

        if (Directory.Exists(path))
        {
            try
            {
                directoryInfo = new DirectoryInfo(path);
                
            }
            catch (Exception)
            {
                Console.WriteLine("Не верный путь к папке");
                return 0;
            }

            long size = 0;

            try
            {
                foreach (var item in directoryInfo.GetFiles())
                {
                    size += item.Length;
                }
            }
            catch (Exception) { }

            try
            {

                foreach (DirectoryInfo item in directoryInfo.GetDirectories())
                {
                    size += GetDirSize(item.FullName);
                }

            }
            catch (Exception) { }
            return size;

        }
        else
        {
            Console.WriteLine("[!] такой каталог не найден");
            return 0;
        }
        
    }


}
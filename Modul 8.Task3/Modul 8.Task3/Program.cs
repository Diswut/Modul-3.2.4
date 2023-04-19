internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Users\Mike\Desktop\MyFolder";

        long Counter_Files = 0;

        Console.WriteLine("Исходный размер папки: " + GetDirSize(path) + " байт");

        Console.WriteLine("Освобождено: " + DeleteFiles(path,ref Counter_Files) + " байт, удаленно файлов {0}", Counter_Files);

        Console.WriteLine("Текущий размер папки: " + GetDirSize(path) + " байт");

        Directory.Delete(path, true);

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

    public static long DeleteFiles(string path, ref long Counter)
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
                    item.Delete();
                    Counter++;
                    
                }
            }
            catch (Exception) { }

            try
            {

                foreach (DirectoryInfo item in directoryInfo.GetDirectories())
                {
                    size += DeleteFiles(item.FullName,ref Counter);
                    item.Delete();
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
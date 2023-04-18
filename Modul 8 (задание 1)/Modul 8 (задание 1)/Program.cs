internal class Program
{
    private static void Main(string[] args)
    {

        string path = @"C:\Users\Mike\Desktop\MyFolder";

        static bool TimeDir(string path)
        {
            DateTime lastWriteTime = Directory.GetLastWriteTime(path);

            TimeSpan timeSpan = TimeSpan.FromMinutes(30);

            DateTime thresholdTime = DateTime.Now.Subtract(timeSpan);

            if (lastWriteTime < thresholdTime)
            {
                return true;

            }
            else
            {
                Console.WriteLine("Время последнего изменения менее 30-ти минут");
                return false;
            }

        }  // Метод проверяет время последнего редактирования дериктории 

        static bool TimeFile(string path)
        {
            DateTime lastWriteTime = File.GetLastWriteTime(path);

            TimeSpan timeSpan = TimeSpan.FromMinutes(30);

            DateTime thresholdTime = DateTime.Now.Subtract(timeSpan);

            if (lastWriteTime < thresholdTime)
            {
                return true;

            }
            else
            {
                Console.WriteLine("Время от последнего изменения менее 30-ти минут");
                return false;
            }

        } // Метод проверяет время последнего редактирования файла 

        if (TimeDir(path))
        {
            Delete(path);
        }


        static void Delete(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {

                    string[] dir = Directory.GetDirectories(path);

                    for (int i = 0; i < dir.Length; i++)
                    {
                        if (TimeDir(dir[i]))
                        {
                            string[] files = Directory.GetFiles(dir[i]);

                            for (int j = 0; j < files.Length; j++)
                            {
                                if (TimeFile(files[j]))
                                {
                                    File.Delete(files[j]);
                                }
                            }
                            Directory.Delete(dir[i]);

                        }



                    }


                }
                else
                {
                    Console.WriteLine("Директории по такому пути не существует");
                }

                Directory.Delete(path, true);
                Console.WriteLine("Удалили папку со всем содержимым");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } // Метод перебирает папки и файлы и удаляет если не использовались более 30 минут. 

    }
}
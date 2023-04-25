using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace FinalTask 
{
    internal class Program
    {
        private static void Main(string[] args)
        {
         
            string path = @"C:\Users\topto\OneDrive\Рабочий стол\Students";

            Directory.CreateDirectory(path);

            string file = @"C:\Users\topto\Students.dat";


            BinaryFormatter bin = new BinaryFormatter();

            using (var fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                Student[] students = (Student[])bin.Deserialize(fs);

                for (int i = 0; i < students.Length; i++)
                {

                    string a = path + "/" + students[i].Group + ".txt";

                    using (FileStream File_Stream = new FileStream(a, FileMode.Append))
                    {
                        using (StreamWriter sw = new StreamWriter(File_Stream))
                        {
                            sw.WriteLine($"{students[i].Name} , {students[i].DateOfBirth}");
                        };

                    }
                    
                }

            }

        }
    }
    [Serializable]
    class Student
    {
        public string Name { get; set; }

        public string Group { get; set; }

        public DateTime DateOfBirth { get; set; }

    }

}
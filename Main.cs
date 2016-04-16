using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KrRob
{
    class Date
    {
        List<FileStream> File1 = new List<FileStream>();   //Создаем наш файловый "список"
        FileStream file;
        public void Create()  
        {
            file = File.Create("Файл1.txt");   //Создаем новый текстовый файл
            File1.Add(file);
        }
        public void Delete()
        {
            File1.Remove(file);      //Удаляем файл
        }
        public void Read()
        {
            using (FileStream file = File.OpenRead("Файл1.txt"))  //Открываем наш файл
            {
                byte[] File = new byte[1024];
                UTF8Encoding sample = new UTF8Encoding(true);
                while (file.Read(File, 0, File.Length) > 0)
                {
                    Console.WriteLine(sample.GetString(File));
                }
            }
        }

    }
}
using KrRob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KrRob
{
    class AndrikUser
    {

        public void Enter()
        {
            Point:
            Console.WriteLine("Введите имя:"); 
            string Name = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            string Pass = Console.ReadLine();
            if (Pass == "1488")
            {
                Console.WriteLine("Добро пожаловать!");     //При правильных данных появляется приветствие и переход в главное меню

            }
            else
            {
                Console.WriteLine("Неправельное имя или пароль!");     //При ошибке ввода отправляемся заново вводить имя и пароль
                goto Point;

            }
            MainMenu();
        }
        static void MainMenu()
        {
        
            string Task = Console.ReadLine();          //Прописываем нужную команду для выполнения
            Date Date = new Date();
            if (Task == "Создать файл")
                Date.Create();
            else if (Task == "Удалить файл")
                Date.Delete();
            else if (Task == "Открыть файл")
                Date.Read();
         }
    }
}

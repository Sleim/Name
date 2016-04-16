using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrRob
{
    class Program
    {
        static void Main(string[] args)
        {
            AndrikUser Andrik = new AndrikUser();  
            Andrik.Enter();   //Запускаем вход в нашего пользователя
            Console.ReadKey();
        }
    }
}

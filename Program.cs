using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adres ADR = null;
            string gorod = new string(' ', 20);
            string ylica = new string(' ', 20);
            int nomer_doma = new int();
            Console.WriteLine("Введите название города");
            gorod = Console.ReadLine();
            Console.WriteLine("Введите название улицы");
            ylica = Console.ReadLine();
            Console.WriteLine("Введите номер дома");
            nomer_doma = Convert.ToInt32(Console.ReadLine());
            ADR = new Adres(gorod, ylica, nomer_doma);
            Console.WriteLine("Обьект созда");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using System.IO;

namespace Otvet_Exzamen
{
    class Program
    {
        static void Main(string[] args)
        {
                int N = 0;
                Console.WriteLine("Введите размер массива");
                N = Convert.ToInt32(Console.ReadLine());
                Route[] Routes = new Route[N];

                for (int i = 0; i < N; i++)
                {
                    Routes[i] = new Route();
                    Console.WriteLine("Введите номер троллейбуса ");
                int Number;
                Int32.TryParse(Console.ReadLine(), out Number);
                Routes[i].Number = Number;
                Console.WriteLine("Введите количество остановок ");
                int Quantity;
                Int32.TryParse(Console.ReadLine(), out Quantity);
                Routes[i].Quantity = Quantity;
                    Console.WriteLine("Введите время в пути в минутах ");
                int Time;
                Int32.TryParse(Console.ReadLine(), out Time);
                Routes[i].Time = Time;

                }

                foreach (var i in Routes)
                {
                    Console.WriteLine("Номер троллейбуса " + i.Number + " Количество остановок " + i.Quantity + " Время в пути " + i.Time + "\n");
                }
            SaveFile(Routes);
            Sortirovka(Routes);
            Console.ReadKey();
            Route[] Sortirovka(Route[] routes)
            {
                Route[] SortirovkaRoutes = Routes.AsQueryable<Route>().OrderBy(rout => rout.Quantity).ThenBy(rout => rout.Time).ToArray();
                return SortirovkaRoutes;
            }
        }
        public static void SaveFile(Route[] Routes)
        {
            using (StreamWriter wrt = new StreamWriter("Car.txt"))
            {
                foreach (var i in Routes)
                {
                    wrt.WriteLine("Номер троллейбуса " + i.Number + " Количество остановок " + i.Quantity + " Время в пути " + i.Time + "\n");
                }
            }
        }
        private static bool Proverka(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    return true;
                }
            }
            return false;
        }

    }
}
            
    


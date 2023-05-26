using System;

namespace задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "world";
            Console.WriteLine(a + b);

            Console.ReadKey();


            int s = 6;
            int z = 10;
            Console.WriteLine(s + z);
            Console.WriteLine(s - z);
            Console.WriteLine(s * z);
            Console.WriteLine(s/z);

            Console.ReadKey();

            Console.WriteLine("Введите своё имя, фамилю и отчество");
            a = Console.ReadLine();
            Console.WriteLine(a);

            Console.ReadKey();

            int hp_p = 50;
            int dam_p = 18;
            int def_p = 3;
            int hp_m = 30;
            int def_m = 2;
            int dam_m = 12;
            Console.WriteLine("Здоровье игрока:" + " "+ Convert.ToString( hp_p - (dam_m / def_p)));
            Console.WriteLine("Здоровье монстра:" + " " + Convert.ToString(hp_m - (dam_p / def_m)));
            Console.WriteLine("Здоровье урон монстра:" + " " + dam_m / def_p);
            Console.WriteLine("Здоровье урон игрока:" + " " + dam_p / def_m);

            Console.ReadKey();
        }
    }
}

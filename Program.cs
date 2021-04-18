using System;
using System.Collections;

namespace console_app_git
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList spektrum = new ArrayList();
            spektrum.Add("Nova");
            spektrum.Add("Aris");
            spektrum.Add("Lamina");
            spektrum.Add("Vidar");
            spektrum.Add("Ütopya");

            Console.Write("Kullanıcı adınızı giriniz:");
            string name = Console.ReadLine();

            if (spektrum.Contains(name) == true)
            {
                Console.WriteLine();
                Console.WriteLine("Ritminizin rengi spektrum, Hoşgeldiniz {0} !", name);
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("spektrum'dan değilsiniz, girişiniz engellendi {0} ! ", name);
                Console.WriteLine();
            }
        }
    }
}

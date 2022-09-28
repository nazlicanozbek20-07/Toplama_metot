using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplama_metot
{
    internal class Program
    {
        static int topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }
        static void Main(string[] args)
        {
            int s1, s2, toplam;

            Console.Write("Birinci Sayıyı Giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            toplam = topla(s1, s2);

            Console.WriteLine("Sayıların toplamı: " + toplam);

            Console.ReadLine();
        }
    }
}

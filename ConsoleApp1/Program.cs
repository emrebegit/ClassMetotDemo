using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.id = 1;
            musteri.ad = "Emre";
            musteri.soyad = "Begit";
            musteri.bakiye = 500;
            musteri.adres = "izmir";
            MusteriManager _mymusteri = new MusteriManager();
            _mymusteri.Add();
            _mymusteri.Delete();
            _mymusteri.Upgrade();
            _mymusteri.List();
            Console.ReadKey();

        }
    }
}

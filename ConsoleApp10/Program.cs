using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci ve ders listelerini oluştur
           
            List<string> ogrenciler = new List<string>{ "kadir","Efe","Mehmet","sadettin","samet","ahmet turan","Necati","yaşar","selim","muzaffer","eyüp ali","özlem","hacı ramazan","ayşenur","erdem","mahmut","bedirhan","hasan","levent","ali berat","abdulmuttalip","muhammed eren","selehaddin","yeliz","samed","burak arif","yağız","ahmet" };
            for (int i = 1; i <= 0; i++)
            {
                ogrenciler.Add(ogrenciler[i]) ;
            }

            List<string> dersler = new List<string> { "Matematik", "Fizik", "Kimya", "Biyoloji", "Nesne Tabanlı", "robotik kodlama", "Beden", "edebiyat", "tarih", "felsefe", "ingilizce", "din kültürü" };
            for (int i = 1; i <= 0; i++)
            {
                dersler.Add(dersler[i]);
            }

           //int i =1;<=30;i++ bu soruyu hocana sor
            Random random = new Random();

            foreach (var ogrenci in ogrenciler)
            {
                
                string randomDers = dersler[random.Next(dersler.Count)];

                
                Console.WriteLine($"{ogrenci} öğrencisine :  {randomDers} Dersi VERİLMİŞTİRRRRRR ♥");
            }

            Console.ReadLine();
        }
    }
}
    


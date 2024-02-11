using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAround
{
	class Program
	{
		private static object person1;

		static void Main(string[] args)
		{
			//Degiskenler();

			Vatandas vatandas1 = new Vatandas();
			SelamVer("Şeyma");
			SelamVer("Beyza");
			SelamVer("Nisa");
			SelamVer();
			int sonuc = Topla(2, 6);

			Person person1 = new Person();
			person1.FirstName = "Engin"; ;
			person1.LastName = "Demiroğ";
			person1.DateOfBirthYear = 1985;
			person1.NationalIdentitiy = 123;



			Person person2 = new Person();
			person2.FirstName = "Murat";




			string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
			string[] sehirler2 = { "Bursa", "Antalya", "Diyarbakır" };
			sehirler2 = sehirler1;
			sehirler1[0] = "Adana";
			Console.WriteLine(sehirler2[0]); // Buna göre şehir 1'in 0. indeksi Adana olur.

			foreach (string sehir in sehirler1)
			{
				Console.WriteLine(sehir);
			}
			//projelerde artık array yerine List kullanılıyor

			List<string> yeniSehirler1 = new List<string>();
			yeniSehirler1.Add("Ankara 1"); // Generic Collection
			yeniSehirler1.Add("İstanbul 1");
			yeniSehirler1.Add("İzmir 1");
			foreach (var sehir in yeniSehirler1)
			{
				Console.WriteLine(sehir);
			}

			PttManager pttManager = new PttManager(new PersonManager());
			pttManager.GiveMask(person1);


			Console.ReadLine();
		}
		static void SelamVer(string isim = "isimsiz")
		{
			Console.WriteLine("Merhaba " + isim);
		}
		static int Topla(int sayi1, int sayi2)
		{
			int sonuc = sayi1 + sayi2;
			Console.WriteLine("Toplam; " + sonuc);
			return sonuc;
		}
		private static void Degiskenler()
		{
			string mesaj = "Merhaba";
			double tutar = 100000;
			int sati = 100;
			bool girısYapılmısMı = false;

			string ad = "Engin";
			string soyad = "Demiroğ";
			int dogumYili = 1985;
			long tcNo = 12345678910;
			Console.WriteLine(tutar * 1.18);
			Console.WriteLine(tutar * 1.18);
		}
	}
	class Vatandas
	{
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public int DogumYili { get; set; }
		public long TcNo { get; set; }
	}
}
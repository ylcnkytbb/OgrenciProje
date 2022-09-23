using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciProje
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public char Cins { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cadde { get; set; }
        public int KapiNo { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public int Maas { get; set; }
        public string GetTitle()
        {
            if (Cins == 'E')
            {
                return "Sn Bay " + Ad + " " + Soyad;
            }
            else
            {
                return "Sn Bayan " + Ad + " " + Soyad;
            }
        }
        public int GetAge()
        {
            DateTime today = DateTime.Now;
            int yas = today.Year - DogumTarihi.Year;
            return yas;
            DateTime DogumGunu = DogumTarihi.AddYears(yas);
            if (DogumGunu < today)
            {
                yas = yas + 1;
            }
            return yas;
        }
        public List<String> GetAdres()
        {
            List<String> adr = new List<String>();
            adr.Add(Cadde);
            adr.Add(KapiNo.ToString());
            adr.Add(Ilce + "/" + Sehir);
            return adr;
        }
        public String GetAdres2()
        {
            return $" Şehir {Sehir}\n No {KapiNo}\n" + $"{Ilce + Sehir}";
        }

    }
}


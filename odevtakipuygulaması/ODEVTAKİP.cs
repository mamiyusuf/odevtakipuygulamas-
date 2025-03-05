using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevtakipuygulaması
{
    internal class Ogr
    {
        public string Ad { get; set; }
        public string No { get; set; }
        public string Soyad { get; set; }
        public int Sınıf { get; set; }
        public string Odevkonusu { get; set; }
        public string Odevpoint { get; set; }
        public string Odevyapıldımı { get; set; }
        public string Ders { get; set; }



        public string FullName
        {
            get
            {
                object[] sınıflar = new object[] { "10-A", "10-C", "10-F", "10-H", "10-G" };

                return $"{Ad} {Soyad} {sınıflar[Sınıf]} {No} {Odevkonusu}";
            }

        }
    }
}

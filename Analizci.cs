using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DokumanSiniflandirma
{
    public class Analizci
    {
        private readonly List<Siniflandirma> _testDatasi;
        private readonly int _ngram;
        private readonly string _klasor;

        public Analizci(int oran, int ngram, string klasor)
        {
            _ngram = ngram;
            _klasor = klasor;
            _testDatasi = new List<Siniflandirma>();

            TestDatasiYukleEkonomi(oran);
            TestDatasiYukleMagazin(oran);
            TestDatasiYukleSaglik(oran);
            TestDatasiYukleSiyasi(oran);
            TestDatasiYukleSpor(oran);
        }
        //Test datası ekonomiyi yükleyen metot 
        private void TestDatasiYukleEkonomi(int oran)
        {
            var adet = Directory.GetFiles(_klasor + @"\ekonomi").Count() * oran / 100;
            var testDokumanlari =
                Directory.GetFiles(_klasor + @"\ekonomi")
                .Take(adet)
                .Select(file => File.ReadAllText(file, Encoding.GetEncoding("iso-8859-9")))
                .ToArray();
            //Frekans değerleri ekonomi dökümanı için hesaplanıp tutuluyor
            _testDatasi.Add(new Siniflandirma(Kategori.Ekonomi, _ngram, testDokumanlari));
        }
        //Test datası magazini yükleyen metot
        private void TestDatasiYukleMagazin(int oran)
        {
            var adet = Directory.GetFiles(_klasor + @"\magazin").Count() * oran / 100;
            var testDokumanlari =
                Directory.GetFiles(_klasor + @"\magazin")
                .Take(adet)
                .Select(file => File.ReadAllText(file, Encoding.GetEncoding("iso-8859-9")))
                .ToArray();
            //Frekans değerleri magazin dökümanı için hesaplanıp tutuluyor
            _testDatasi.Add(new Siniflandirma(Kategori.Magazin, _ngram, testDokumanlari));
        }
        //Test datası sağlığı yükleyen metot
        private void TestDatasiYukleSaglik(int oran)
        {
            var adet = Directory.GetFiles(_klasor + @"\saglik").Count() * oran / 100;
            var testDokumanlari =
                Directory.GetFiles(_klasor + @"\saglik")
                .Take(adet)
                .Select(file => File.ReadAllText(file, Encoding.GetEncoding("iso-8859-9")))
                .ToArray();
            //Frekans değerleri sağlık dökümanı için hesaplanıp tutuluyor
            _testDatasi.Add(new Siniflandirma(Kategori.Saglik, _ngram, testDokumanlari));
        }
        //Test datası siyasiyi yükleyen metot
        private void TestDatasiYukleSiyasi(int oran)
        {
            var adet = Directory.GetFiles(_klasor + @"\siyasi").Count() * oran / 100;
            var testDokumanlari =
                Directory.GetFiles(_klasor + @"\siyasi")
                .Take(adet)
                .Select(file => File.ReadAllText(file, Encoding.GetEncoding("iso-8859-9")))
                .ToArray();
            //Frekans değerleri siyasi dökümanı için hesaplanıp tutuluyor
            _testDatasi.Add(new Siniflandirma(Kategori.Siyasi, _ngram, testDokumanlari));
        }
        //Test datası sporu yükleyen metot
        private void TestDatasiYukleSpor(int oran)
        {
            var adet = Directory.GetFiles(@"C:\Users\Gulnihan\Desktop\1150haber\raw_texts\spor").Count() * oran / 100;
            var testDokumanlari =
                Directory.GetFiles(@"C:\Users\Gulnihan\Desktop\1150haber\raw_texts\spor")
                .Take(adet)
                .Select(file => File.ReadAllText(file, Encoding.GetEncoding("iso-8859-9")))
                .ToArray();
            //Frekans değerleri spor dökümanı için hesaplanıp tutuluyor
            _testDatasi.Add(new Siniflandirma(Kategori.Spor, _ngram, testDokumanlari));
        }

        //frekans değerleri döküman döküman tutulan testdatalarına göre hedef dataları analiz edip ne olduğu tahmin ediliyor
        //(key kategoriyi, value kac tane ngram kümesine ait kelime grubu olduğunu temsil eder)
        //hangi kategoriden kac adet gectigini hesaplayıp en büyük olanı da döndüren metot
        public Dictionary<Kategori, int> AnalizEt(string hedef)
        {
            var sonuc = new Dictionary<Kategori, int>();
            foreach (var i in _testDatasi)
            {
                sonuc.Add(i.Kategori, i.AnalizEt(hedef, _ngram));
            }
            var toplam = sonuc.Select(x => x.Value).Sum();
            
            sonuc = sonuc.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value * 100 / toplam);

            return sonuc;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DokumanSiniflandirma
{
    public class Siniflandirma
    {
        public Kategori Kategori { get; set; }
        private List<string> _testDokumanlari;
        private readonly int _nGram;
        public Dictionary<string, int> Frekans { get; set; }

        public Siniflandirma(Kategori kategori, int nGram,string[] testDokumanlari)
        {
            Kategori = kategori;
            _nGram = nGram;
            _testDokumanlari = new List<string>(testDokumanlari);
            Frekans = new Dictionary<string, int>();
            AnalizEt();
        }
        
        //test dokumanlarını ngramlara ayırıp herbir aynı kategoride olan frekans değerlerini hesaplayan metot
        private void AnalizEt()
        {
            foreach (var dokuman in _testDokumanlari)
            {
                var ngram = new NGram(dokuman, _nGram);

                foreach (var i in ngram.Sonuc)
                {
                    
                    if (!Frekans.ContainsKey(i))
                    {
                        Frekans.Add(i, 0);
                    }
               
                    Frekans[i] += 1;
                }
            }
            //frekansı 50'den büyük olan n gramlar sınıflandırmada kullanılsın
            Frekans = Frekans.Where(x => x.Value > 50).ToDictionary(x => x.Key,x => x.Value);
        }
        //hedef dataları ngramlarına ayırıp
        //ayrılmış bu elemanlar test dokumanlarının frekans değerlerini içeriyorsa 
        //kac adet gecmis onu hesaplayan metot
        public int AnalizEt(string hedef, int ngram)
        {
            int sonuc = 0;
            var hedefNGram = new NGram(hedef, ngram);

            foreach (var i in hedefNGram.Sonuc)
            {
                if (Frekans.ContainsKey(i))
                {
                    sonuc += Frekans[i];
                }
            }

            return sonuc;
        }
    }
}

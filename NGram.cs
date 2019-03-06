using System.Collections.Generic;

namespace DokumanSiniflandirma
{
    public class NGram
    {
        private readonly string _text;
        public List<string> Sonuc { get; }

        public NGram(string text, int nGram)
        {
            _text = NoktalamaIsaretleriniKaldir(text);
            Sonuc = GenerateNGram(nGram);
        }
        //text'i kac parcaya yani ngrama ayıracagını belirleyen ve boslukları _ yapıp döndüren metot
        private List<string> GenerateNGram(int ngramSize)
        {
            var sonuc = new List<string>();
            int sayac = 0;
            for (int i = ngramSize; i <= _text.Length; i++)
            {
                sonuc.Add(_text.Substring(sayac, ngramSize).Replace(" ", "_"));
                sayac++;
            }

            return sonuc;
        }
        //noktalama işaretlerini kaldıran metot
        static string NoktalamaIsaretleriniKaldir(string value)
        {
            int removeFromStart = 0;
            //Dizenin başındaki noktalama işareti karakterlerinin sayısını sayar
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsPunctuation(value[i]))
                {
                    removeFromStart++;
                }
                else
                {
                    break;
                }
            }

            int removeFromEnd = 0;
            //Sondaki noktalama işaretlerini sayar.Ters sırayla yineler
            for (int i = value.Length - 1; i >= 0; i--)
            {
                if (char.IsPunctuation(value[i]))
                {
                    removeFromEnd++;
                }
                else
                {
                    break;
                }
            }
            //Hiçbir noktalama işareti içermiyorsa orjinal dizeyi değiştirmeden döndürür
            if (removeFromStart == 0 &&
                removeFromEnd == 0)
            {
                return value;
            }
            //Tüm karakterler noktalama işareti ise boş bir dize döndürür
            if (removeFromStart == value.Length &&
                removeFromEnd == value.Length)
            {
                return "";
            }
            //kaldırılan noktalama karakterleriyle bir alt dize döndürülür
            return value.Substring(removeFromStart,
                value.Length - removeFromEnd - removeFromStart);
        }
    }
}

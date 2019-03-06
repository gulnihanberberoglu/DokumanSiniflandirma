namespace DokumanSiniflandirma
{

    public class Sonuc
    {
        public Kategori GercekKategori { get; set; }

        public string Text { get; set; }

        public Kategori TahminiKategori { get; set; }

        public int TahminiEkonomiYuzde { get; set; }

        public int TahminiMagazinYuzde { get; set; }

        public int TahminiSaglikYuzde { get; set; }

        public int TahminiSiyasiYuzde { get; set; }

        public int TahminiSporsYuzde { get; set; }
        //Dosyaları yüklerken gercek kategori sonucunu set eden metot
        public Sonuc(Kategori kategori, string text)
        {
            GercekKategori = kategori;
            Text = text;
        }

    }
}

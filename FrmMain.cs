using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokumanSiniflandirma
{

    public partial class FrmMain : Form
    {
        private string klasor;
        private List<BasariOrani> basariOrani;
        private List<Sonuc> dokumanlar;
        private Analizci analizci;

        public FrmMain()
        {
            InitializeComponent();
        }
        //Klasörü seçme işlemini gerçekleştiren metot
        private void buttonKlasorSec_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    klasor = fbd.SelectedPath;
                }
            }
        }

        //ana klasör içindeki alt klasörleri getiren 
        //dokuman listesine gercek kategorilere göre dosyaları yükleyen metot
        private void DosyalariYukle()
        {
            dokumanlar = new List<Sonuc>();
            var oran = int.Parse(comboBoxTestOrani.Text);

            dokumanlar.AddRange(
               Directory.GetFiles(klasor + @"\ekonomi")
               .Take(100 - oran)
               .Select(file => new Sonuc(Kategori.Ekonomi, File.ReadAllText(file, Encoding.GetEncoding("iso-8859-9")))));
            dokumanlar.AddRange(
               Directory.GetFiles(klasor + @"\magazin")
               .Take(100 - oran)
               .Select(file => new Sonuc(Kategori.Magazin, File.ReadAllText(file, Encoding.GetEncoding("iso-8859-9")))));
            dokumanlar.AddRange(
               Directory.GetFiles(klasor + @"\saglik")
               .Take(100 - oran)
               .Select(file => new Sonuc(Kategori.Saglik, File.ReadAllText(file, Encoding.GetEncoding("iso-8859-9")))));
            dokumanlar.AddRange(
               Directory.GetFiles(klasor + @"\siyasi")
               .Take(100 - oran)
               .Select(file => new Sonuc(Kategori.Siyasi, File.ReadAllText(file, Encoding.GetEncoding("iso-8859-9")))));
            dokumanlar.AddRange(
               Directory.GetFiles(klasor + @"\spor")
               .Take(100 - oran)
               .Select(file => new Sonuc(Kategori.Spor, File.ReadAllText(file, Encoding.GetEncoding("iso-8859-9")))));
        }
        
        //dosyaları yükleyip girilen oran ve ngram değerine göre 
        //her bir klasörü analiz eden buna göre tahmini kategorileri belirleyen
        //Basari ölçütlerini hesaplayıp gridi güncelleyip son halini yazdıran metot
        private void buttonAnalizEt_Click(object sender, EventArgs e)
        {
            DosyalariYukle();

            var oran = int.Parse(comboBoxTestOrani.Text);
            var ngram = int.Parse(comboBoxNGram.Text);
            //girilen oran ve ngram değerlerine göre klasördeki test datalarını oluşturan kısım
            analizci = new Analizci(oran, ngram, klasor);
            foreach (var dokuman in dokumanlar)
            {
                //test datalarını analiz edip(frekans değelerini hesaplayıp döküman döküman tutuyoruz) sınıflandıran kısım
                var sonuc = analizci.AnalizEt(dokuman.Text);
                dokuman.TahminiKategori = sonuc.First().Key;
                dokuman.TahminiEkonomiYuzde = sonuc[Kategori.Ekonomi];
                dokuman.TahminiMagazinYuzde = sonuc[Kategori.Magazin];
                dokuman.TahminiSaglikYuzde = sonuc[Kategori.Saglik];
                dokuman.TahminiSiyasiYuzde = sonuc[Kategori.Siyasi];
                dokuman.TahminiSporsYuzde = sonuc[Kategori.Spor];
            }
            BasariOraniHesapla();
            GridGuncelle();
        }

        //Başarı ölçütlerini(tp, fn, fp, tn) her bir kategori için toplam doküman için hesaplayıp 
        //bir listede tutulması işlemini gerçekleştiren metot
        private void BasariOraniHesapla()
        {
            basariOrani = new List<BasariOrani>();
            foreach (Kategori kategori in Enum.GetValues(typeof(Kategori)))
            {
                var sonuc = new BasariOrani();
                sonuc.Kategori = kategori;
                foreach (var dokuman in dokumanlar)
                {
                    if (dokuman.GercekKategori == kategori && dokuman.TahminiKategori == kategori)
                    {
                        sonuc.TruePositiveCount += 1;
                    }
                    else if (dokuman.GercekKategori == kategori && dokuman.TahminiKategori != kategori)
                    {
                        sonuc.FalseNegativeCount += 1;
                    }
                    else if (dokuman.GercekKategori != kategori && dokuman.TahminiKategori == kategori)
                    {
                        sonuc.FalsePositiveCount += 1;
                    }
                    else if (dokuman.GercekKategori != kategori && dokuman.TahminiKategori != kategori)
                    {
                        sonuc.TrueNegativeCount += 1;
                    }
                }

                basariOrani.Add(sonuc);
            }
        }

        //Birkaç tabloyu dökümanlar ile doldurup 
        //Birkaç tabloyu da basarı oranı ölçütleri ile doldurup 
        //güncelleme, yenileme işlemlerini yani Gridi Güncelleme işlemini gerçekleştiren metot
        private void GridGuncelle()
        {
            dataGridViewAnaliz.DataSource = dokumanlar;
            dataGridViewAnaliz.Update();
            dataGridViewAnaliz.Refresh();
            dataGridViewBasariOrani.DataSource = basariOrani;
            dataGridViewBasariOrani.Update();
            dataGridViewBasariOrani.Refresh();
        }

       }
}

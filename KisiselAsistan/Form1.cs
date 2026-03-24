using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselAsistan
{
    public partial class Form1 : Form
    {
        // Verilerimizi program çalıştığı sürece burada tutacağız
        List<FinansIslem> finansListesi = new List<FinansIslem>();
        List<Gorev> gorevListesi = new List<Gorev>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tabloda bir hücreye tıklayınca tüm satırı seçsin
            dgvFinans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // ComboBox'ın varsayılan olarak ilk sırasını seçili getir (Gelir)
            if (cmbTur.Items.Count > 0)
            {
                cmbTur.SelectedIndex = 0;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // 1. Veri Doğrulama: Açıklama boş mu? Tutar 0 mı?
            if (string.IsNullOrWhiteSpace(txtAciklama.Text) || numTutar.Value <= 0)
            {
                MessageBox.Show("Lütfen açıklama giriniz ve tutarın 0'dan büyük olduğundan emin olunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi durdur
            }

            // 2. Yeni bir FinansIslem nesnesi oluştur
            FinansIslem yeniIslem = new FinansIslem();
            yeniIslem.Id = finansListesi.Count + 1; // Basit bir ID ataması
            yeniIslem.Aciklama = txtAciklama.Text;
            yeniIslem.Tutar = numTutar.Value;
            yeniIslem.Tarih = dtpTarih.Value;

            // Türü belirle (ComboBox'tan gelen yazıya göre)
            if (cmbTur.SelectedItem.ToString() == "Gelir")
                yeniIslem.Tur = IslemTuru.Gelir;
            else
                yeniIslem.Tur = IslemTuru.Gider;

            // 3. Listeye ekle
            finansListesi.Add(yeniIslem);

            // 4. Listeyi Ekrana (DataGridView) Yansıtma 
            // (Listeyi yenilemek için önce null yapıp sonra tekrar veriyoruz)
            dgvFinans.DataSource = null;
            dgvFinans.DataSource = finansListesi;

            // 5. Ekranı Temizle (Kullanıcı yeni giriş için uğraşmasın)
            txtAciklama.Clear();
            numTutar.Value = 0;
            txtAciklama.Focus(); // İmleci tekrar açıklama kutusuna getir

            // 6. Hesaplamaları Güncelle 
            HesaplaVeYazdir();
        }
        private void HesaplaVeYazdir()
        {
            decimal toplamGelir = 0;
            decimal toplamGider = 0;

            // Tüm listeyi dönüp toplama işlemi yapıyoruz
            foreach (var islem in finansListesi)
            {
                if (islem.Tur == IslemTuru.Gelir)
                    toplamGelir += islem.Tutar;
                else
                    toplamGider += islem.Tutar;
            }

            // Label'lara yazdır
            lblGelir.Text = "Gelir: " + toplamGelir.ToString("C2"); // C2: Para birimi formatı
            lblGider.Text = "Gider: " + toplamGider.ToString("C2");

            decimal net = toplamGelir - toplamGider;
            lblNet.Text = "Net: " + net.ToString("C2");

            // Net durum eksiye düşerse rengi kırmızı yapalım
            if (net < 0) lblNet.ForeColor = Color.Red;
            else lblNet.ForeColor = Color.Green;
        }

        private void btnSilFinans_Click(object sender, EventArgs e)
        {
            
            // 1. Seçili bir satır var mı kontrol et
            if (dgvFinans.SelectedRows.Count > 0)
            {
                // 2. Kullanıcıya emin misin diye sor (Güvenlik önlemi)
                DialogResult cevap = MessageBox.Show("Bu kaydı silmek istediğine emin misin?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    // 3. Seçili satırdaki nesneyi yakala
                    // (DataBoundItem özelliği, o satırın arkasındaki 'FinansIslem' nesnesini verir)
                    FinansIslem silinecekIslem = (FinansIslem)dgvFinans.SelectedRows[0].DataBoundItem;

                    // 4. Listeden sil
                    finansListesi.Remove(silinecekIslem);

                    // 5. Tabloyu Güncelle (Kapat-Aç taktiği)
                    dgvFinans.DataSource = null;
                    dgvFinans.DataSource = finansListesi;

                    // 6. Toplamları yeniden hesapla (Çünkü para azaldı/arttı)
                    HesaplaVeYazdir();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için listeden bir satır seçiniz.");
            }
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGorev.Text)) return; // Boşsa işlem yapma

            // Yeni görev oluştur
            Gorev yeniGorev = new Gorev();
            yeniGorev.Id = gorevListesi.Count + 1;
            yeniGorev.Baslik = txtGorev.Text;
            yeniGorev.SonTarih = dtpGorevTarih.Value;
            yeniGorev.TamamlandiMi = false;

            // Listeye ekle
            gorevListesi.Add(yeniGorev);

            // Listeyi CheckedListBox'a Yansıt
            ListeyiGuncelle();

            // Kutuyu temizle
            txtGorev.Clear();
            txtGorev.Focus();
        }

        // Bunu butonun hemen altına ayrı bir metod olarak ekle
        private void ListeyiGuncelle()
        {
            clbGorevler.Items.Clear(); // Önce temizle

            foreach (var gorev in gorevListesi)
            {
                // Listeye yazılacak metni oluşturuyoruz
                string gorunum = $"{gorev.Baslik} (Son: {gorev.SonTarih.ToShortDateString()})";
                clbGorevler.Items.Add(gorunum, gorev.TamamlandiMi);
            }
        }

        private void btnSilGorev_Click(object sender, EventArgs e)
        {
            // Seçili bir öğe var mı? (CheckedListBox'ta seçili olanı index ile buluyoruz)
            if (clbGorevler.SelectedIndex != -1)
            {
                // Listeden o sıradaki görevi sil
                gorevListesi.RemoveAt(clbGorevler.SelectedIndex);

                // Ekranı güncelle
                ListeyiGuncelle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir görev seçiniz.");
            }
        }
    }
}


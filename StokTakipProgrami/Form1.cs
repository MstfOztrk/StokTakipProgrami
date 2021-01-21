using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StokTakipProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter data;
        DataSet dt;

        string resimYolu = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            VeritabaniDoldur();
        }

        public void VeritabaniDoldur()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UrunTakip.accdb");
            data = new OleDbDataAdapter("Select * from Urunler", baglanti);
            dt = new DataSet();
            baglanti.Open();
            data.Fill(dt, "Urunler");
            dataGridView1.DataSource = dt.Tables["Urunler"];
            baglanti.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            UrunKayit(resimYolu);
        }
        bool BarkodTest;
        bool BarkodTekrarEngelleme()
        {
            BarkodArama(textBoxBarkod);
            if(dataGridView1.Rows.Count>1)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        
        void UrunKayit(string resimYol)
        {
            BarkodTest = BarkodTekrarEngelleme();
            if (BarkodTest == false)
            {
                MessageBox.Show("Girmiş Olduğunuz Değerlerde Bir Barkod Zaten Bulunmaktadır Lütfen Farklı bir Barkod Giriniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
                
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO Urunler (Barkod,UrunAdi,Birim,Stok,Cinsi,Depo,SatisOnay,Aciklama,UrunResim,Fiyat) values (@barkod,@urunad,@birim,@stok,@cinsi,@depo,@satisonay,@aciklama,@urunresim,@fiyat)";
            komut.Parameters.AddWithValue("@barkod", textBoxBarkod.Text);
            komut.Parameters.AddWithValue("@urunad",textBoxUrunAd.Text);
            komut.Parameters.AddWithValue("@birim",comboBoxBirim.Text);
            komut.Parameters.AddWithValue("@stok",numericUpDownStok.Value);
            komut.Parameters.AddWithValue("@cinsi",comboBoxCinsi.Text);
            komut.Parameters.AddWithValue("@depo",comboBoxDepo.Text);
            komut.Parameters.AddWithValue("@satisonay",checkBoxSatis.Checked);
            komut.Parameters.AddWithValue("@aciklama",textBoxAciklama.Text);
            komut.Parameters.AddWithValue("@urunresim",resimYol);
            komut.Parameters.AddWithValue("@fiyat",numericUpDownFiyat.Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VeritabaniDoldur();
            AlanlariTemizle();
            MessageBox.Show("Ürün Başarıyla Eklenmiştir.");
        }
        void AlanlariTemizle()
        {
            textBoxBarkod.Text = "";
            textBoxUrunAd.Text = "";
            comboBoxBirim.Text = "";
            numericUpDownStok.Value = 0;
            comboBoxCinsi.Text = "";
            comboBoxDepo.Text = "";
            checkBoxSatis.Checked = true;
            textBoxAciklama.Text = "";
            resimYolu = "";
            numericUpDownFiyat.Value = 0;
            pictureBoxKayit.Image = null;
        }
        private void buttonResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                 resimYolu= op.FileName;
                pictureBoxKayit.ImageLocation = resimYolu;
                label12.Text = resimYolu;
            }
            else
            {
                resimYolu = "";
            }
        }
        void BarkodArama(TextBox arama)
        {
            if (arama.Text != "")
            {
                data = new OleDbDataAdapter("Select * from Urunler where Barkod like '" + arama.Text + "%'", baglanti);
                dt = new DataSet();
                baglanti.Open();
                data.Fill(dt, "Urunler");
                dataGridView1.DataSource = dt.Tables["Urunler"];
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Barkodunuzu Kontrol Ediniz.");
            }
            
        }
        void UrunTuruArama()
        {
            if (comboBoxAraTur.Text != "")
            {
                data = new OleDbDataAdapter("Select * from Urunler where Cinsi like '" + comboBoxAraTur.Text + "%'", baglanti);
                dt = new DataSet();
                baglanti.Open();
                data.Fill(dt, "Urunler");
                dataGridView1.DataSource = dt.Tables["Urunler"];
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Herhangi bir Tür Seçtiğinizden Emin Olun.");
            }

        }
        void BarkodSilme()
        {       
            if (textBoxAraBarkod.Text != "")
            {
                var sonuc = MessageBox.Show(textBoxAraBarkod.Text + " : Barkodu Silmek İstediğinize emin misiniz?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (sonuc==DialogResult.OK)
                {
                    komut = new OleDbCommand();
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "DELETE from Urunler where Barkod=" + textBoxAraBarkod.Text + "";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    VeritabaniDoldur();
                }
                else
                {
                    MessageBox.Show("Silme İşlemi İptal Edildi.");
                }              
            }
            else
            {
                MessageBox.Show("Barkodunuzu Kontrol Ediniz.");
            }

        }
        void SatistaOlanUrunleriArama()
        {
            data = new OleDbDataAdapter("Select * from Urunler where SatisOnay like " + checkBoxAraSatis.Checked + "", baglanti);
            dt = new DataSet();
            baglanti.Open();
            data.Fill(dt, "Urunler");
            dataGridView1.DataSource = dt.Tables["Urunler"];
            baglanti.Close();
        }
        void VerileriGuncelleme()
        {
            
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "update Urunler set UrunAdi=@urunad,Birim=@birim,Stok=@stok,Cinsi=@cinsi,Depo=@depo,SatisOnay=@satisonay,Aciklama=@aciklama,UrunResim=@urunresim,Fiyat=@fiyat";
            komut.Parameters.AddWithValue("@urunad", textBoxUrunAd.Text);
            komut.Parameters.AddWithValue("@birim", comboBoxBirim.Text);
            komut.Parameters.AddWithValue("@stok", numericUpDownStok.Value);
            komut.Parameters.AddWithValue("@cinsi", comboBoxCinsi.Text);
            komut.Parameters.AddWithValue("@depo", comboBoxDepo.Text);
            komut.Parameters.AddWithValue("@satisonay", checkBoxSatis.Checked);
            komut.Parameters.AddWithValue("@aciklama", textBoxAciklama.Text);
            komut.Parameters.AddWithValue("@urunresim", label12.Text);
            komut.Parameters.AddWithValue("@fiyat", numericUpDownFiyat.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Verileriniz Başarıyla güncellenmiştir.");
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            UrunTuruArama();
        }

        private void buttonAraBarkod_Click(object sender, EventArgs e)
        {
            BarkodArama(textBoxAraBarkod);
        }

        private void buttonSilBarkod_Click(object sender, EventArgs e)
        {
            BarkodSilme();
            VeritabaniDoldur();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SatistaOlanUrunleriArama();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            VeritabaniDoldur();
        }
        int seçilensatır;
        void SecilenSatirinBilgileriniGetir(DataGridViewCellEventArgs e)
        {
            int a = dataGridView1.RowCount;
            if (e.RowIndex < (a-1))
            {
                seçilensatır = Convert.ToInt16(dt.Tables["Urunler"].Rows[e.RowIndex]["Barkod"]);

                textBoxBarkod.Text = seçilensatır.ToString();
                textBoxUrunAd.Text = dt.Tables["Urunler"].Rows[e.RowIndex]["UrunAdi"].ToString();
                comboBoxBirim.Text = dt.Tables["Urunler"].Rows[e.RowIndex]["Birim"].ToString();
                numericUpDownStok.Value = Convert.ToInt32(dt.Tables["Urunler"].Rows[e.RowIndex]["Stok"]);
                comboBoxCinsi.Text = dt.Tables["Urunler"].Rows[e.RowIndex]["Cinsi"].ToString();
                comboBoxDepo.Text = dt.Tables["Urunler"].Rows[e.RowIndex]["Depo"].ToString();
                checkBoxSatis.Checked = Convert.ToBoolean(dt.Tables["Urunler"].Rows[e.RowIndex]["SatisOnay"]);
                textBoxAciklama.Text = dt.Tables["Urunler"].Rows[e.RowIndex]["Aciklama"].ToString();
                numericUpDownFiyat.Value = Convert.ToInt32(dt.Tables["Urunler"].Rows[e.RowIndex]["Fiyat"]);
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenSatirinBilgileriniGetir(e);
        }
        void VerileriAraclaraDoldur()
        {
            textBoxBarkod.Text = dt.Tables["Urunler"].Rows[0]["Barkod"].ToString();
            textBoxUrunAd.Text = dt.Tables["Urunler"].Rows[0]["UrunAdi"].ToString();
            comboBoxBirim.Text = dt.Tables["Urunler"].Rows[0]["Birim"].ToString();
            numericUpDownStok.Value = Convert.ToInt32(dt.Tables["Urunler"].Rows[0]["Stok"]);
            comboBoxCinsi.Text = dt.Tables["Urunler"].Rows[0]["Cinsi"].ToString();
            comboBoxDepo.Text = dt.Tables["Urunler"].Rows[0]["Depo"].ToString();
            checkBoxSatis.Checked = Convert.ToBoolean(dt.Tables["Urunler"].Rows[0]["SatisOnay"]);
            textBoxAciklama.Text = dt.Tables["Urunler"].Rows[0]["Aciklama"].ToString();
            numericUpDownFiyat.Value = Convert.ToInt32(dt.Tables["Urunler"].Rows[0]["Fiyat"]);
            label12.Text = dt.Tables["Urunler"].Rows[0]["UrunResim"].ToString();
        }
        private void button6_Click_2(object sender, EventArgs e)
        {
            BarkodArama(textBoxGuncelle);
            VerileriAraclaraDoldur();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            VerileriGuncelleme();
            VeritabaniDoldur();
        }
    }
}

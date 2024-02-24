using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace veriodev
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // Her 1000 milisaniyede bir (1 saniye) tetiklenecek
            timer.Tick += SaatEkle;

            // Timer'ı başlat
            timer.Start();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=veriodev;User Id = postgres; Password = lab1234");
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void tabloyu_goster(string txt)
            {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void gosterbtn_Click(object sender, EventArgs e)
        {
            tabloyu_goster("select * from \"public\".\"HastaTablom\";");
        }


        private void KayitSilbtn_Click(object sender, EventArgs e)
        {
            if (radioButtonTc.Checked)
            {
                tabloyu_goster("SELECT * FROM public.\"HastaTablom\";\r\nDELETE FROM public.\"HastaTablom\"\r\n\tWHERE \"TCNo\"=" + bilgitxt.Text + ";");
            }
            else
            {
                MessageBox.Show("Kayıt silme işlemi sadece tc girilerek yapılır");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabloyu_goster("SELECT * FROM public.\"HastaTablom\";\r\nINSERT INTO public.\"HastaTablom\" (\"TCNo\",\"Ad\",\"Soyad\",\"Telefonno\",\"DogumYeri\",\"DogumTarihi\",\"Adres\",\r\n\t\t\t\t\t\t\t\t  \"Hastalik\",\"İlac\")\r\n" +
               "values (" + texttc.Text + " ,'" + textad.Text + "','" + textsoyad.Text + "'," + texttel.Text + ",'" + textdy.Text + "','" + textdt.Text + "','" + textadres.Text + "','" + texthastalik.Text + "','" + textilac.Text + "');");
            MessageBox.Show("Kayıt sisteme başarıyla eklendi");
        }

        private void Listelebtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) //seçili mi kontroll
            {
                string secilenSecenek = comboBox1.SelectedItem.ToString();

                if (secilenSecenek == "Hastalık")
                {
                    tabloyu_goster("SELECT * FROM public.\"HastaTablom\"\r\nOrder by \"Hastalik\" asc");
                }
                else if (secilenSecenek == "Hasta Adı")
                {
                    tabloyu_goster("SELECT * FROM public.\"HastaTablom\"\r\nOrder by \"Ad\" asc");
                }
                else if(secilenSecenek=="Tc")
                {
                    tabloyu_goster("SELECT * FROM public.\"HastaTablom\"\r\nORDER BY \"TCNo\" ASC ");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir seçenek seçiniz!");
            }
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            string tcKimlik = bilgitxt.Text;

            // TC kimlik bilgisine göre hastanın verilerini getirir
            string baslangıc = $"SELECT * FROM public.\"HastaTablom\" WHERE \"TCNo\" = " + tcKimlik + ";";
            tabloyu_goster(baslangıc);
            // Kullanıcının güncellediği bilgileri aldık
            string yeniTc = texttc.Text;
            string yeniAd = textad.Text;
            string yeniSoyad = textsoyad.Text;
            string yeniAdres = textadres.Text;
            string yeniTelNo = texttel.Text;
            string yeniDogumYeri =textdy.Text;
            string yeniDogumTarihi = textdt.Text;
            string yeniHastalikAdi = texthastalik.Text;
            string yeniIlacBilgisi = textilac.Text;

            // Güncelleme sorgusunu oluştururuz
            string ekleme = $"UPDATE public.\"HastaTablom\" SET ";
            if(!string.IsNullOrEmpty(yeniTc))
            {
                ekleme += $"\"TCNo\"='" + yeniTc + "',";
            }
            if (!string.IsNullOrEmpty(yeniAd))
            {
                ekleme += $"\"Ad\"= '"+yeniAd+"', ";
            }

            if (!string.IsNullOrEmpty(yeniSoyad))
            {
                ekleme += $"\"Soyad\"= '"+yeniSoyad+"', ";
            }
            if (!string.IsNullOrEmpty(yeniTelNo))
            {
                ekleme += $"\"Telefonno\" = " + yeniTelNo + ", ";
            }
            if (!string.IsNullOrEmpty(yeniDogumYeri))
            {
                ekleme += $"\"DogumYeri\" = '" + yeniDogumYeri + "', ";
            }

            if (!string.IsNullOrEmpty(yeniDogumTarihi))
            {
                ekleme += $"\"DogumTarihi\" = '" + yeniDogumTarihi + "', ";
            }

            if (!string.IsNullOrEmpty(yeniAdres))
            {
                ekleme += $"\"Adres\" = '"+yeniAdres+"', ";
            }


            if (!string.IsNullOrEmpty(yeniHastalikAdi))
            {
                ekleme += $"\"Hastalik\" = '"+yeniHastalikAdi+"', ";
            }

            if (!string.IsNullOrEmpty(yeniIlacBilgisi))
            {
                ekleme += $"\"İlac\"= '"+yeniIlacBilgisi+"', ";
            }

                // Sonunda virgül varsa virgülü kaldırır
            if (ekleme.EndsWith(", "))
            {
                 ekleme = ekleme.Substring(0, ekleme.Length - 2);
            }

            ekleme += $" WHERE \"TCNo\" = "+tcKimlik+"";

            // Güncelleme sorgusunu çalıştır
            conn.Open();
            NpgsqlCommand updateCommand = new NpgsqlCommand(ekleme, conn);
            updateCommand.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Hasta bilgileri güncellendi.");

            // Güncelleme sonrası tabloyu tekrar göster
            tabloyu_goster("select * from \"public\".\"HastaTablom\";");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = eklesekme;
        }

        private void Getirbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(bilgitxt.Text))
            {
                if (radioButtonHasta.Checked)
                {
                    tabloyu_goster("select * from \"public\".\"HastaTablom\" where \"Ad\"='" + bilgitxt.Text + "';");
                }
                else if (radioButtonTc.Checked)
                {
                    MessageBox.Show("Eğer güncelleme yapacaksanız buraya tc giriniz ve diğer sayfadan güncelleme işleminizi tamamlayınız.");
                    tabloyu_goster("select * from \"public\".\"HastaTablom\" where \"TCNo\"=" + bilgitxt.Text + ";");
                }
                else if (radioButtonHastalik.Checked)
                {
                    tabloyu_goster("select * from \"public\".\"HastaTablom\" where \"Hastalik\"='" + bilgitxt.Text + "';");
                }
            }
            else
            {
                MessageBox.Show("BU alanı boş bırakamazsınız.");
            }
        }

        private void radioButtonTc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void degerlabel_Click(object sender, EventArgs e)
        {

        }
        private void SaatEkle(object sender, EventArgs e)
        {
            // Şuanki saat ve tarih bilgisini al
            DateTime now = DateTime.Now;

            // Saat bilgisini Label kontrolüne yaz
            labelSaat.Text = now.ToString("HH:mm");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = anasekme;
        }

        private void anasekme_Click(object sender, EventArgs e)
        {

        }
    }
}


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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //iegeytek
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Sefer No", 50);
            listView1.Columns.Add("Tarih", 60);
            listView1.Columns.Add("Saat", 60);
            listView1.Columns.Add("Ad Soyad", 60);
            listView1.Columns.Add("Telefon", 60);
            listView1.Columns.Add("Koltuk Numarası", 60);
            listView1.Columns.Add("Ücret", 60);
            listView1.Columns.Add("Cinsiyet", 70);
            comboBox1.Items.Add("Erkek");
            comboBox1.Items.Add("Kadın");
            comboBox1.Items.Add("Belirtmek İstemiyorum");
            comboBox2.Items.Add("Pendik");
            comboBox2.Items.Add("Kartal");
            comboBox2.Items.Add("Beykoz");
            comboBox2.Items.Add("Maltepe");
            comboBox2.Items.Add("Tuzla");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Önemli Kısım
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\Usb Bellek\\Vs-Projeler\\WindowsFormsApplication1\\Database2.mdb"); //bu bölümü kendi Dosya konumuna göre değiştir!!!
        
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void goster()
        {
            listView1.Items.Clear();//iegeytek
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM bilgiler", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();//iegeytek
                    ekle.Text = oku["SeferNo"].ToString();
                    ekle.SubItems.Add(oku["Tarih"].ToString());
                    ekle.SubItems.Add(oku["Saat"].ToString());//iegeytek
                    ekle.SubItems.Add(oku["AdSoyad"].ToString());
                    ekle.SubItems.Add(oku["Telefon"].ToString());
                    ekle.SubItems.Add(oku["KoltukNo"].ToString());
                    ekle.SubItems.Add(oku["Ucret"].ToString());
                    ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                    ekle.SubItems.Add(oku["Binis"].ToString()); 
                    listView1.Items.Add(ekle);
                    //iegeytek
                }

                baglanti.Close();
            }//iegeytek
            catch (Exception err)
            {
                MessageBox.Show($"Error:{err.Message}");
                baglanti.Close();//iegeytek
            }  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            goster();   
        }

        private void button2_Click(object sender, EventArgs e)
        {//iegeytek
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO bilgiler ([SeferNo], [Tarih], [Saat], [AdSoyad], [Telefon], [KoltukNo], [Ucret], [Cinsiyet], [Binis]) VALUES (@SeferNo, @Tarih, @Saat, @AdSoyad, @Telefon, @KoltukNo, @Ucret, @Cinsiyet, @Binis)", baglanti);
                komut.Parameters.AddWithValue("@SeferNo", textBox1.Text);
                komut.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@Saat", textBox3.Text);
                komut.Parameters.AddWithValue("@AdSoyad", textBox4.Text);
                komut.Parameters.AddWithValue("@Telefon", textBox5.Text);
                komut.Parameters.AddWithValue("@KoltukNo", textBox6.Text);//iegeytek
                komut.Parameters.AddWithValue("@Ucret", textBox7.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text.ToString());
                komut.Parameters.AddWithValue("@Bitis", comboBox2.Text.ToString());
                komut.ExecuteNonQuery();
                goster();
                baglanti.Close();

            }
            catch(Exception err)//iegeytek
            {
                MessageBox.Show($"Error:{err.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = "1";
            button3.Enabled = false;
            button3.ForeColor = Color.Green;
        }//iegeytek

        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Text = "2";
            button4.Enabled = false;
            button4.ForeColor = Color.Green;
        }
        //iegeytek
        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = "3";
            button5.Enabled = false;
            button5.ForeColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)//iegeytek
        {
            textBox6.Text = "4";
            button6.Enabled = false;
            button6.ForeColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox6.Text = "5";
            button7.Enabled = false;
            button7.ForeColor = Color.Green;//iegeytek
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox6.Text = "6";
            button8.Enabled = false;//iegeytek
            button8.ForeColor = Color.Green;
        }//iegeytek

        private void button9_Click(object sender, EventArgs e)//iegeytek
        {
            textBox6.Text = "7";
            button9.Enabled = false;
            button9.ForeColor = Color.Green;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox6.Text = "8";
            button10.Enabled = false;//iegeytek
            button10.ForeColor = Color.Green;
        }
        //iegeytek
        private void button11_Click(object sender, EventArgs e)
        {
            textBox6.Text = "9";
            button11.Enabled = false;
            button11.ForeColor = Color.Green;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox6.Text = "10";//iegeytek
            button12.Enabled = false;
            button12.ForeColor = Color.Green;
        }

        private void button13_Click(object sender, EventArgs e)//iegeytek
        {
            textBox6.Text = "11";//iegeytek
            button13.Enabled = false;
            button13.ForeColor = Color.Green;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox6.Text = "12";
            button14.Enabled = false;
            button14.ForeColor = Color.Green;
        }
        //iegeytek
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("DELETE FROM bilgiler WHERE AdSoyad = ?", baglanti);
                komut.Parameters.AddWithValue("?", textBox4.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();//iegeytek
                goster();
            }
            catch(Exception err)
            {
                MessageBox.Show($"Error: {err.Message}");
            }
        }

        private void button16_Click(object sender, EventArgs e)//iegeytek
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("UPDATE bilgiler SET SeferNo=@SeferNo, Tarih=@Tarih, Saat=@Saat, Telefon=@Telefon, KoltukNo=@KoltukNo, Ucret=@Ucret, Cinsiyet=@Cinsiyet, Binis=@Binis where AdSoyad=@AdSoyad",baglanti);
                komut.Parameters.AddWithValue("@SeferNo", textBox1.Text);
                komut.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@Saat", textBox3.Text);//iegeytek
                komut.Parameters.AddWithValue("@Telefon", textBox5.Text);
                komut.Parameters.AddWithValue("@KoltukNo", textBox6.Text);
                komut.Parameters.AddWithValue("@Ucret", textBox7.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text.ToString());
                komut.Parameters.AddWithValue("@Binis", comboBox2.Text.ToString());
                komut.Parameters.AddWithValue("@AdSoyad", textBox4.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                goster();
            }
            catch(Exception err)
            {//iegeytek
                MessageBox.Show($"Error: {err.Message}");
                baglanti.Close();
            }
        }
    }
}//iegeytek

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p23Listeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnListele1_Click(object sender, EventArgs e)
        {
            List<string> karakterler = new List<string>();
            karakterler.Add("Mazhar");
            karakterler.Add("Fuat");
            karakterler.Add("Özkan");
            karakterler.Add("Cem");
            karakterler.Add("Esra");
            karakterler.Add("Reyhan");
            karakterler.Add("Firdevs");

            karakterler.Remove("Cem");

            foreach (string k in karakterler)
            {
                listBox1.Items.Add(k);
            }

        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(23);
            sayilar.Add(25);
            sayilar.Add(90);
            sayilar.Add(22);
            sayilar.Add(63);
            sayilar.Add(15);

            int kontroledileceksayi;
            kontroledileceksayi = Convert.ToInt16(textBox1.Text);

            if (sayilar.Contains(kontroledileceksayi))
            {
                MessageBox.Show("VAR");
            }
            else
            {
                MessageBox.Show("Yok");
            }
        }

        private void btnListele3_Click(object sender, EventArgs e)
        {
            List<kisiler> kisi = new List<kisiler>();
            kisi.Add(new kisiler()
            {
                ADI="Ali",
                Soyad="Çınar",
                Meslek="Öğretmen"
            });     

            foreach(kisiler k in kisi)
            {
                listBox3.Items.Add(k.ADI+" "+k.Soyad+" "+k.Meslek);
            }
        }

        private void btnListele4_Click(object sender, EventArgs e)
        {
            string marka;
            string model;
            string ulke;

            marka=textBox2.Text.ToString();
            model=textBox3.Text.ToString();
            ulke =textBox4.Text.ToString();

            List<araba> arabalar  = new List<araba>();
            arabalar.Add(new araba()
            {
                markasi = marka,
                modeli = model,
                ulkesi = ulke,
            });

            foreach(araba a in arabalar)
            {
                listBox4.Items.Add(marka + " " + model + " " + ulke);
            }
        }
    }
}

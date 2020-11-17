using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("KİŞİ BİLGİLERİ || Adı-Soyadı: "+textBox1.Text+" "+textBox1.Text+" | "+" Cep Telefonu: "+maskedTextBox1.Text+" | "+" E-mail: "+textBox3.Text);
            listBox1.Items.Add("ODA BİLGİLERİ || Kat: " + comboBox2.Text + " | " + " Oda: " + comboBox1.Text + " | " + " Yatak Sayısı: " + comboBox3.Text + " | " + " Cephe: " + comboBox4.Text);
            listBox1.Items.Add("ÖDEME BİLGİLERİ || Giriş Tarihi: " + maskedTextBox2.Text + " | " + " Çıkış Tarihi: " + maskedTextBox3.Text + " | " + " Günlük Ücret: " + textBox4.Text + " | " + " Tutar: " + textBox5.Text);
            listBox1.Items.Add("-------------------------------------------------------------------");

            if (comboBox1.Text=="1")
            {
                btn1.Enabled = true;
                btn1.BackColor = Color.Red;
                
            }
            if (comboBox1.Text == "2")
            {
                btn2.Enabled = true;
                btn2.BackColor = Color.Red;
            }
            if (comboBox1.Text == "3")
            {
                btn3.Enabled = true;
                btn3.BackColor = Color.Red;
            }
            if (comboBox1.Text == "4")
            {
                btn4.Enabled = true;
                btn4.BackColor = Color.Red;
            }
            if (comboBox1.Text == "5")
            {
                btn5.Enabled = true;
                btn5.BackColor = Color.Red;
            }
            if (comboBox1.Text == "6")
            {
                btn6.Enabled = true;
                btn6.BackColor = Color.Red;
            }
            if (comboBox1.Text == "7")
            {
                btn7.Enabled = true;
                btn7.BackColor = Color.Red;
            }
            if (comboBox1.Text == "8")
            {
                btn8.Enabled = true;
                btn8.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
            {
                btn1.Enabled = false;
                btn1.BackColor = Color.Green;

            }
            if (comboBox1.Text == "2")
            {
                btn2.Enabled = false;
                btn2.BackColor = Color.Green;
            }
            if (comboBox1.Text == "3")
            {
                btn3.Enabled = false;
                btn3.BackColor = Color.Green;
            }
            if (comboBox1.Text == "4")
            {
                btn4.Enabled = false;
                btn4.BackColor = Color.Green;
            }
            if (comboBox1.Text == "5")
            {
                btn5.Enabled = false;
                btn5.BackColor = Color.Green;
            }
            if (comboBox1.Text == "6")
            {
                btn6.Enabled = false;
                btn6.BackColor = Color.Green;
            }
            if (comboBox1.Text == "7")
            {
                btn7.Enabled = false;
                btn7.BackColor = Color.Green;
            }
            if (comboBox1.Text == "8")
            {
                btn8.Enabled = false;
                btn8.BackColor = Color.Green;
            }
        }
    }
}

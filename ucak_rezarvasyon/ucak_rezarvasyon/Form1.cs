using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucak_rezarvasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden: " + comboBox_nereden.Text + "  -->  " + comboBox_nereye.Text + " Tarih:  " + dateTimePicker_Tarih.Text+" Saat:  " +maskedTextBox_saat.Text+" Yolcu Bilgileri // Ad Soyad:"+textBox1_adsoyad.Text+" T.C Kimlik: "+maskedTextBox_tckimlik.Text+" Telefon No: "+maskedTextBox_telefn.Text );
            MessageBox.Show("Yolcu Kaydı Yapıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox_nereye.Text;
            comboBox_nereye.Text = comboBox_nereden.Text;
            comboBox_nereden.Text = label9.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesafe_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Saat, Hiz, Mesafe;
        private void button1Hesaplama_Click(object sender, EventArgs e)
        {
            if (textBox1Mesafe.Text != "" && textBox2Hiz.Text != "")
            {
                Mesafe = Convert.ToDouble(textBox1Mesafe.Text);
                Hiz = Convert.ToDouble(textBox2Hiz.Text);
                Saat = Mesafe / Hiz;

                label4Saatyaz.Text = Saat.ToString();
            }
            else
            {
                MessageBox.Show("Degerler Boş Geçilemez..!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
    }
}

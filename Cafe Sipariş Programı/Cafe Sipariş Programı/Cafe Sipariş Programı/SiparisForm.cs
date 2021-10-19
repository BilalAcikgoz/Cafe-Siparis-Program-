using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Sipariş_Programı
{
    public partial class SiparisForm : Form
    {
        byte americano = 0;
        byte latte = 0;
        byte mocha = 0;

        public SiparisForm()
        {
            InitializeComponent();
        }

        private void americanoArtirmaButton_Click(object sender, EventArgs e)
        {
            americano++;
            americanoSayisiLabel.Text = Convert.ToString(americano);
        }

        private void americanoAzaltmaButton_Click(object sender, EventArgs e)
        {
            if (americano > 0)
            {
                americano--;
                americanoSayisiLabel.Text = Convert.ToString(americano);
            }    
        }

        private void latteArtirmaButton_Click(object sender, EventArgs e)
        {
            latte++;
            latteSayisiLabel.Text = Convert.ToString(latte);
        }

        private void latteAzaltmaButton_Click(object sender, EventArgs e)
        {
            if (latte > 0)
            {
                latte--;
                latteSayisiLabel.Text = Convert.ToString(latte);
            }
        }

        private void mochaArtirmaButton_Click(object sender, EventArgs e)
        {
            mocha++;
            mochaSayisiLabel.Text = Convert.ToString(mocha);
        }

        private void mochaAzaltmaButton_Click(object sender, EventArgs e)
        {
            if (mocha > 0)
            {
                mocha--;
                mochaSayisiLabel.Text = Convert.ToString(mocha);
            }
        }

        private void sifirlaButton_Click(object sender, EventArgs e)
        {
            americano = 0;
            latte = 0;
            mocha = 0;
            americanoSayisiLabel.Text = "0";
            latteSayisiLabel.Text = "0";
            mochaSayisiLabel.Text = "0";
        }

        private void siparisiTamamlaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SİPARİŞ ÖZETİ: " + americanoSayisiLabel.Text + " Americano " + latteSayisiLabel.Text + " Latte " + mochaSayisiLabel.Text + " Mocha");
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

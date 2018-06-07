using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string liczbaPierwsza, liczbaDruga,wynik;
        char rodzajDzialania=' ';

        private void tbWynik_TextChanged(object sender, EventArgs e)
        {

        }

        private void bDodawanie_Click(object sender, EventArgs e)
        {
            if (liczbaDruga == null)
            {
                rodzajDzialania = '+';
                tbWynik.Text = "";
            }
            else
            {
                liczbaPierwsza = (double.Parse(liczbaPierwsza) + double.Parse(liczbaDruga)).ToString();
                tbWynik.Text = liczbaPierwsza;
                liczbaDruga = null;
            }
        }

        private void bOdejmowanie_Click(object sender, EventArgs e)
        {
            if (liczbaDruga == null)
            {
                rodzajDzialania = '-';
                tbWynik.Text = "";
            }
            else
            {
                liczbaPierwsza = (double.Parse(liczbaPierwsza) - double.Parse(liczbaDruga)).ToString();
                tbWynik.Text = liczbaPierwsza;
                liczbaDruga = null;
            }
        }

        private void bMnozenie_Click(object sender, EventArgs e)
        {
            if (liczbaDruga == null)
            {
                rodzajDzialania = '*';
                tbWynik.Text = "";
            }
            else
            {
                liczbaPierwsza = (double.Parse(liczbaPierwsza) * double.Parse(liczbaDruga)).ToString();
                tbWynik.Text = liczbaPierwsza;
                liczbaDruga = null;
            }
        }

        private void bDzielenie_Click(object sender, EventArgs e)
        {
            if (liczbaDruga == null)
            {
                rodzajDzialania = '/';
                tbWynik.Text = "";
            }
            else
            {
                liczbaPierwsza = (double.Parse(liczbaPierwsza) / double.Parse(liczbaDruga)).ToString();
                tbWynik.Text = liczbaPierwsza;
                liczbaDruga = null;
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void bWynik_Click(object sender, EventArgs e)
        {
            switch (rodzajDzialania)
            {
                case ('+'):
                    wynik = (double.Parse(liczbaPierwsza) + double.Parse(liczbaDruga)).ToString();
                    tbWynik.Text = wynik;
                    break;
                case ('-'):
                    wynik = (double.Parse(liczbaPierwsza) - double.Parse(liczbaDruga)).ToString();
                    tbWynik.Text = wynik;
                    break;
                case ('*'):
                    wynik = (double.Parse(liczbaPierwsza) * double.Parse(liczbaDruga)).ToString();
                    tbWynik.Text = wynik;
                    break;
                case ('/'):
                    if (liczbaDruga != "0")
                    {
                        wynik = (double.Parse(liczbaPierwsza) / double.Parse(liczbaDruga)).ToString();
                        tbWynik.Text = wynik;
                    }
                    else
                    {
                        tbWynik.Text = "Nie można dzielić przez 0";
                    }
                    break;
            }
            liczbaPierwsza = wynik;
            liczbaDruga = null;
            rodzajDzialania = ' ';
        }

        private void bCzysc_Click(object sender, EventArgs e)
        {
            liczbaPierwsza = null;
            liczbaDruga = null;
            wynik = null;
            tbWynik.Text = " ";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }

        public void Dzialanie(int liczba)
        {
            if (rodzajDzialania == ' ')
            {
                liczbaPierwsza += liczba;
                tbWynik.Text = liczbaPierwsza;
            }
            else
            {
                liczbaDruga += liczba;
                tbWynik.Text = liczbaDruga;
            }
        }
    }
}

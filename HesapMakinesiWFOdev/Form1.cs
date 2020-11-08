using HesapMakinesiWFOdev.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiWFOdev
{
    public partial class Form1 : Form
    {
        Sayi sayi1;
        Sayi sayi2; 
        HesapMakinesi islem;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void bHesapla_Click(object sender, EventArgs e)
        {   
            sayi1 = new Sayi();
            sayi2 = new Sayi();
            if (string.IsNullOrWhiteSpace(tbSayi1.Text) || string.IsNullOrWhiteSpace(tbSayi2.Text))
            {
                MessageBox.Show("Lüfen Sayıları giriniz !", "Sayı Giriniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sayi1.Deger = Convert.ToDouble(tbSayi1.Text);
                sayi2.Deger = Convert.ToDouble(tbSayi2.Text);
                double S1 = sayi1.Deger;
                double S2 = sayi2.Deger;
                double sonuc = 0;
                islem = new HesapMakinesi();
                islem.Islem = cbIslem.Text;
                switch (islem.Islem)
                {
                    case "+":
                        sonuc = S1 + S2;
                        break;
                    case "-":
                        sonuc = S1 - S2;
                        break;
                    case "*":
                        sonuc = S1 * S2;
                        break;
                    case "/":
                        sonuc = S1 / S2;
                        break;
                    case "%":
                        sonuc = S1 % S2;
                        break;
                    case "^":
                        sonuc = Math.Pow(S1, S2);
                        break;
                    case "^(1/2)":
                        sonuc = Math.Pow(S1, 1 / S2);
                        break;
                    default:
                        MessageBox.Show("Lütfen işlem seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                }

                lbSonuc.Items.Add(sonuc);
            }
        }
    }
}

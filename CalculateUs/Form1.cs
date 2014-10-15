using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateUs
{
    public partial class frmCalculate : Form 
    {

        // int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; // convert ederken sorun
        string[] sayilar = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "00"};
        bool durum = false;
        functions fonksiyon = new functions();
        public frmCalculate()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            txtekran.Focus();
            txtekran.Select();
            Button myButton = (Button)sender;
            //int say = Array.IndexOf(sayilar, myButton.Text.ToString());
            int say2 = Array.IndexOf(sayilar, Convert.ToInt32("1"));
            //MessageBox.Show(say.ToString()+" / " + say2.ToString() );
            if (Array.IndexOf(sayilar,myButton.Text.ToString(),0,10) != -1)
            {
                if (durum)
                {
                    txtekran.Text = "";
                    txtekran.Text += myButton.Text;
                    durum = false;
                }
                else
                {
                    txtekran.Text += myButton.Text;
                }
                
                
            }
            else
            {
                switch (myButton.Text)
                {
                    case "+": fonksiyon.topla(lbl1, lbl2, lbldurum, txtekran);  durum = true;
                        break;
                    case "-": fonksiyon.cikar(lbl1, lbl2, lbldurum, txtekran); durum = true;
                        break;
                    case "/": fonksiyon.bol(lbl1, lbl2, lbldurum, txtekran); durum = true;
                        break;
                    case "*": fonksiyon.carp(lbl1, lbl2, lbldurum, txtekran); durum = true;
                        break;
                    case "=": fonksiyon.esittir(lbl1, lbl2,lbldurum, txtekran); durum = true;
                        break;
                    case "%": fonksiyon.mod(lbl1, lbl2, lbldurum, txtekran); durum = true;
                        break;
                    case "C": txtekran.Text = "";
                        break;
                    case "CE": txtekran.Text = ""; lbl1.Text = ""; lbl2.Text = ""; lbldurum.Text = ""; lbl1.Visible = false; lbl2.Visible = false; lbldurum.Visible = false;
                        break;
                    case "<--": fonksiyon.sil(txtekran);
                        break;
                    case "00": fonksiyon.ciftsıfır(txtekran);
                        break;
                    case "OFF": Application.Exit();
                        break;
                    case ",": fonksiyon.virgul(txtekran); 
                         break;
                }
                
            }
        }

        private void txtekran_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            switch (e.KeyChar)
            {
                case (char)13: fonksiyon.esittir(lbl1, lbl2, lbldurum, txtekran); durum = true;
                    break;
                case (char)45: fonksiyon.cikar(lbl1, lbl2, lbldurum, txtekran); durum = true;
                    break;
                case (char)43: fonksiyon.topla(lbl1, lbl2, lbldurum, txtekran); durum = true;
                    break;
                case (char)42: fonksiyon.carp(lbl1, lbl2, lbldurum, txtekran); durum = true;
                    break;
                case (char)47: fonksiyon.bol(lbl1, lbl2, lbldurum, txtekran); durum = true;
                    break;
                case (char)37: fonksiyon.mod(lbl1, lbl2, lbldurum, txtekran); durum = true;
                    break;
                case (char)48: tara(e);
                    break;
                case (char)49: tara(e);
                    break;
                case (char)50: tara(e);
                    break;
                case (char)51: tara(e);
                    break;
                case (char)52: tara(e);
                    break;
                case (char)53: tara(e);
                    break;
                case (char)54: tara(e);
                    break;
                case (char)55: tara(e);
                    break;
                case (char)56: tara(e);
                    break;
                case (char)57: tara(e);
                    break;
                case (char)8: fonksiyon.sil(txtekran);
                    break;
                case (char)27: Application.Exit();
                    break;
            }
           
        }
        public void tara(KeyPressEventArgs key)
        {
            if (durum)
            {
                txtekran.Text = "";
                txtekran.Text += key.KeyChar.ToString();
                durum = false;
            }
            else
            {
                txtekran.Text += key.KeyChar.ToString();
            }
        }

        private void frmCalculate_Load(object sender, EventArgs e)
        {
            txtekran.Focus();
        }
    }
}

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
    public class functions
    {
        islem islemyap = new islem();
        public void topla(Label lb1, Label lb2, Label lb3, TextBox tx)// toplama fonksiyonu
        {
            lb3.Visible = true;
            if (lb1.Visible == false && tx.Text != "")
            {
                lb1.Text = tx.Text;
                lb1.Visible = true;
                lb3.Text = "+";
            }
            else
            {
                try
                {
                    if (lb2.Visible == true && tx.Text != "")
                    {
                        lb1.Text = lb2.Text;
                        lb2.Text = islemyap.toplam(Convert.ToDouble(lb2.Text), Convert.ToDouble(tx.Text)).ToString();
                        lb3.Text = "+";
                    }
                    else
                    {
                        lb2.Text = islemyap.toplam(Convert.ToDouble(lb1.Text), Convert.ToDouble(tx.Text)).ToString();
                        lb3.Text = "+";
                        lb2.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lb3.Text = "+";

                }
            }
        }
        public void cikar(Label lb1, Label lb2, Label lb3, TextBox tx)
        {
            lb3.Visible = true;
            if (lb1.Visible == false && tx.Text != "")
            {
                lb1.Text = tx.Text;
                lb1.Visible = true;
                lb3.Text = "-";
            }
            else
            {
                try
                {
                    if (lb2.Visible == true && tx.Text != "")
                    {
                        lb1.Text = lb2.Text;
                        lb2.Text = islemyap.cikar(Convert.ToDouble(lb2.Text), Convert.ToDouble(tx.Text)).ToString();
                        lb3.Text = "-";
                    }
                    else
                    {
                        lb2.Text = islemyap.cikar(Convert.ToDouble(lb1.Text), Convert.ToDouble(tx.Text)).ToString();
                        lb3.Text = "-";
                        lb2.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lb3.Text = "-";

                }
            }
        }
        public void carp(Label lb1, Label lb2, Label lb3, TextBox tx)
        {
            lb3.Visible = true;
            if (lb1.Visible == false && tx.Text != "")
            {
                lb1.Text = tx.Text;
                lb1.Visible = true;
                lb3.Text = "*";
            }
            else
            {
                try
                {
                    if (lb2.Visible == true && tx.Text != "")
                    {
                        lb1.Text = lb2.Text;
                        lb2.Text = islemyap.carp(Convert.ToDouble(lb2.Text), Convert.ToDouble(tx.Text)).ToString();
                        lb3.Text = "*";
                    }
                    else
                    {
                        lb2.Text = islemyap.carp(Convert.ToDouble(lb1.Text), Convert.ToDouble(tx.Text)).ToString();
                        lb3.Text = "*";
                        lb2.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lb3.Text = "*";

                }
            }
        }
        public void bol(Label lb1, Label lb2, Label lb3, TextBox tx)
        {
            lb3.Visible = true;
            if (lb1.Visible == false && tx.Text != "")
            {
                lb1.Text = tx.Text;
                lb1.Visible = true;
                lb3.Text = "/";
            }
            else
            {
                try
                {
                    if (lb2.Visible == true && tx.Text != "")
                    {
                        lb1.Text = lb2.Text;
                        lb2.Text = islemyap.bol(Convert.ToDouble(lb2.Text), Convert.ToDouble(tx.Text)).ToString();
                        lb3.Text = "/";
                    }
                    else
                    {
                        lb2.Text = islemyap.bol(Convert.ToDouble(lb1.Text), Convert.ToDouble(tx.Text)).ToString();
                        lb3.Text = "/";
                        lb2.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lb3.Text = "/";

                }
            }
        }
        public void mod(Label lb1, Label lb2, Label lb3, TextBox tx)
        {
            lb3.Visible = true;
            if (lb1.Visible == false && tx.Text != "")
            {
                lb1.Text = tx.Text;
                lb1.Visible = true;
                lb3.Text = "%";
            }
            else
            {
                try
                {
                    if (lb2.Visible == true && tx.Text != "")
                    {
                        lb1.Text = lb2.Text;
                        lb2.Text = islemyap.mod(Convert.ToDecimal(lb2.Text), Convert.ToDecimal(tx.Text)).ToString();
                        lb3.Text = "%";
                    }
                    else
                    {
                        lb2.Text = islemyap.mod(Convert.ToDecimal(lb1.Text), Convert.ToDecimal(tx.Text)).ToString();
                        lb3.Text = "%";
                        lb2.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lb3.Text = "%";

                }
            }
        }
        public void esittir(Label lb1, Label lb2, Label lbdurum, TextBox tx)
        {
            
            try
            {
                if (lbdurum.Text != "" && tx.Text != "")
                {
                    switch (lbdurum.Text)
                    {
                        case "+": topla(lb1,lb2,lbdurum,tx);
                            break;
                        case "-": cikar(lb1, lb2, lbdurum, tx);
                            break;
                        case "*": carp(lb1, lb2, lbdurum, tx);
                            break;
                        case "/": bol(lb1, lb2, lbdurum, tx);
                            break;
                    }
                }
            }
            catch (Exception)
            {

            }

        }
        public void sil(TextBox tx)
        {
            if (tx.Text !="")
            {
                tx.Text = tx.Text.Remove(tx.Text.Length - 1, 1);
            }
            
        }
        public void ciftsıfır(TextBox tx)
        {
            tx.Text += "00";
        }
        public void virgul(TextBox tx)
        {
            if (tx.Text.IndexOf(",") == -1)
            {
                if (tx.Text == "")
                {
                    tx.Text += "0";
                }
                tx.Text += ",";
            }        
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        float num1, ans;
        int count;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tiga_Click(object sender, EventArgs e)
        {
            if (Angka.Text == "0")
            {
                Angka.Clear();
            }
           
            Angka.Text = Angka.Text + 3;
        }

        private void satu_Click(object sender, EventArgs e)
        {
            if (Angka.Text == "0")
            {
                Angka.Clear();
            }
            Angka.Text = Angka.Text + 1;
        }

        private void dua_Click(object sender, EventArgs e)
        {
            if (Angka.Text == "0")
            {
                Angka.Clear();
            }
            Angka.Text = Angka.Text + 2;
        }

        private void empat_Click(object sender, EventArgs e)
        {
            if (Angka.Text == "0")
            {
                Angka.Clear();
            }
            Angka.Text = Angka.Text + 4;
        }

        private void lima_Click(object sender, EventArgs e)
        {
            if (Angka.Text == "0")
            {
                Angka.Clear();
            }
            Angka.Text = Angka.Text + 5;
        }

        private void enam_Click(object sender, EventArgs e)
        {
            if (Angka.Text == "0")
            {
                Angka.Clear();
            }
            Angka.Text = Angka.Text + 6;
        }

        private void tujuh_Click(object sender, EventArgs e)
        {
            if (Angka.Text == "0")
            {
                Angka.Clear();
            }
            Angka.Text = Angka.Text + 7;
            
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            if (Angka.Text == "0")
            {
                Angka.Clear();
            }
            Angka.Text = Angka.Text + 8;
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            if (Angka.Text == "0")
            {
                Angka.Clear();
            }
            Angka.Text = Angka.Text + 9;
        }

        private void nol_Click(object sender, EventArgs e)
        {
            if (Angka.Text == "0")
            {
                Angka.Clear();
            }
            Angka.Text = Angka.Text + 0;
        }

        private void titik_Click(object sender, EventArgs e)
        {
            int c = Angka.TextLength;
            int flag = 0;
            string text = Angka.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1;
                    break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                Angka.Text = Angka.Text + ".";
            }

        }

        private void C_Click(object sender, EventArgs e)
        {
            Angka.Clear();
            Angka.Focus();
            count = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void sin_Click(object sender, EventArgs e)
        {
             double a, b;
             a = Convert.ToDouble(Angka.Text);
             b = Math.Sin(a);
             Angka.Text = Convert.ToString(b);
         
        }

        private void Deg_Click(object sender, EventArgs e)
        {

        }

        private void HYP_Click(object sender, EventArgs e)
        {

        }

        private void MC_Click(object sender, EventArgs e)
        {

        }

        private void MR_Click(object sender, EventArgs e)
        {

        }

        private void Mplus_Click(object sender, EventArgs e)
        {

        }

        private void Mmin_Click(object sender, EventArgs e)
        {

        }

        private void MS_Click(object sender, EventArgs e)
        {

        }

        private void TutupKurung_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void samadengan_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Angka.Text);
            Angka.Clear();
            Angka.Focus();
            count = 2;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            if (num1 == 0 && Angka.TextLength > 0)
            {
                num1 = 0;
                Angka.Clear();
            }
            else if (num1 > 0 && Angka.TextLength > 0)
            {
                Angka.Clear();
            }
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            if (Angka.Text == "-")
            {
                Angka.Text = Angka.Text;
            }
            num1 = float.Parse(Angka.Text);
            Angka.Clear();
            Angka.Focus();
            count = 1;
        }

        private void kali_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Angka.Text);
            Angka.Clear();
            Angka.Focus();
            count = 3;

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            num1 = float.Parse(Angka.Text);
            Angka.Clear();
            Angka.Focus();
            count = 4;
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(Angka.Text);
                    Angka.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(Angka.Text);
                    Angka.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(Angka.Text);
                    Angka.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(Angka.Text);
                    Angka.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

      

        private void Angka_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if (Angka.Text.Length > 0)
            {
                Angka.Text = Angka.Text.Remove(Angka.Text.Length - 1);
            }

        }

        private void centang_Click(object sender, EventArgs e)
        {
            double bil = Math.Sqrt(Convert.ToDouble(Angka.Text));
            Angka.Text = Convert.ToString(bil);

        }

        private void Xpangkat2_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(Angka.Text);
            b = Math.Pow(a, 2);
            Angka.Text = Convert.ToString(b);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(Angka.Text);
            b = Math.Cos(a);
            Angka.Text = Convert.ToString(b);
        }

        private void tan_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(Angka.Text);
            b = Math.Tan(a);
            Angka.Text = Convert.ToString(b);
        }

        private void log_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(Angka.Text);
            b = Math.Log(a);
            Angka.Text = Convert.ToString(b);
        }

        private void Angka_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Angka.Text = "0";
        }

        
       

        
    }
}


      
        

      



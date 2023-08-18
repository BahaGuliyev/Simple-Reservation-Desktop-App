using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervasiya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "994";
        }
        string masa = "";
        string masa_reng_ucun = "";
        private void button10_Click(object sender, EventArgs e)
        {
            if(masa_reng_ucun!="" && textBox1.Text!="" && maskedTextBox1.Text!="")
            { 
            Button secilmis_masa = this.Controls.Find(masa_reng_ucun, true).FirstOrDefault() as Button;
            if (secilmis_masa.BackColor != Color.Green)
            {
                listBox1.Items.Add(masa + ", " + textBox1.Text + ", " + maskedTextBox1.Text);
            }
            secilmis_masa.BackColor = Color.Green;
            secilmis_masa.ForeColor = Color.White;
            }
            else
            {
                MessageBox.Show("Məlumatlar tam daxil edilməyib!");
            }
            textBox1.Clear();
            maskedTextBox1.Clear();
            maskedTextBox1.Text = "994";
        }

        private void masa1_Click(object sender, EventArgs e)
        {
            masa_reng_ucun = masa1.Name;
            masa = masa1.Text;
            label3.Text = "Masa 1-i seçdiniz.";
        }

        private void masa2_Click(object sender, EventArgs e)
        {
            masa_reng_ucun = masa2.Name;
            masa = masa2.Text;
            label3.Text = "Masa 2-ni seçdiniz.";

        }

        private void masa3_Click(object sender, EventArgs e)
        {
            masa_reng_ucun = masa3.Name;
            masa = masa3.Text;
            label3.Text = "Masa 3-ü seçdiniz.";

        }

        private void masa4_Click(object sender, EventArgs e)
        {
            masa_reng_ucun = masa4.Name;
            masa = masa4.Text;
            label3.Text = "Masa 4-ü seçdiniz.";

        }

        private void masa5_Click(object sender, EventArgs e)
        {
            masa_reng_ucun = masa5.Name;
            masa = masa5.Text;
            label3.Text = "Masa 5-i seçdiniz.";
        }

        private void masa6_Click(object sender, EventArgs e)
        {
            masa_reng_ucun = masa6.Name;
            masa = masa6.Text;
            label3.Text = "Masa 6-nı seçdiniz.";

        }

        private void masa7_Click(object sender, EventArgs e)
        {
            masa_reng_ucun = masa7.Name;
            masa = masa7.Text;
            label3.Text = "Masa 7-ni seçdiniz.";

        }

        private void masa8_Click(object sender, EventArgs e)
        {
            masa_reng_ucun = masa8.Name;
            masa = masa8.Text;
            label3.Text = "Masa 8-i seçdiniz.";

        }

        private void masa9_Click(object sender, EventArgs e)
        {
            masa_reng_ucun = masa9.Name;
            masa = masa9.Text;
            label3.Text = "Masa 9-u seçdiniz.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() != "")
            {
                string[] masani_acmaq_ucun = listBox1.SelectedItem.ToString().Split(' ');
                Button acmaq_ucun_btn = this.Controls.Find("masa" + masani_acmaq_ucun[1].Trim(','), true).FirstOrDefault() as Button;
                acmaq_ucun_btn.BackColor = Color.Ivory;
                acmaq_ucun_btn.ForeColor = Color.Black;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Silmək üçün masa seçin");
            }
        }
    }
}

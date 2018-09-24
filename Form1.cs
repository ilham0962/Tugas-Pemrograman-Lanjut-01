using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a   = int.Parse(txtnilaia.Text);
            var b = Convert.ToInt32(txtnilaib.Text);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                        txthasil.Text =Penambahan(a,b).ToString();
                    break;
                case 1:
                    txthasil.Text = Pengurangan(a, b).ToString();
                    break;
                case 2:
                    txthasil.Text = Perkalian(a, b).ToString();
                    break;
                case 3:
                    txthasil.Text = Pembagian(a, b).ToString();
                    break;
            }
        }
        private int Penambahan(int a,int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}

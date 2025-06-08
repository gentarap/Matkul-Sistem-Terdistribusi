using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWcf_22SA11A116
{
    public partial class Form1: Form
    {
        wcfService.CalculatorClient myservice;
        double hasil;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myservice = new wcfService.CalculatorClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hasil = myservice.tambah(int.Parse(txtA.Text), int.Parse(txtB.Text));
            txtHasil.Text = hasil.ToString();
        }

        private void buttonkurang_Click(object sender, EventArgs e)
        {
            hasil = myservice.kurang(int.Parse(txtA.Text), int.Parse(txtB.Text));
            txtHasil.Text = hasil.ToString();
        }

        private void buttonkali_Click(object sender, EventArgs e)
        {
            hasil = myservice.kali(int.Parse(txtA.Text), int.Parse(txtB.Text));
            txtHasil.Text = hasil.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hasil = myservice.bagi(int.Parse(txtA.Text), int.Parse(txtB.Text));
            txtHasil.Text = hasil.ToString();
        }
    }
}

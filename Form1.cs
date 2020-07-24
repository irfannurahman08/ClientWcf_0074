using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWcf_0074
{
    public partial class Form1 : Form
    {
        wcfService.CalculatorClient myservice;
        double hasil;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myservice = new wcfService.CalculatorClient();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            hasil = myservice.tambah(int.Parse(textBoxA.Text), int.Parse(textBoxB.Text));
            textBoxHasil.Text = hasil.ToString();
        }

        private void buttonKurang_Click(object sender, EventArgs e)
        {
            hasil = myservice.kurang(int.Parse(textBoxA.Text), int.Parse(textBoxB.Text));
            textBoxHasil.Text = hasil.ToString();
        }

        private void buttonKali_Click(object sender, EventArgs e)
        {

            hasil = myservice.kali(int.Parse(textBoxA.Text), int.Parse(textBoxB.Text));
            textBoxHasil.Text = hasil.ToString();
        }

        private void buttonBagi_Click(object sender, EventArgs e)
        {

            hasil = myservice.bagi(int.Parse(textBoxA.Text), int.Parse(textBoxB.Text));
            textBoxHasil.Text = hasil.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUDWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSupplier supplier = new FormSupplier();
            supplier.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBarang barang = new FormBarang();
            barang.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPembeli pembeli = new FormPembeli();
            pembeli.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTransaksi transaksi = new FormTransaksi();
            transaksi.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPembayaran pembayaran = new FormPembayaran();
            pembayaran.Show();
            this.Hide();
        }
    }
}

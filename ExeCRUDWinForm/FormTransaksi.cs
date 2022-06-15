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
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pet_ShopDataSet1.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.pet_ShopDataSet1.Transaksi);

        }
    }
}

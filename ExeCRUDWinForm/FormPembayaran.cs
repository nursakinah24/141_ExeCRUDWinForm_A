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
    public partial class FormPembayaran : Form
    {
        public FormPembayaran()
        {
            InitializeComponent();
        }

        private void FormPembayaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pet_ShopDataSet1.Pembayaran' table. You can move, or remove it, as needed.
            this.pembayaranTableAdapter.Fill(this.pet_ShopDataSet1.Pembayaran);
            // TODO: This line of code loads data into the 'pet_ShopDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.pet_ShopDataSet.Supplier);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }
    }
}

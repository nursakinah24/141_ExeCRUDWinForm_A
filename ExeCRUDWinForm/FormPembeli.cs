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
    public partial class FormPembeli : Form
    {
        public FormPembeli()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void FormPembeli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pet_ShopDataSet1.Pembeli' table. You can move, or remove it, as needed.
            this.pembeliTableAdapter.Fill(this.pet_ShopDataSet1.Pembeli);

        }
    }
}

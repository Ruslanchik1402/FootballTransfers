using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransfers111
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Zadacha1_1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            this.zapr1TableAdapter.Fill(myTransfers1DataSet.Zapr1, "");
            this.Text = "Запрос на основании объекта TableAdapter";
        }        private void btnFill_Click(object sender, EventArgs e)
        {
            string club = Convert.ToString(txtClub.Text);
            this.zapr1TableAdapter.Fill(myTransfers1DataSet.Zapr1, club);
        }
    }
}

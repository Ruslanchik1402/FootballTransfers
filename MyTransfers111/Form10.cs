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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTransfers1DataSet.Zapr3". При необходимости она может быть перемещена или удалена.
            this.zapr3TableAdapter.Fill(this.myTransfers1DataSet.Zapr3);

        }


        private void Zadacha3_1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            this.zapr3TableAdapter.Fill(myTransfers1DataSet.Zapr3);
            this.Text = "Запрос на основании объекта TableAdapter";
        }
    }
}

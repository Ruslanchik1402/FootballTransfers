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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTransfers1DataSet.Zapr4". При необходимости она может быть перемещена или удалена.
            this.zapr4TableAdapter.Fill(this.myTransfers1DataSet.Zapr4);

        }

        private void Zadacha4_1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            this.zapr4TableAdapter.Fill(myTransfers1DataSet.Zapr4);
            this.Text = "Запрос на основании объекта TableAdapter";
        }
    }
}

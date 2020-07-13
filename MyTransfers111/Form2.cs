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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTransfers1DataSet.PlayersList". При необходимости она может быть перемещена или удалена.
            this.playersListTableAdapter.Fill(this.myTransfers1DataSet.PlayersList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTransfers1DataSet.ClubsList". При необходимости она может быть перемещена или удалена.
            this.clubsListTableAdapter.Fill(this.myTransfers1DataSet.ClubsList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTransfers1DataSet.ClubAfillation". При необходимости она может быть перемещена или удалена.
            this.clubAfillationTableAdapter.Fill(this.myTransfers1DataSet.ClubAfillation);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "Связь")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = clubAfillationBindingSource;
                bindingNavigator1.BindingSource = clubAfillationBindingSource;
                lblTableName.Text = "Связь";
            }
        }        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "Клубы")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = clubsListBindingSource;
                bindingNavigator1.BindingSource = clubsListBindingSource;
                lblTableName.Text = "Клубы";
            }
        }        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "Игроки")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = playersListBindingSource;
                bindingNavigator1.BindingSource = playersListBindingSource;
                lblTableName.Text = "Игроки";
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tableAdapterManager1.UpdateAll(myTransfers1DataSet);
            MessageBox.Show("Изменения сохранены");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Удалить элемент?",
        "Сообщение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                int a = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
            }
            else
            {
                this.TopMost = true;
            }
            this.TopMost = true;
        }

        private void btnINS_Click(object sender, EventArgs e)
        {
            int nRow = dataGridView1.CurrentCell.RowIndex;
            int nCol = dataGridView1.CurrentCell.ColumnIndex;
            dataGridView1.CurrentCell = dataGridView1[nCol, dataGridView1.RowCount - 1];
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}

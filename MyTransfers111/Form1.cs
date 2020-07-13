using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransfers111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTransfers1DataSet.PlayersList". При необходимости она может быть перемещена или удалена.
            this.playersListTableAdapter.Fill(this.myTransfers1DataSet.PlayersList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTransfers1DataSet.ClubsList". При необходимости она может быть перемещена или удалена.
            this.clubsListTableAdapter.Fill(this.myTransfers1DataSet.ClubsList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTransfers1DataSet.ClubAfillation". При необходимости она может быть перемещена или удалена.
            this.clubAfillationTableAdapter.Fill(this.myTransfers1DataSet.ClubAfillation);

        }

        private void cLUBAFILLATIONdataGridView_Click(object sender,
EventArgs e)
        {
            bindingNavigator1.BindingSource = clubAfillationBindingSource;
            this.dataGridView2.DataSource = bindingSource2;
            this.dataGridView3.DataSource = bindingSource1;
            lblTable.Text = "Связь игрока и клуба";
           
        }
        private void cLUBSLISTdataGridView_Click(object sender, EventArgs
        e)
        {
            bindingNavigator1.BindingSource = clubsListBindingSource;
            this.dataGridView2.DataSource = clubsListBindingSource;
            lblTable.Text = "Клубы";
            
        }
        private void pLAYERSdataGridView_Click(object sender, EventArgs
        e)
        {

            dataGridView3.DataSource = playersListBindingSource;
            this.dataGridView3.DataSource = playersListBindingSource;
            lblTable.Text = "Игроки";
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int nRow = dataGridView3.CurrentCell.RowIndex;
            int nCol = dataGridView3.CurrentCell.ColumnIndex;
            if (nRow < dataGridView3.RowCount - 1)
                dataGridView3.CurrentCell = dataGridView3[nCol, ++nRow];
        }        private void btnPrev_Click(object sender, EventArgs e)
        {
            int nRow = dataGridView3.CurrentCell.RowIndex;
            int nCol = dataGridView3.CurrentCell.ColumnIndex;
            if (nRow > 0)
                dataGridView3.CurrentCell = dataGridView3[nCol, --nRow];
        }        private void btnFirst_Click(object sender, EventArgs e)
        {
            int nRow = dataGridView3.CurrentCell.RowIndex;
            int nCol = dataGridView3.CurrentCell.ColumnIndex;
            dataGridView3.CurrentCell = dataGridView3[nCol, 0];
        }      
        private void dataGridView3_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentCell != null)
            { //если существует выбранная ячейка
                int nRow = dataGridView3.CurrentCell.RowIndex;
                //первая строка
                if (nRow == 0)
                {
                    btnPrev.Enabled = false;
                    btnFirst.Enabled = false;
                }
                else
                {
                    btnPrev.Enabled = true;
                    btnFirst.Enabled = true;
                }
                //последняя строка
                if (nRow == dataGridView3.RowCount - 1)
                {
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }
            }
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
                int a = dataGridView3.CurrentRow.Index;
                dataGridView3.Rows.Remove(dataGridView3.Rows[a]);
            }
            this.TopMost = true;
        }

        private void btnINS_Click(object sender, EventArgs e)
        {
            int nRow = dataGridView3.CurrentCell.RowIndex;
            int nCol = dataGridView3.CurrentCell.ColumnIndex;
            dataGridView3.CurrentCell = dataGridView3[nCol, dataGridView3.RowCount - 1];
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int nRow = dataGridView3.CurrentCell.RowIndex;
            int nCol = dataGridView3.CurrentCell.ColumnIndex;
            dataGridView3.CurrentCell = dataGridView3[nCol, dataGridView3.RowCount - 2];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //сохранение данных
            this.playersListTableAdapter.Update(this.myTransfers1DataSet.PlayersList);
            //обновление данных из источника
            this.playersListTableAdapter.Fill(this.myTransfers1DataSet.PlayersList);
            //обновление состояния навигатора
            this.dataGridView3_CurrentCellChanged(dataGridView3, e);
        }        private void btnSave1_Click(object sender, EventArgs e)
        {
            //сохранение данных
            this.clubAfillationTableAdapter.Update(this.myTransfers1DataSet.ClubAfillation);
            //обновление данных из источника
            this.clubAfillationTableAdapter.Fill(this.myTransfers1DataSet.ClubAfillation);
            //обновление состояния навигатора
            //сохранение данных
            this.clubsListTableAdapter.Update(this.myTransfers1DataSet.ClubsList);
            //обновление данных из источника
            this.clubsListTableAdapter.Fill(this.myTransfers1DataSet.ClubsList);
            //обновление состояния навигатора
            this.playersListTableAdapter.Update(this.myTransfers1DataSet.PlayersList);
            //обновление данных из источника
            this.playersListTableAdapter.Fill(this.myTransfers1DataSet.PlayersList);
            //обновление состояния навигатора
        }        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            //обновление данных из источника
            this.clubAfillationTableAdapter.Fill(this.myTransfers1DataSet.ClubAfillation);
        }        private void btnSave2_Click(object sender, EventArgs e)
        {
            //сохранение данных
            this.clubsListTableAdapter.Update(this.myTransfers1DataSet.ClubsList);
            //обновление данных из источника
            this.clubsListTableAdapter.Fill(this.myTransfers1DataSet.ClubsList);
            //обновление состояния навигатора
        }        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            //обновление данных из источника iDDataGridViewTextBoxColumn
            this.clubsListTableAdapter.Fill(this.myTransfers1DataSet.ClubsList);
        }        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (dataGridView2.Columns[e.ColumnIndex].Name == "iDDataGridViewTextBoxColumn")
                    if (Convert.ToInt32(e.FormattedValue) < 0)
                        throw new Exception("Код клуба не может быть отрицательным");
                if (dataGridView2.Columns[e.ColumnIndex].Name == "numofplayersDataGridViewTextBoxColumn")
                    if (Convert.ToInt32(e.FormattedValue) < 0)
                        throw new Exception("Число игроков не может быть отрицательным");
                if (dataGridView2.Columns[e.ColumnIndex].Name == "stadium_capacityDataGridViewTextBoxColumn")
                    if (Convert.ToInt32(e.FormattedValue) < 0)
                        throw new Exception("Вместительность стадиона не может быть отрицательным");
            }
            catch (Exception a)
            {
                e.Cancel = true;
            MessageBox.Show(a.Message);
                dataGridView2.Rows[e.RowIndex].ErrorText = a.Message;
            }
        }        private void dataGridView3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (dataGridView3.Columns[e.ColumnIndex].Name == "iDDataGridViewTextBoxColumn1")
                    if (Convert.ToInt32(e.FormattedValue) < 0)
                        throw new Exception("Код игрока не может быть отрицательным");
                if (dataGridView3.Columns[e.ColumnIndex].Name == "birthdateDataGridViewTextBoxColumn")
                    if (Convert.ToDateTime(e.FormattedValue) >= Convert.ToDateTime("01.01.2001") || Convert.ToDateTime(e.FormattedValue) <= Convert.ToDateTime("01.01.1980"))
                        throw new Exception("Игрок должен иметь адекватный возраст");
                if (dataGridView3.Columns[e.ColumnIndex].Name == "is_natteam_playerDataGridViewTextBoxColumn")
                    if (Convert.ToInt32(e.FormattedValue)!=1 || Convert.ToInt32(e.FormattedValue) != 0)
                        throw new Exception("Признак имеет значения 1 или 0");
            }
            catch (Exception a)
            {
                e.Cancel = true;
                MessageBox.Show(a.Message);
                dataGridView3.Rows[e.RowIndex].ErrorText = a.Message;
            }
        }        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //обновление данных из источника
            this.playersListTableAdapter.Fill(myTransfers1DataSet.PlayersList);
            //обновление состояния навигатора
            this.dataGridView3_CurrentCellChanged(dataGridView3, e);
        }
        private void btnSProc_Click(object sender, EventArgs e)
        {
            try
            {
                String club = dataGridView2.CurrentRow.Cells["clubnameDataGridViewTextBoxColumn"].Value.ToString();
                SqlConnection con = new SqlConnection();
                con.ConnectionString =  Properties.Settings.Default.MyTransfers1ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getmaxsalaryofclub1337";
                SqlParameter param = new SqlParameter("@SumKol", SqlDbType.Money);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.Parameters.Add(new SqlParameter("@Club", club));
                con.Open();
                cmd.ExecuteNonQuery();
                string kolvo = cmd.Parameters["@SumKol"].Value.ToString();
                con.Close();
                lblSalary.Text = kolvo + " - максимальный контракт в клубе " + club;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSProc1_Click(object sender, EventArgs e)
        {
            try
            {
                String club = dataGridView2.CurrentRow.Cells["clubnameDataGridViewTextBoxColumn"].Value.ToString();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.MyTransfers1ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getmaxsalaryofclub1337_cursor";
                SqlParameter param = new SqlParameter("@SumKol", SqlDbType.Money);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.Parameters.Add(new SqlParameter("@Club", club));
                con.Open();
                cmd.ExecuteNonQuery();
                string kolvo = cmd.Parameters["@SumKol"].Value.ToString();
                con.Close();
                lblSalary.Text = kolvo + " - максимальный контракт в клубе " + club;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void альтернативнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Zapr1_1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Zapr1_2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Zapr1_3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void Zapr1_4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void Zapr1_5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void Zapr2_1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void Zapr2_2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void Zapr3_1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void Zapr3_2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void Zapr4_1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void Zapr4_2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }

        private void Zapr4_3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
        }
    }
}

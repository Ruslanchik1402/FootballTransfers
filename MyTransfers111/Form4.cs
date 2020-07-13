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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            string club = Convert.ToString(txtClub.Text);
            this.zapr1TableAdapter.Fill(myTransfers1DataSet.Zapr1, club);
        }


        private void Zadacha1_2_Load(object sender, EventArgs e)
        {
            this.playersListTableAdapter1.Fill(this.myTransfers1DataSet.PlayersList);
            this.clubsListTableAdapter1.Fill(this.myTransfers1DataSet.ClubsList);
            this.clubAfillationTableAdapter1.Fill(this.myTransfers1DataSet.ClubAfillation);
            //Заполним данными таблицы в датасете
            QueryZapr1();
        }
        public void QueryZapr1()
        {
            myTransfers1DataSet.Zapr1.Clear();
            foreach (MyTransfers1DataSet.ClubsListRow rRow in myTransfers1DataSet.ClubsList.Rows)
            {
                if (rRow.clubname == Convert.ToString(txtClub.Text))
                {
                    foreach (MyTransfers1DataSet.PlayersListRow pRow in myTransfers1DataSet.PlayersList.Rows)
                    {
                        if (pRow.countryoforigin == "Российская Федерация")
                        {
                            foreach (MyTransfers1DataSet.ClubAfillationRow caRow in myTransfers1DataSet.ClubAfillation.Rows)
                            {
                                if ((rRow.ID == caRow.ID_club) && (pRow.ID == caRow.ID_player))
                                {
                                    MyTransfers1DataSet.Zapr1Row zRow = myTransfers1DataSet.Zapr1.NewZapr1Row();
                                    zRow.name = pRow.name;
                                    zRow.surname = pRow.surname;
                                    zRow.ID = pRow.ID;
                                    myTransfers1DataSet.Zapr1.AddZapr1Row(zRow);
                                }
                            }
                        }
                    }

                }

            }
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtClub_TextChanged(object sender, EventArgs e)
        {

        }

        private void zapr1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

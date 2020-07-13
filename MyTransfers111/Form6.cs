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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            string club = Convert.ToString(txtClub.Text);
            this.zapr1TableAdapter.Fill(myTransfers1DataSet.Zapr1, club);
        }


        private void Zadacha1_4_Load(object sender, EventArgs e)
        {
            this.playersListTableAdapter1.Fill(this.myTransfers1DataSet.PlayersList);
            this.clubsListTableAdapter1.Fill(this.myTransfers1DataSet.ClubsList);
            this.clubAfillationTableAdapter1.Fill(this.myTransfers1DataSet.ClubAfillation);
            //Заполним данными таблицы в датасете
            QueryZapr3();
        }



        private void QueryZapr3()
        {
            myTransfers1DataSet.Zapr1.Clear();
            foreach (MyTransfers1DataSet.ClubsListRow rRow in myTransfers1DataSet.ClubsList.Rows)
            {
                if (rRow.clubname == Convert.ToString(txtClub.Text))
                {
                    foreach (MyTransfers1DataSet.ClubAfillationRow aRow in myTransfers1DataSet.ClubAfillation.Rows)
                    {
                        if (rRow.ID == aRow.ID_club)
                        {
                            MyTransfers1DataSet.PlayersListRow pRow = aRow.GetParentRow("FK_ClubAfillation_PlayersList") as MyTransfers1DataSet.PlayersListRow;
                            if (pRow.countryoforigin == "Российская Федерация")
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
            dataGridView1.Refresh();
        }
    }
}

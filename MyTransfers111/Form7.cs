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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            string club = Convert.ToString(txtClub.Text);
            this.zapr1TableAdapter.Fill(myTransfers1DataSet.Zapr1, club);
        }


        private void Zadacha1_5_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            FillGridByReader();
        }


        private void FillGridByReader()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MyTransfers1ConnectionString);
            // создаем объект связь с бд, строку соединения берём из
            // свойств проекта, можно задать самим строкой
            con.Open();
            // подключаемся к бд
            String str = "Select PlayersList.name, PlayersList.surname, PlayersList.ID FROM PlayersList,ClubsList,ClubAfillation Where PlayersList.ID=ClubAfillation.ID_Player AND ClubsList.ID=ClubAfillation.ID_Club AND PlayersList.countryoforigin=\"Российская Федерация\" AND ClubsList.clubname=" + txtClub.Text;

            // задаем текст запроса, добавляем текст из txtKolvo
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            // создали команду и выполнили метод ExecuteReader

            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            // при помощи ридера заполнили таблицу и закрыли
            // соединение с бд

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            // программно создали объект BindingSource и связали
            // его с таблицей, далее грид и навигатор укажем на
            // него для связи с таблицей

            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }
    }
}

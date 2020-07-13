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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTransfers1DataSet.Zapr3". При необходимости она может быть перемещена или удалена.
            this.zapr3TableAdapter.Fill(this.myTransfers1DataSet.Zapr3);

        }

        private void Zadacha3_2_Load(object sender, EventArgs e)
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
            String str = "select clubname, ID from ClubsList group by clubname, ID Having clubname not in (Select ClubsList.clubname from PlayersList, ClubAfillation, ClubsList Where (PlayersList.birthdate>='1999-12-18' or PlayersList.birthdate<='1989-12-18') and ClubsList.ID=ClubAfillation.ID_club and PlayersList.ID=ClubAfillation.ID_player)";

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

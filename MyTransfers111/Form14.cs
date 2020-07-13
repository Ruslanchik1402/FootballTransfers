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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        private void Zapr4_Click(object sender, EventArgs e)

        { Zapr4_CS(); }

        private void Zapr4_SQL()
        {
            zapr4TableAdapter.Fill(myTransfers1DataSet.Zapr4);
            dataGridView1.DataSource = zapr4BindingSource;
        }

        private void Zapr4_CS()
        {

            Dictionary<String, decimal> map = new Dictionary<string, decimal>();
            clubAfillationSORTTableAdapter1.Fill(myTransfers1DataSet.ClubAfillationSORT);
            myTransfers1DataSet.Zapr4.Clear();
            int sum = 0, kod = -1;
            MyTransfers1DataSet.Zapr4Row zRow = null;
            foreach (MyTransfers1DataSet.ClubAfillationSORTRow s in myTransfers1DataSet.ClubAfillationSORT.Rows)
            {

                if (zRow == null)
                {
                    if(Convert.ToDateTime(s.dateofsigning)>=Convert.ToDateTime("01.01.2017") && Convert.ToDateTime(s.dateofsigning) <= Convert.ToDateTime("31.12.2017"))
                    kod = s.ID_club;
                    zRow = myTransfers1DataSet.Zapr4.NewZapr4Row();
                    sum+=Convert.ToInt32(s.totalsalary);
                }

                else if (kod == s.ID_club)
                {
                    sum += Convert.ToInt32(s.totalsalary); ;
                }
                else
                {
                    if (sum > 0)
                    {
                        zRow.clubname = myTransfers1DataSet.ClubsList.FindByID(kod).clubname;
                        zRow.summarysalary = sum;
                        map.Add(zRow.clubname, zRow.summarysalary);
                    }
                    sum = 1;
                    kod = s.ID_club;
                    zRow = myTransfers1DataSet.Zapr4.NewZapr4Row();
                }

            }
            if (zRow != null && sum > 0)
            {
                zRow.clubname = myTransfers1DataSet.ClubsList.FindByID(kod).clubname;
                zRow.summarysalary = sum;
                map.Add(zRow.clubname, zRow.summarysalary);
            }

            foreach (MyTransfers1DataSet.ClubsListRow n in myTransfers1DataSet.ClubsList.Rows)
            {

                decimal val = 0;

                if (map.TryGetValue(n.clubname, out val))
                {
                    zRow = myTransfers1DataSet.Zapr4.NewZapr4Row();
                    zRow.clubname = n.clubname;
                    zRow.summarysalary = val;
                    myTransfers1DataSet.Zapr4.Rows.Add(zRow);
                }

                else
                {
                    zRow = myTransfers1DataSet.Zapr4.NewZapr4Row();
                    zRow.clubname = n.clubname;
                    zRow.summarysalary = 0;
                    myTransfers1DataSet.Zapr4.Rows.Add(zRow);
                }

            }

            dataGridView1.DataSource = zapr4BindingSource;

            dataGridView1.Refresh();

        }

    }
}


﻿using System;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTransfers1DataSet.Zapr2". При необходимости она может быть перемещена или удалена.
            this.zapr2TableAdapter.Fill(this.myTransfers1DataSet.Zapr2);

        }

        private void Zadacha1_1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            this.zapr2TableAdapter.Fill(myTransfers1DataSet.Zapr2);
            this.Text = "Запрос на основании объекта TableAdapter";
        }
    }
}

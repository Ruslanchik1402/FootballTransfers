namespace MyTransfers111
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtClub = new System.Windows.Forms.TextBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zapr1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myTransfers1DataSet = new MyTransfers111.MyTransfers1DataSet();
            this.zapr1TableAdapter = new MyTransfers111.MyTransfers1DataSetTableAdapters.Zapr1TableAdapter();
            this.clubAfillationTableAdapter1 = new MyTransfers111.MyTransfers1DataSetTableAdapters.ClubAfillationTableAdapter();
            this.clubsListTableAdapter1 = new MyTransfers111.MyTransfers1DataSetTableAdapters.ClubsListTableAdapter();
            this.playersListTableAdapter1 = new MyTransfers111.MyTransfers1DataSetTableAdapters.PlayersListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapr1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTransfers1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClub
            // 
            this.txtClub.Location = new System.Drawing.Point(225, 22);
            this.txtClub.Name = "txtClub";
            this.txtClub.Size = new System.Drawing.Size(124, 20);
            this.txtClub.TabIndex = 11;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(389, 20);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(99, 23);
            this.btnFill.TabIndex = 10;
            this.btnFill.Text = "Выполнить";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zapr1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(225, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(264, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // zapr1BindingSource
            // 
            this.zapr1BindingSource.DataMember = "Zapr1";
            this.zapr1BindingSource.DataSource = this.myTransfers1DataSet;
            // 
            // myTransfers1DataSet
            // 
            this.myTransfers1DataSet.DataSetName = "MyTransfers1DataSet";
            this.myTransfers1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zapr1TableAdapter
            // 
            this.zapr1TableAdapter.ClearBeforeFill = true;
            // 
            // clubAfillationTableAdapter1
            // 
            this.clubAfillationTableAdapter1.ClearBeforeFill = true;
            // 
            // clubsListTableAdapter1
            // 
            this.clubsListTableAdapter1.ClearBeforeFill = true;
            // 
            // playersListTableAdapter1
            // 
            this.playersListTableAdapter1.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtClub);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapr1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTransfers1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClub;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zapr1BindingSource;
        private MyTransfers1DataSet myTransfers1DataSet;
        private MyTransfers1DataSetTableAdapters.Zapr1TableAdapter zapr1TableAdapter;
        private MyTransfers1DataSetTableAdapters.ClubAfillationTableAdapter clubAfillationTableAdapter1;
        private MyTransfers1DataSetTableAdapters.ClubsListTableAdapter clubsListTableAdapter1;
        private MyTransfers1DataSetTableAdapters.PlayersListTableAdapter playersListTableAdapter1;
    }
}
namespace MyTransfers111
{
    partial class Form14
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clubnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summarysalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zapr4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myTransfers1DataSet = new MyTransfers111.MyTransfers1DataSet();
            this.zapr4TableAdapter = new MyTransfers111.MyTransfers1DataSetTableAdapters.Zapr4TableAdapter();
            this.playersListTableAdapter1 = new MyTransfers111.MyTransfers1DataSetTableAdapters.PlayersListTableAdapter();
            this.clubsListTableAdapter1 = new MyTransfers111.MyTransfers1DataSetTableAdapters.ClubsListTableAdapter();
            this.clubAfillationTableAdapter1 = new MyTransfers111.MyTransfers1DataSetTableAdapters.ClubAfillationTableAdapter();
            this.clubAfillationSORTTableAdapter1 = new MyTransfers111.MyTransfers1DataSetTableAdapters.ClubAfillationSORTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapr4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTransfers1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubnameDataGridViewTextBoxColumn,
            this.summarysalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zapr4BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(232, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(252, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // clubnameDataGridViewTextBoxColumn
            // 
            this.clubnameDataGridViewTextBoxColumn.DataPropertyName = "clubname";
            this.clubnameDataGridViewTextBoxColumn.HeaderText = "clubname";
            this.clubnameDataGridViewTextBoxColumn.Name = "clubnameDataGridViewTextBoxColumn";
            // 
            // summarysalaryDataGridViewTextBoxColumn
            // 
            this.summarysalaryDataGridViewTextBoxColumn.DataPropertyName = "summarysalary";
            this.summarysalaryDataGridViewTextBoxColumn.HeaderText = "summarysalary";
            this.summarysalaryDataGridViewTextBoxColumn.Name = "summarysalaryDataGridViewTextBoxColumn";
            this.summarysalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zapr4BindingSource
            // 
            this.zapr4BindingSource.DataMember = "Zapr4";
            this.zapr4BindingSource.DataSource = this.myTransfers1DataSet;
            // 
            // myTransfers1DataSet
            // 
            this.myTransfers1DataSet.DataSetName = "MyTransfers1DataSet";
            this.myTransfers1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zapr4TableAdapter
            // 
            this.zapr4TableAdapter.ClearBeforeFill = true;
            // 
            // playersListTableAdapter1
            // 
            this.playersListTableAdapter1.ClearBeforeFill = true;
            // 
            // clubsListTableAdapter1
            // 
            this.clubsListTableAdapter1.ClearBeforeFill = true;
            // 
            // clubAfillationTableAdapter1
            // 
            this.clubAfillationTableAdapter1.ClearBeforeFill = true;
            // 
            // clubAfillationSORTTableAdapter1
            // 
            this.clubAfillationSORTTableAdapter1.ClearBeforeFill = true;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form14";
            this.Text = "Form14";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapr4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTransfers1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summarysalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zapr4BindingSource;
        private MyTransfers1DataSet myTransfers1DataSet;
        private MyTransfers1DataSetTableAdapters.Zapr4TableAdapter zapr4TableAdapter;
        private MyTransfers1DataSetTableAdapters.PlayersListTableAdapter playersListTableAdapter1;
        private MyTransfers1DataSetTableAdapters.ClubsListTableAdapter clubsListTableAdapter1;
        private MyTransfers1DataSetTableAdapters.ClubAfillationTableAdapter clubAfillationTableAdapter1;
        private MyTransfers1DataSetTableAdapters.ClubAfillationSORTTableAdapter clubAfillationSORTTableAdapter1;
    }
}
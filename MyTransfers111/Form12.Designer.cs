namespace MyTransfers111
{
    partial class Form12
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
            this.myTransfers1DataSet = new MyTransfers111.MyTransfers1DataSet();
            this.zapr4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zapr4TableAdapter = new MyTransfers111.MyTransfers1DataSetTableAdapters.Zapr4TableAdapter();
            this.clubnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summarysalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTransfers1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapr4BindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(311, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // myTransfers1DataSet
            // 
            this.myTransfers1DataSet.DataSetName = "MyTransfers1DataSet";
            this.myTransfers1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zapr4BindingSource
            // 
            this.zapr4BindingSource.DataMember = "Zapr4";
            this.zapr4BindingSource.DataSource = this.myTransfers1DataSet;
            // 
            // zapr4TableAdapter
            // 
            this.zapr4TableAdapter.ClearBeforeFill = true;
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
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTransfers1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapr4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MyTransfers1DataSet myTransfers1DataSet;
        private System.Windows.Forms.BindingSource zapr4BindingSource;
        private MyTransfers1DataSetTableAdapters.Zapr4TableAdapter zapr4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summarysalaryDataGridViewTextBoxColumn;
    }
}
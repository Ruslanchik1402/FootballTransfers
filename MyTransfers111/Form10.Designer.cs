namespace MyTransfers111
{
    partial class Form10
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
            this.zapr3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zapr3TableAdapter = new MyTransfers111.MyTransfers1DataSetTableAdapters.Zapr3TableAdapter();
            this.clubnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTransfers1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapr3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubnameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zapr3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(259, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // myTransfers1DataSet
            // 
            this.myTransfers1DataSet.DataSetName = "MyTransfers1DataSet";
            this.myTransfers1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zapr3BindingSource
            // 
            this.zapr3BindingSource.DataMember = "Zapr3";
            this.zapr3BindingSource.DataSource = this.myTransfers1DataSet;
            // 
            // zapr3TableAdapter
            // 
            this.zapr3TableAdapter.ClearBeforeFill = true;
            // 
            // clubnameDataGridViewTextBoxColumn
            // 
            this.clubnameDataGridViewTextBoxColumn.DataPropertyName = "clubname";
            this.clubnameDataGridViewTextBoxColumn.HeaderText = "clubname";
            this.clubnameDataGridViewTextBoxColumn.Name = "clubnameDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTransfers1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapr3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MyTransfers1DataSet myTransfers1DataSet;
        private System.Windows.Forms.BindingSource zapr3BindingSource;
        private MyTransfers1DataSetTableAdapters.Zapr3TableAdapter zapr3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}
namespace LabTest2
{
    partial class FormAuthor
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
            this.admiralBookstoreDatabaseDataSet2 = new LabTest2.AdmiralBookstoreDatabaseDataSet2();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new LabTest2.AdmiralBookstoreDatabaseDataSet2TableAdapters.AuthorTableAdapter();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAuthorID = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxBirthYear = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnToStock = new System.Windows.Forms.Button();
            this.btnToBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.birthYearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.authorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // admiralBookstoreDatabaseDataSet2
            // 
            this.admiralBookstoreDatabaseDataSet2.DataSetName = "AdmiralBookstoreDatabaseDataSet2";
            this.admiralBookstoreDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.admiralBookstoreDatabaseDataSet2;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthYearDataGridViewTextBoxColumn
            // 
            this.birthYearDataGridViewTextBoxColumn.DataPropertyName = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.HeaderText = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthYearDataGridViewTextBoxColumn.Name = "birthYearDataGridViewTextBoxColumn";
            this.birthYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "AuthorID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "BirthYear";
            // 
            // txtBoxAuthorID
            // 
            this.txtBoxAuthorID.Location = new System.Drawing.Point(305, 276);
            this.txtBoxAuthorID.Name = "txtBoxAuthorID";
            this.txtBoxAuthorID.Size = new System.Drawing.Size(325, 22);
            this.txtBoxAuthorID.TabIndex = 6;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(305, 341);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(325, 22);
            this.txtBoxName.TabIndex = 7;
            // 
            // txtBoxBirthYear
            // 
            this.txtBoxBirthYear.Location = new System.Drawing.Point(305, 402);
            this.txtBoxBirthYear.Name = "txtBoxBirthYear";
            this.txtBoxBirthYear.Size = new System.Drawing.Size(325, 22);
            this.txtBoxBirthYear.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(508, 447);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 42);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnToStock
            // 
            this.btnToStock.Location = new System.Drawing.Point(866, 541);
            this.btnToStock.Name = "btnToStock";
            this.btnToStock.Size = new System.Drawing.Size(122, 23);
            this.btnToStock.TabIndex = 11;
            this.btnToStock.Text = "Form Stock";
            this.btnToStock.UseVisualStyleBackColor = true;
            this.btnToStock.Click += new System.EventHandler(this.btnToStock_Click);
            // 
            // btnToBook
            // 
            this.btnToBook.Location = new System.Drawing.Point(866, 512);
            this.btnToBook.Name = "btnToBook";
            this.btnToBook.Size = new System.Drawing.Size(122, 23);
            this.btnToBook.TabIndex = 10;
            this.btnToBook.Text = "Form Book";
            this.btnToBook.UseVisualStyleBackColor = true;
            this.btnToBook.Click += new System.EventHandler(this.btnToBook_Click);
            // 
            // FormAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 613);
            this.Controls.Add(this.btnToStock);
            this.Controls.Add(this.btnToBook);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxBirthYear);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxAuthorID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAuthor";
            this.Text = "Form Author";
            this.Load += new System.EventHandler(this.FormAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AdmiralBookstoreDatabaseDataSet2 admiralBookstoreDatabaseDataSet2;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private AdmiralBookstoreDatabaseDataSet2TableAdapters.AuthorTableAdapter authorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxAuthorID;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxBirthYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnToStock;
        private System.Windows.Forms.Button btnToBook;
    }
}


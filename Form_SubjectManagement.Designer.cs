namespace iTriviant
{
    partial class Form_SubjectManagement
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
            this.dataGridView_ListSubject = new System.Windows.Forms.DataGridView();
            this.IDSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ListSubject
            // 
            this.dataGridView_ListSubject.AllowUserToAddRows = false;
            this.dataGridView_ListSubject.AllowUserToDeleteRows = false;
            this.dataGridView_ListSubject.AllowUserToOrderColumns = true;
            this.dataGridView_ListSubject.AllowUserToResizeColumns = false;
            this.dataGridView_ListSubject.AllowUserToResizeRows = false;
            this.dataGridView_ListSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSubject,
            this.NameSubject});
            this.dataGridView_ListSubject.Location = new System.Drawing.Point(478, 44);
            this.dataGridView_ListSubject.Name = "dataGridView_ListSubject";
            this.dataGridView_ListSubject.RowHeadersVisible = false;
            this.dataGridView_ListSubject.Size = new System.Drawing.Size(269, 338);
            this.dataGridView_ListSubject.TabIndex = 15;
            this.dataGridView_ListSubject.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ListParticipant_CellMouseDoubleClick);
            // 
            // IDSubject
            // 
            this.IDSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDSubject.HeaderText = "ID";
            this.IDSubject.Name = "IDSubject";
            this.IDSubject.ReadOnly = true;
            this.IDSubject.Visible = false;
            // 
            // NameSubject
            // 
            this.NameSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameSubject.HeaderText = "Subject";
            this.NameSubject.Name = "NameSubject";
            this.NameSubject.ReadOnly = true;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(245, 124);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 13;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(179, 127);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(41, 13);
            this.label_Name.TabIndex = 9;
            this.label_Name.Text = "Naam: ";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(92, 359);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 8;
            this.button_Add.Text = "Toevoegen";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(198, 359);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 16;
            this.button_Update.Text = "Bewerken";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(308, 359);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 17;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Form_SubjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.dataGridView_ListSubject);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_Add);
            this.Name = "Form_SubjectManagement";
            this.Text = "Form_SubjectManagement";
            this.Load += new System.EventHandler(this.Form_SubjectManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ListSubject;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSubject;
    }
}
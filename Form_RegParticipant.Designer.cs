namespace iTriviant
{
    partial class Form_RegParticipant
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
            this.button_Add = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.dataGridView_ListParticipant = new System.Windows.Forms.DataGridView();
            this.IDParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastnameParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListParticipant)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(136, 298);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Toevoegen";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(60, 89);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(41, 13);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Naam: ";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(60, 128);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(70, 13);
            this.label_LastName.TabIndex = 2;
            this.label_LastName.Text = "Achternaam: ";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(126, 86);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 5;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(126, 121);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_LastName.TabIndex = 6;
            // 
            // dataGridView_ListParticipant
            // 
            this.dataGridView_ListParticipant.AllowUserToAddRows = false;
            this.dataGridView_ListParticipant.AllowUserToDeleteRows = false;
            this.dataGridView_ListParticipant.AllowUserToOrderColumns = true;
            this.dataGridView_ListParticipant.AllowUserToResizeColumns = false;
            this.dataGridView_ListParticipant.AllowUserToResizeRows = false;
            this.dataGridView_ListParticipant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListParticipant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDParticipant,
            this.NameParticipant,
            this.LastnameParticipant,
            this.CodeParticipant});
            this.dataGridView_ListParticipant.Location = new System.Drawing.Point(282, 54);
            this.dataGridView_ListParticipant.Name = "dataGridView_ListParticipant";
            this.dataGridView_ListParticipant.RowHeadersVisible = false;
            this.dataGridView_ListParticipant.Size = new System.Drawing.Size(515, 338);
            this.dataGridView_ListParticipant.TabIndex = 7;
//            this.dataGridView_ListParticipant.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ListParticipant_CellMouseDoubleClick);
            // 
            // IDParticipant
            // 
            this.IDParticipant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDParticipant.HeaderText = "ID";
            this.IDParticipant.Name = "IDParticipant";
            this.IDParticipant.ReadOnly = true;
            this.IDParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDParticipant.Visible = false;
            // 
            // NameParticipant
            // 
            this.NameParticipant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameParticipant.HeaderText = "Naam";
            this.NameParticipant.Name = "NameParticipant";
            this.NameParticipant.ReadOnly = true;
            this.NameParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LastnameParticipant
            // 
            this.LastnameParticipant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastnameParticipant.HeaderText = "Achternaam";
            this.LastnameParticipant.Name = "LastnameParticipant";
            this.LastnameParticipant.ReadOnly = true;
            this.LastnameParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CodeParticipant
            // 
            this.CodeParticipant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeParticipant.HeaderText = "Code";
            this.CodeParticipant.Name = "CodeParticipant";
            this.CodeParticipant.ReadOnly = true;
            this.CodeParticipant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form_RegParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_ListParticipant);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_Add);
            this.Name = "Form_RegParticipant";
            this.Text = "Form_RegParticipant";
            this.Load += new System.EventHandler(this.Form_RegParticipant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListParticipant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.DataGridView dataGridView_ListParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastnameParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeParticipant;
    }
}
namespace iTriviant
{
    partial class Form_QuestionManagement
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
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.dataGridView_ListQuestion = new System.Windows.Forms.DataGridView();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.label_Question = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_AnswerA = new System.Windows.Forms.TextBox();
            this.label_AnswerA = new System.Windows.Forms.Label();
            this.textBox_AnswerB = new System.Windows.Forms.TextBox();
            this.label_AnswerB = new System.Windows.Forms.Label();
            this.textBox_AnswerC = new System.Windows.Forms.TextBox();
            this.label_AnswerC = new System.Windows.Forms.Label();
            this.textBox_AnswerD = new System.Windows.Forms.TextBox();
            this.label_AnswerD = new System.Windows.Forms.Label();
            this.label_RightAnswer = new System.Windows.Forms.Label();
            this.comboBox_Subject = new System.Windows.Forms.ComboBox();
            this.label_Subject = new System.Windows.Forms.Label();
            this.IDSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionTextSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(289, 371);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 23;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(179, 371);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 22;
            this.button_Update.Text = "Bewerken";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // dataGridView_ListQuestion
            // 
            this.dataGridView_ListQuestion.AllowUserToAddRows = false;
            this.dataGridView_ListQuestion.AllowUserToDeleteRows = false;
            this.dataGridView_ListQuestion.AllowUserToOrderColumns = true;
            this.dataGridView_ListQuestion.AllowUserToResizeColumns = false;
            this.dataGridView_ListQuestion.AllowUserToResizeRows = false;
            this.dataGridView_ListQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSubject,
            this.QuestionTextSubject,
            this.SubjectQuestion});
            this.dataGridView_ListQuestion.Location = new System.Drawing.Point(459, 56);
            this.dataGridView_ListQuestion.Name = "dataGridView_ListQuestion";
            this.dataGridView_ListQuestion.RowHeadersVisible = false;
            this.dataGridView_ListQuestion.Size = new System.Drawing.Size(329, 338);
            this.dataGridView_ListQuestion.TabIndex = 21;
            this.dataGridView_ListQuestion.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ListQuestion_CellMouseDoubleClick);
            // 
            // textBox_Question
            // 
            this.textBox_Question.Location = new System.Drawing.Point(112, 56);
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(252, 20);
            this.textBox_Question.TabIndex = 20;
            // 
            // label_Question
            // 
            this.label_Question.AutoSize = true;
            this.label_Question.Location = new System.Drawing.Point(46, 59);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(41, 13);
            this.label_Question.TabIndex = 19;
            this.label_Question.Text = "Vraag: ";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(73, 371);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 18;
            this.button_Add.Text = "Toevoegen";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_AnswerA
            // 
            this.textBox_AnswerA.Location = new System.Drawing.Point(112, 117);
            this.textBox_AnswerA.Name = "textBox_AnswerA";
            this.textBox_AnswerA.Size = new System.Drawing.Size(252, 20);
            this.textBox_AnswerA.TabIndex = 25;
            // 
            // label_AnswerA
            // 
            this.label_AnswerA.AutoSize = true;
            this.label_AnswerA.Location = new System.Drawing.Point(46, 120);
            this.label_AnswerA.Name = "label_AnswerA";
            this.label_AnswerA.Size = new System.Drawing.Size(68, 13);
            this.label_AnswerA.TabIndex = 24;
            this.label_AnswerA.Text = "Antwoord A: ";
            // 
            // textBox_AnswerB
            // 
            this.textBox_AnswerB.Location = new System.Drawing.Point(112, 143);
            this.textBox_AnswerB.Name = "textBox_AnswerB";
            this.textBox_AnswerB.Size = new System.Drawing.Size(252, 20);
            this.textBox_AnswerB.TabIndex = 27;
            // 
            // label_AnswerB
            // 
            this.label_AnswerB.AutoSize = true;
            this.label_AnswerB.Location = new System.Drawing.Point(46, 146);
            this.label_AnswerB.Name = "label_AnswerB";
            this.label_AnswerB.Size = new System.Drawing.Size(68, 13);
            this.label_AnswerB.TabIndex = 26;
            this.label_AnswerB.Text = "Antwoord B: ";
            // 
            // textBox_AnswerC
            // 
            this.textBox_AnswerC.Location = new System.Drawing.Point(112, 169);
            this.textBox_AnswerC.Name = "textBox_AnswerC";
            this.textBox_AnswerC.Size = new System.Drawing.Size(252, 20);
            this.textBox_AnswerC.TabIndex = 29;
            // 
            // label_AnswerC
            // 
            this.label_AnswerC.AutoSize = true;
            this.label_AnswerC.Location = new System.Drawing.Point(46, 172);
            this.label_AnswerC.Name = "label_AnswerC";
            this.label_AnswerC.Size = new System.Drawing.Size(68, 13);
            this.label_AnswerC.TabIndex = 28;
            this.label_AnswerC.Text = "Antwoord C: ";
            // 
            // textBox_AnswerD
            // 
            this.textBox_AnswerD.Location = new System.Drawing.Point(112, 195);
            this.textBox_AnswerD.Name = "textBox_AnswerD";
            this.textBox_AnswerD.Size = new System.Drawing.Size(252, 20);
            this.textBox_AnswerD.TabIndex = 31;
            // 
            // label_AnswerD
            // 
            this.label_AnswerD.AutoSize = true;
            this.label_AnswerD.Location = new System.Drawing.Point(46, 198);
            this.label_AnswerD.Name = "label_AnswerD";
            this.label_AnswerD.Size = new System.Drawing.Size(69, 13);
            this.label_AnswerD.TabIndex = 30;
            this.label_AnswerD.Text = "Antwoord D: ";
            // 
            // label_RightAnswer
            // 
            this.label_RightAnswer.AutoSize = true;
            this.label_RightAnswer.Location = new System.Drawing.Point(370, 120);
            this.label_RightAnswer.Name = "label_RightAnswer";
            this.label_RightAnswer.Size = new System.Drawing.Size(82, 13);
            this.label_RightAnswer.TabIndex = 32;
            this.label_RightAnswer.Text = "Juiste Antwoord";
            // 
            // comboBox_Subject
            // 
            this.comboBox_Subject.FormattingEnabled = true;
            this.comboBox_Subject.Location = new System.Drawing.Point(112, 253);
            this.comboBox_Subject.Name = "comboBox_Subject";
            this.comboBox_Subject.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Subject.TabIndex = 33;
            // 
            // label_Subject
            // 
            this.label_Subject.AutoSize = true;
            this.label_Subject.Location = new System.Drawing.Point(46, 256);
            this.label_Subject.Name = "label_Subject";
            this.label_Subject.Size = new System.Drawing.Size(59, 13);
            this.label_Subject.TabIndex = 34;
            this.label_Subject.Text = "Onderwerp";
            // 
            // IDSubject
            // 
            this.IDSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDSubject.HeaderText = "ID";
            this.IDSubject.Name = "IDSubject";
            this.IDSubject.ReadOnly = true;
            this.IDSubject.Visible = false;
            // 
            // QuestionTextSubject
            // 
            this.QuestionTextSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuestionTextSubject.HeaderText = "Vraag";
            this.QuestionTextSubject.Name = "QuestionTextSubject";
            this.QuestionTextSubject.ReadOnly = true;
            // 
            // SubjectQuestion
            // 
            this.SubjectQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectQuestion.HeaderText = "Onderwerp";
            this.SubjectQuestion.Name = "SubjectQuestion";
            this.SubjectQuestion.ReadOnly = true;
            // 
            // Form_QuestionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Subject);
            this.Controls.Add(this.comboBox_Subject);
            this.Controls.Add(this.label_RightAnswer);
            this.Controls.Add(this.textBox_AnswerD);
            this.Controls.Add(this.label_AnswerD);
            this.Controls.Add(this.textBox_AnswerC);
            this.Controls.Add(this.label_AnswerC);
            this.Controls.Add(this.textBox_AnswerB);
            this.Controls.Add(this.label_AnswerB);
            this.Controls.Add(this.textBox_AnswerA);
            this.Controls.Add(this.label_AnswerA);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.dataGridView_ListQuestion);
            this.Controls.Add(this.textBox_Question);
            this.Controls.Add(this.label_Question);
            this.Controls.Add(this.button_Add);
            this.Name = "Form_QuestionManagement";
            this.Text = "Form_QuestionManagement";
            this.Load += new System.EventHandler(this.Form_QuestionManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.DataGridView dataGridView_ListQuestion;
        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_AnswerA;
        private System.Windows.Forms.Label label_AnswerA;
        private System.Windows.Forms.TextBox textBox_AnswerB;
        private System.Windows.Forms.Label label_AnswerB;
        private System.Windows.Forms.TextBox textBox_AnswerC;
        private System.Windows.Forms.Label label_AnswerC;
        private System.Windows.Forms.TextBox textBox_AnswerD;
        private System.Windows.Forms.Label label_AnswerD;
        private System.Windows.Forms.Label label_RightAnswer;
        private System.Windows.Forms.ComboBox comboBox_Subject;
        private System.Windows.Forms.Label label_Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionTextSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectQuestion;
    }
}
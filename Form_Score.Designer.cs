namespace iTriviant
{
    partial class Form_Score
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
            this.label_Code = new System.Windows.Forms.Label();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.dataGridView_Tokens = new System.Windows.Forms.DataGridView();
            this.button_CheckScore = new System.Windows.Forms.Button();
            this.dataGridView_Wins = new System.Windows.Forms.DataGridView();
            this.dataGridView_Losses = new System.Windows.Forms.DataGridView();
            this.IDWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLosses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLosses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectLosses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Tokens = new System.Windows.Forms.Label();
            this.label_RoundsWon = new System.Windows.Forms.Label();
            this.label_RoundsLost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tokens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Wins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Losses)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Code
            // 
            this.label_Code.AutoSize = true;
            this.label_Code.Location = new System.Drawing.Point(211, 85);
            this.label_Code.Name = "label_Code";
            this.label_Code.Size = new System.Drawing.Size(35, 13);
            this.label_Code.TabIndex = 0;
            this.label_Code.Text = "Code:";
            // 
            // textBox_Code
            // 
            this.textBox_Code.Location = new System.Drawing.Point(253, 85);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(100, 20);
            this.textBox_Code.TabIndex = 1;
            // 
            // dataGridView_Tokens
            // 
            this.dataGridView_Tokens.AllowUserToAddRows = false;
            this.dataGridView_Tokens.AllowUserToDeleteRows = false;
            this.dataGridView_Tokens.AllowUserToOrderColumns = true;
            this.dataGridView_Tokens.AllowUserToResizeColumns = false;
            this.dataGridView_Tokens.AllowUserToResizeRows = false;
            this.dataGridView_Tokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDToken,
            this.NameToken,
            this.SubjectToken});
            this.dataGridView_Tokens.Location = new System.Drawing.Point(12, 182);
            this.dataGridView_Tokens.Name = "dataGridView_Tokens";
            this.dataGridView_Tokens.RowHeadersVisible = false;
            this.dataGridView_Tokens.Size = new System.Drawing.Size(240, 240);
            this.dataGridView_Tokens.TabIndex = 2;
            // 
            // button_CheckScore
            // 
            this.button_CheckScore.Location = new System.Drawing.Point(535, 83);
            this.button_CheckScore.Name = "button_CheckScore";
            this.button_CheckScore.Size = new System.Drawing.Size(103, 23);
            this.button_CheckScore.TabIndex = 5;
            this.button_CheckScore.Text = "Score Bekijken";
            this.button_CheckScore.UseVisualStyleBackColor = true;
            this.button_CheckScore.Click += new System.EventHandler(this.button_CheckScore_Click);
            // 
            // dataGridView_Wins
            // 
            this.dataGridView_Wins.AllowUserToAddRows = false;
            this.dataGridView_Wins.AllowUserToDeleteRows = false;
            this.dataGridView_Wins.AllowUserToOrderColumns = true;
            this.dataGridView_Wins.AllowUserToResizeColumns = false;
            this.dataGridView_Wins.AllowUserToResizeRows = false;
            this.dataGridView_Wins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Wins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDWins,
            this.DateWins,
            this.SubjectWins});
            this.dataGridView_Wins.Location = new System.Drawing.Point(273, 182);
            this.dataGridView_Wins.Name = "dataGridView_Wins";
            this.dataGridView_Wins.RowHeadersVisible = false;
            this.dataGridView_Wins.Size = new System.Drawing.Size(240, 240);
            this.dataGridView_Wins.TabIndex = 6;
            // 
            // dataGridView_Losses
            // 
            this.dataGridView_Losses.AllowUserToAddRows = false;
            this.dataGridView_Losses.AllowUserToDeleteRows = false;
            this.dataGridView_Losses.AllowUserToOrderColumns = true;
            this.dataGridView_Losses.AllowUserToResizeColumns = false;
            this.dataGridView_Losses.AllowUserToResizeRows = false;
            this.dataGridView_Losses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Losses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLosses,
            this.DateLosses,
            this.SubjectLosses});
            this.dataGridView_Losses.Location = new System.Drawing.Point(535, 182);
            this.dataGridView_Losses.Name = "dataGridView_Losses";
            this.dataGridView_Losses.RowHeadersVisible = false;
            this.dataGridView_Losses.Size = new System.Drawing.Size(240, 240);
            this.dataGridView_Losses.TabIndex = 7;
            // 
            // IDWins
            // 
            this.IDWins.HeaderText = "ID";
            this.IDWins.Name = "IDWins";
            this.IDWins.ReadOnly = true;
            this.IDWins.Visible = false;
            // 
            // DateWins
            // 
            this.DateWins.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateWins.HeaderText = "Datum";
            this.DateWins.Name = "DateWins";
            this.DateWins.ReadOnly = true;
            // 
            // SubjectWins
            // 
            this.SubjectWins.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectWins.HeaderText = "Onderwerp";
            this.SubjectWins.Name = "SubjectWins";
            this.SubjectWins.ReadOnly = true;
            // 
            // IDLosses
            // 
            this.IDLosses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDLosses.HeaderText = "ID";
            this.IDLosses.Name = "IDLosses";
            this.IDLosses.ReadOnly = true;
            this.IDLosses.Visible = false;
            // 
            // DateLosses
            // 
            this.DateLosses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateLosses.HeaderText = "Datum";
            this.DateLosses.Name = "DateLosses";
            this.DateLosses.ReadOnly = true;
            // 
            // SubjectLosses
            // 
            this.SubjectLosses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectLosses.HeaderText = "Onterwerp";
            this.SubjectLosses.Name = "SubjectLosses";
            this.SubjectLosses.ReadOnly = true;
            // 
            // IDToken
            // 
            this.IDToken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDToken.HeaderText = "ID";
            this.IDToken.Name = "IDToken";
            this.IDToken.ReadOnly = true;
            this.IDToken.Visible = false;
            // 
            // NameToken
            // 
            this.NameToken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameToken.HeaderText = "Naam";
            this.NameToken.Name = "NameToken";
            this.NameToken.ReadOnly = true;
            // 
            // SubjectToken
            // 
            this.SubjectToken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectToken.HeaderText = "Onderwerp";
            this.SubjectToken.Name = "SubjectToken";
            this.SubjectToken.ReadOnly = true;
            // 
            // label_Tokens
            // 
            this.label_Tokens.AutoSize = true;
            this.label_Tokens.Location = new System.Drawing.Point(9, 166);
            this.label_Tokens.Name = "label_Tokens";
            this.label_Tokens.Size = new System.Drawing.Size(43, 13);
            this.label_Tokens.TabIndex = 8;
            this.label_Tokens.Text = "Tokens";
            // 
            // label_RoundsWon
            // 
            this.label_RoundsWon.AutoSize = true;
            this.label_RoundsWon.Location = new System.Drawing.Point(270, 166);
            this.label_RoundsWon.Name = "label_RoundsWon";
            this.label_RoundsWon.Size = new System.Drawing.Size(99, 13);
            this.label_RoundsWon.TabIndex = 9;
            this.label_RoundsWon.Text = "Rondes Gewonnen";
            // 
            // label_RoundsLost
            // 
            this.label_RoundsLost.AutoSize = true;
            this.label_RoundsLost.Location = new System.Drawing.Point(532, 166);
            this.label_RoundsLost.Name = "label_RoundsLost";
            this.label_RoundsLost.Size = new System.Drawing.Size(86, 13);
            this.label_RoundsLost.TabIndex = 10;
            this.label_RoundsLost.Text = "Rondes Verloren";
            // 
            // Form_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_RoundsLost);
            this.Controls.Add(this.label_RoundsWon);
            this.Controls.Add(this.label_Tokens);
            this.Controls.Add(this.dataGridView_Losses);
            this.Controls.Add(this.dataGridView_Wins);
            this.Controls.Add(this.button_CheckScore);
            this.Controls.Add(this.dataGridView_Tokens);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.label_Code);
            this.Name = "Form_Score";
            this.Text = "Form_Score";
            this.Load += new System.EventHandler(this.Form_Score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tokens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Wins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Losses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Code;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.DataGridView dataGridView_Tokens;
        private System.Windows.Forms.Button button_CheckScore;
        private System.Windows.Forms.DataGridView dataGridView_Wins;
        private System.Windows.Forms.DataGridView dataGridView_Losses;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLosses;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLosses;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectLosses;
        private System.Windows.Forms.Label label_Tokens;
        private System.Windows.Forms.Label label_RoundsWon;
        private System.Windows.Forms.Label label_RoundsLost;
    }
}
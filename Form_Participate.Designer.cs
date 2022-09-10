namespace iTriviant
{
    partial class Form_Participate
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
            this.comboBox_Subject = new System.Windows.Forms.ComboBox();
            this.label_Subject = new System.Windows.Forms.Label();
            this.label_Code = new System.Windows.Forms.Label();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.button_Participate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Subject
            // 
            this.comboBox_Subject.FormattingEnabled = true;
            this.comboBox_Subject.Location = new System.Drawing.Point(310, 150);
            this.comboBox_Subject.Name = "comboBox_Subject";
            this.comboBox_Subject.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Subject.TabIndex = 0;
            // 
            // label_Subject
            // 
            this.label_Subject.AutoSize = true;
            this.label_Subject.Location = new System.Drawing.Point(245, 153);
            this.label_Subject.Name = "label_Subject";
            this.label_Subject.Size = new System.Drawing.Size(62, 13);
            this.label_Subject.TabIndex = 1;
            this.label_Subject.Text = "Onderwerp:";
            // 
            // label_Code
            // 
            this.label_Code.AutoSize = true;
            this.label_Code.Location = new System.Drawing.Point(269, 183);
            this.label_Code.Name = "label_Code";
            this.label_Code.Size = new System.Drawing.Size(35, 13);
            this.label_Code.TabIndex = 2;
            this.label_Code.Text = "Code:";
            // 
            // textBox_Code
            // 
            this.textBox_Code.Location = new System.Drawing.Point(310, 183);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(121, 20);
            this.textBox_Code.TabIndex = 3;
            // 
            // button_Participate
            // 
            this.button_Participate.Location = new System.Drawing.Point(323, 269);
            this.button_Participate.Name = "button_Participate";
            this.button_Participate.Size = new System.Drawing.Size(75, 23);
            this.button_Participate.TabIndex = 4;
            this.button_Participate.Text = "Meespelen";
            this.button_Participate.UseVisualStyleBackColor = true;
            this.button_Participate.Click += new System.EventHandler(this.button_Participate_Click);
            // 
            // Form_Participate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Participate);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.label_Code);
            this.Controls.Add(this.label_Subject);
            this.Controls.Add(this.comboBox_Subject);
            this.Name = "Form_Participate";
            this.Text = "Form_Participate";
            this.Load += new System.EventHandler(this.Form_Participate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Subject;
        private System.Windows.Forms.Label label_Subject;
        private System.Windows.Forms.Label label_Code;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.Button button_Participate;
    }
}
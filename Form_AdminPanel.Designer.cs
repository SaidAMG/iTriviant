namespace iTriviant
{
    partial class Form_AdminPanel
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
            this.button_RegParticipant = new System.Windows.Forms.Button();
            this.button_SubjectManagement = new System.Windows.Forms.Button();
            this.button_QuestionManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_RegParticipant
            // 
            this.button_RegParticipant.Location = new System.Drawing.Point(339, 147);
            this.button_RegParticipant.Name = "button_RegParticipant";
            this.button_RegParticipant.Size = new System.Drawing.Size(133, 23);
            this.button_RegParticipant.TabIndex = 0;
            this.button_RegParticipant.Text = "Registreer Deelnemer";
            this.button_RegParticipant.UseVisualStyleBackColor = true;
            this.button_RegParticipant.Click += new System.EventHandler(this.button_RegParticipant_Click);
            // 
            // button_SubjectManagement
            // 
            this.button_SubjectManagement.Location = new System.Drawing.Point(339, 209);
            this.button_SubjectManagement.Name = "button_SubjectManagement";
            this.button_SubjectManagement.Size = new System.Drawing.Size(133, 23);
            this.button_SubjectManagement.TabIndex = 1;
            this.button_SubjectManagement.Text = "Onderwerp management";
            this.button_SubjectManagement.UseVisualStyleBackColor = true;
            this.button_SubjectManagement.Click += new System.EventHandler(this.button_SubjectManagement_Click);
            // 
            // button_QuestionManagement
            // 
            this.button_QuestionManagement.Location = new System.Drawing.Point(339, 270);
            this.button_QuestionManagement.Name = "button_QuestionManagement";
            this.button_QuestionManagement.Size = new System.Drawing.Size(133, 23);
            this.button_QuestionManagement.TabIndex = 2;
            this.button_QuestionManagement.Text = "Vragen management";
            this.button_QuestionManagement.UseVisualStyleBackColor = true;
            this.button_QuestionManagement.Click += new System.EventHandler(this.button_QuestionManagement_Click);
            // 
            // Form_AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_QuestionManagement);
            this.Controls.Add(this.button_SubjectManagement);
            this.Controls.Add(this.button_RegParticipant);
            this.Name = "Form_AdminPanel";
            this.Text = "Form_AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_RegParticipant;
        private System.Windows.Forms.Button button_SubjectManagement;
        private System.Windows.Forms.Button button_QuestionManagement;
    }
}
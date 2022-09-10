namespace iTriviant
{
    partial class Form_HomeMenu
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
            this.button_Admin = new System.Windows.Forms.Button();
            this.button_Participant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Admin
            // 
            this.button_Admin.Location = new System.Drawing.Point(348, 107);
            this.button_Admin.Name = "button_Admin";
            this.button_Admin.Size = new System.Drawing.Size(75, 23);
            this.button_Admin.TabIndex = 0;
            this.button_Admin.Text = "Administratie";
            this.button_Admin.UseVisualStyleBackColor = true;
            this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // button_Participant
            // 
            this.button_Participant.Location = new System.Drawing.Point(348, 275);
            this.button_Participant.Name = "button_Participant";
            this.button_Participant.Size = new System.Drawing.Size(75, 23);
            this.button_Participant.TabIndex = 1;
            this.button_Participant.Text = "Deelnemer";
            this.button_Participant.UseVisualStyleBackColor = true;
            this.button_Participant.Click += new System.EventHandler(this.button_Participant_Click);
            // 
            // Form_HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Participant);
            this.Controls.Add(this.button_Admin);
            this.Name = "Form_HomeMenu";
            this.Text = "Form_HomeMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Admin;
        private System.Windows.Forms.Button button_Participant;
    }
}
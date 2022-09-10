namespace iTriviant
{
    partial class Form_ParticipantPanel
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
            this.button_WatchScore = new System.Windows.Forms.Button();
            this.button_Participate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_WatchScore
            // 
            this.button_WatchScore.Location = new System.Drawing.Point(338, 153);
            this.button_WatchScore.Name = "button_WatchScore";
            this.button_WatchScore.Size = new System.Drawing.Size(91, 23);
            this.button_WatchScore.TabIndex = 0;
            this.button_WatchScore.Text = "Score bekijken";
            this.button_WatchScore.UseVisualStyleBackColor = true;
            this.button_WatchScore.Click += new System.EventHandler(this.button_WatchScore_Click);
            // 
            // button_Participate
            // 
            this.button_Participate.Location = new System.Drawing.Point(338, 242);
            this.button_Participate.Name = "button_Participate";
            this.button_Participate.Size = new System.Drawing.Size(91, 23);
            this.button_Participate.TabIndex = 1;
            this.button_Participate.Text = "Deelnemen";
            this.button_Participate.UseVisualStyleBackColor = true;
            this.button_Participate.Click += new System.EventHandler(this.button_Participate_Click);
            // 
            // Form_ParticipantPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Participate);
            this.Controls.Add(this.button_WatchScore);
            this.Name = "Form_ParticipantPanel";
            this.Text = "Form_ParticipantPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_WatchScore;
        private System.Windows.Forms.Button button_Participate;
    }
}
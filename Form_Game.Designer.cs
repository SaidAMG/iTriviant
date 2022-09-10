namespace iTriviant
{
    partial class Form_Game
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
            this.label_Question = new System.Windows.Forms.Label();
            this.button_A = new System.Windows.Forms.Button();
            this.button_B = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_D = new System.Windows.Forms.Button();
            this.label_Timer = new System.Windows.Forms.Label();
            this.timer_Counter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_Question
            // 
            this.label_Question.AutoSize = true;
            this.label_Question.Location = new System.Drawing.Point(377, 109);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(16, 13);
            this.label_Question.TabIndex = 0;
            this.label_Question.Text = "...";
            // 
            // button_A
            // 
            this.button_A.Location = new System.Drawing.Point(278, 219);
            this.button_A.Name = "button_A";
            this.button_A.Size = new System.Drawing.Size(75, 23);
            this.button_A.TabIndex = 1;
            this.button_A.Text = "buttonA";
            this.button_A.UseVisualStyleBackColor = true;
            this.button_A.Click += new System.EventHandler(this.button_A_Click);
            // 
            // button_B
            // 
            this.button_B.Location = new System.Drawing.Point(416, 219);
            this.button_B.Name = "button_B";
            this.button_B.Size = new System.Drawing.Size(75, 23);
            this.button_B.TabIndex = 2;
            this.button_B.Text = "buttonB";
            this.button_B.UseVisualStyleBackColor = true;
            this.button_B.Click += new System.EventHandler(this.button_B_Click);
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(278, 262);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(75, 23);
            this.button_C.TabIndex = 3;
            this.button_C.Text = "buttonC";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_D
            // 
            this.button_D.Location = new System.Drawing.Point(416, 262);
            this.button_D.Name = "button_D";
            this.button_D.Size = new System.Drawing.Size(75, 23);
            this.button_D.TabIndex = 4;
            this.button_D.Text = "buttonD";
            this.button_D.UseVisualStyleBackColor = true;
            this.button_D.Click += new System.EventHandler(this.button_D_Click);
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Location = new System.Drawing.Point(698, 42);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(28, 13);
            this.label_Timer.TabIndex = 5;
            this.label_Timer.Text = "0:00";
            // 
            // timer_Counter
            // 
            this.timer_Counter.Interval = 1000;
            this.timer_Counter.Tick += new System.EventHandler(this.timer_Counter_Tick);
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Timer);
            this.Controls.Add(this.button_D);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_B);
            this.Controls.Add(this.button_A);
            this.Controls.Add(this.label_Question);
            this.Name = "Form_Game";
            this.Text = "Form_Game";
            this.Load += new System.EventHandler(this.Form_Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Button button_A;
        private System.Windows.Forms.Button button_B;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_D;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Timer timer_Counter;
    }
}
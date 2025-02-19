namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LoginForside = new Button();
            Signupforside = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Impact", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(551, 122);
            label1.TabIndex = 0;
            label1.Text = "Busterblock";
            label1.Click += label1_Click;
            // 
            // LoginForside
            // 
            LoginForside.BackColor = Color.AliceBlue;
            LoginForside.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginForside.ForeColor = Color.FromArgb(0, 192, 0);
            LoginForside.Location = new Point(93, 187);
            LoginForside.Name = "LoginForside";
            LoginForside.Size = new Size(216, 262);
            LoginForside.TabIndex = 1;
            LoginForside.Text = "Login";
            LoginForside.UseVisualStyleBackColor = false;
            LoginForside.Click += button1_Click;
            // 
            // Signupforside
            // 
            Signupforside.BackColor = SystemColors.Info;
            Signupforside.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signupforside.ForeColor = Color.Crimson;
            Signupforside.Location = new Point(332, 187);
            Signupforside.Name = "Signupforside";
            Signupforside.Size = new Size(216, 262);
            Signupforside.TabIndex = 2;
            Signupforside.Text = "Sign up";
            Signupforside.UseVisualStyleBackColor = false;
            Signupforside.Click += Signupforside_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(643, 532);
            Controls.Add(Signupforside);
            Controls.Add(LoginForside);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button LoginForside;
        private Button Signupforside;
    }
}

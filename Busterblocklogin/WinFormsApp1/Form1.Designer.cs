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
            label1.Location = new Point(49, 47);
            label1.Name = "label1";
            label1.Size = new Size(674, 163);
            label1.TabIndex = 0;
            label1.Text = "Busterblock";
            label1.Click += label1_Click;
            // 
            // LoginForside
            // 
            LoginForside.BackColor = Color.AliceBlue;
            LoginForside.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginForside.ForeColor = Color.FromArgb(0, 192, 0);
            LoginForside.Location = new Point(106, 249);
            LoginForside.Margin = new Padding(3, 4, 3, 4);
            LoginForside.Name = "LoginForside";
            LoginForside.Size = new Size(247, 349);
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
            Signupforside.Location = new Point(379, 249);
            Signupforside.Margin = new Padding(3, 4, 3, 4);
            Signupforside.Name = "Signupforside";
            Signupforside.Size = new Size(247, 349);
            Signupforside.TabIndex = 2;
            Signupforside.Text = "Sign up";
            Signupforside.UseVisualStyleBackColor = false;
            Signupforside.Click += Signupforside_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(735, 709);
            Controls.Add(Signupforside);
            Controls.Add(LoginForside);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
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

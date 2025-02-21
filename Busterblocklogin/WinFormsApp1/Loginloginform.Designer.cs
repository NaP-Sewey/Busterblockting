
namespace WinFormsApp1
{
    partial class Loginloginform
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
            label1 = new Label();
            Loginloginform1 = new Label();
            _1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            LoginLoginside = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(1, 12);
            label1.Name = "label1";
            label1.Size = new Size(281, 63);
            label1.TabIndex = 1;
            label1.Text = "Busterblock";
            // 
            // Loginloginform1
            // 
            Loginloginform1.AutoSize = true;
            Loginloginform1.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loginloginform1.ForeColor = Color.Yellow;
            Loginloginform1.Location = new Point(120, 109);
            Loginloginform1.Name = "Loginloginform1";
            Loginloginform1.Size = new Size(91, 23);
            Loginloginform1.TabIndex = 2;
            Loginloginform1.Text = "Username";
            Loginloginform1.Click += Loginloginform1_Click;
            // 
            // _1
            // 
            _1.AutoSize = true;
            _1.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _1.ForeColor = Color.Yellow;
            _1.Location = new Point(82, 151);
            _1.Name = "_1";
            _1.Size = new Size(160, 18);
            _1.TabIndex = 3;
            _1.Text = "___________________";
            _1.Click += _1_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.HotTrack;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = Color.Yellow;
            txtUsername.Location = new Point(94, 144);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(136, 20);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.HotTrack;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.Yellow;
            txtPassword.Location = new Point(94, 260);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(136, 20);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(82, 267);
            label2.Name = "label2";
            label2.Size = new Size(160, 18);
            label2.TabIndex = 6;
            label2.Text = "___________________";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(120, 225);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 5;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // LoginLoginside
            // 
            LoginLoginside.BackColor = Color.FromArgb(128, 255, 128);
            LoginLoginside.BackgroundImageLayout = ImageLayout.None;
            LoginLoginside.FlatStyle = FlatStyle.Flat;
            LoginLoginside.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLoginside.ForeColor = Color.Black;
            LoginLoginside.Location = new Point(105, 333);
            LoginLoginside.Margin = new Padding(3, 4, 3, 4);
            LoginLoginside.Name = "LoginLoginside";
            LoginLoginside.Size = new Size(114, 43);
            LoginLoginside.TabIndex = 10;
            LoginLoginside.Text = "Login";
            LoginLoginside.UseVisualStyleBackColor = false;
            LoginLoginside.Click += LoginLoginside_Click;
            // 
            // Loginloginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(334, 415);
            Controls.Add(LoginLoginside);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(_1);
            Controls.Add(Loginloginform1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Loginloginform";
            Text = "Loginloginform";
            Load += Loginloginform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label Loginloginform1;
        private Label _1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Button LoginLoginside;
    }
}
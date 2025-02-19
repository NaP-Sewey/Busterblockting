
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Close = new Button();
            Minimize = new Button();
            LoginLoginside = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 47);
            label1.TabIndex = 1;
            label1.Text = "Busterblock";
            // 
            // Loginloginform1
            // 
            Loginloginform1.AutoSize = true;
            Loginloginform1.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loginloginform1.ForeColor = Color.Yellow;
            Loginloginform1.Location = new Point(105, 82);
            Loginloginform1.Name = "Loginloginform1";
            Loginloginform1.Size = new Size(73, 19);
            Loginloginform1.TabIndex = 2;
            Loginloginform1.Text = "Username";
            Loginloginform1.Click += Loginloginform1_Click;
            // 
            // _1
            // 
            _1.AutoSize = true;
            _1.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _1.ForeColor = Color.Yellow;
            _1.Location = new Point(72, 113);
            _1.Name = "_1";
            _1.Size = new Size(140, 14);
            _1.TabIndex = 3;
            _1.Text = "___________________";
            _1.Click += _1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Yellow;
            textBox1.Location = new Point(82, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 16);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HotTrack;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.Yellow;
            textBox2.Location = new Point(82, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 16);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(72, 200);
            label2.Name = "label2";
            label2.Size = new Size(140, 14);
            label2.TabIndex = 6;
            label2.Text = "___________________";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(105, 169);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 5;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // Close
            // 
            Close.BackColor = SystemColors.ControlDark;
            Close.BackgroundImageLayout = ImageLayout.None;
            Close.FlatStyle = FlatStyle.Flat;
            Close.ForeColor = Color.Red;
            Close.Location = new Point(262, 9);
            Close.Name = "Close";
            Close.Size = new Size(21, 24);
            Close.TabIndex = 8;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += button1_Click;
            // 
            // Minimize
            // 
            Minimize.BackColor = SystemColors.ControlDark;
            Minimize.BackgroundImageLayout = ImageLayout.None;
            Minimize.FlatStyle = FlatStyle.Flat;
            Minimize.Font = new Font("Ravie", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Minimize.ForeColor = Color.Fuchsia;
            Minimize.Location = new Point(235, 9);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(21, 24);
            Minimize.TabIndex = 9;
            Minimize.Text = "-";
            Minimize.UseVisualStyleBackColor = false;
            Minimize.Click += Minimize_Click;
            // 
            // LoginLoginside
            // 
            LoginLoginside.BackColor = Color.FromArgb(128, 255, 128);
            LoginLoginside.BackgroundImageLayout = ImageLayout.None;
            LoginLoginside.FlatStyle = FlatStyle.Flat;
            LoginLoginside.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLoginside.ForeColor = Color.Black;
            LoginLoginside.Location = new Point(92, 250);
            LoginLoginside.Name = "LoginLoginside";
            LoginLoginside.Size = new Size(100, 32);
            LoginLoginside.TabIndex = 10;
            LoginLoginside.Text = "Login";
            LoginLoginside.UseVisualStyleBackColor = false;
            LoginLoginside.Click += LoginLoginside_Click;
            // 
            // Loginloginform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(292, 311);
            Controls.Add(LoginLoginside);
            Controls.Add(Minimize);
            Controls.Add(Close);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(_1);
            Controls.Add(Loginloginform1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button Close;
        private Button Minimize;
        private Button LoginLoginside;
    }
}
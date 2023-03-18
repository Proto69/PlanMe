namespace PlanMe.User_Controls
{
    partial class LogIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.LogIn;
            pictureBox1.Location = new Point(353, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // usernameBox
            // 
            usernameBox.Anchor = AnchorStyles.None;
            usernameBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            usernameBox.Location = new Point(301, 245);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Enter username";
            usernameBox.Size = new Size(290, 30);
            usernameBox.TabIndex = 11;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.None;
            passwordBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.Location = new Point(301, 295);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = "Enter password";
            passwordBox.Size = new Size(290, 30);
            passwordBox.TabIndex = 12;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(301, 365);
            button1.Name = "button1";
            button1.Size = new Size(290, 50);
            button1.TabIndex = 13;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.ForestGreen;
            linkLabel1.Location = new Point(498, 197);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 23);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(301, 197);
            label1.Name = "label1";
            label1.Size = new Size(191, 23);
            label1.TabIndex = 16;
            label1.Text = "Don't have an account?";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(277, 153);
            label3.Name = "label3";
            label3.Size = new Size(339, 20);
            label3.TabIndex = 18;
            label3.Text = "_______________________________________________________";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LogInBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            DoubleBuffered = true;
            Name = "LogIn";
            Size = new Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label3;
    }
}

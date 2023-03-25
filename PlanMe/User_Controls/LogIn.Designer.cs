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
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            LogInButton = new Button();
            SignUpLinkedLabel = new LinkLabel();
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
            // UsernameBox
            // 
            UsernameBox.Anchor = AnchorStyles.None;
            UsernameBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameBox.Location = new Point(291, 245);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.PlaceholderText = "Enter username";
            UsernameBox.Size = new Size(300, 30);
            UsernameBox.TabIndex = 11;
            // 
            // PasswordBox
            // 
            PasswordBox.Anchor = AnchorStyles.None;
            PasswordBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.Location = new Point(291, 295);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.PlaceholderText = "Enter password";
            PasswordBox.Size = new Size(300, 30);
            PasswordBox.TabIndex = 12;
            // 
            // LogInButton
            // 
            LogInButton.Anchor = AnchorStyles.None;
            LogInButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LogInButton.BackColor = Color.ForestGreen;
            LogInButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LogInButton.ForeColor = SystemColors.ButtonHighlight;
            LogInButton.Location = new Point(291, 358);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(300, 50);
            LogInButton.TabIndex = 13;
            LogInButton.Text = "Log in";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // SignUpLinkedLabel
            // 
            SignUpLinkedLabel.Anchor = AnchorStyles.None;
            SignUpLinkedLabel.AutoSize = true;
            SignUpLinkedLabel.BackColor = Color.Transparent;
            SignUpLinkedLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpLinkedLabel.LinkColor = Color.ForestGreen;
            SignUpLinkedLabel.Location = new Point(489, 197);
            SignUpLinkedLabel.Name = "SignUpLinkedLabel";
            SignUpLinkedLabel.Size = new Size(68, 23);
            SignUpLinkedLabel.TabIndex = 15;
            SignUpLinkedLabel.TabStop = true;
            SignUpLinkedLabel.Text = "Sign up";
            SignUpLinkedLabel.LinkClicked += SignUpLinkedLabel_LinkClicked;
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
            Controls.Add(SignUpLinkedLabel);
            Controls.Add(LogInButton);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            DoubleBuffered = true;
            Name = "LogIn";
            Size = new Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button LogInButton;
        private LinkLabel SignUpLinkedLabel;
        private Label label1;
        private Label label3;
    }
}

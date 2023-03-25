namespace PlanMe.User_Controls
{
    partial class SignUp
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
            NameBox = new TextBox();
            PasswordBox = new TextBox();
            RepeatPasswordBox = new TextBox();
            SignUpButton = new Button();
            LogInLinkedLabel = new LinkLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Anchor = AnchorStyles.None;
            NameBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(300, 224);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Enter username";
            NameBox.Size = new Size(300, 30);
            NameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Anchor = AnchorStyles.None;
            PasswordBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.Location = new Point(300, 272);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.PlaceholderText = "Enter password";
            PasswordBox.Size = new Size(300, 30);
            PasswordBox.TabIndex = 1;
            // 
            // RepeatPasswordBox
            // 
            RepeatPasswordBox.Anchor = AnchorStyles.None;
            RepeatPasswordBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RepeatPasswordBox.Location = new Point(300, 321);
            RepeatPasswordBox.Name = "RepeatPasswordBox";
            RepeatPasswordBox.PasswordChar = '*';
            RepeatPasswordBox.PlaceholderText = "Repeat password";
            RepeatPasswordBox.Size = new Size(300, 30);
            RepeatPasswordBox.TabIndex = 2;
            // 
            // SignUpButton
            // 
            SignUpButton.Anchor = AnchorStyles.None;
            SignUpButton.BackColor = Color.ForestGreen;
            SignUpButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpButton.ForeColor = SystemColors.ButtonHighlight;
            SignUpButton.Location = new Point(300, 386);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(300, 50);
            SignUpButton.TabIndex = 3;
            SignUpButton.Text = "Sign up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // LogInLinkedLabel
            // 
            LogInLinkedLabel.Anchor = AnchorStyles.None;
            LogInLinkedLabel.AutoSize = true;
            LogInLinkedLabel.BackColor = Color.Transparent;
            LogInLinkedLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LogInLinkedLabel.LinkColor = Color.Green;
            LogInLinkedLabel.Location = new Point(502, 176);
            LogInLinkedLabel.Name = "LogInLinkedLabel";
            LogInLinkedLabel.Size = new Size(57, 23);
            LogInLinkedLabel.TabIndex = 4;
            LogInLinkedLabel.TabStop = true;
            LogInLinkedLabel.Text = "Log in";
            LogInLinkedLabel.LinkClicked += LogInLinkedLabel_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(300, 176);
            label1.Name = "label1";
            label1.Size = new Size(206, 23);
            label1.TabIndex = 8;
            label1.Text = "Already have an account?";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.SingUp;
            pictureBox1.Location = new Point(345, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(280, 140);
            label2.Name = "label2";
            label2.Size = new Size(339, 20);
            label2.TabIndex = 10;
            label2.Text = "_______________________________________________________";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SignUpBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Controls.Add(LogInLinkedLabel);
            Controls.Add(SignUpButton);
            Controls.Add(RepeatPasswordBox);
            Controls.Add(PasswordBox);
            DoubleBuffered = true;
            Name = "SignUp";
            Size = new Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private TextBox PasswordBox;
        private TextBox RepeatPasswordBox;
        private Button SignUpButton;
        private LinkLabel LogInLinkedLabel;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}

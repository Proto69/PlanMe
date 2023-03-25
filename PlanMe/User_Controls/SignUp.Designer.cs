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
            NameBox.Location = new Point(450, 336);
            NameBox.Margin = new Padding(4, 4, 4, 4);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Enter username";
            NameBox.Size = new Size(448, 39);
            NameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Anchor = AnchorStyles.None;
            PasswordBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.Location = new Point(450, 408);
            PasswordBox.Margin = new Padding(4, 4, 4, 4);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.PlaceholderText = "Enter password";
            PasswordBox.Size = new Size(448, 39);
            PasswordBox.TabIndex = 1;
            // 
            // RepeatPasswordBox
            // 
            RepeatPasswordBox.Anchor = AnchorStyles.None;
            RepeatPasswordBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RepeatPasswordBox.Location = new Point(450, 482);
            RepeatPasswordBox.Margin = new Padding(4, 4, 4, 4);
            RepeatPasswordBox.Name = "RepeatPasswordBox";
            RepeatPasswordBox.PasswordChar = '*';
            RepeatPasswordBox.PlaceholderText = "Repeat password";
            RepeatPasswordBox.Size = new Size(448, 39);
            RepeatPasswordBox.TabIndex = 2;
            // 
            // SignUpButton
            // 
            SignUpButton.Anchor = AnchorStyles.None;
            SignUpButton.BackColor = Color.ForestGreen;
            SignUpButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpButton.ForeColor = SystemColors.ButtonHighlight;
            SignUpButton.Location = new Point(450, 579);
            SignUpButton.Margin = new Padding(4, 4, 4, 4);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(450, 75);
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
            LogInLinkedLabel.Location = new Point(753, 264);
            LogInLinkedLabel.Margin = new Padding(4, 0, 4, 0);
            LogInLinkedLabel.Name = "LogInLinkedLabel";
            LogInLinkedLabel.Size = new Size(80, 32);
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
            label1.Location = new Point(450, 264);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 32);
            label1.TabIndex = 8;
            label1.Text = "Already have an account?";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.SingUp;
            pictureBox1.Location = new Point(518, 90);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(420, 210);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(508, 30);
            label2.TabIndex = 10;
            label2.Text = "_______________________________________________________";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "SignUp";
            Size = new Size(1350, 750);
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

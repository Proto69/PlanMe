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
            nameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            repeatPasswordTextBox = new TextBox();
            signUpButton = new Button();
            logInLinkLabel = new LinkLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.None;
            nameTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(300, 224);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Enter username";
            nameTextBox.Size = new Size(300, 30);
            nameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(300, 272);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Enter password";
            passwordTextBox.Size = new Size(300, 30);
            passwordTextBox.TabIndex = 1;
            // 
            // repeatPasswordTextBox
            // 
            repeatPasswordTextBox.Anchor = AnchorStyles.None;
            repeatPasswordTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            repeatPasswordTextBox.Location = new Point(300, 321);
            repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            repeatPasswordTextBox.PasswordChar = '*';
            repeatPasswordTextBox.PlaceholderText = "Repeat password";
            repeatPasswordTextBox.Size = new Size(300, 30);
            repeatPasswordTextBox.TabIndex = 2;
            // 
            // signUpButton
            // 
            signUpButton.Anchor = AnchorStyles.None;
            signUpButton.BackColor = Color.ForestGreen;
            signUpButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signUpButton.ForeColor = SystemColors.ButtonHighlight;
            signUpButton.Location = new Point(300, 390);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(300, 55);
            signUpButton.TabIndex = 3;
            signUpButton.Text = "Sign up";
            signUpButton.UseVisualStyleBackColor = false;
            // 
            // logInLinkLabel
            // 
            logInLinkLabel.Anchor = AnchorStyles.None;
            logInLinkLabel.AutoSize = true;
            logInLinkLabel.BackColor = Color.Transparent;
            logInLinkLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            logInLinkLabel.LinkColor = Color.Green;
            logInLinkLabel.Location = new Point(502, 176);
            logInLinkLabel.Name = "logInLinkLabel";
            logInLinkLabel.Size = new Size(57, 23);
            logInLinkLabel.TabIndex = 4;
            logInLinkLabel.TabStop = true;
            logInLinkLabel.Text = "Log in";
            logInLinkLabel.Click += logInLinkLabel_Click;
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
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(logInLinkLabel);
            Controls.Add(signUpButton);
            Controls.Add(repeatPasswordTextBox);
            Controls.Add(passwordTextBox);
            DoubleBuffered = true;
            Name = "SignUp";
            Size = new Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox passwordTextBox;
        private TextBox repeatPasswordTextBox;
        private Button signUpButton;
        private LinkLabel logInLinkLabel;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}

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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.logInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(301, 235);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(300, 27);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Enter name";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(302, 287);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(300, 27);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Enter password";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(301, 342);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(300, 27);
            this.repeatPasswordTextBox.TabIndex = 2;
            this.repeatPasswordTextBox.Text = "Repeat password";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.ForestGreen;
            this.signUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signUpButton.Location = new System.Drawing.Point(300, 412);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(301, 36);
            this.signUpButton.TabIndex = 3;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUp_Click);
            // 
            // logInLinkLabel
            // 
            this.logInLinkLabel.AutoSize = true;
            this.logInLinkLabel.LinkColor = System.Drawing.Color.Green;
            this.logInLinkLabel.Location = new System.Drawing.Point(476, 186);
            this.logInLinkLabel.Name = "logInLinkLabel";
            this.logInLinkLabel.Size = new System.Drawing.Size(50, 20);
            this.logInLinkLabel.TabIndex = 4;
            this.logInLinkLabel.TabStop = true;
            this.logInLinkLabel.Text = "Log in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Already have an account?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlanMe.Properties.Resources.PlanMe1;
            this.pictureBox1.Location = new System.Drawing.Point(330, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 85);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logInLinkLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private TextBox passwordTextBox;
        private TextBox repeatPasswordTextBox;
        private Button signUpButton;
        private LinkLabel logInLinkLabel;
        private Label label1;
        private PictureBox pictureBox1;
    }
}

namespace PlanMe.User_Controls
{
    partial class _3
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
            this.nameTextBox.Location = new System.Drawing.Point(452, 352);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(448, 35);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Enter name";
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(453, 430);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(448, 35);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Enter password";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(452, 513);
            this.repeatPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(448, 35);
            this.repeatPasswordTextBox.TabIndex = 2;
            this.repeatPasswordTextBox.Text = "Repeat password";
            this.repeatPasswordTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.ForestGreen;
            this.signUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signUpButton.Location = new System.Drawing.Point(450, 618);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(452, 54);
            this.signUpButton.TabIndex = 3;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // logInLinkLabel
            // 
            this.logInLinkLabel.AutoSize = true;
            this.logInLinkLabel.LinkColor = System.Drawing.Color.Green;
            this.logInLinkLabel.Location = new System.Drawing.Point(714, 279);
            this.logInLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logInLinkLabel.Name = "logInLinkLabel";
            this.logInLinkLabel.Size = new System.Drawing.Size(70, 30);
            this.logInLinkLabel.TabIndex = 4;
            this.logInLinkLabel.TabStop = true;
            this.logInLinkLabel.Text = "Log in";
            this.logInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Already have an account?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlanMe.Properties.Resources.PlanMe1;
            this.pictureBox1.Location = new System.Drawing.Point(502, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 128);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // _3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logInLinkLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "_3";
            this.Size = new System.Drawing.Size(1350, 750);
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

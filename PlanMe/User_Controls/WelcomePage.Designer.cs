namespace PlanMe.User_Controls
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            StartButton = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.ForestGreen;
            StartButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.ForeColor = SystemColors.ButtonHighlight;
            StartButton.Location = new Point(1017, 649);
            StartButton.Margin = new Padding(4);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(262, 88);
            StartButton.TabIndex = 12;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.WelcomePage;
            pictureBox1.Location = new Point(250, 70);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(765, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(102, 164);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1075, 30);
            label2.TabIndex = 15;
            label2.Text = "______________________________________________________________________________________________________________________";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Calibri", 15.8571434F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(92, 216);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(1104, 405);
            textBox1.TabIndex = 16;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(StartButton);
            Controls.Add(label2);
            Margin = new Padding(4);
            Name = "WelcomePage";
            Size = new Size(1350, 750);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button StartButton;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
    }
}

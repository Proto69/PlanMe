namespace PlanMe.User_Controls
{
    partial class AddList
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
            label1 = new Label();
            label2 = new Label();
            CreateListButton = new Button();
            ListNameBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(184, 50);
            label1.Name = "label1";
            label1.Size = new Size(270, 62);
            label1.TabIndex = 1;
            label1.Text = "Create a list";
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(135, 86);
            label2.Name = "label2";
            label2.Size = new Size(301, 30);
            label2.TabIndex = 3;
            label2.Text = "________________________________";
            // 
            // CreateListButton
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(158, 232);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 4;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ListNameBox
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(89, 151);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Write list's name...";
            textBox1.Size = new Size(320, 34);
            textBox1.TabIndex = 5;
            // 
            // AddList
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(ListNameBox);
            Controls.Add(CreateListButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "AddList";
            Size = new Size(482, 336);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button CreateListButton;
        private TextBox ListNameBox;
    }
}

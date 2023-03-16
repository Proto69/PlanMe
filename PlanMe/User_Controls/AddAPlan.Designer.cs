namespace PlanMe.User_Controls
{
    partial class AddAPlan
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.InfoBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a plan";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameBox.Location = new System.Drawing.Point(137, 148);
            this.NameBox.Name = "NameBox";
            this.NameBox.PlaceholderText = "Name ";
            this.NameBox.Size = new System.Drawing.Size(306, 32);
            this.NameBox.TabIndex = 2;
            // 
            // DateBox
            // 
            this.DateBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateBox.Location = new System.Drawing.Point(140, 198);
            this.DateBox.Name = "DateBox";
            this.DateBox.PlaceholderText = "Date";
            this.DateBox.Size = new System.Drawing.Size(306, 32);
            this.DateBox.TabIndex = 3;
            // 
            // InfoBox
            // 
            this.InfoBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoBox.Location = new System.Drawing.Point(137, 253);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.PlaceholderText = "About";
            this.InfoBox.Size = new System.Drawing.Size(306, 32);
            this.InfoBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(201, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(137, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "__________________________________________________";
            // 
            // AddAPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlanMe.Properties.Resources.background;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddAPlan";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox NameBox;
        private TextBox DateBox;
        private TextBox InfoBox;
        private Button button1;
        private Label label2;
    }
}

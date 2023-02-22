﻿namespace PlanMe
{
    partial class MainScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plansButton = new System.Windows.Forms.Button();
            this.listsButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.phraseBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlanMe.Properties.Resources.PlanMe1;
            this.pictureBox1.Location = new System.Drawing.Point(598, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 83);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // plansButton
            // 
            this.plansButton.BackColor = System.Drawing.Color.ForestGreen;
            this.plansButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plansButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.plansButton.Location = new System.Drawing.Point(391, 232);
            this.plansButton.Name = "plansButton";
            this.plansButton.Size = new System.Drawing.Size(110, 60);
            this.plansButton.TabIndex = 11;
            this.plansButton.Text = "plans";
            this.plansButton.UseVisualStyleBackColor = false;
            this.plansButton.Click += new System.EventHandler(this.plansButton_Click);
            // 
            // listsButton
            // 
            this.listsButton.BackColor = System.Drawing.Color.ForestGreen;
            this.listsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listsButton.Location = new System.Drawing.Point(155, 356);
            this.listsButton.Name = "listsButton";
            this.listsButton.Size = new System.Drawing.Size(110, 60);
            this.listsButton.TabIndex = 12;
            this.listsButton.Text = "lists";
            this.listsButton.UseVisualStyleBackColor = false;
            this.listsButton.Click += new System.EventHandler(this.listsButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PlanMe.Properties.Resources.calendar;
            this.pictureBox2.Location = new System.Drawing.Point(-29, -20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(951, 546);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.ForestGreen;
            this.infoButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.infoButton.Location = new System.Drawing.Point(625, 419);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(110, 60);
            this.infoButton.TabIndex = 14;
            this.infoButton.Text = "for the app";
            this.infoButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Phrase of the day:";
            // 
            // phraseBox
            // 
            this.phraseBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phraseBox.Location = new System.Drawing.Point(51, 61);
            this.phraseBox.Multiline = true;
            this.phraseBox.Name = "phraseBox";
            this.phraseBox.ReadOnly = true;
            this.phraseBox.Size = new System.Drawing.Size(430, 43);
            this.phraseBox.TabIndex = 16;
            this.phraseBox.Text = "daily phrase";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.phraseBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.listsButton);
            this.Controls.Add(this.plansButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button plansButton;
        private Button listsButton;
        private PictureBox pictureBox2;
        private Button infoButton;
        private Label label1;
        private TextBox phraseBox;
    }
}

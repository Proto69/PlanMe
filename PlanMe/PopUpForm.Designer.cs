namespace PlanMe
{
    partial class PopUpForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addaTask1 = new PlanMe.User_Controls.AddATask();
            this.SuspendLayout();
            // 
            // addaTask1
            // 
            this.addaTask1.Location = new System.Drawing.Point(0, 0);
            this.addaTask1.Name = "addaTask1";
            this.addaTask1.Size = new System.Drawing.Size(460, 379);
            this.addaTask1.TabIndex = 0;
            // 
            // AddATask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 385);
            this.Controls.Add(this.addaTask1);
            this.Name = "AddATask";
            this.Text = "AddATask";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.AddATask addaTask1;
    }
}
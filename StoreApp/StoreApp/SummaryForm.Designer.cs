namespace StoreApp
{
    partial class SummaryForm
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
            this.ExitSummaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitSummaryButton
            // 
            this.ExitSummaryButton.Location = new System.Drawing.Point(675, 389);
            this.ExitSummaryButton.Name = "ExitSummaryButton";
            this.ExitSummaryButton.Size = new System.Drawing.Size(75, 23);
            this.ExitSummaryButton.TabIndex = 0;
            this.ExitSummaryButton.Text = "Exit";
            this.ExitSummaryButton.UseVisualStyleBackColor = true;
            this.ExitSummaryButton.Click += new System.EventHandler(this.ExitSummaryButton_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitSummaryButton);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitSummaryButton;
    }
}
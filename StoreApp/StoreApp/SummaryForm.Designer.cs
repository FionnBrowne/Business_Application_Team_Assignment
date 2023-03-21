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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.ExitSummaryButton = new System.Windows.Forms.Button();
            this.StockListbox = new System.Windows.Forms.ListBox();
            this.SalesListbox = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitSummaryButton
            // 
            this.ExitSummaryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitSummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitSummaryButton.Location = new System.Drawing.Point(88, 401);
            this.ExitSummaryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitSummaryButton.Name = "ExitSummaryButton";
            this.ExitSummaryButton.Size = new System.Drawing.Size(107, 33);
            this.ExitSummaryButton.TabIndex = 0;
            this.ExitSummaryButton.Text = "&Close";
            this.toolTip1.SetToolTip(this.ExitSummaryButton, "Closes the Summary Form");
            this.ExitSummaryButton.UseVisualStyleBackColor = false;
            this.ExitSummaryButton.Click += new System.EventHandler(this.ExitSummaryButton_Click);
            // 
            // StockListbox
            // 
            this.StockListbox.FormattingEnabled = true;
            this.StockListbox.ItemHeight = 16;
            this.StockListbox.Location = new System.Drawing.Point(15, 14);
            this.StockListbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StockListbox.Name = "StockListbox";
            this.StockListbox.Size = new System.Drawing.Size(237, 212);
            this.StockListbox.TabIndex = 1;
            // 
            // SalesListbox
            // 
            this.SalesListbox.FormattingEnabled = true;
            this.SalesListbox.ItemHeight = 16;
            this.SalesListbox.Location = new System.Drawing.Point(276, 14);
            this.SalesListbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalesListbox.Name = "SalesListbox";
            this.SalesListbox.Size = new System.Drawing.Size(237, 420);
            this.SalesListbox.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::StoreApp.Properties.Resources._3_guys_pizzeria1;
            this.pictureBox1.Location = new System.Drawing.Point(53, 236);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(527, 443);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SalesListbox);
            this.Controls.Add(this.StockListbox);
            this.Controls.Add(this.ExitSummaryButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitSummaryButton;
        private System.Windows.Forms.ListBox StockListbox;
        private System.Windows.Forms.ListBox SalesListbox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
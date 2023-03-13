namespace StoreApp
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PizzaSizeListBox = new System.Windows.Forms.ListBox();
            this.PizzaTypeListBox = new System.Windows.Forms.ListBox();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PizzaSizeListBox);
            this.panel1.Controls.Add(this.PizzaTypeListBox);
            this.panel1.Controls.Add(this.SummaryButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkedListBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(77, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1932, 598);
            this.panel1.TabIndex = 0;
            // 
            // PizzaSizeListBox
            // 
            this.PizzaSizeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaSizeListBox.FormattingEnabled = true;
            this.PizzaSizeListBox.ItemHeight = 20;
            this.PizzaSizeListBox.Items.AddRange(new object[] {
            " 6  inch",
            " 9  inch",
            "12 inch",
            "15 inch",
            "18 inch"});
            this.PizzaSizeListBox.Location = new System.Drawing.Point(263, 63);
            this.PizzaSizeListBox.Name = "PizzaSizeListBox";
            this.PizzaSizeListBox.Size = new System.Drawing.Size(151, 224);
            this.PizzaSizeListBox.TabIndex = 16;
            // 
            // PizzaTypeListBox
            // 
            this.PizzaTypeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaTypeListBox.FormattingEnabled = true;
            this.PizzaTypeListBox.ItemHeight = 18;
            this.PizzaTypeListBox.Items.AddRange(new object[] {
            "Margherita Pizza\t\t",
            "Hawaiian Pizza\t\t\t",
            "Pepperoni\t\t",
            "Meat Feast\t\t",
            "Chicago Deep Dish Pizza\t",
            "Veggie Pizza\t\t",
            "BBQ Chicken Pizza\t\t",
            "Peri Peri Chicken Pizza\t",
            "Beef Supreme Pizza\t",
            "Neapolitan Pizza\t\t",
            "Buffalo Pizza\t\t",
            "Ham and Cheese Pizza\t",
            "3-Guys-Special-Pizza"});
            this.PizzaTypeListBox.Location = new System.Drawing.Point(58, 63);
            this.PizzaTypeListBox.Name = "PizzaTypeListBox";
            this.PizzaTypeListBox.Size = new System.Drawing.Size(199, 202);
            this.PizzaTypeListBox.TabIndex = 15;
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(1376, 419);
            this.SummaryButton.Margin = new System.Windows.Forms.Padding(4);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(100, 28);
            this.SummaryButton.TabIndex = 14;
            this.SummaryButton.Text = "Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1376, 247);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Apples",
            "cars",
            "road kill",
            "plastic"});
            this.checkedListBox3.Location = new System.Drawing.Point(974, 50);
            this.checkedListBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(217, 225);
            this.checkedListBox3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(970, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Additional toppings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pizza type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pizza sizes& cost";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 565);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "3 Guys Pizza";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.ListBox PizzaSizeListBox;
        private System.Windows.Forms.ListBox PizzaTypeListBox;
    }
}


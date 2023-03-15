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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentOrderTotalTextBox = new System.Windows.Forms.TextBox();
            this.AddOrderToOrderButton = new System.Windows.Forms.Button();
            this.PizzaSizeListBox = new System.Windows.Forms.ListBox();
            this.PizzaTypeListBox = new System.Windows.Forms.ListBox();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ExitSummaryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CurrentOrderTotalTextBox);
            this.panel1.Controls.Add(this.AddOrderToOrderButton);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.PizzaSizeListBox);
            this.panel1.Controls.Add(this.PizzaTypeListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(58, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 385);
            this.panel1.TabIndex = 0;
            // 
            // CurrentOrderTotalTextBox
            // 
            this.CurrentOrderTotalTextBox.Location = new System.Drawing.Point(480, 161);
            this.CurrentOrderTotalTextBox.Name = "CurrentOrderTotalTextBox";
            this.CurrentOrderTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurrentOrderTotalTextBox.TabIndex = 18;
            // 
            // AddOrderToOrderButton
            // 
            this.AddOrderToOrderButton.Location = new System.Drawing.Point(600, 158);
            this.AddOrderToOrderButton.Name = "AddOrderToOrderButton";
            this.AddOrderToOrderButton.Size = new System.Drawing.Size(75, 23);
            this.AddOrderToOrderButton.TabIndex = 17;
            this.AddOrderToOrderButton.Text = "Add to Order";
            this.AddOrderToOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderToOrderButton.Click += new System.EventHandler(this.AddOrderToOrderButton_Click);
            // 
            // PizzaSizeListBox
            // 
            this.PizzaSizeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaSizeListBox.FormattingEnabled = true;
            this.PizzaSizeListBox.ItemHeight = 16;
            this.PizzaSizeListBox.Items.AddRange(new object[] {
            " 6  inch",
            " 9  inch",
            "12 inch",
            "15 inch",
            "18 inch"});
            this.PizzaSizeListBox.Location = new System.Drawing.Point(197, 51);
            this.PizzaSizeListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PizzaSizeListBox.Name = "PizzaSizeListBox";
            this.PizzaSizeListBox.Size = new System.Drawing.Size(114, 180);
            this.PizzaSizeListBox.TabIndex = 16;
            // 
            // PizzaTypeListBox
            // 
            this.PizzaTypeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaTypeListBox.FormattingEnabled = true;
            this.PizzaTypeListBox.ItemHeight = 15;
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
            this.PizzaTypeListBox.Location = new System.Drawing.Point(44, 51);
            this.PizzaTypeListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PizzaTypeListBox.Name = "PizzaTypeListBox";
            this.PizzaTypeListBox.Size = new System.Drawing.Size(150, 154);
            this.PizzaTypeListBox.TabIndex = 15;
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryButton.Location = new System.Drawing.Point(3, 135);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(80, 27);
            this.SummaryButton.TabIndex = 14;
            this.SummaryButton.Text = "&Summary";
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Confirm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.SummaryButton);
            this.flowLayoutPanel1.Controls.Add(this.ExitSummaryButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(881, 175);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(85, 200);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 27);
            this.button2.TabIndex = 19;
            this.button2.Text = "&Button";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 27);
            this.button3.TabIndex = 20;
            this.button3.Text = "&Button";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 27);
            this.button4.TabIndex = 21;
            this.button4.Text = "&Button";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ExitSummaryButton
            // 
            this.ExitSummaryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitSummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitSummaryButton.Location = new System.Drawing.Point(3, 168);
            this.ExitSummaryButton.Name = "ExitSummaryButton";
            this.ExitSummaryButton.Size = new System.Drawing.Size(80, 27);
            this.ExitSummaryButton.TabIndex = 18;
            this.ExitSummaryButton.Text = "&Exit";
            this.ExitSummaryButton.UseVisualStyleBackColor = false;
            this.ExitSummaryButton.Click += new System.EventHandler(this.ExitSummaryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pizza type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pizza sizes& cost";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "3 Guys Pizza";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.ListBox PizzaSizeListBox;
        private System.Windows.Forms.ListBox PizzaTypeListBox;
        private System.Windows.Forms.Button AddOrderToOrderButton;
        private System.Windows.Forms.TextBox CurrentOrderTotalTextBox;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ExitSummaryButton;
    }
}


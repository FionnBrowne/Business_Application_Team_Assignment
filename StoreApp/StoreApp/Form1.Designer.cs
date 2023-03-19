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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.DecreaseQuantityButton = new System.Windows.Forms.Button();
            this.PizzaQuantityTextbox = new System.Windows.Forms.TextBox();
            this.IncreaseQuantityButton = new System.Windows.Forms.Button();
            this.CancelTransactionButton = new System.Windows.Forms.Button();
            this.RemoveSelectedItemButton = new System.Windows.Forms.Button();
            this.OrderTotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderedListbox = new System.Windows.Forms.ListBox();
            this.CurrentOrderTotalTextBox = new System.Windows.Forms.TextBox();
            this.AddOrderToOrderButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ExitSummaryButton = new System.Windows.Forms.Button();
            this.PizzaSizeListBox = new System.Windows.Forms.ListBox();
            this.PizzaTypeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.QuantityLabel);
            this.panel1.Controls.Add(this.DecreaseQuantityButton);
            this.panel1.Controls.Add(this.PizzaQuantityTextbox);
            this.panel1.Controls.Add(this.IncreaseQuantityButton);
            this.panel1.Controls.Add(this.CancelTransactionButton);
            this.panel1.Controls.Add(this.RemoveSelectedItemButton);
            this.panel1.Controls.Add(this.OrderTotalTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OrderedListbox);
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Current Transaction Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total Transaction Cost";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(3, 206);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(91, 13);
            this.QuantityLabel.TabIndex = 28;
            this.QuantityLabel.Text = "Number Of Pizzas";
            // 
            // DecreaseQuantityButton
            // 
            this.DecreaseQuantityButton.Location = new System.Drawing.Point(100, 203);
            this.DecreaseQuantityButton.Name = "DecreaseQuantityButton";
            this.DecreaseQuantityButton.Size = new System.Drawing.Size(16, 20);
            this.DecreaseQuantityButton.TabIndex = 27;
            this.DecreaseQuantityButton.Text = "<";
            this.DecreaseQuantityButton.UseVisualStyleBackColor = true;
            this.DecreaseQuantityButton.Click += new System.EventHandler(this.DecreaseQuantityButton_Click);
            // 
            // PizzaQuantityTextbox
            // 
            this.PizzaQuantityTextbox.Location = new System.Drawing.Point(117, 203);
            this.PizzaQuantityTextbox.Name = "PizzaQuantityTextbox";
            this.PizzaQuantityTextbox.ReadOnly = true;
            this.PizzaQuantityTextbox.ShortcutsEnabled = false;
            this.PizzaQuantityTextbox.Size = new System.Drawing.Size(20, 20);
            this.PizzaQuantityTextbox.TabIndex = 26;
            this.PizzaQuantityTextbox.TabStop = false;
            this.PizzaQuantityTextbox.Text = "1";
            this.PizzaQuantityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IncreaseQuantityButton
            // 
            this.IncreaseQuantityButton.Location = new System.Drawing.Point(139, 203);
            this.IncreaseQuantityButton.Name = "IncreaseQuantityButton";
            this.IncreaseQuantityButton.Size = new System.Drawing.Size(16, 20);
            this.IncreaseQuantityButton.TabIndex = 25;
            this.IncreaseQuantityButton.Text = ">";
            this.IncreaseQuantityButton.UseVisualStyleBackColor = true;
            this.IncreaseQuantityButton.Click += new System.EventHandler(this.IncreaseQuantityButton_Click);
            // 
            // CancelTransactionButton
            // 
            this.CancelTransactionButton.Location = new System.Drawing.Point(331, 294);
            this.CancelTransactionButton.Name = "CancelTransactionButton";
            this.CancelTransactionButton.Size = new System.Drawing.Size(86, 34);
            this.CancelTransactionButton.TabIndex = 23;
            this.CancelTransactionButton.Text = "Cancel Transaction";
            this.CancelTransactionButton.UseVisualStyleBackColor = true;
            this.CancelTransactionButton.Click += new System.EventHandler(this.CancelTransactionButton_Click);
            // 
            // RemoveSelectedItemButton
            // 
            this.RemoveSelectedItemButton.Location = new System.Drawing.Point(331, 254);
            this.RemoveSelectedItemButton.Name = "RemoveSelectedItemButton";
            this.RemoveSelectedItemButton.Size = new System.Drawing.Size(86, 34);
            this.RemoveSelectedItemButton.TabIndex = 22;
            this.RemoveSelectedItemButton.Text = "Remove Selected Item";
            this.RemoveSelectedItemButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedItemButton.Click += new System.EventHandler(this.RemoveSelectedItemButton_Click);
            // 
            // OrderTotalTextBox
            // 
            this.OrderTotalTextBox.Location = new System.Drawing.Point(331, 362);
            this.OrderTotalTextBox.Name = "OrderTotalTextBox";
            this.OrderTotalTextBox.ReadOnly = true;
            this.OrderTotalTextBox.Size = new System.Drawing.Size(86, 20);
            this.OrderTotalTextBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Order Summary";
            // 
            // OrderedListbox
            // 
            this.OrderedListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderedListbox.FormattingEnabled = true;
            this.OrderedListbox.ItemHeight = 15;
            this.OrderedListbox.Location = new System.Drawing.Point(2, 254);
            this.OrderedListbox.Margin = new System.Windows.Forms.Padding(2);
            this.OrderedListbox.Name = "OrderedListbox";
            this.OrderedListbox.Size = new System.Drawing.Size(324, 109);
            this.OrderedListbox.TabIndex = 19;
            // 
            // CurrentOrderTotalTextBox
            // 
            this.CurrentOrderTotalTextBox.Location = new System.Drawing.Point(331, 334);
            this.CurrentOrderTotalTextBox.Name = "CurrentOrderTotalTextBox";
            this.CurrentOrderTotalTextBox.ReadOnly = true;
            this.CurrentOrderTotalTextBox.Size = new System.Drawing.Size(86, 20);
            this.CurrentOrderTotalTextBox.TabIndex = 18;
            // 
            // AddOrderToOrderButton
            // 
            this.AddOrderToOrderButton.Location = new System.Drawing.Point(214, 201);
            this.AddOrderToOrderButton.Name = "AddOrderToOrderButton";
            this.AddOrderToOrderButton.Size = new System.Drawing.Size(75, 23);
            this.AddOrderToOrderButton.TabIndex = 17;
            this.AddOrderToOrderButton.Text = "Add to Order";
            this.AddOrderToOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderToOrderButton.Click += new System.EventHandler(this.AddOrderToOrderButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.ConfirmButton);
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
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(3, 102);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(80, 27);
            this.ConfirmButton.TabIndex = 13;
            this.ConfirmButton.Text = "&Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
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
            this.PizzaSizeListBox.Location = new System.Drawing.Point(214, 51);
            this.PizzaSizeListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PizzaSizeListBox.Name = "PizzaSizeListBox";
            this.PizzaSizeListBox.Size = new System.Drawing.Size(79, 132);
            this.PizzaSizeListBox.TabIndex = 16;
            this.PizzaSizeListBox.SelectedIndexChanged += new System.EventHandler(this.PizzaSizeListBox_SelectedIndexChanged);
            // 
            // PizzaTypeListBox
            // 
            this.PizzaTypeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaTypeListBox.FormattingEnabled = true;
            this.PizzaTypeListBox.ItemHeight = 15;
            this.PizzaTypeListBox.Items.AddRange(new object[] {
            "Margherita Pizza",
            "Hawaiian Pizza",
            "Pepperoni Pizza",
            "Meat Feast Pizza",
            "Chicago Deep Dish Pizza",
            "Veggie Pizza",
            "BBQ Chicken Pizza",
            "Peri Peri Chicken Pizza",
            "Beef Supreme Pizza",
            "Neapolitan Pizza",
            "Buffalo Pizza",
            "Ham and Cheese Pizza",
            "3-Guys-Special-Pizza"});
            this.PizzaTypeListBox.Location = new System.Drawing.Point(44, 51);
            this.PizzaTypeListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PizzaTypeListBox.Name = "PizzaTypeListBox";
            this.PizzaTypeListBox.Size = new System.Drawing.Size(166, 139);
            this.PizzaTypeListBox.TabIndex = 15;
            this.PizzaTypeListBox.SelectedIndexChanged += new System.EventHandler(this.PizzaTypeListBox_SelectedIndexChanged);
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
            this.label2.Location = new System.Drawing.Point(208, 25);
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
        private System.Windows.Forms.Button ConfirmButton;
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
        private System.Windows.Forms.ListBox OrderedListbox;
        private System.Windows.Forms.TextBox OrderTotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveSelectedItemButton;
        private System.Windows.Forms.Button CancelTransactionButton;
        private System.Windows.Forms.Button DecreaseQuantityButton;
        private System.Windows.Forms.TextBox PizzaQuantityTextbox;
        private System.Windows.Forms.Button IncreaseQuantityButton;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}


﻿namespace StoreApp
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
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.DecreaseQuantityButton = new System.Windows.Forms.Button();
            this.PizzaQuantityTextbox = new System.Windows.Forms.TextBox();
            this.IncreaseQuantityButton = new System.Windows.Forms.Button();
            this.CancelTransactionButton = new System.Windows.Forms.Button();
            this.OrderTotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderedListbox = new System.Windows.Forms.ListBox();
            this.CurrentOrderTotalTextBox = new System.Windows.Forms.TextBox();
            this.AddOrderToOrderButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.OrderConformationButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ExitSummaryButton = new System.Windows.Forms.Button();
            this.PizzaSizeListBox = new System.Windows.Forms.ListBox();
            this.PizzaTypeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchResultListBox = new System.Windows.Forms.ListBox();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchDetailsPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.BookingNumberLabel = new System.Windows.Forms.Label();
            this.CloseSearchButton = new System.Windows.Forms.Button();
            this.SearchTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.DateSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.TrxNumSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SearchDetailsPanel.SuspendLayout();
            this.SearchTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ConfirmButton);
            this.panel1.Controls.Add(this.QuantityLabel);
            this.panel1.Controls.Add(this.DecreaseQuantityButton);
            this.panel1.Controls.Add(this.PizzaQuantityTextbox);
            this.panel1.Controls.Add(this.IncreaseQuantityButton);
            this.panel1.Controls.Add(this.CancelTransactionButton);
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Current Transaction Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total Transaction Cost";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(885, 163);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(80, 27);
            this.ConfirmButton.TabIndex = 13;
            this.ConfirmButton.Text = "&Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(3, 206);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(113, 16);
            this.QuantityLabel.TabIndex = 28;
            this.QuantityLabel.Text = "Number Of Pizzas";
            // 
            // DecreaseQuantityButton
            // 
            this.DecreaseQuantityButton.Location = new System.Drawing.Point(122, 203);
            this.DecreaseQuantityButton.Name = "DecreaseQuantityButton";
            this.DecreaseQuantityButton.Size = new System.Drawing.Size(16, 20);
            this.DecreaseQuantityButton.TabIndex = 27;
            this.DecreaseQuantityButton.Text = "<";
            this.DecreaseQuantityButton.UseVisualStyleBackColor = true;
            this.DecreaseQuantityButton.Click += new System.EventHandler(this.DecreaseQuantityButton_Click);
            // 
            // PizzaQuantityTextbox
            // 
            this.PizzaQuantityTextbox.Location = new System.Drawing.Point(139, 203);
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
            this.IncreaseQuantityButton.Location = new System.Drawing.Point(161, 203);
            this.IncreaseQuantityButton.Name = "IncreaseQuantityButton";
            this.IncreaseQuantityButton.Size = new System.Drawing.Size(16, 20);
            this.IncreaseQuantityButton.TabIndex = 25;
            this.IncreaseQuantityButton.Text = ">";
            this.IncreaseQuantityButton.UseVisualStyleBackColor = true;
            this.IncreaseQuantityButton.Click += new System.EventHandler(this.IncreaseQuantityButton_Click);
            // 
            // CancelTransactionButton
            // 
            this.CancelTransactionButton.Location = new System.Drawing.Point(331, 273);
            this.CancelTransactionButton.Name = "CancelTransactionButton";
            this.CancelTransactionButton.Size = new System.Drawing.Size(86, 34);
            this.CancelTransactionButton.TabIndex = 23;
            this.CancelTransactionButton.Text = "Cancel Transaction";
            this.CancelTransactionButton.UseVisualStyleBackColor = true;
            this.CancelTransactionButton.Click += new System.EventHandler(this.CancelTransactionButton_Click);
            // 
            // OrderTotalTextBox
            // 
            this.OrderTotalTextBox.Location = new System.Drawing.Point(331, 356);
            this.OrderTotalTextBox.Name = "OrderTotalTextBox";
            this.OrderTotalTextBox.ReadOnly = true;
            this.OrderTotalTextBox.Size = new System.Drawing.Size(86, 20);
            this.OrderTotalTextBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Order Summary";
            // 
            // OrderedListbox
            // 
            this.OrderedListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderedListbox.FormattingEnabled = true;
            this.OrderedListbox.ItemHeight = 15;
            this.OrderedListbox.Location = new System.Drawing.Point(2, 254);
            this.OrderedListbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderedListbox.Name = "OrderedListbox";
            this.OrderedListbox.Size = new System.Drawing.Size(324, 94);
            this.OrderedListbox.TabIndex = 19;
            // 
            // CurrentOrderTotalTextBox
            // 
            this.CurrentOrderTotalTextBox.Location = new System.Drawing.Point(331, 328);
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
            this.flowLayoutPanel1.Controls.Add(this.OrderConformationButton);
            this.flowLayoutPanel1.Controls.Add(this.SummaryButton);
            this.flowLayoutPanel1.Controls.Add(this.ExitSummaryButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(881, 206);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(85, 169);
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
            // OrderConformationButton
            // 
            this.OrderConformationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderConformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderConformationButton.Location = new System.Drawing.Point(3, 36);
            this.OrderConformationButton.Name = "OrderConformationButton";
            this.OrderConformationButton.Size = new System.Drawing.Size(80, 27);
            this.OrderConformationButton.TabIndex = 21;
            this.OrderConformationButton.Text = "&Search";
            this.OrderConformationButton.UseVisualStyleBackColor = false;
            this.OrderConformationButton.Click += new System.EventHandler(this.OrderConformationButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryButton.Location = new System.Drawing.Point(3, 69);
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
            this.ExitSummaryButton.Location = new System.Drawing.Point(3, 102);
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
            this.PizzaSizeListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PizzaSizeListBox.Name = "PizzaSizeListBox";
            this.PizzaSizeListBox.Size = new System.Drawing.Size(79, 84);
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
            this.PizzaTypeListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PizzaTypeListBox.Name = "PizzaTypeListBox";
            this.PizzaTypeListBox.Size = new System.Drawing.Size(166, 79);
            this.PizzaTypeListBox.TabIndex = 15;
            this.PizzaTypeListBox.SelectedIndexChanged += new System.EventHandler(this.PizzaTypeListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pizza type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pizza sizes";
            // 
            // SearchResultListBox
            // 
            this.SearchResultListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchResultListBox.FormattingEnabled = true;
            this.SearchResultListBox.ItemHeight = 16;
            this.SearchResultListBox.Location = new System.Drawing.Point(92, 135);
            this.SearchResultListBox.Name = "SearchResultListBox";
            this.SearchResultListBox.Size = new System.Drawing.Size(306, 196);
            this.SearchResultListBox.TabIndex = 1;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.ClearSearchButton);
            this.SearchGroupBox.Controls.Add(this.SearchLabel);
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchDetailsPanel);
            this.SearchGroupBox.Controls.Add(this.CloseSearchButton);
            this.SearchGroupBox.Controls.Add(this.SearchTypeGroupBox);
            this.SearchGroupBox.Controls.Add(this.SearchResultListBox);
            this.SearchGroupBox.Controls.Add(this.SearchButton);
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(1082, 52);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(412, 393);
            this.SearchGroupBox.TabIndex = 2;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSearchButton.Location = new System.Drawing.Point(318, 95);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(80, 27);
            this.ClearSearchButton.TabIndex = 23;
            this.ClearSearchButton.Text = "&Clear";
            this.ClearSearchButton.UseVisualStyleBackColor = false;
            this.ClearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(227, 18);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(139, 16);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Enter details below";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(192, 55);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(207, 22);
            this.SearchTextBox.TabIndex = 5;
            // 
            // SearchDetailsPanel
            // 
            this.SearchDetailsPanel.Controls.Add(this.label9);
            this.SearchDetailsPanel.Controls.Add(this.label8);
            this.SearchDetailsPanel.Controls.Add(this.label7);
            this.SearchDetailsPanel.Controls.Add(this.label6);
            this.SearchDetailsPanel.Controls.Add(this.DateLabel);
            this.SearchDetailsPanel.Controls.Add(this.BookingNumberLabel);
            this.SearchDetailsPanel.Location = new System.Drawing.Point(6, 137);
            this.SearchDetailsPanel.Name = "SearchDetailsPanel";
            this.SearchDetailsPanel.Size = new System.Drawing.Size(81, 133);
            this.SearchDetailsPanel.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Trx. Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Order List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Total Pizza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Total Cost";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(18, 15);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(65, 15);
            this.DateLabel.TabIndex = 25;
            this.DateLabel.Text = "Trx. Date";
            // 
            // BookingNumberLabel
            // 
            this.BookingNumberLabel.AutoSize = true;
            this.BookingNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingNumberLabel.Location = new System.Drawing.Point(-3, -1);
            this.BookingNumberLabel.Name = "BookingNumberLabel";
            this.BookingNumberLabel.Size = new System.Drawing.Size(86, 15);
            this.BookingNumberLabel.TabIndex = 24;
            this.BookingNumberLabel.Text = "Trx. Number";
            // 
            // CloseSearchButton
            // 
            this.CloseSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseSearchButton.Location = new System.Drawing.Point(7, 356);
            this.CloseSearchButton.Name = "CloseSearchButton";
            this.CloseSearchButton.Size = new System.Drawing.Size(80, 27);
            this.CloseSearchButton.TabIndex = 22;
            this.CloseSearchButton.Text = "&Close";
            this.CloseSearchButton.UseVisualStyleBackColor = false;
            this.CloseSearchButton.Click += new System.EventHandler(this.CloseSearchButton_Click);
            // 
            // SearchTypeGroupBox
            // 
            this.SearchTypeGroupBox.Controls.Add(this.DateSearchRadioButton);
            this.SearchTypeGroupBox.Controls.Add(this.TrxNumSearchRadioButton);
            this.SearchTypeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTypeGroupBox.Location = new System.Drawing.Point(23, 21);
            this.SearchTypeGroupBox.Name = "SearchTypeGroupBox";
            this.SearchTypeGroupBox.Size = new System.Drawing.Size(162, 59);
            this.SearchTypeGroupBox.TabIndex = 3;
            this.SearchTypeGroupBox.TabStop = false;
            this.SearchTypeGroupBox.Text = "Select a Search Criteria";
            // 
            // DateSearchRadioButton
            // 
            this.DateSearchRadioButton.AutoSize = true;
            this.DateSearchRadioButton.Location = new System.Drawing.Point(91, 26);
            this.DateSearchRadioButton.Name = "DateSearchRadioButton";
            this.DateSearchRadioButton.Size = new System.Drawing.Size(54, 20);
            this.DateSearchRadioButton.TabIndex = 1;
            this.DateSearchRadioButton.TabStop = true;
            this.DateSearchRadioButton.Text = "Date";
            this.DateSearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // TrxNumSearchRadioButton
            // 
            this.TrxNumSearchRadioButton.AutoSize = true;
            this.TrxNumSearchRadioButton.Location = new System.Drawing.Point(6, 26);
            this.TrxNumSearchRadioButton.Name = "TrxNumSearchRadioButton";
            this.TrxNumSearchRadioButton.Size = new System.Drawing.Size(75, 20);
            this.TrxNumSearchRadioButton.TabIndex = 0;
            this.TrxNumSearchRadioButton.TabStop = true;
            this.TrxNumSearchRadioButton.Text = "Trx Num";
            this.TrxNumSearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(192, 95);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(80, 27);
            this.SearchButton.TabIndex = 22;
            this.SearchButton.Text = "&Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 482);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "3 Guys Pizza";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.SearchDetailsPanel.ResumeLayout(false);
            this.SearchDetailsPanel.PerformLayout();
            this.SearchTypeGroupBox.ResumeLayout(false);
            this.SearchTypeGroupBox.PerformLayout();
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
        private System.Windows.Forms.Button OrderConformationButton;
        private System.Windows.Forms.Button ExitSummaryButton;
        private System.Windows.Forms.ListBox OrderedListbox;
        private System.Windows.Forms.TextBox OrderTotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelTransactionButton;
        private System.Windows.Forms.Button DecreaseQuantityButton;
        private System.Windows.Forms.TextBox PizzaQuantityTextbox;
        private System.Windows.Forms.Button IncreaseQuantityButton;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox SearchResultListBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.GroupBox SearchTypeGroupBox;
        private System.Windows.Forms.Panel SearchDetailsPanel;
        private System.Windows.Forms.Button ClearSearchButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label BookingNumberLabel;
        private System.Windows.Forms.RadioButton DateSearchRadioButton;
        private System.Windows.Forms.RadioButton TrxNumSearchRadioButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CloseSearchButton;
    }
}


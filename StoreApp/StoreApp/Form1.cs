﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class MainForm : Form
    {
        //List box items
        static String[] PizzaTypes = { "Margherita Pizza", "Hawaiian Pizza", "Pepperoni Pizza", "Meat Feast Pizza", "Chicago Deep Dish Pizza", "Veggie Pizza", "BBQ Chicken Pizza", "Peri Peri Chicken Pizza", "Beef Supreme Pizza", "Neapolitan Pizza", "Buffalo Pizza", "Ham and Cheese Pizza", "3-Guys-Special-Pizza" };
        //decimal[] CostOfPizza = { 7.50m, 8.00m, 7.00m, 9.00m, 8.50m, 7.00m, 10.00m, 10.50m, 11.00m, 8.75m, 9.00m, 8.00m, 12.00m };
       
        
        string Pizza;
        const int INCREMENT = 10, FORMSTARTWIDTH = 1100, FORMSTARTHEIGHT = 512, FORMEXPANDWIDTH = 1406;
        Boolean FormWidthExpanded = true;
        decimal[,] PizzaSizeCost = new decimal[13, 5] {
            { 7.50m, 10.50m, 13.50m, 15.50m, 17.50m},
            { 8.00m, 12.25m, 15.00m, 18.50m, 22.00m },
            { 7.00m, 9.25m, 11.00m, 14.00m, 17.50m },
            { 9.00m, 12.00m, 15.00m,18.00m, 21.00m },
            { 8.50m, 11.50m, 13.90m, 16.00m, 19.00m },
            { 7.00m, 9.00m, 12.00m, 14.50m, 18.50m },
            { 10.00m, 13.00m, 16.50m, 19.00m, 21.50m },
            { 10.50m, 13.00m, 15.50m, 18.00m, 20.00m },
            { 11.00m, 14.00m, 17.50m, 19.50m, 21.00m },
            { 8.75m, 10.50m, 13.50m, 16.00m, 19.00m },
            { 9.00m, 11.90m, 14.00m, 16.60m, 19.00m },
            { 8.00m, 10.90m, 13.00m, 15.00m, 18.00m },
            { 12.00m, 15.00m, 19.90m, 22.00m, 26.90m },};
        public MainForm()
        {
            InitializeComponent();
        }

        decimal TotalTransactionCost { get;set; }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            var newform = new SummaryForm();
            newform.Show();
        }

        
        private void AddOrderToOrderButton_Click(object sender, EventArgs e)
        {
            int PizzaTypeIndex = 0, PizzaSizeIndex = 0;
            //int[,] PizzaSizeIndex = [0, 0];
            decimal PizzaPrice;

            if (PizzaTypeListBox.SelectedIndex != -1)
            {
                if (PizzaSizeListBox.SelectedIndex != -1)
                {
                    int Quantity = int.Parse(PizzaQuantityTextbox.Text);

                    for (int i = 0; i < Quantity; i++)
                    {
                        PizzaTypeIndex = PizzaTypeListBox.SelectedIndex;
                        PizzaSizeIndex = PizzaSizeListBox.SelectedIndex;
                        //PizzaPrice is = to the Pizza type index position on the array of pizza then the size index position
                        Pizza = PizzaTypes[PizzaTypeIndex];
                        PizzaPrice = PizzaSizeCost[PizzaTypeIndex, PizzaSizeIndex];

                        //Gets the item selected from pizza listbox & inch
                        string PizzaSelected = PizzaTypeListBox.SelectedItem.ToString();
                        string SizeSelected = PizzaSizeListBox.SelectedItem.ToString();
                        string TotalPizza = CurrentOrderTotalTextBox.Text;

                        //Shows the total transaction cost
                        TotalTransactionCost += PizzaPrice;
                        OrderTotalTextBox.Text = TotalTransactionCost.ToString("C2");

                        //Adds it into the new listbox
                        OrderedListbox.Items.Add(PizzaSelected + "           " + SizeSelected + "           " + TotalPizza);

                        OrderedListbox.SelectedIndex = OrderedListbox.SelectedIndex + 1;
                        //Adds order total
                    }

                    //highlighted items in listboxes are unselected
                    PizzaSizeListBox.ClearSelected();
                    PizzaTypeListBox.ClearSelected();
                    PizzaQuantityTextbox.Text = "1";
                }
                else
                {
                    MessageBox.Show("A Pizza Type is needed to proceed", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PizzaSizeListBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("A Pizza Size is needed to proceed", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PizzaTypeListBox.Focus();
            }

            
            
              
        }
        private void ExitSummaryButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelTransactionButton_Click(object sender, EventArgs e)
        {
            //clears all the transaction
            DialogResult = MessageBox.Show("Are you sure you would like to Cancel the Transaction?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                OrderedListbox.Items.Clear();
                PizzaSizeListBox.ClearSelected();
                PizzaTypeListBox.ClearSelected();
                CurrentOrderTotalTextBox.Clear();
                OrderTotalTextBox.Clear();
                TotalTransactionCost = 0;
                PizzaQuantityTextbox.Text = "1";
            }
        }

        private void IncreaseQuantityButton_Click(object sender, EventArgs e)
        {
            int Add = 1, quantity;

            quantity = int.Parse(PizzaQuantityTextbox.Text);
            quantity += Add;
            PizzaQuantityTextbox.Text = quantity.ToString();
            ChangeDuringClick();
        }

        private void DecreaseQuantityButton_Click(object sender, EventArgs e)
        {
            int subtract = 1, quantity;

            quantity = int.Parse(PizzaQuantityTextbox.Text);

            if (quantity != 1)
            {
                quantity -= subtract;
                PizzaQuantityTextbox.Text = quantity.ToString();
                ChangeDuringClick();
            }
        }

        private void PizzaSizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDuringClick();
        }

        private void PizzaTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDuringClick();
        }

        private void OrderConformationButton_Click(object sender, EventArgs e)
        {
            ChangeFormWidth(true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChangeFormWidth(false);
        }

        //When listboxes are clicked, or increase/decrease quantity, the current price changes
        private int ChangeDuringClick()
        {
            int PizzaTypeIndex = 0, PizzaSizeIndex = 0, Quantity = int.Parse(PizzaQuantityTextbox.Text);
            decimal PizzaPrice;
            if (PizzaSizeListBox.SelectedItems.Count > 0 && PizzaTypeListBox.SelectedItems.Count > 0)
            {
                PizzaTypeIndex = PizzaTypeListBox.SelectedIndex;
                PizzaSizeIndex = PizzaSizeListBox.SelectedIndex;
                Pizza = PizzaTypes[PizzaTypeIndex];
                PizzaPrice = PizzaSizeCost[PizzaTypeIndex, PizzaSizeIndex];

                PizzaPrice *= Quantity;
                CurrentOrderTotalTextBox.Text = PizzaPrice.ToString("C2");
            }
            return 0;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string[] array = new string[OrderedListbox.Items.Count], words = null;
            string FormatArray;

            if (OrderedListbox.Items.Count != 0)
            {
                
                DialogResult = MessageBox.Show("Are you sure you would like to Save and Process the Transaction?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        StreamWriter OutputFile = File.AppendText("TransactionSummary.txt");

                       // OutputFile.WriteLine(txno
                         //   OutputFile.WriteLine(DateBoldEventArgs

                           // OutputFile.WriteLine( TotalTransactionCost


                        for (int i = 0; i < OrderedListbox.Items.Count; i++)
                        {
                          /*  object s = OrderedListbox.Items[i];
                            array[i] = OrderedListbox.Items[i].ToString();
                            OrderedListbox.Items.CopyTo(array, 0);

                            FormatArray = array[i];
                            //words = FormatArray; //FormatArray.Split(',');
                          */
                            OutputFile.WriteLine(OrderedListbox.Items[i].ToString());
                        }
                        OutputFile.WriteLine();//end tx

                        ChangeFormWidth(false);
                        OutputFile.Close();
                    }
                    catch
                    {
                        MessageBox.Show("A fatal error has occured, please contact your administator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make an order before proceeding", "No Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ChangeFormWidth(Boolean Expand)
        {
            if (Expand)
            {
                if (!FormWidthExpanded)
                {
                    for (int i = FORMSTARTWIDTH; i < FORMEXPANDWIDTH; i += INCREMENT)
                    {
                        this.Size = new Size(i, FORMSTARTHEIGHT);
                        this.Update();
                        System.Threading.Thread.Sleep(1);
                    }
                    FormWidthExpanded = true;
                }
            }
            else
            {
                if (FormWidthExpanded)
                {
                    for (int i = FORMEXPANDWIDTH; i > FORMSTARTWIDTH; i -= INCREMENT)
                    {
                        this.Size = new Size(i, FORMSTARTHEIGHT);
                        this.Update();
                        System.Threading.Thread.Sleep(1);
                    }
                    FormWidthExpanded = false;
                }
            }
        }



        private void readPrices()
        {
            String file = "";

            String[] allRows, oneRow;

            allRows = File.ReadAllLines(file);  


            for (int row = 0; row < allRows.Length; row++)
            {
                oneRow = allRows[row].Split(',');

                for (int col = 0; col < allRows.Length; col++)
                {
                    PizzaSizeCost[row, col] = decimal.Parse(oneRow[col]);

                }
            }



        }
    }
}
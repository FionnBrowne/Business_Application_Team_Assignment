using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.Expando;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StoreApp
{
    public partial class MainForm : Form
    {
        //List box items 1d array 
        static String[] PizzaTypes = { "Margherita Pizza", "Hawaiian Pizza", "Pepperoni Pizza", "Meat Feast Pizza", "Chicago Deep Dish Pizza", "Veggie Pizza", "BBQ Chicken Pizza", "Peri Peri Chicken Pizza", "Beef Supreme Pizza", "Neapolitan Pizza", "Buffalo Pizza", "Ham and Cheese Pizza", "3-Guys-Special-Pizza" };
        static String[] PizzaSizeInch = { "6", "9", "12", "15", "18" };

        //Form width and Length set up
        string Pizza;
        const int INCREMENT = 10, FORMSTARTWIDTH = 1075, FORMSTARTHEIGHT = 521, FORMEXPANDWIDTH = 1533, MIN_RANNUM = 100000, MAX_RANNUM = 999999;
        Boolean FormWidthExpanded = true;

        //2d arrays.
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

        //2d arrays.
        decimal[,] PizzaSelectedDuringTransaction = new decimal[13, 5] {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },};

        public MainForm()
        {
            InitializeComponent();
            //StockSelectedTransaction();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //when clicked, contracts the form width
            ChangeFormWidth(false);
            //resets stock when program is run (test code)
            ResetStockSelected(PizzaSelectedDuringTransaction);
        }
        // Getting the value of the object then setting it in the textbox
        decimal TotalTransactionCostForTextbox { get; set; }

        // Getting the value of the object then using it in multiple methods and storing the value into the file
        decimal TotalTranactionCost { get; set; }
        int TransactionCount { get; set; }
        int TotalPizzaSold { get; set; }
        int AvailableStock { get; set; }

        //When summary button is pressed, a pop up of form 2 comes up
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            var newform = new SummaryForm();
            newform.Show();
        }

        //Stores selected index from 2d arrays into order listbox
        private void AddOrderToOrderButton_Click(object sender, EventArgs e)
        {
            int PizzaTypeIndex = 0, PizzaSizeIndex = 0, PizzaTransactionTypeIndex = 0, PizzaTransactionSizeIndex = 0;
            int[,] PizzasSold = new int[13, 5];
            //int[,] PizzaSizeIndex = [0, 0];
            decimal PizzaPrice;
            string PizzaTransactionType, PizzaTransactionSize;

            if (PizzaTypeListBox.SelectedIndex != -1)
            {
                if (PizzaSizeListBox.SelectedIndex != -1)
                {
                    int Quantity = int.Parse(PizzaQuantityTextbox.Text);

                    for (int i = 0; i < Quantity; i++)
                    {
                        //Whatever index has been selected, it is placed as a array which is linked to the 2d array
                        PizzaTypeIndex = PizzaTypeListBox.SelectedIndex;
                        PizzaSizeIndex = PizzaSizeListBox.SelectedIndex;
                        //PizzaPrice is = to the Pizza type index position on the array of pizza then the size index position
                        Pizza = PizzaTypes[PizzaTypeIndex];
                        PizzaPrice = PizzaSizeCost[PizzaTypeIndex, PizzaSizeIndex];

                        //Gets the item selected from pizza listbox & inch
                        string PizzaSelected = PizzaTypeListBox.SelectedItem.ToString();
                        string SizeSelected = PizzaSizeListBox.SelectedItem.ToString();
                        decimal TotalPizza = decimal.Parse(CurrentOrderTotalTextBox.Text);

                        TotalPizza = TotalPizza / int.Parse(PizzaQuantityTextbox.Text);

                        //Adds it into the new listbox
                        OrderedListbox.Items.Add(PizzaSelected + "           " + SizeSelected + "           " + TotalPizza.ToString("c2"));

                        //Shows the total transaction cost
                        TotalTransactionCostForTextbox += PizzaPrice;
                        OrderTotalTextBox.Text = TotalTransactionCostForTextbox.ToString("C2");

                        OrderedListbox.SelectedIndex = OrderedListbox.SelectedIndex + 1;
                        //Adds order total
                    }

                    PizzaTransactionTypeIndex = PizzaTypeListBox.SelectedIndex;
                    PizzaTransactionSizeIndex = PizzaSizeListBox.SelectedIndex;
                    //PizzaPrice is = to the Pizza type index position on the array of pizza then the size index position
                    PizzaTransactionType = PizzaTypes[PizzaTypeIndex];
                    PizzaTransactionSize = PizzaSizeInch[PizzaSizeIndex];
                    PizzasSold[PizzaTypeIndex, PizzaSizeIndex] = Quantity;
                    Console.WriteLine("Array (After using Clear):");
                    StockSelectedTransaction(PizzasSold);

                    //highlighted items in listboxes are unselected
                    PizzaSizeListBox.ClearSelected();
                    PizzaTypeListBox.ClearSelected();
                    PizzaQuantityTextbox.Text = "1";
                }
                else
                {
                    //if user did not selected a pizza type in listbox, displays message
                    MessageBox.Show("A Pizza Type is needed to proceed", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PizzaSizeListBox.Focus();
                }
            }
            else
            {
                //if user did not selected a pizza size in listbox, displays message
                MessageBox.Show("A Pizza Size is needed to proceed", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PizzaTypeListBox.Focus();
            }

        }
        private void ExitSummaryButton_Click(object sender, EventArgs e)
        {
            //Closes the application (form1)
            this.Close();
        }
        private void CancelTransactionButton_Click(object sender, EventArgs e)
        {
            //clears all the transaction and resets the process
            DialogResult = MessageBox.Show("Are you sure you would like to Cancel the Transaction?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                OrderedListbox.Items.Clear();
                PizzaSizeListBox.ClearSelected();
                PizzaTypeListBox.ClearSelected();
                CurrentOrderTotalTextBox.Clear();
                OrderTotalTextBox.Clear();
                TotalTransactionCostForTextbox = 0;
                PizzaQuantityTextbox.Text = "1";
            }
        }

        //This button increases the same pizza quantity that is going inside order listbox
        private void IncreaseQuantityButton_Click(object sender, EventArgs e)
        {
            int Add = 1, quantity;

            quantity = int.Parse(PizzaQuantityTextbox.Text);

            //if there is no available stock, prevents the user from buying this type of pizza + size
            if (quantity != AvailableStock)
            {
                quantity += Add;
                PizzaQuantityTextbox.Text = quantity.ToString();
                //(method on bottom of code)
                ChangeDuringClick();
            }
            else
            {
                //if product is out of stock, displays message
                MessageBox.Show("Sorry, but this is the Current Maximum Number of this Pizzas Type and Size in Stock", "Maximum Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //This button decreases the same pizza quantity that is going inside order listbox
        private void DecreaseQuantityButton_Click(object sender, EventArgs e)
        {
            int subtract = 1, quantity;

            quantity = int.Parse(PizzaQuantityTextbox.Text);

            //Prevents the user from ordering less than 1 pizza type + size
            if (quantity != 1)
            {
                quantity -= subtract;
                PizzaQuantityTextbox.Text = quantity.ToString();
                //(method on bottom of code)
                ChangeDuringClick();
            }
        }

        //when button is clicked, reset pizza quantity and runs method (method on bottom of code)
        private void PizzaSizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PizzaQuantityTextbox.Text = "1";
            //(method on bottom of code)
            ChangeDuringClick();
            //StockSelectedTransaction();
        }

        private void PizzaTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PizzaQuantityTextbox.Text = "1";
            //(method on bottom of code)
            ChangeDuringClick();
            //StockSelectedTransaction();
        }

        private void OrderConformationButton_Click(object sender, EventArgs e)
        {
            //when clicked, expands the form width
            ChangeFormWidth(true);
        }

        //allows the user to search by transaction number + time
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //prevents the user from not selecting search critera
            if (TrxNumSearchRadioButton.Checked != false || DateSearchRadioButton.Checked != false)
            {
                //prevents the user from entering no search input
                if (SearchTextBox.Text != "")
                {
                    SearchResultListBox.Items.Clear();

                    string SearchString = SearchTextBox.Text;
                    int QuantityPizza;
                    decimal TotalCost;

                    int index = 0; 

                    try
                    {                       
                        String[] InPutFile = File.ReadAllLines("TransactionSummary.txt");

                        do
                        {
                            index = Array.IndexOf(InPutFile, SearchString, index);

                            if (index != -1)
                            {
                                if (!TrxNumSearchRadioButton.Checked)
                                {
                                    index--; // matched with date, 2nd line of record, so index - 1 for TX_No
                                }

                                SearchResultListBox.Items.Add(InPutFile[index]);
                                SearchResultListBox.Items.Add(InPutFile[index + 1]);
                                SearchResultListBox.Items.Add(InPutFile[index + 2]);
                                QuantityPizza = int.Parse(InPutFile[index + 3]);
                                SearchResultListBox.Items.Add(QuantityPizza);
                                TotalCost = decimal.Parse(InPutFile[index + 4]);


                                index += 4;
                                //reads until it finds the transaction order
                                while (index < InPutFile.Length && !String.IsNullOrEmpty(InPutFile[index]))
                                {
                                    SearchResultListBox.Items.Add(InPutFile[index++]);
                                }
                                index++;//next search must start at next index

                                QuantityPizza += 2;

                                //Cycling through pizzas in order
                                for (int i = 0; i < QuantityPizza; i++)
                                {
                                    SearchResultListBox.Items.Add(InPutFile[index++]);
                                }

                                index++;

                                //disables search features until clear button is pressed
                                SearchButton.Enabled = false;
                                SearchTextBox.Enabled = false;
                                SearchTypeGroupBox.Enabled = false;
                            }
                            else
                            {
                                //if index is -1 then no transaction has been found
                                MessageBox.Show("The Transaction has not been found", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                break;
                            }

                        } while (!TrxNumSearchRadioButton.Checked);// keep searching if by date
                    }
                    catch
                    {
                        //the end point of the transaction, where the loop stops
                        MessageBox.Show("End transaction History", "End of Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Transaction Number/Date", "No Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Select a Search Criteria", "No Search Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /*string TransactionNum, TransactionDate;
            Boolean TrxFound = false;

            if (SearchTextBox.Text != "")
            {
                SearchResultListBox.Items.Clear();

                string SearchString = SearchTextBox.Text;
                int QuantityPizza;

                try
                {

                    if (TrxNumSearchRadioButton.Checked)
                    {
                        while (!InPutFile.EndOfStream || !TrxFound)
                        {
                            TransactionNum = InPutFile.ReadLine();

                            if (TransactionNum.Equals(SearchString))
                            {
                                SearchResultListBox.Items.Add(TransactionNum);
                                SearchResultListBox.Items.Add(InPutFile.ReadLine());
                                QuantityPizza = int.Parse(InPutFile.ReadLine());
                                SearchResultListBox.Items.Add(QuantityPizza);
                                SearchResultListBox.Items.Add(InPutFile.ReadLine());
                                SearchResultListBox.Items.Add(InPutFile.ReadLine());
                                for (int i = 0; i < QuantityPizza; i++)
                                {
                                    SearchResultListBox.Items.Add(InPutFile.ReadLine());
                                }
                                TrxFound = true;
                            }
                            else
                            {
                                for (int i = 0; i < FILELENGTH; i++)
                                {
                                    InPutFile.ReadLine();
                                }
                            }
                        }
                        InPutFile.Close();

                    }
                    else
                    {
                        while (!InPutFile.EndOfStream)
                        {
                            TransactionNum = InPutFile.ReadLine();
                            TransactionDate = InPutFile.ReadLine();

                            if (TransactionDate.Equals(SearchString))
                            {
                                SearchResultListBox.Items.Add(TransactionNum);
                                SearchResultListBox.Items.Add(TransactionDate);
                            }
                            else
                            {
                                for (int i = 0; i < FILELENGTH; i++)
                                {
                                    InPutFile.ReadLine();
                                }
                            }
                        }
                        InPutFile.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("A fatal error has occured, please contact your administator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a transaction number/date", "Enter Date/Transaction Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            //clears all search functionualties
            SearchTextBox.Clear();
            SearchResultListBox.Items.Clear();
            TrxNumSearchRadioButton.Checked = false;
            DateSearchRadioButton.Checked = false;
            SearchButton.Enabled = true;
            SearchTextBox.Enabled = true;
            SearchTypeGroupBox.Enabled = true;
        }

        private void CloseSearchButton_Click(object sender, EventArgs e)
        {
            //contracts form width
            ChangeFormWidth(false);
        }



        //When listboxes are clicked, or increase/decrease quantity, the current price changes. also prevents user from
        //ordering more pizzas than there actually is currently in stock
        private int ChangeDuringClick()
        {
            int PizzaTypeIndex = 0, PizzaSizeIndex = 0, Quantity = int.Parse(PizzaQuantityTextbox.Text), row, col, value;
            decimal PizzaPrice;

            // Reads the file and puts all items into variable
            string PizzaStock = File.ReadAllText("StockList.txt");

            // splits the file, making all numbers go into 1 line and removes ,
            string[] rows = PizzaStock.Split('\n');
            int numRows = rows.Length;
            int numCols = rows[0].Split(',').Length;
            int[,] array = new int[numRows, numCols];

            for (int r = 0; r < numRows; r++)
            {
                string[] cols = rows[r].Split(',');
                for (int c = 0; c < numCols; c++)
                {
                    array[r, c] = int.Parse(cols[c].Trim());
                }
            }

            // Gets the pizza type and size index into array and searches the stock file
            if (PizzaSizeListBox.SelectedItems.Count > 0 && PizzaTypeListBox.SelectedItems.Count > 0)
            {
                row = PizzaTypeListBox.SelectedIndex;
                col = PizzaSizeListBox.SelectedIndex;
                value = array[row, col];

                if (value == 0)
                {
                    MessageBox.Show("Sorry, this Pizza Type and Size are currently Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PizzaQuantityTextbox.Text = "0";
                    CurrentOrderTotalTextBox.Text = "";
                    AddOrderToOrderButton.Enabled = false;
                    IncreaseQuantityButton.Enabled = false;
                    DecreaseQuantityButton.Enabled = false;
                }
                else
                {
                    PizzaTypeIndex = PizzaTypeListBox.SelectedIndex;
                    PizzaSizeIndex = PizzaSizeListBox.SelectedIndex;
                    Pizza = PizzaTypes[PizzaTypeIndex];
                    PizzaPrice = PizzaSizeCost[PizzaTypeIndex, PizzaSizeIndex];

                    PizzaPrice *= Quantity;
                    CurrentOrderTotalTextBox.Text = PizzaPrice.ToString();
                    AvailableStock = value;

                    AddOrderToOrderButton.Enabled = true;
                    IncreaseQuantityButton.Enabled = true;
                    DecreaseQuantityButton.Enabled = true;
                }
            }
            return 0;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string[] array = new string[OrderedListbox.Items.Count];

            // Allows to put a value in dialogbox
            DialogResult Result;
            List<string> lt = new List<string>();
            string str = null, OrderSummary;
            string Time = DateTime.Now.ToString("HH:mm"), Date = DateTime.Now.ToString("d");
            string OrderNumber;
            int TransactionCount1 = 0, TotalPizzaSold1 = 0;
            decimal TotalTransactionsCost = 0;
            //prevents the user from ordering nothing
            if (OrderedListbox.Items.Count != 0)
            {
                foreach (var item in OrderedListbox.Items)
                {
                    lt.Add(item.ToString()); //store the items in the list
                    str += item + "\r\n";    //store the items in the string
                }

                //creates messagebox that displays all order into it
                OrderNumber = GenerateRandomNumber(MIN_RANNUM, MAX_RANNUM);
                OrderSummary = "Order Number: " + OrderNumber + "\nOrder Date: " + Date + " " + Time + "\nOrder Contents: \n" + str;
                DialogResult = MessageBox.Show(OrderSummary, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //puts details into the file that is then displayed in summary 
                if (DialogResult == DialogResult.Yes)
                {
                    ResetStockSelected(PizzaSelectedDuringTransaction);
                    try
                    {
                        TransactionCount += 1;
                        TotalTranactionCost = TotalTransactionCostForTextbox;
                        TotalPizzaSold = OrderedListbox.Items.Count;

                        if (!File.Exists("Summary.txt"))
                        {
                            File.Create("Summary.txt");
                        }
                        StreamReader InputFile = File.OpenText("Summary.txt");

                        if (InputFile == null)
                        {
                            InputFile.Close();
                            TransactionCount1++;
                            TotalPizzaSold1 = TotalPizzaSold;
                            TotalTransactionsCost = TotalTranactionCost;
                            StreamWriter OutputFile2 = File.CreateText("Summary.txt");
                            OutputFile2.WriteLine(Date);
                            OutputFile2.WriteLine(TotalPizzaSold1);
                            OutputFile2.WriteLine(TransactionCount1);
                            OutputFile2.WriteLine(TotalTransactionsCost);
                            OutputFile2.WriteLine(" ");
                            OutputFile2.Close();
                        }
                        else if (DateTime.Now.ToString("d") != (Date = InputFile.ReadLine()))
                        {
                            InputFile.Close();
                            File.Delete("Summary.txt");
                            TransactionCount1++;
                            TotalPizzaSold1 = TotalPizzaSold;
                            TotalTransactionsCost = TotalTranactionCost;
                            StreamWriter OutputFile2 = File.CreateText("Summary.txt");
                            OutputFile2.WriteLine(DateTime.Now.ToString("d"));
                            OutputFile2.WriteLine(TotalPizzaSold1);
                            OutputFile2.WriteLine(TransactionCount1);
                            OutputFile2.WriteLine(TotalTransactionsCost);
                            OutputFile2.WriteLine(" ");
                            OutputFile2.Close();
                        }
                        else
                        {
                            TransactionCount1 = int.Parse(InputFile.ReadLine());
                            TotalPizzaSold1 = int.Parse(InputFile.ReadLine());
                            TotalTransactionsCost = decimal.Parse(InputFile.ReadLine());
                            TransactionCount1++;
                            TotalPizzaSold1 += TotalPizzaSold;
                            TotalTransactionsCost += TotalTranactionCost;
                            InputFile.Close();
                            StreamWriter OutputFile2 = File.CreateText("Summary.txt");
                            OutputFile2.WriteLine(Date);
                            OutputFile2.WriteLine(TransactionCount1);
                            OutputFile2.WriteLine(TotalPizzaSold1);
                            OutputFile2.WriteLine(TotalTransactionsCost);
                            OutputFile2.WriteLine(" ");
                            OutputFile2.Close();
                        }

                        //saves the order into a file whuch can be used by search
                        StreamWriter OutputFile = File.AppendText("TransactionSummary.txt");
                        //adding time to transaction
                        OutputFile.WriteLine(OrderNumber);
                        OutputFile.WriteLine(Date);
                        OutputFile.WriteLine(Time.ToString());
                        OutputFile.WriteLine(TotalPizzaSold);
                        OutputFile.WriteLine(TotalTranactionCost);
                        OutputFile.WriteLine("");
                        OutputFile.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

                        //writes in all ordered pizzas into file
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

                        OrderedListbox.Items.Clear();
                        //message saying the save was successfull and no error has occured
                        MessageBox.Show("Order has been Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChangeFormWidth(false);
                        OutputFile.Close();
                    }
                    catch
                    {
                        //creates message if a error occurs that user cant fix
                        MessageBox.Show("A fatal error has occured, please contact your administator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make an order before proceeding", "No Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /*
         *Methods 
         * 
         */

        //Expands/contracts the form width when excecuted
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

        //random Number Generator for transaction
        private String GenerateRandomNumber(int Min, int Max)
        {
            Random MyRandomObject;
            int RandomNumber;

            MyRandomObject = new Random();
            RandomNumber = MyRandomObject.Next(Min, Max);

            return RandomNumber.ToString();
        }

        //makes a list of new stock array (not implemented)
        private void StockSelectedTransaction(int[,] arr)
        {
            StreamWriter OutputFile = File.AppendText("Summary.txt");
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    OutputFile.Write(arr[i, j] + " ");
                }
                OutputFile.Write("\n");
            }
            OutputFile.Write(" ");
            OutputFile.Flush();
            OutputFile.Close();
        }
        
        //resets the file when executed
        private void ResetStockSelected(decimal[,] arr)
        {
            Array.Clear(arr, 0, arr.Length);
            /*Console.WriteLine("Array (After using Clear):");
            foreach (int val in arr)
            {
                Console.WriteLine(val);

            }*/
        }
    }
}


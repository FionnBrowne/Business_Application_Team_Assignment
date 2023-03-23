using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StoreApp
{
    public partial class MainForm : Form
    {
        //List box items
        static String[] PizzaTypes = { "Margherita Pizza", "Hawaiian Pizza", "Pepperoni Pizza", "Meat Feast Pizza", "Chicago Deep Dish Pizza", "Veggie Pizza", "BBQ Chicken Pizza", "Peri Peri Chicken Pizza", "Beef Supreme Pizza", "Neapolitan Pizza", "Buffalo Pizza", "Ham and Cheese Pizza", "3-Guys-Special-Pizza" };
        //decimal[] CostOfPizza = { 7.50m, 8.00m, 7.00m, 9.00m, 8.50m, 7.00m, 10.00m, 10.50m, 11.00m, 8.75m, 9.00m, 8.00m, 12.00m };
       
        
        string Pizza;
        const int INCREMENT = 10, FORMSTARTWIDTH = 1100, FORMSTARTHEIGHT = 512, FORMEXPANDWIDTH = 1406, MIN_RANNUM = 100000, MAX_RANNUM = 999999;
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
        // what is this
        decimal TotalTransactionCostForTextbox { get;set; }
        decimal TotalTranactionCost { get;set; }
        int TransactionCount { get; set; }
        int TotalPizzaSold { get; set; }
        int AvailableStock { get; set; }

        int FILELENGTH = 5;

        int chk = 0;


       
        private void SearchButon_Click(object sender, EventArgs e)
            // EXPAND SEARCH FORM
        {
            if (chk == 0)
            {
                for (int i = 1075; i <= 1533; i++)
                {
                    this.Size = new Size(i, 521);
                }
                chk = 1;
            }
            else if (chk == 1)
            {
                for (int i = 1533; i >= 1075; i--)
                {
                    this.Size = new Size(i, 521);
                }
                chk = 0;
            }
        }

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
                TotalTransactionCostForTextbox = 0;
                PizzaQuantityTextbox.Text = "1";
            }
        }

        private void IncreaseQuantityButton_Click(object sender, EventArgs e)
        {
            int Add = 1, quantity;

            quantity = int.Parse(PizzaQuantityTextbox.Text);

            if (quantity != AvailableStock)
            {
                quantity += Add;
                PizzaQuantityTextbox.Text = quantity.ToString();
                ChangeDuringClick();
            }
            else
            {
                MessageBox.Show("Sorry, but this is the Current Maximum Number of this Pizzas Type and Size in Stock", "Maximum Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            PizzaQuantityTextbox.Text = "1";
            ChangeDuringClick();
        }

        private void PizzaTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PizzaQuantityTextbox.Text = "1";
            ChangeDuringClick();        
        }

        private void OrderConformationButton_Click(object sender, EventArgs e)
        {
            ChangeFormWidth(true);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (TrxNumSearchRadioButton.Checked != false || DateSearchRadioButton.Checked != false)
            {
                if (SearchTextBox.Text != "")
                {
                    SearchResultListBox.Items.Clear();

                    string SearchString = SearchTextBox.Text;
                    int QuantityPizza;
                    decimal TotalCost;

                    //NB ***************
                    int index = 0; //start search at first element in array
                                   //******************************
                    try
                    {
                        //StreamReader InPutFile = File.OpenText("TransactionSummary.txt");
                        String[] InPutFile = File.ReadAllLines("TransactionSummary.txt");
                        //if (TrxNumSearchRadioButton.Checked)
                        //{
                        //while (!InPutFile.EndOfStream || !TrxFound)
                        //{
                        do
                        {
                            index = Array.IndexOf(InPutFile, SearchString, index);
                            //see: https://learn.microsoft.com/en-us/dotnet/api/system.array.indexof?view=netframework-4.7.2&f1url=%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(System.Array.IndexOf%60%601)%3Bk(TargetFrameworkMoniker-.NETFramework%2CVersion%253Dv4.7.2)%3Bk(DevLang-csharp)%26rd%3Dtrue                       
                            //2nd overload
                            if (index != -1)
                            {
                                if (!TrxNumSearchRadioButton.Checked)
                                {
                                    index--; // matched wit date, 2nd line of record, so index - 1 for TX_No
                                }

                                SearchResultListBox.Items.Add(InPutFile[index]);
                                SearchResultListBox.Items.Add(InPutFile[index + 1]);
                                SearchResultListBox.Items.Add(InPutFile[index + 2]);
                                QuantityPizza = int.Parse(InPutFile[index + 3]);
                                SearchResultListBox.Items.Add(QuantityPizza);
                                TotalCost = decimal.Parse(InPutFile[index + 4]);


                                index += 4;
                                while (index < InPutFile.Length && !String.IsNullOrEmpty(InPutFile[index]))
                                {
                                    SearchResultListBox.Items.Add(InPutFile[index++]);
                                }
                                index++;//next search must start at next index

                                QuantityPizza += 2;

                                for (int i = 0; i < QuantityPizza; i++)
                                {
                                    SearchResultListBox.Items.Add(InPutFile[index++]);
                                }

                                index++;

                                SearchButton.Enabled = false;
                                SearchTextBox.Enabled = false;
                                SearchTypeGroupBox.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("The Transaction has not been found", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                break;
                            }

                        } while (!TrxNumSearchRadioButton.Checked);// keep searching if by date
                                                                   //end do-while
                    }
                    catch
                    {
                        MessageBox.Show("A fatal error has occured, please contact your administator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SearchTextBox.Clear();
            SearchResultListBox.Items.Clear();
            TrxNumSearchRadioButton.Checked = false;
            DateSearchRadioButton.Checked = false;
            SearchButton.Enabled = true;
            SearchTextBox.Enabled = true;
            SearchTypeGroupBox.Enabled = true;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            ChangeFormWidth(false);
        }

        //When listboxes are clicked, or increase/decrease quantity, the current price changes
        private int ChangeDuringClick()
        {
            int PizzaTypeIndex = 0, PizzaSizeIndex = 0, Quantity = int.Parse(PizzaQuantityTextbox.Text), row, col, value;
            decimal PizzaPrice;

            // read the contents of the file into a string variable
            string PizzaStock = File.ReadAllText("StockList.txt");

            // split the string into rows and columns
            string[] rows = PizzaStock.Split('\n');
            int numRows = rows.Length;
            int numCols = rows[0].Split(',').Length;
            int[,] array = new int[numRows, numCols];

            for (int i = 0; i < numRows; i++)
            {
                string[] cols = rows[i].Split(',');
                for (int j = 0; j < numCols; j++)
                {
                    array[i, j] = int.Parse(cols[j].Trim());
                }
            }

            // access a specific element of the array
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
            DialogResult Result;
            List<string> lt = new List<string>();
            string str = null, OrderSummary;
            string Time = DateTime.Now.ToString("HH:mm"), Date = DateTime.Now.ToString("d");
            string OrderNumber;
            int TransactionCount1 = 0, TotalPizzaSold1 = 0;
            decimal TotalTransactionsCost = 0;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // need to write order and date to file (DONE)
            if (OrderedListbox.Items.Count != 0)
            {
                foreach (var item in OrderedListbox.Items)
                {  
                    lt.Add(item.ToString()); //store the items in the list
                    str += item + "\r\n";    //store the items in the string
                }
                OrderNumber = GenerateRandomNumber(MIN_RANNUM, MAX_RANNUM);
                OrderSummary = "Order Number: " + OrderNumber + "\nOrder Date: " + Date + " " + Time + "\nOrder Contents: \n" + str;
                DialogResult = MessageBox.Show(OrderSummary, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        TransactionCount += 1;
                        TotalTranactionCost = TotalTransactionCostForTextbox;
                        TotalPizzaSold = OrderedListbox.Items.Count;

                        StreamReader InputFile = File.OpenText("Form2Summary.txt");

                        if (InputFile == null)
                        {
                            TransactionCount1++;
                            TotalPizzaSold1 = TotalPizzaSold;
                            TotalTransactionsCost = TotalTranactionCost;
                            StreamWriter OutputFile2 = File.CreateText("Form2Summary.txt");
                            OutputFile2.WriteLine(TransactionCount1);
                            OutputFile2.WriteLine(TotalPizzaSold1);
                            OutputFile2.WriteLine(TotalTransactionsCost.ToString());
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
                            StreamWriter OutputFile2 = File.CreateText("Form2Summary.txt");
                            OutputFile2.WriteLine(TransactionCount1);
                            OutputFile2.WriteLine(TotalPizzaSold1);
                            OutputFile2.WriteLine(TotalTransactionsCost);
                            OutputFile2.Close();
                        }

                        StreamWriter OutputFile = File.AppendText("TransactionSummary.txt");
                        //adding time to transaction
                        OutputFile.WriteLine(OrderNumber);
                        OutputFile.WriteLine(Date.ToString());
                        OutputFile.WriteLine(Time.ToString());
                        OutputFile.WriteLine(TotalPizzaSold);
                        OutputFile.WriteLine(TotalTranactionCost);
                        OutputFile.WriteLine("");
                        OutputFile.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
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

                        OrderedListbox.Items.Clear();
                        MessageBox.Show("Order has been Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        /*
         *Methods 
         * 
         */
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
        //random Number Generator
        private String GenerateRandomNumber(int Min, int Max)
        {
            Random MyRandomObject;
            int RandomNumber;

            MyRandomObject = new Random();
            RandomNumber = MyRandomObject.Next(Min, Max);

            return RandomNumber.ToString();
        }

    }


}
    
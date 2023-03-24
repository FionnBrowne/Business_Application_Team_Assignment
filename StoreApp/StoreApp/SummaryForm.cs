using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class SummaryForm : Form
    {
        //Array created for Pizza sizes
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
        public SummaryForm()
        {
            InitializeComponent();
            //Inputs the available stock that is stored in the file into the listbox
            readStock();
            //Inputs the Company summary details that were done on the current date
            CompanySummary();
        }

        private void ExitSummaryButton_Click(object sender, EventArgs e)
        {
            // Only closes the summary form
            this.Close();
        }

        //Reads the Stock File and writes in the available stock into the listbox
        private void readStock()
        {

            String file = "StockList.txt";
            String[] allRows = File.ReadAllLines(file);
            StockListbox.Items.Clear();

            // Define the PizzaSizeCost array with enough rows and columns
            decimal[,] PizzaSizeCost = new decimal[allRows.Length, 5];

            for (int row = 0; row < allRows.Length; row++)
            {
                string[] oneRow = allRows[row].Split(',');

                // Parse the values to decimals and store them in the PizzaSizeCost array
                for (int col = 0; col < 5; col++)
                {
                    decimal value;
                    if (decimal.TryParse(oneRow[col], out value))
                    {
                        PizzaSizeCost[row, col] = value;
                    }
                }

                // Add the values to the listBox2 control
                StockListbox.Items.Add(string.Join(" ", oneRow));
            }
        }
        private void CompanySummary()
        {
            string date;
            decimal TransactionCount = 0, TotalPizzaSold = 0, AverageItemsPerTransaction = 0,
                    AveragePizzaCost = 0, TotalTransactionsCost = 0, AverageCostOfOrder = 0;
            Boolean ContinueWhile = true;
            String[,] SummaryStock = new String[13, 5];
            string[,] ReadingStock = new String[13, 5];
            try
            {
                StreamReader Input = File.OpenText("Summary.txt");
                date = Input.ReadLine();
                TransactionCount = int.Parse(Input.ReadLine());
                TotalPizzaSold = int.Parse(Input.ReadLine());
                TotalTransactionsCost = decimal.Parse(Input.ReadLine());
                try
                {
                    AverageItemsPerTransaction = TotalPizzaSold / TransactionCount; 
                    AveragePizzaCost = TotalTransactionsCost / TotalPizzaSold;
                    AverageCostOfOrder = TotalTransactionsCost / TransactionCount;
                    SalesListbox.Items.Add("Date: " + date);
                    SalesListbox.Items.Add("Transactions Processed: " + TransactionCount);
                    SalesListbox.Items.Add("Pizzas Sold: " + TotalPizzaSold);
                    SalesListbox.Items.Add("Profit: " + TotalTransactionsCost);
                    SalesListbox.Items.Add("Average items Per Transaction: " + AverageItemsPerTransaction.ToString("C2"));
                    SalesListbox.Items.Add("Average Pizza Sale: " + AveragePizzaCost.ToString("C2"));
                    SalesListbox.Items.Add("Average Cost of Order: " + AverageCostOfOrder.ToString("C2"));
                    Input.Close();

                    //Tried to create method that stores all transactions made on current date into company summary

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////               
                    /*String[] InPutFile = File.ReadAllLines("TransactionStock.txt");

                    do
                    {
                        int index = 0;
                        index += 13;
                        index = Array.IndexOf(InPutFile, index);
                        //reads until it finds the transaction order
                        while (index < InPutFile.Length && !String.IsNullOrEmpty(InPutFile[index]))
                        {
                            SalesListbox.Items.Add("hello");
                            ReadingStock[13, 5] = InPutFile[index++];
                        }
                        for (int row = 0; row < InPutFile.Length; row++)
                        {
                            SalesListbox.Items.Add("hello");
                            //StockListbox.Items.Add("hello");
                            for (int col = 0; col < InPutFile.Length; col++)
                            {
                                SalesListbox.Items.Add("hello");
                                ReadingStock[13, 5] = InPutFile[index++];
                                SalesListbox.Items.Add(ReadingStock[13, 5]);
                            }
                        }
                        SummaryStock[13, 5] += ReadingStock;
                        for (int row = 0; row < InPutFile.Length; row++)
                        {
                            SalesListbox.Items.Add("hello");

                            //StockListbox.Items.Add("hello");
                            for (int col = 0; col < InPutFile.Length; col++)
                            {
                                SalesListbox.Items.Add("hello");
                                SalesListbox.Items.Add(ReadingStock[13, 5]);
                            }
                        }
                        Console.WriteLine("Array (After using Clear):");
                        foreach (int val in arr)
                        {
                            Console.WriteLine(val);
                        }
                        Console.WriteLine("Array (After using Clear):");
                        //SummaryStock[13, 5] += ReadingStock;
                        // StockListbox.Items.Add(ReadingStock[13,5]);
                        index++;

                    } while (ContinueWhile == true);*/
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                }
                catch
                {

                }
            }
            catch
            {
                //catches the error and prevents the program from crashing
                MessageBox.Show("A fatal error has occured, please contact your administator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

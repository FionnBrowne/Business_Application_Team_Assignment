using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class SummaryForm : Form
    {
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
            readStock();
            CompanySummary();
        }

        private void ExitSummaryButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void readStock()
        {
            StreamWriter OutputFile = File.AppendText("TransactionSummary.txt");

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
            try
            {
                StreamReader Input = File.OpenText("Form2Summary.txt");

                SalesListbox.Items.Add("Transactions Processed: " + Input.ReadLine());
                SalesListbox.Items.Add("Pizzas Sold: " + Input.ReadLine().ToString());
                SalesListbox.Items.Add("Profit: " + Input.ReadLine());

                Input.Close();
            }
            catch
            {
                MessageBox.Show("A fatal error has occured, please contact your administator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

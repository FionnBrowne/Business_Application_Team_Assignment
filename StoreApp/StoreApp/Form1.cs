using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class MainForm : Form
    {
        //List box items
        String[] PizzaTypes = { "Margherita Pizza", "Hawaiian Pizza", "Pepperoni", "Meat Feast", "Chicago Deep Dish Pizza", "Veggie Pizza", "BBQ Chicken Pizza", "Peri Peri Chicken Pizza", "Beef Supreme Pizza", "Neapolitan Pizza", "Buffalo Pizza", "Ham and Cheese Pizza", "3-Guys-Special-Pizza" };
        //decimal[] CostOfPizza = { 7.50m, 8.00m, 7.00m, 9.00m, 8.50m, 7.00m, 10.00m, 10.50m, 11.00m, 8.75m, 9.00m, 8.00m, 12.00m };



        decimal[,] PizzaSizeCost = {
            { 7.50m, 10.50m, 13.50m,15.50m,17.50m},
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



        private void SummaryButton_Click(object sender, EventArgs e)
        {
            var newform = new SummaryForm();
            newform.Show();
        }


        private void AddOrderToOrderButton_Click(object sender, EventArgs e)
        {

        }
        private void ExitSummaryButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
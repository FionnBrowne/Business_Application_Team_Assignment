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
        decimal[] CostOfPizza = { 7.50m, 8.00m, 7.00m, 9.00m, 8.50m, 7.00m, 10.00m, 10.50m, 11.00m, 8.75m, 9.00m, 8.00m, 12.00m };
        public MainForm()
        {
            InitializeComponent();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            var newform = new SummaryForm();
            newform.Show();
        }
    }
}

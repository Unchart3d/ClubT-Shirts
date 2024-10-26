using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubT_Shirts
{
    public partial class Form1 : Form
    {
        private OrderManager orderManager = new OrderManager();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "XSmall", "Small", "Medium", "Large", "XLarge", "XXLarge" });
        }
        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
                labelTotalCost displayOrder = new labelTotalCost();
                foreach (var item in orderManager.GetOrders())
                {
                    displayOrder.AddItem(item.Size, item.Quantity, item.Cost);
                }
                displayOrder.Show();
        }

        private void addToCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedsizes = comboBox1.SelectedItem.ToString();
            int quantity;

            if (!string.IsNullOrEmpty(textBox1.Text) && int.TryParse(textBox1.Text, out quantity) && quantity > 0)
            {
                orderManager.AddOrder(selectedsizes,quantity); 
                MessageBox.Show("Item added to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please choose the size and input the quantity of that size." +
                "\nYou are able to make multiple size selections, " +
                "\njust input how many you would like.");
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

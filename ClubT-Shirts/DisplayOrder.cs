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
    public partial class labelTotalCost : Form
    {
        private decimal totalCost = 0;
        public labelTotalCost()
        {
            InitializeComponent();

            listView1.Columns.Add("Size", 100);
            listView1.Columns.Add("Quantity", 100);
            listView1.Columns.Add("Cost");
        }

        public void AddItem(string size, int quantity, decimal cost)
        {
            ListViewItem item = new ListViewItem(size);
            item.SubItems.Add(quantity.ToString());
            item.SubItems.Add(cost.ToString("C"));
            listView1.Items.Add(item);

            totalCost += cost;
            UpdateTotalCostLabel();
        }
        private void UpdateTotalCostLabel()
        {
            label1.Text = "Total Cost: " + totalCost.ToString("C");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

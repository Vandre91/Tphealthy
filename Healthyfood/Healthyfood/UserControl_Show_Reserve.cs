using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockFood;

namespace Healthyfood
{
    public partial class UserControl_Show_Reserve : UserControl
    {
        
        public UserControl_Show_Reserve()
        {
            InitializeComponent();
        }
        public Menu Root
        {
            get { return (Menu)FindForm(); }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            this.Visible = false;
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            string name = listView1.SelectedItems[0].SubItems[0].Text;
            string expiration_date = listView1.SelectedItems[0].SubItems[2].Text;
            DateTime expiration = Convert.ToDateTime(expiration_date);
            Root.Healthy.Stocks.RemoveIngredient(name, expiration);
            label1.Text = "Ingredient supprimé";
            UserControl_Show_Reserve_Enter(sender, e);
        }

        private void UserControl_Show_Reserve_Enter(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (var p in Root.Healthy.Stocks.IStock)
            {
                string date = Convert.ToString(p.Expiration_Date);
                string[] row = { p.Name, p.Balance.ToString(),date };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }
    }
}

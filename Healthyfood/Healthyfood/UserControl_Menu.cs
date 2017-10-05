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
    public partial class UserControl_Menu : UserControl
    {
        public UserControl_Menu()
        {
            InitializeComponent();
            
        }
        public Menu Root
        {
            get { return (Menu)FindForm(); }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            userControl_Add_Menu1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            try
            {
                string name = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                StockFood.Menu men = Root.Healthy.AllMenu.FindMenu(name);
                Root.Healthy.AllMenu.RemoveMenu(men);
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
            catch (ArgumentException)
            {
                label2.Visible = true;
            }
        }

        public void UserControl_Menu_Enter(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (var p in Root.Healthy.AllMenu.Menus)
            {
                string[] row = { p.Name, p.Datefirst.ToShortDateString(), p.Datelast.ToShortDateString() };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = true;

            string name = listView1.SelectedItems[0].SubItems[0].Text.ToString();
            StockFood.Menu men = Root.Healthy.AllMenu.FindMenu(name);
            StringBuilder builder = new StringBuilder();
            foreach (var m in men.IMenu)
            {
               foreach(var i in m.IRecipe)
                {
                    builder.Append(i.Balance).Append(" ");
                    builder.Append(i.Name).Append('\n');
                    
                }
                string result = builder.ToString();
                richTextBox1.Text += result;
            }
            
        }

        private void button_view_Click_1(object sender, EventArgs e)
        {
            label2.Visible = false;
            try
            {
                string name = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                StockFood.Menu men = Root.Healthy.AllMenu.FindMenu(name);
                Root.Healthy.Menu = men;
                userControl_Modify_Menu1.Visible = true;
                userControl_Modify_Menu1.Focus();
            }
            catch (ArgumentException)
            {
                label2.Visible = true;
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}

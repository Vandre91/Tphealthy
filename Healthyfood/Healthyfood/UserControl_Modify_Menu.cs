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
using System.Speech.Synthesis;

namespace Healthyfood
{
    public partial class UserControl_Modify_Menu : UserControl
    {
        public SpeechSynthesizer _parole = new SpeechSynthesizer();
        public UserControl_Modify_Menu()
        {
            InitializeComponent();
        }
        public Menu Root
        {
            get { return (Menu)FindForm(); }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void UserControl_Modify_Menu_Enter(object sender, EventArgs e)
        {
            label_week.Text = "Menu du "+Root.Healthy.Menu.Datefirst.ToShortDateString()+" aux " + Root.Healthy.Menu.Datelast.ToShortDateString() + ".";
            listView1.Items.Clear();
            double i= 0;
            int ii = 0;
            DateTime datef = Root.Healthy.Menu.Datefirst;
            

            foreach (var r in Root.Healthy.Menu.IMenu)
            {
                DateTime datenew = datef.AddDays(i);
                string date = datenew.ToShortDateString();
                string[] row = { date,r.Name };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);

                if (ii == 1)
                {
                    ii = 0;
                    i++;
                }
                else
                {
                    ii++;
                }
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string name = listView1.SelectedItems[0].SubItems[1].Text;
            Recipe recipe = Root.Healthy.AllRecipe.FindHealthyrecipe(name);

            label_Name.Text = recipe.Name;
            StringBuilder builder = new StringBuilder();
            foreach (var p in recipe.IRecipe)
            {
                builder.Append(p.Balance).Append(" ");
                builder.Append(p.Name).Append('\n');
            }
            string result = builder.ToString();
            richTextBox1.Text = result;
            richTextBox_Describe.Text = recipe.Describe;
            panel1.Visible = true;
            panel1.Focus();
        }

        private void button_Back_Panel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            _parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            _parole.SpeakAsync(richTextBox_Describe.Text);
        }

        private void button_Heat_Click(object sender, EventArgs e)
        {
            Recipe rec = Root.Healthy.AllRecipe.FindHealthyrecipe(label_Name.Text);
            bool contain = false;
            int count = 0;
            foreach (Ingredient ingred in rec.IRecipe)
            {
                foreach (Ingredient ing in Root.Healthy.Stocks.IStock)
                {
                    if (ingred.Name == ing.Name && ingred.Balance < ing.Balance)
                    {
                        count++;
                        contain = true;
                    }
                    if (contain) break;
                }
                contain = false;
            }
            if (count == rec.IRecipe.Count)
            {
                foreach (Ingredient ingred in rec.IRecipe)
                {
                    foreach (Ingredient ing in Root.Healthy.Stocks.IStock)
                    {
                        if (ingred.Name == ing.Name && ingred.Balance < ing.Balance)
                        {
                            Root.Healthy.Stocks.ReduceIngredient(ing.Name, ingred.Balance, ing.Expiration_Date);
                            break;
                        }
                    }
                }
                label2.ForeColor = Color.Green;
                label2.Text = "Validé";
            }

            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Ingredients manquants";
            }
        }
    }
}

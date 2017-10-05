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
    public partial class UserControl_Recipe : UserControl
    {
        public UserControl_Recipe()
        {
            InitializeComponent();
            userControl_Recipe_Healthy1.Visible = false;
            userControl_Recipe_Utilisateur1.Visible = false;
            userControl_Your_Recipes1.Visible = false;
            userControl_World_Recipe1.Visible = false;
            userControl_RecipeExpiration1.Visible = false;
        }
        public Menu Root
        {
            get { return (Menu)FindForm(); }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string name = listView1.SelectedItems[0].SubItems[0].Text;
                string lastname = listView1.SelectedItems[0].SubItems[1].Text;
                UserProfile profil = Root.Healthy.Utilisateur.FindUser(name, lastname);
                Root.Healthy.Profil = profil;
                label2.Visible = false;
                userControl_Recipe_Healthy1.Visible = true;
                userControl_Recipe_Healthy1.Focus();
            }
            catch(ArgumentException)
            {
                label2.Visible = true;
            }
        }

        private void button2_yours_recipes_Click(object sender, EventArgs e)
        {
            userControl_Your_Recipes1.Visible = true;
            label2.Visible = false;
            userControl_Your_Recipes1.Focus();
        }

        private void button3_world_recipes_Click(object sender, EventArgs e)
        {
            userControl_World_Recipe1.Visible = true;
            label2.Visible = false;
            userControl_World_Recipe1.Focus();
        }

        private void UserControl_Recipe_Enter(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label2.Visible = false;

            foreach (var p in Root.Healthy.Utilisateur.IUtilisateur)
            {
                string[] row = { p.FirstName, p.LastName };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userControl_Recipe_Utilisateur1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl_RecipeExpiration1.Visible = true;
        }
    }
}

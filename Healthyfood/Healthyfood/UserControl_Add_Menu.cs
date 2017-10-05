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
    public partial class UserControl_Add_Menu : UserControl
    {
        public UserControl_Add_Menu()
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
        #region Combobox Click
        private void comboBox1_Click(object sender, EventArgs e)
        {
            foreach(Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox1.Items.Add(recipe.Name);
            }
        }

        private void comboBox_ls_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_ls.Items.Add(recipe.Name);
            }
        }

        private void comboBox_mm_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_mm.Items.Add(recipe.Name);
            }
        }

        private void comboBox_ms_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_ms.Items.Add(recipe.Name);
            }
        }

        private void comboBox_mem_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_mem.Items.Add(recipe.Name);
            }
        }

        private void comboBox_mes_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_mes.Items.Add(recipe.Name);
            }
        }

        private void comboBox_jm_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_jm.Items.Add(recipe.Name);
            }
        }

        private void comboBox_js_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_js.Items.Add(recipe.Name);
            }
        }

        private void comboBox_vm_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_vm.Items.Add(recipe.Name);
            }
        }

        private void comboBox_vs_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_vs.Items.Add(recipe.Name);
            }
        }

        private void comboBox_sm_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_sm.Items.Add(recipe.Name);
            }
        }

        private void comboBox_ss_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_ss.Items.Add(recipe.Name);
            }
        }

        private void comboBox_dm_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBox_dm.Items.Add(recipe.Name);
            }
        }

        private void comboBoxds_Click(object sender, EventArgs e)
        {
            foreach (Recipe recipe in Root.Healthy.AllRecipe.Healthyrecipe)
            {
                comboBoxds.Items.Add(recipe.Name);
            }
        }
        #endregion

        private void button_Save_Click(object sender, EventArgs e)
        {
            label_d.Visible = false;
            label_n.Visible = false;
            label_g.Visible = false;
            label_erreur.Visible = false;
            label_combo.Visible = false;

            string name = textBox1.Text;
            Dictionary<string, Recipe> recipe = new Dictionary<string, Recipe>();
            string d = textBox_b.Text;
            string de = textBox_e.Text;

            try
            {
                Recipe rec1 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox1.SelectedItem.ToString());
                recipe.Add(rec1.Name, rec1);
                Recipe rec2 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox_ls.SelectedItem.ToString());
                recipe.Add(rec2.Name, rec2);
                Recipe rec3 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox_mm.SelectedItem.ToString());
                recipe.Add(rec3.Name, rec3);
                Recipe rec4 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox_ms.SelectedItem.ToString());
                recipe.Add(rec4.Name, rec4);
                Recipe rec5 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox_mem.SelectedItem.ToString());
                recipe.Add(rec5.Name, rec5);
                Recipe rec6 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox_mes.SelectedItem.ToString());
                recipe.Add(rec6.Name, rec6);
                Recipe rec7 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox_jm.SelectedItem.ToString());
                recipe.Add(rec7.Name, rec7);
                Recipe rec8 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox_js.SelectedItem.ToString());
                recipe.Add(rec8.Name, rec8);
                Recipe rec9 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox_vm.SelectedItem.ToString());
                recipe.Add(rec9.Name, rec9);
                Recipe rec10 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox_vs.SelectedItem.ToString());
                recipe.Add(rec10.Name, rec10);
                Recipe rec11 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox_sm.SelectedItem.ToString());
                recipe.Add(rec11.Name, rec11);
                Recipe rec12 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox_ss.SelectedItem.ToString());
                recipe.Add(rec12.Name, rec12);
                Recipe rec13 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBox_dm.SelectedItem.ToString());
                recipe.Add(rec13.Name, rec13);
                Recipe rec14 = Root.Healthy.AllRecipe.FindHealthyrecipe(comboBoxds.SelectedItem.ToString());
                recipe.Add(rec14.Name, rec14);

            }
            catch (ArgumentException )
            {
                label_erreur.Text = "Une des recette a été selectionner deux fois";
                label_erreur.Visible = true;
            }
            catch(NullReferenceException)
            {
                label_combo.Visible = true;
            }
            if (textBox1.Text == "")
            {
                label_n.Visible = true;
            }
            
            if (textBox_b.Text == "" || textBox_e.Text == "")
            {
                label_d.Visible = true;
            }
            else
            {
                DateTime dateb = DateTime.Parse(d);
                DateTime datee = DateTime.Parse(de);

                label_g.Visible = true;
                textBox1.Clear();
                textBox_b.Clear();
                textBox_e.Clear();
                comboBox1.Items.Clear();
                comboBox_ls.Items.Clear();
                comboBox_mm.Items.Clear();
                comboBox_ms.Items.Clear();
                comboBox_mem.Items.Clear();
                comboBox_mes.Items.Clear();
                comboBox_jm.Items.Clear();
                comboBox_js.Items.Clear();
                comboBox_vm.Items.Clear();
                comboBox_vs.Items.Clear();
                comboBox_sm.Items.Clear();
                comboBox_ss.Items.Clear();
                comboBox_dm.Items.Clear();
                comboBoxds.Items.Clear();
                monthCalendar1.Visible = false;
                monthCalendar2.Visible = false;


                Root.Healthy.AllMenu.AddMenu(name, recipe, dateb, datee);
            }
        }
        #region Calendar
        private void textBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar2.Visible = false;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
            monthCalendar1.Visible = false;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox_b.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox_e.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
        }
        #endregion
    }
}

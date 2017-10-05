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
    public partial class UserControl_RecipeExpiration : UserControl
    {
        public SpeechSynthesizer _parole = new SpeechSynthesizer();
        public UserControl_RecipeExpiration()
        {
            InitializeComponent();
            panel_Show_Recipes.Visible = false;
        }

        public Menu Root
        {
            get { return (Menu)FindForm(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
        }

        private void listView1_Enter(object sender, EventArgs e)
        {
            int x = 0;
            listView1.Items.Clear();
            Dictionary<string, Recipe> expir = new Dictionary<string, Recipe>();
            foreach (Ingredient ingre in Root.Healthy.Stocks.IStock)
            {
                if (ingre.Expiration_Date <= DateTime.Today.AddDays(3) && ingre.Expiration_Date >= DateTime.Today)
                {
                    foreach (Recipe rec in Root.Healthy.AllRecipe._healthyrecipe.Values)
                    {
                        foreach (Ingredient ing in rec.IRecipe)
                        {
                            if (ing.Name == ingre.Name && !(expir.ContainsKey(rec.Name)))
                            {
                                expir.Add(rec.Name, rec);
                            }
                        }
                    }
                }

            }

            if (expir.Count > 0)
            {
                foreach (var p in expir.Values)
                {
                    string[] row = { p.Name, p.Describe, RecipeCal(p).ToString() };
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);
                    if (EatPossible(p).Count > 1)
                    {
                        listView1.Items[x].ImageIndex = 1;
                    }
                    else listView1.Items[x].ImageIndex = 0;
                    x++;
                }
            }

            
    }

        public int RecipeCal(Recipe Rec)
        {

            int cal = 0;
            foreach (Ingredient ing in Rec.IRecipe)
            {
                if (Unite(ing) == " unités")
                    cal = cal + ((ing.Balance * IngredientCal(ing.Name)));
                else
                {
                    cal = cal + ((ing.Balance * IngredientCal(ing.Name)) / 100);
                }
            }
            if (cal > 2000 && cal < 10000) cal = 890 + IngredientCal(Rec.IRecipe[0].Name);
            else if (cal >= 10000 && cal < 1000000) cal = 1200 + IngredientCal(Rec.IRecipe[0].Name);
            return cal;
        }

        public int IngredientCal(string ingred)
        {
            int cal = 100;
            if (Root.Healthy.Calories.Cal.ContainsKey(ingred))
            {
                cal = Root.Healthy.Calories.Cal[ingred];
            }
            return cal;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string name = listView1.SelectedItems[0].SubItems[0].Text;
            Recipe recipe = Root.Healthy.AllRecipe.FindHealthyrecipe(name);

            label_Name.Text = recipe.Name;
            StringBuilder builder = new StringBuilder();
            foreach (var p in recipe.IRecipe)
            {
                builder.Append(p.Balance).Append(" ").Append(Unite(p)).Append(" ");
                builder.Append(p.Name).Append('\n');
            }
            string result = builder.ToString();
            richTextBox1.Text = result;
            richTextBox_Describe.Text = recipe.Describe;
            panel_Show_Recipes.Visible = true;
            panel_Show_Recipes.Focus();
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
                MessageBox.Show("Bon appetit");
            }

            else
            {
                foreach (Ingredient i in EatPossible(rec))
                {
                    MessageBox.Show("Il vous manque l'ingredient suivant : " + i.Name + " , Quantité : " + Convert.ToString(i.Balance) + Unite(i));
                }
            }
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            _parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            _parole.SpeakAsync(richTextBox_Describe.Text);
        }

        private void button_Back_Panel_Click(object sender, EventArgs e)
        {
            //label1.Text = null;
            panel_Show_Recipes.Visible = false;
        }

        public List<Ingredient> EatPossible(Recipe rec)
        {
            List<Ingredient> liste = new List<Ingredient>();
            int quant;
            foreach (Ingredient ingred in rec.IRecipe)
            {
                quant = 0;
                foreach (Ingredient ing in Root.Healthy.Stocks.IStock)
                {
                    if (ing.Name == ingred.Name && ing.Expiration_Date > DateTime.Today)
                    {
                        quant = quant + ing.Balance;
                    }
                }
                if (quant < ingred.Balance)
                {
                    Ingredient i = new Ingredient(ingred.Category1, ingred.Name, ingred.Balance - quant, DateTime.Today);
                    liste.Add(i);
                }
            }
            return liste;
        }

        public string Unite(StockFood.Ingredient ingred)
        {
            string unit;
            if (ingred.Category1 == "boisson") unit = " ml";
            else if (ingred.Category1 == "boulangerie" || ingred.Category1 == "fruit" || ingred.Category1 == "legume"
            || ingred.Category1 == "poisson" || ingred.Category1 == "crustace" || ingred.Category1 == "dessert_sucrerie" || ingred.Category1 == "volaille")
                unit = " unités";
            else if (ingred.Category1 == "feculent" || ingred.Category1 == "herbe_plante") unit = " g";
            else if (ingred.Category1 == "viande") unit = " g";
            else if (ingred.Category1 == "produit_laitier")
            {
                if (ingred.Name == "beurre" || ingred.Name == "lait en poudre" || ingred.Name == "fromage frais" || ingred.Name == "fromage fermier" ||
                    ingred.Name == "fromage affiné" || ingred.Name == "caséine") unit = " g";
                else unit = " ml";
            }
            else if (ingred.Category1 == "matiere_grasse")
            {
                if (ingred.Name == "beurre") unit = " g";
                else unit = " ml";
            }
            else unit = " g";


            return unit;
        }
    }
}

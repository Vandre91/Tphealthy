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
    public partial class UserControl_Recipe_Utilisateur : UserControl
    {
        public UserControl_Recipe_Utilisateur()
        {
            InitializeComponent();
        }
        public Menu Root
        {
            get { return (Menu)FindForm(); }
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            label_prep.Visible = false;
            label_ing.Visible = false;
            label_name.Visible = false;
            label_save.Visible = false;
           
            string n = "";
            string q = "";
            string c = "";
            
            if (textBox1.Text == null || textBox1.Text == "")
            {
                label_name.Visible = true;
            }
            if (listView1.Items.Count <=0)
            {
                label_ing.Visible = true;
            }
            if (richTextBox1.Text == null || richTextBox1.Text == "")
            {
                label_prep.Visible = true;
            }
            else
            { 
            List<Ingredient> ing = new List<Ingredient> { };
            foreach (ListViewItem l in listView1.Items)
            {
                n = l.Text;
                q = l.SubItems[1].Text;
                c = l.SubItems[2].Text;
                int numVal = Int32.Parse(q);
                Ingredient i = new Ingredient(c, n, numVal, DateTime.Today);
                ing.Add(i);
            }

            Root.Healthy.AllRecipe.AddHealthyrecipe(textBox1.Text, ing, richTextBox1.Text);

            label_save.Visible = true;
            textBox1.Clear();
            listView1.Clear();
            richTextBox1.Clear();
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { textBox_name.Text, textBox_quantity.Text, textBox_categorie.Text };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);

            textBox_name.Clear();
            textBox_quantity.Clear();
            textBox_categorie.Clear();
        }

        private void label_Beef_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            int countv = Root.Healthy._viande.Count;
            string[] _beef = new string[countv];
            int v = 0;
            Root.Healthy._viande.CopyTo(_beef);

            foreach (var p in _beef)
            {
                ListViewItem item = new ListViewItem(_beef[v]);
                listView2.Items.Add(item);
                v++;
            }

            textBox_categorie.Text = label_Beef.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_Drink_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            int countd = Root.Healthy._boisson.Count;
            string[] _drink = new string[countd];
            int b = 0;
            Root.Healthy._boisson.CopyTo(_drink);

            foreach (var p in _drink)
            {
                ListViewItem item = new ListViewItem(_drink[b]);
                listView2.Items.Add(item);
                b++;
            }

            textBox_categorie.Text = label_Drink.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_poultry_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            int countvo = Root.Healthy._volaille.Count;
            string[] _volaile = new string[countvo];
            int vo = 0;
            Root.Healthy._volaille.CopyTo(_volaile);

            foreach (var p in _volaile)
            {
                ListViewItem item = new ListViewItem(_volaile[vo]);
                listView2.Items.Add(item);
                vo++;
            }

            textBox_categorie.Text = label_poultry.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_vegetable_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            int countl = Root.Healthy._legume.Count;
            string[] _legume = new string[countl];
            int l = 0;
            Root.Healthy._legume.CopyTo(_legume);

            foreach (var p in _legume)
            {
                ListViewItem item = new ListViewItem(_legume[l]);
                listView2.Items.Add(item);
                l++;
            }

            textBox_categorie.Text = label_vegetable.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_fruit_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            int countf = Root.Healthy._fruit.Count;
            string[] _fruit = new string[countf];
            int f = 0;
            Root.Healthy._fruit.CopyTo(_fruit);

            foreach (var p in _fruit)
            {
                ListViewItem item = new ListViewItem(_fruit[f]);
                listView2.Items.Add(item);
                f++;

            }

            textBox_categorie.Text = label_fruit.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_Milk_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            int countpf = Root.Healthy._produit_laitier.Count;
            string[] _produit_laitier = new string[countpf];
            int pf = 0;
            Root.Healthy._produit_laitier.CopyTo(_produit_laitier);

            foreach (var p in _produit_laitier)
            {
                ListViewItem item = new ListViewItem(_produit_laitier[pf]);
                listView2.Items.Add(item);
                pf++;
            }

            textBox_categorie.Text = label_Milk.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_feculent_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            int countfe = Root.Healthy._feculent.Count;
            string[] _feculent = new string[countfe];
            int fe = 0;
            Root.Healthy._feculent.CopyTo(_feculent);

            foreach (var p in _feculent)
            {
                ListViewItem item = new ListViewItem(_feculent[fe]);
                listView2.Items.Add(item);
                fe++;
            }

            textBox_categorie.Text = label_feculent.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_grasse_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            int countmg = Root.Healthy._matiere_grasse.Count;
            string[] _matière_grasse = new string[countmg];
            int mg = 0;
            Root.Healthy._matiere_grasse.CopyTo(_matière_grasse);

            foreach (var p in _matière_grasse)
            {
                ListViewItem item = new ListViewItem(_matière_grasse[mg]);
                listView2.Items.Add(item);
                mg++;
            }

            textBox_categorie.Text = label_grasse.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_dessert_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            int countds = Root.Healthy._dessert_sucrerie.Count;
            string[] _sucrerie_dessert = new string[countds];
            int s = 0;
            Root.Healthy._dessert_sucrerie.CopyTo(_sucrerie_dessert);

            foreach (var p in _sucrerie_dessert)
            {
                ListViewItem item = new ListViewItem(_sucrerie_dessert[s]);
                listView2.Items.Add(item);
                s++;
            }

            textBox_categorie.Text = label_dessert.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_crustace_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            int countc = Root.Healthy._crustace.Count;
            string[] _crustace = new string[countc];
            int c = 0;
            Root.Healthy._crustace.CopyTo(_crustace);

            foreach (var p in _crustace)
            {
                ListViewItem item = new ListViewItem(_crustace[c]);
                listView2.Items.Add(item);
                c++;
            }

            textBox_categorie.Text = label_crustace.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_plante_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            int counthp = Root.Healthy._herbe_plante.Count;
            string[] _herbe_plante = new string[counthp];
            int hp = 0;
            Root.Healthy._herbe_plante.CopyTo(_herbe_plante);

            foreach (var p in _herbe_plante)
            {
                ListViewItem item = new ListViewItem(_herbe_plante[hp]);
                listView2.Items.Add(item);
                hp++;
            }

            textBox_categorie.Text = label_plante.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_backerie_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            int countbl = Root.Healthy._boulangerie.Count;
            string[] _boulangerie = new string[countbl];
            int bl = 0;
            Root.Healthy._boulangerie.CopyTo(_boulangerie);

            foreach (var p in _boulangerie)
            {
                ListViewItem item = new ListViewItem(_boulangerie[bl]);
                listView2.Items.Add(item);
                bl++;
            }

            textBox_categorie.Text = label_backerie.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void label_fish_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            int countp = Root.Healthy._poisson.Count;
            string[] _poisson = new string[countp];
            int po = 0;
            Root.Healthy._poisson.CopyTo(_poisson);

            foreach (var p in _poisson)
            {
                ListViewItem item = new ListViewItem(_poisson[po]);
                listView2.Items.Add(item);
                po++;
            }

            textBox_categorie.Text = label_fish.Text;
            listView2.Visible = true;
            button_Ok.Visible = true;
            button_back1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_name.Text = listView2.SelectedItems[0].Text;
            listView2.Visible = false;
            panel1.Visible = false;
            button_Ok.Visible = false;
            button_back1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
            panel1.Visible = false;
            button_Ok.Visible = false;
            button_back1.Visible = false;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void textBox_categorie_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        
    }
}

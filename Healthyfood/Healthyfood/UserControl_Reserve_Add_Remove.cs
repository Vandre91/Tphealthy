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
    public partial class UserControl_Reserve_Add_Remove : UserControl
    {
        object _s;
        EventArgs _e;

        public UserControl_Reserve_Add_Remove()
        {
            InitializeComponent();
            tabPage_Beef.ImageIndex = 0;
        }
        public Menu Root
        {
            get { return (Menu)FindForm(); }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_meat.Text = listView1.SelectedItems[0].Text;
            textBox_Quantity.Text = "En grammes";
        }

        private void button_back1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        #region Refresh
        public void UserControl_Reserve_Add_Remove_Enter(object sender, EventArgs e)
        {
            _s = sender;
            _e = e;

            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();
            listView5.Items.Clear();
            listView6.Items.Clear();
            listView7.Items.Clear();
            listView8.Items.Clear();
            listView9.Items.Clear();
            listView10.Items.Clear();
            listView11.Items.Clear();
            listView12.Items.Clear();
            listView13.Items.Clear();

            int countv = Root.Healthy._viande.Count;
            int countd = Root.Healthy._boisson.Count;
            int countds = Root.Healthy._dessert_sucrerie.Count;
            int countc = Root.Healthy._crustace.Count;
            int countp = Root.Healthy._poisson.Count;
            int countvo = Root.Healthy._volaille.Count;
            int countl = Root.Healthy._legume.Count;
            int countf = Root.Healthy._fruit.Count;
            int countpf = Root.Healthy._produit_laitier.Count;
            int countmg = Root.Healthy._matiere_grasse.Count;
            int countfe = Root.Healthy._feculent.Count;
            int counthp = Root.Healthy._herbe_plante.Count;
            int countbl = Root.Healthy._boulangerie.Count;

            string[] _beef = new string[countv];
            string[] _drink = new string[countd];
            string[] _sucrerie_dessert = new string[countds];
            string[] _crustace = new string[countc];
            string[] _poisson = new string[countp];
            string[] _volaile = new string[countvo];
            string[] _legume = new string[countl];
            string[] _fruit = new string[countf];
            string[] _produit_laitier = new string[countpf];
            string[] _matière_grasse = new string[countmg];
            string[] _feculent = new string[countfe];
            string[] _herbe_plante = new string[counthp];
            string[] _boulangerie = new string[countbl];

            int v = 0;
            int b = 0;
            int s = 0;
            int c = 0;
            int po = 0;
            int vo = 0;
            int l = 0;
            int f = 0;
            int pf = 0;
            int mg = 0;
            int fe = 0;
            int hp = 0;
            int bl = 0;

            Root.Healthy._viande.CopyTo(_beef);
            Root.Healthy._crustace.CopyTo(_crustace);
            Root.Healthy._boisson.CopyTo(_drink);
            Root.Healthy._dessert_sucrerie.CopyTo(_sucrerie_dessert);
            Root.Healthy._poisson.CopyTo(_poisson);
            Root.Healthy._volaille.CopyTo(_volaile);
            Root.Healthy._legume.CopyTo(_legume);
            Root.Healthy._fruit.CopyTo(_fruit);
            Root.Healthy._produit_laitier.CopyTo(_produit_laitier);

            Root.Healthy._matiere_grasse.CopyTo(_matière_grasse);
            Root.Healthy._feculent.CopyTo(_feculent);
            Root.Healthy._herbe_plante.CopyTo(_herbe_plante);
            Root.Healthy._boulangerie.CopyTo(_boulangerie);
            int i = 0;
            foreach (var p in _beef)
            {
                ListViewItem item = new ListViewItem(_beef[v]);
                listView1.Items.Add(item);
                if ((i % 2) == 0) listView1.Items[i].BackColor = Color.WhiteSmoke;
                else listView1.Items[i].BackColor = Color.White;
                i++;
                v++;
            }
            i = 0;
            foreach (var p in _drink)
            {
                ListViewItem item = new ListViewItem(_drink[b]);
                listView2.Items.Add(item);
                if ((i % 2) == 0) listView2.Items[i].BackColor = Color.WhiteSmoke;
                else listView2.Items[i].BackColor = Color.White;
                i++;
                b++;
            }
            i = 0;
            foreach (var p in _sucrerie_dessert)
            {
                ListViewItem item = new ListViewItem(_sucrerie_dessert[s]);
                listView3.Items.Add(item);
                if ((i % 2) == 0) listView3.Items[i].BackColor = Color.WhiteSmoke;
                else listView3.Items[i].BackColor = Color.White;
                i++;
                s++;
            }
            i = 0;
            foreach ( var p in _crustace)
            {
                ListViewItem item = new ListViewItem(_crustace[c]);
                listView4.Items.Add(item);
                if ((i % 2) == 0) listView4.Items[i].BackColor = Color.WhiteSmoke;
                else listView4.Items[i].BackColor = Color.White;
                i++;
                c++;
            }
            i = 0;
            foreach (var p in _poisson)
            {
                ListViewItem item = new ListViewItem(_poisson[po]);
                listView5.Items.Add(item);
                if ((i % 2) == 0) listView5.Items[i].BackColor = Color.WhiteSmoke;
                else listView5.Items[i].BackColor = Color.White;
                i++;
                po++;
            }
            i = 0;
            foreach (var p in _volaile)
            {
                ListViewItem item = new ListViewItem(_volaile[vo]);
                listView6.Items.Add(item);
                if ((i % 2) == 0) listView6.Items[i].BackColor = Color.WhiteSmoke;
                else listView6.Items[i].BackColor = Color.White;
                i++;
                vo++;
            }
            i = 0;
            foreach ( var p in _legume)
            {
                ListViewItem item = new ListViewItem(_legume[l]);
                listView7.Items.Add(item);
                if ((i % 2) == 0) listView7.Items[i].BackColor = Color.WhiteSmoke;
                else listView7.Items[i].BackColor = Color.White;
                i++;
                l++;
            }
            i = 0;
            foreach (var p in _fruit)
            {
                ListViewItem item = new ListViewItem(_fruit[f]);
                listView8.Items.Add(item);
                if ((i % 2) == 0) listView8.Items[i].BackColor = Color.WhiteSmoke;
                else listView8.Items[i].BackColor = Color.White;
                i++;
                f++;

            }
            i = 0;
            foreach (var p in _produit_laitier)
            {
                ListViewItem item = new ListViewItem(_produit_laitier[pf]);
                listView9.Items.Add(item);
                if ((i % 2) == 0) listView9.Items[i].BackColor = Color.WhiteSmoke;
                else listView9.Items[i].BackColor = Color.White;
                i++;
                pf++;
            }
            i = 0;
            foreach (var p in _matière_grasse)
            {
                ListViewItem item = new ListViewItem(_matière_grasse[mg]);
                listView10.Items.Add(item);
                if ((i % 2) == 0) listView10.Items[i].BackColor = Color.WhiteSmoke;
                else listView10.Items[i].BackColor = Color.White;
                i++;
                mg++;
            }
            i = 0;
            foreach (var p in _feculent)
            {
                ListViewItem item = new ListViewItem(_feculent[fe]);
                listView11.Items.Add(item);
                if ((i % 2) == 0) listView11.Items[i].BackColor = Color.WhiteSmoke;
                else listView11.Items[i].BackColor = Color.White;
                i++;
                fe++;
            }
            i = 0;
            foreach ( var p in _herbe_plante)
            {
                ListViewItem item = new ListViewItem(_herbe_plante[hp]);
                listView12.Items.Add(item);
                hp++;
                if ((i % 2) == 0) listView12.Items[i].BackColor = Color.WhiteSmoke;
                else listView12.Items[i].BackColor = Color.White;
                i++;
            }
            i = 0;
            foreach (var p in _boulangerie)
            {
                ListViewItem item = new ListViewItem(_boulangerie[bl]);
                listView13.Items.Add(item);
                if ((i % 2) == 0) listView13.Items[i].BackColor = Color.WhiteSmoke;
                else listView13.Items[i].BackColor = Color.White;
                i++;
                bl++;
            }
        }
        #endregion
        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_drink.Text = listView2.SelectedItems[0].Text;
            textbox_quantity_drink.Text = " En ml";
        }

        private void listView3_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_dessert.Text = listView3.SelectedItems[0].Text;
            txt_quantity_dessert.Text = "Par unité";
        }


        #region BtnBack

        private void Btn_back_milk_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Btn_back_fat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Btn_back_starchy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Btn_bacl_grass_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Btn_back_bakery_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_dessert_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_crustacean_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_Back_fish_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_poultry_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_vegetable_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_fruit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_dairyproduct_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_starchyfood_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_fat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_grass_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_back_bukery_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        #endregion

        #region Listview_Mouseclick
        private void listView4_MouseClick(object sender, MouseEventArgs e)
        {
            txt_name_crust.Text = listView4.SelectedItems[0].Text;
            txt_quantity_crust.Text = "Par unité";

        }

        private void listView5_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_fish.Text = listView5.SelectedItems[0].Text;
            txt_quantity_fish.Text = "Par unité";
        }

        private void listView6_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_poultry.Text = listView6.SelectedItems[0].Text;
            txt_quantity_poultry.Text = "Par unité";
        }

        private void listView7_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_vegetable.Text = listView7.SelectedItems[0].Text;
            txt_quantity_vegetable.Text = "Par unité";
        }

        private void listView8_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_fruit.Text = listView8.SelectedItems[0].Text;
            txt_quantity_fruit.Text = "Par unité";
        }

        private void listView9_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_milk.Text = listView9.SelectedItems[0].Text;
            if (text_name_milk.Text == "beurre" || text_name_milk.Text == "lait en poudre" || text_name_milk.Text == "fromage frais"
                ||text_name_milk.Text == "fromage fermier" ) textBox24.Text = "En grammes";
            else textBox24.Text = "En ml";
        }

        private void listView10_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_fat.Text = listView10.SelectedItems[0].Text;
            if (text_name_fat.Text == "beurre") textBox27.Text = "En grammes";
            else textBox27.Text = "En ml";
        }

        private void listView11_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_starchy.Text = listView11.SelectedItems[0].Text;
            textBox30.Text = "En grammes";
        }

        private void listView12_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_plant.Text = listView12.SelectedItems[0].Text;
            textBox33.Text = "En grammes";
        }

        private void listView13_MouseClick(object sender, MouseEventArgs e)
        {
            text_name_bakery.Text = listView13.SelectedItems[0].Text;
            textBox36.Text = "Par unité";
        }
        #endregion
        #region Verrif_error
        int verify_error(TextBox boxname, TextBox boxdate, TextBox boxquantity, Label error1, Label error2, Label error3, Label error4)
        {

            DateTime date = Convert.ToDateTime(boxdate.Text);
            int quantity = Int32.Parse(boxquantity.Text);
            string text = string.Copy(boxname.Text);
            if (date < DateTime.Today & quantity > 0 & text != string.Empty )
            {
                boxdate.BackColor = Color.Red;
                boxquantity.BackColor = Color.White;
                boxname.BackColor = Color.White;
                error1.Text = "La date entrée est invalide";
                error2.Text = null;
                error3.Text = null;
                error4.Text = null;
                return 0;
            }
            else if (date < DateTime.Today & quantity <= 0 & text != string.Empty)
            {
                boxdate.BackColor = Color.Red;
                boxquantity.BackColor = Color.Red;
                boxname.BackColor = Color.White;
                error1.Text = "La date entrée est invalide";
                error2.Text = "La quantité entrée est invalide";
                error3.Text = null;
                error4.Text = null;
                return 0;
            }

            else if (date < DateTime.Today & quantity > 0 & text == string.Empty)
            {
                boxdate.BackColor = Color.Red;
                boxquantity.BackColor = Color.White;
                boxname.BackColor = Color.Red;
                error1.Text = "La date entrée est invalide";
                error2.Text = null;
                error3.Text = "Aucun aliment sélection";
                error4.Text = null;
                return 0;
            }
            else if (date < DateTime.Today & quantity <= 0 & text == string.Empty)
            {
                boxdate.BackColor = Color.Red;
                boxquantity.BackColor = Color.Red;
                boxname.BackColor = Color.Red;
                error1.Text = "La date entrée est invalide";
                error2.Text = "La quantité entrée est invalide";
                error3.Text = "Aucun aliment sélectionné";
                error4.Text = null;
                return 0;
            }
            else if (date >= DateTime.Today & quantity <= 0 & text == string.Empty)
            {
                boxquantity.BackColor = Color.Red;
                boxdate.BackColor = Color.White;
                boxname.BackColor = Color.Red;
                error2.Text = "La quantité entrée est invalide";
                error1.Text = null;
                error3.Text = "Aucun aliment sélectionné";
                error4.Text = null;
                return 0;
            }
            else if (date >= DateTime.Today & quantity <= 0 & text != string.Empty)
            {
                boxquantity.BackColor = Color.Red;
                boxdate.BackColor = Color.White;
                boxname.BackColor = Color.White;
                error2.Text = "La quantité entrée est invalide";
                error1.Text = null;
                error3.Text = null;
                error4.Text = null;
                return 0;
            }

            else if (date >= DateTime.Today & quantity > 0 & text == string.Empty)
            {
                boxname.BackColor = Color.Red;
                boxdate.BackColor = Color.White;
                boxquantity.BackColor = Color.White;
                error2.Text = null;
                error1.Text = null;
                error3.Text = "Aucun aliment sélectionné";
                error4.Text = null;
                return 0;
            }
            else
            {
                boxquantity.Clear();
                boxdate.Clear();
                boxdate.BackColor = Color.White;
                boxquantity.BackColor = Color.White;
                boxname.BackColor = Color.White;
                error1.Text = null;
                error2.Text = null;
                error3.Text = null;
                MessageBox.Show( "Aliment enregistré");
                return 1;
            }
        }
        #endregion
        #region BtnSave
        private void button_Save_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar1.Visible = false;
            if (!(DateTime.TryParse(textBox_Date.Text, out date)) || !(Int32.TryParse(textBox_Quantity.Text, out quantity)))
            {
                text_error1.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(textBox_Quantity.Text);
                date = Convert.ToDateTime(textBox_Date.Text);
                int x = 0;
                x= verify_error(text_name_meat, textBox_Date, textBox_Quantity, text_error1, text_error2, text_error3, text_error4);
                if (x == 1) Root.Healthy.Stocks.AddIngredient("viande", text_name_meat.Text, quantity, date);
            }
        }

        private void button_save_drink_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar2.Visible = false;
            if (!(DateTime.TryParse(textbox_datePeremption.Text, out date)) || !(Int32.TryParse(textbox_quantity_drink.Text, out quantity)))
            {

                label37.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(textbox_quantity_drink.Text);
                int x = 0;
                date = Convert.ToDateTime(textbox_datePeremption.Text);
                x = verify_error(text_name_drink, textbox_datePeremption, textbox_quantity_drink, label37, label38, label39, label40);
                if (x == 1) Root.Healthy.Stocks.AddIngredient("boisson", text_name_drink.Text, quantity, date);
            }

        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar3.Visible = false;
            if (!(DateTime.TryParse(txt_dateperemtion_dessert.Text, out date)) || !(Int32.TryParse(txt_quantity_dessert.Text, out quantity)))
            {
                label41.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(txt_quantity_dessert.Text);
                int x = 0;
                date = Convert.ToDateTime(txt_dateperemtion_dessert.Text);
                x = verify_error(text_name_dessert, txt_dateperemtion_dessert, txt_quantity_dessert, label41, label42, label43, label44);
                if (x == 1) Root.Healthy.Stocks.AddIngredient("dessert_sucrerie", text_name_dessert.Text, quantity, date);
            }
        }

        private void btn_enreg_crustaceam_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar4.Visible = false;
            if (!(DateTime.TryParse(txt_dateperemption_crust.Text, out date)) || !(Int32.TryParse(txt_quantity_crust.Text, out quantity)))
            {
                label45.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(txt_quantity_crust.Text);
                int x = 0;
                date = Convert.ToDateTime(txt_dateperemption_crust.Text);

                x = verify_error(txt_name_crust, txt_dateperemption_crust, txt_quantity_crust, label45, label46, label47, label48);
                if (x == 1) Root.Healthy.Stocks.AddIngredient("crustace", txt_name_crust.Text, quantity, date);
            }
        }

        private void btn_enreg_fish_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar5.Visible = false;
            if (!(DateTime.TryParse(txt_dateperemption_fish.Text, out date)) || !(Int32.TryParse(txt_quantity_fish.Text, out quantity)))
            {
                label49.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(txt_quantity_fish.Text);
                int x = 0;
                date = Convert.ToDateTime(txt_dateperemption_fish.Text);
                x = verify_error(text_name_fish, txt_dateperemption_fish, txt_quantity_fish, label49, label50, label51, label52);
                if (x == 1) Root.Healthy.Stocks.AddIngredient("poisson", text_name_fish.Text, quantity, date);
            }
        }

        private void btn_enreg_poultry_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar6.Visible = false;
            if (!(DateTime.TryParse(txt_dateperemtion_poultry.Text, out date)) || !(Int32.TryParse(txt_quantity_poultry.Text, out quantity)))
            {
                label53.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(txt_quantity_poultry.Text);
                int x = 0;
                date = Convert.ToDateTime(txt_dateperemtion_poultry.Text);

                x = verify_error(text_name_poultry, txt_dateperemtion_poultry, txt_quantity_poultry, label53, label54, label55, label56);
                if (x == 1) Root.Healthy.Stocks.AddIngredient("volaille", text_name_poultry.Text, quantity, date);
            }
        }

        private void btn_enreg_vegetable_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar7.Visible = false;
            if (!(DateTime.TryParse(txt_dateperemtion_vegetable.Text, out date)) || !(Int32.TryParse(txt_quantity_vegetable.Text, out quantity)))
            {
                label57.Text = "Le format est invalide";

            }
            else
            {
                quantity = Int32.Parse(txt_quantity_vegetable.Text);
                int x = 0;
                date = Convert.ToDateTime(txt_dateperemtion_vegetable.Text);

                x = verify_error(text_name_vegetable, txt_dateperemtion_vegetable, txt_quantity_vegetable, label57, label58, label59, label60);
                if (x == 1) Root.Healthy.Stocks.AddIngredient("legume", text_name_vegetable.Text, quantity, date);
            }
        }

        private void btn_enreg_fruit_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar8.Visible = false;
            if (!(DateTime.TryParse(txt_dateperemtion_fruit.Text, out date)) || !(Int32.TryParse(txt_quantity_fruit.Text, out quantity)))
            {
                label61.Text = "Le format est invalide";

            }
            else
            {
                date = Convert.ToDateTime(txt_dateperemtion_fruit.Text);
                quantity = Int32.Parse(txt_quantity_fruit.Text);
                int x = 0;

                x = verify_error(text_name_fruit, txt_dateperemtion_fruit, txt_quantity_fruit, label61, label62, label63, label64);
                if (x == 1) Root.Healthy.Stocks.AddIngredient("fruit", text_name_fruit.Text, quantity, date);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar9.Visible = false;
            if (!(DateTime.TryParse(textBox23.Text, out date)) || !(Int32.TryParse(textBox24.Text, out quantity)))
            {
                label65.Text = "Le format est invalide";

            }
            else
            {
                date = Convert.ToDateTime(textBox23.Text);
                quantity = Int32.Parse(textBox24.Text);
                int x = 0;

                x = verify_error(text_name_milk, textBox23, textBox24, label65, label66, label67, label68);
                if (x == 1) Root.Healthy.Stocks.AddIngredient("produit_laitier", text_name_milk.Text, quantity, date);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar10.Visible = false;
            if (!(DateTime.TryParse(textBox26.Text, out date)) || !(Int32.TryParse(textBox27.Text, out quantity)))
            {
                label69.Text = "Le format est invalide";

            }
            else
            {
                date = Convert.ToDateTime(textBox26.Text);
                quantity = Int32.Parse(textBox27.Text);
                int x = 0;

                x = verify_error(text_name_fat, textBox26, textBox27, label69, label70, label71, label72);
                if (x == 1) Root.Healthy.Stocks.AddIngredient("matiere_grasse", text_name_fat.Text, quantity, date);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar11.Visible = false;
            if (!(DateTime.TryParse(textBox29.Text, out date)) || !(Int32.TryParse(textBox30.Text, out quantity)))
            {
                label73.Text = "Le format est invalide";

            }
            else
            {
                date = Convert.ToDateTime(textBox29.Text);
                quantity = Int32.Parse(textBox30.Text);
                int x = 0;

                x = verify_error(text_name_starchy, textBox29, textBox30, label73, label74, label75, label76);
                if (x == 1) Root.Healthy.Stocks.AddIngredient("feculent", text_name_starchy.Text, quantity, date);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar12.Visible = false;
            if (!(DateTime.TryParse(textBox32.Text, out date)) || !(Int32.TryParse(textBox33.Text, out quantity)))
            {
                label77.Text = "Le format est invalide";

            }
            else
            {
                date = Convert.ToDateTime(textBox32.Text);
                quantity = Int32.Parse(textBox33.Text);
                int x = 0;

                x = verify_error(text_name_plant, textBox32, textBox33, label77, label78, label79, label80);
                if (x == 1) Root.Healthy.Stocks.AddIngredient("herbe_plante", text_name_plant.Text, quantity, date);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DateTime date;
            int quantity;
            monthCalendar13.Visible = false;
            if (!(DateTime.TryParse(textBox37.Text, out date)) || !(Int32.TryParse(textBox36.Text, out quantity)))
            {
                label81.Text = "Le format est invalide";

            }
            else
            {
            date = Convert.ToDateTime(textBox37.Text);
            quantity = Int32.Parse(textBox36.Text);
            int x = 0;

                x = verify_error(text_name_bakery, textBox37, textBox36, label81, label82, label83, label84);
            if (x == 1) Root.Healthy.Stocks.AddIngredient("boulangerie", text_name_bakery.Text, quantity, date);
            }
        }
        #endregion
        #region BtnAdd
                private void button_ajouter_viande_Click(object sender, EventArgs e)
                {
                    panel2.Visible = true;
                }

                private void button_ajouter_boisson_Click(object sender, EventArgs e)
                {
                    panel1.Visible = true;
                }

                private void button_ajouter_dessert_Click(object sender, EventArgs e)
                {
                    panel3.Visible = true;
                }

                private void button_ajouter_crustacé_Click(object sender, EventArgs e)
                {
                    panel4.Visible = true;
                }

                private void button_ajouter_poisson_Click(object sender, EventArgs e)
                {
                    panel5.Visible = true;
                }

                private void button_ajouter_volailles_Click(object sender, EventArgs e)
                {
                    panel6.Visible = true;
                }

                private void button_ajouter_legumes_Click(object sender, EventArgs e)
                {
                    panel7.Visible = true;
                }

                private void button_ajouter_fruit_Click(object sender, EventArgs e)
                {
                    panel8.Visible = true;
                }

                private void button_ajouter_produit_laitier_Click(object sender, EventArgs e)
                {
                    panel9.Visible = true;
                }

                private void button_ajouter_matiére_grasse_Click(object sender, EventArgs e)
                {
                    panel10.Visible = true;
                }

                private void button_ajouter_feculent_Click(object sender, EventArgs e)
                {
                    panel11.Visible = true;
                }

                private void button_ajout_boulangerie_Click(object sender, EventArgs e)
                {
                    panel13.Visible = true;
                }

                private void button_ajouter_herbe_Click(object sender, EventArgs e)
                {
                    panel12.Visible = true;
                }
        #endregion
        #region BtnOk
        private void button1_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._boisson.Contains(textBox1.Text))
            {
                textBox1.BackColor = Color.Red;
                label88.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView2.Items)
                {
                    if (item.Text == textBox1.Text)
                    {
                        listView2.Items[i].Selected = true;
                        listView2.Select();

                    }

                    i++;
                }
            }
            else
            {
                Root.Healthy.CreateIngredient("boisson", textBox1.Text);
                panel1.Visible = false;
                UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._viande.Contains(textBox2.Text))
            {
                textBox2.BackColor = Color.Red;
                label87.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text == textBox2.Text)
                    { listView1.Items[i].Selected = true;
                        listView1.Select();

                    }
                    
                    i++;
                }
            }
            else
            {
                label85.Text = null;
                Root.Healthy.CreateIngredient("viande", textBox2.Text);
                panel2.Visible = false;
                UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._dessert_sucrerie.Contains(textBox3.Text))
            {
                textBox3.BackColor = Color.Red;
                label85.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView3.Items)
                {
                    if (item.Text == textBox3.Text)
                    {
                        listView3.Items[i].Selected = true;
                        listView3.Select();

                    }

                    i++;
                }
            }
            else
            {
                Root.Healthy.CreateIngredient("dessert_sucrerie", textBox3.Text);
                panel3.Visible = false;
                UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._crustace.Contains(textBox4.Text))
            {
                textBox4.BackColor = Color.Red;
                label86.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView4.Items)
                {
                    if (item.Text == textBox4.Text)
                    {
                        listView4.Items[i].Selected = true;
                        listView4.Select();

                    }

                    i++;
                }
            }
            else
            {
                Root.Healthy.CreateIngredient("crustace", textBox4.Text);
                panel4.Visible = false;
                UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._poisson.Contains(textBox5.Text))
            {
                textBox5.BackColor = Color.Red;
                label89.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView5.Items)
                {
                    if (item.Text == textBox5.Text)
                    {
                        listView5.Items[i].Selected = true;
                        listView5.Select();

                    }

                    i++;
                }
            }
            else
            {
                Root.Healthy.CreateIngredient("poisson", textBox5.Text);
            panel5.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }
         }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._volaille.Contains(textBox6.Text))
            {
                textBox6.BackColor = Color.Red;
                label90.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView6.Items)
                {
                    if (item.Text == textBox6.Text)
                    {
                        listView6.Items[i].Selected = true;
                        listView6.Select();

                    }

                    i++;
                }
            }
            else
            {
                Root.Healthy.CreateIngredient("volaille", textBox6.Text);
            panel6.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._legume.Contains(textBox7.Text))
            {
                textBox7.BackColor = Color.Red;
                label91.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView7.Items)
                {
                    if (item.Text == textBox7.Text)
                    {
                        listView7.Items[i].Selected = true;
                        listView7.Select();

                    }

                    i++;
                }
            }
            else
            {
                Root.Healthy.CreateIngredient("legume", textBox7.Text);
            panel7.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._fruit.Contains(textBox8.Text))
            {
                textBox8.BackColor = Color.Red;
                label92.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView8.Items)
                {
                    if (item.Text == textBox8.Text)
                    {
                        listView8.Items[i].Selected = true;
                        listView8.Select();

                    }

                    i++;
                }
            }
            else
            {
                Root.Healthy.CreateIngredient("fruit", textBox8.Text);
            panel8.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._produit_laitier.Contains(textBox9.Text))
            {
                textBox9.BackColor = Color.Red;
                label93.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView9.Items)
                {
                    if (item.Text == textBox9.Text)
                    {
                        listView9.Items[i].Selected = true;
                        listView9.Select();

                    }

                    i++;
                }
            }
            else
            {
                Root.Healthy.CreateIngredient("produit_laitier", textBox9.Text);
            panel9.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._matiere_grasse.Contains(textBox10.Text))
            {
                textBox10.BackColor = Color.Red;
                label94.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView10.Items)
                {
                    if (item.Text == textBox10.Text)
                    {
                        listView10.Items[i].Selected = true;
                        listView10.Select();

                    }

                    i++;
                }
            }
            else
            {
                Root.Healthy.CreateIngredient("matiere_grasse", textBox10.Text);
            panel10.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._feculent.Contains(textBox11.Text))
            {
                textBox11.BackColor = Color.Red;
                label95.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView11.Items)
                {
                    if (item.Text == textBox11.Text)
                    {
                        listView11.Items[i].Selected = true;
                        listView11.Select();

                    }

                    i++;
                }
            }
            else
            {
                Root.Healthy.CreateIngredient("feculent", textBox11.Text);
            panel11.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._herbe_plante.Contains(textBox12.Text))
            {
                textBox12.BackColor = Color.Red;
                label96.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView12.Items)
                {
                    if (item.Text == textBox12.Text)
                    {
                        listView12.Items[i].Selected = true;
                        listView12.Select();

                    }

                    i++;
                }
            }
            else
            {
                Root.Healthy.CreateIngredient("herbe_plante", textBox12.Text);
            panel12.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Root.Healthy._boulangerie.Contains(textBox13.Text))
            {
                textBox13.BackColor = Color.Red;
                label97.Text = "Ingrédient déjà existant";
                int i = 0;
                foreach (ListViewItem item in listView13.Items)
                {
                    if (item.Text == textBox13.Text)
                    {
                        listView13.Items[i].Selected = true;
                        listView13.Select();

                    }

                    i++;
                }
            }
            else
            {
                Root.Healthy.CreateIngredient("boulangerie", textBox13.Text);
            panel13.Visible = false;
            UserControl_Reserve_Add_Remove_Enter(_s, _e);
            }
        }
        #endregion

        #region Calendar
        private void textBox_Date_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox_Date.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void textbox_datePeremption_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textbox_datePeremption.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
        }

        private void txt_dateperemtion_dessert_Click(object sender, EventArgs e)
        {
            monthCalendar3.Visible = true;
        }

        private void monthCalendar3_DateSelected(object sender, DateRangeEventArgs e)
        {
            txt_dateperemtion_dessert.Text = monthCalendar3.SelectionRange.Start.ToShortDateString();
        }

        private void txt_dateperemption_crust_Click(object sender, EventArgs e)
        {
            monthCalendar4.Visible = true;
        }

        private void monthCalendar4_DateSelected(object sender, DateRangeEventArgs e)
        {
            txt_dateperemption_crust.Text = monthCalendar4.SelectionRange.Start.ToShortDateString();
        }

        private void txt_dateperemption_fish_Click(object sender, EventArgs e)
        {
            monthCalendar5.Visible = true;
        }

        private void monthCalendar5_DateSelected(object sender, DateRangeEventArgs e)
        {
            txt_dateperemption_fish.Text = monthCalendar5.SelectionRange.Start.ToShortDateString();
        }

        private void txt_dateperemtion_poultry_Click(object sender, EventArgs e)
        {
            monthCalendar6.Visible = true;
        }

        private void monthCalendar6_DateSelected(object sender, DateRangeEventArgs e)
        {
            txt_dateperemtion_poultry.Text = monthCalendar6.SelectionRange.Start.ToShortDateString();
        }

        private void txt_dateperemtion_vegetable_Click(object sender, EventArgs e)
        {
            monthCalendar7.Visible = true;
        }

        private void monthCalendar7_DateSelected(object sender, DateRangeEventArgs e)
        {
            txt_dateperemtion_vegetable.Text = monthCalendar7.SelectionRange.Start.ToShortDateString();
        }

        private void txt_dateperemtion_fruit_Click(object sender, EventArgs e)
        {
            monthCalendar8.Visible = true;
        }

        private void monthCalendar8_DateSelected(object sender, DateRangeEventArgs e)
        {
            txt_dateperemtion_fruit.Text = monthCalendar8.SelectionRange.Start.ToShortDateString();
        }

        private void textBox23_Click(object sender, EventArgs e)
        {
            monthCalendar14.Visible = true;
        }

        private void monthCalendar9_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox23.Text = monthCalendar14.SelectionRange.Start.ToShortDateString();
        }

        private void textBox26_Click(object sender, EventArgs e)
        {
            monthCalendar15.Visible = true;
        }

        private void monthCalendar10_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox26.Text = monthCalendar15.SelectionRange.Start.ToShortDateString();
        }

        private void textBox29_Click(object sender, EventArgs e)
        {
            monthCalendar11.Visible = true;
        }

        private void monthCalendar11_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox29.Text = monthCalendar11.SelectionRange.Start.ToShortDateString();
        }

        private void textBox32_Click(object sender, EventArgs e)
        {
            monthCalendar12.Visible = true;
        }

        private void monthCalendar12_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox32.Text = monthCalendar12.SelectionRange.Start.ToShortDateString();
        }

        private void textBox37_Click(object sender, EventArgs e)
        {
            monthCalendar13.Visible = true;
        }

        private void monthCalendar13_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox37.Text = monthCalendar13.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar14_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox23.Text = monthCalendar14.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar15_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox26.Text = monthCalendar15.SelectionRange.Start.ToShortDateString();
        }


        #endregion

        private void textBox_Quantity_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Quantity.Text = null;
        }

        private void textbox_quantity_drink_MouseClick(object sender, MouseEventArgs e)
        {
            textbox_quantity_drink.Text = null;
        }

        private void txt_quantity_dessert_MouseClick(object sender, MouseEventArgs e)
        {
            txt_quantity_dessert.Text = null;
        }

        private void txt_quantity_crust_MouseClick(object sender, MouseEventArgs e)
        {
            txt_quantity_crust.Text = null;
        }

        private void txt_quantity_fish_MouseClick(object sender, MouseEventArgs e)
        {
            txt_quantity_fish.Text = null;
        }

        private void txt_quantity_poultry_MouseClick(object sender, MouseEventArgs e)
        {
            txt_quantity_poultry.Text = null;
        }

        private void txt_quantity_vegetable_MouseClick(object sender, MouseEventArgs e)
        {
            txt_quantity_vegetable.Text = null;

        }

        private void txt_quantity_fruit_MouseClick(object sender, MouseEventArgs e)
        {
            txt_quantity_fruit.Text = null;
        }

        private void textBox24_MouseClick(object sender, MouseEventArgs e)
        {
            textBox24.Text = null;
        }

        private void textBox27_MouseClick(object sender, MouseEventArgs e)
        {
            textBox27.Text = null;
        }

        private void textBox30_MouseClick(object sender, MouseEventArgs e)
        {
            textBox30.Text = null;
        }

        private void textBox33_MouseClick(object sender, MouseEventArgs e)
        {
            textBox33.Text = null;
        }

        private void textBox36_MouseClick(object sender, MouseEventArgs e)
        {
            textBox36.Text = null;
        }
    }
}

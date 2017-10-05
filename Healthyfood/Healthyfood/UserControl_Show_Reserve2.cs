using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Healthyfood
{
    public partial class UserControl_Show_Reserve2 : UserControl
    {
        int repeat = 0;
        public UserControl_Show_Reserve2()
        {
            InitializeComponent();
            columnHeader1.ImageIndex =2 ;
            columnHeader2.ImageIndex = 1;
            columnHeader3.ImageIndex = 0;

        }
        public Menu Root
        {
            get { return (Menu)FindForm(); }
        }

      

        private void UserControl_Show_Reserve2_Enter(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            int i = 0;
            foreach (var p in Root.Healthy.Stocks.IStock)
            {
                string date = Convert.ToString(p.Expiration_Date);
                string[] row = { p.Name, p.Balance.ToString()+ Unite(p), date };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
                listView1.Items[i].ImageIndex = categoryImage(p.Category1);
                if ((i % 2) == 0) listView1.Items[i].BackColor = Color.WhiteSmoke;
                else listView1.Items[i].BackColor = Color.White;
                listView2.Items.Add(" ");
                listView2.Items[i].ImageIndex = DateImage(p.Expiration_Date);
                i++;

            }
            if (repeat == 0)
            {
                Root.Healthy.Stocks.DateIng();
                repeat++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = listView1.SelectedItems[0].SubItems[0].Text;
            string expiration_date = listView1.SelectedItems[0].SubItems[2].Text;
            DateTime expiration = Convert.ToDateTime(expiration_date);
            Root.Healthy.Stocks.RemoveIngredient(name, expiration);
            UserControl_Show_Reserve2_Enter(sender, e);
        }

        private int categoryImage (string category)
        {
            if (category == "viande") return 3;//
            else if (category == "poisson") return 4;//
            else if (category == "crustace") return 15;//
            else if (category == "dessert_sucrerie") return 8;//
            else if (category == "boisson") return 5;//
            else if (category == "volaille") return 6;
            else if (category == "legume") return 10;//
            else if (category == "fruit") return 14;//
            else if (category == "produit_laitier") return 9;//

            else if (category == "matiere_grasse") return 13;

            else if (category == "feculent") return 11;//

            else if (category == "boulangerie") return 12;//

            else return 7;
        }

        private int DateImage (DateTime date)
        {
            if (date < DateTime.Today) return 17;
            else if (date >= DateTime.Today && date <= DateTime.Today.AddDays(2)) return 18;
            else return 16;
        }

        public string Unite (StockFood.Ingredient ingred)
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

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            //foreach (var ingred in Root.Healthy.Stocks.IStock)
            //{
            //    if (ingred.Expiration_Date < DateTime.Today) Root.Healthy.Stocks.RemoveIngredient(ingred.Name, ingred.Expiration_Date);
            //}
            //UserControl_Show_Reserve2_Enter(sender, e);
        }
    }
}




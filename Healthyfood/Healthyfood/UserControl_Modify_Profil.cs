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
using System.Text.RegularExpressions;

namespace Healthyfood
{
    public partial class UserControl_Modify_Profil : UserControl
    {
        public UserControl_Modify_Profil()
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

        private void button_Save_Click(object sender, EventArgs e)
        {
            int age1;
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
            label7.Text = null;
            bool validn = Regex.IsMatch(textBox_Name.Text, "[a - zA - Z]");
            bool validf = Regex.IsMatch(textBox_Fisrtname.Text, "[a - zA - Z]");
            bool check = false;

            if (!validn||textBox_Name.Text == null || textBox_Name.Text == string.Empty || string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                label1.Text = "Le texte est invalide";
            }

            if (!validf || textBox_Fisrtname.Text == null || textBox_Fisrtname.Text == string.Empty || string.IsNullOrWhiteSpace(textBox_Fisrtname.Text))
            {
                label2.Text = "Le texte est invalide";
            }
            if (!(Int32.TryParse(textBox_Age.Text, out age1)))
            {
                label3.Text = "Le format n'est pas valide";
            }
            else
            {
                age1 = Int32.Parse(textBox_Age.Text);
                if (age1 < 0 || age1 > 130) label3.Text = "L'age n'est pas valide";
            }
            if (!(Int32.TryParse(textBox_Height.Text, out age1)))
            {
                label5.Text = "Le format n'est pas valide";
            }
            else
            {
                age1 = Int32.Parse(textBox_Height.Text);
                if (age1 < 30 || age1 > 230) label5.Text = "La taille n'est pas valide";
            }

            if (!(Int32.TryParse(textBox_Weight.Text, out age1)))
            {
                label6.Text = "Le format n'est pas valide";
            }
            else
            {
                age1 = Int32.Parse(textBox_Weight.Text);
                if (age1 < 0 || age1 > 250) label6.Text = "Le poids n'est pas valide";
            }

            if (checkBox1.Checked == false && checkBox2.Checked == false|| checkBox1.Checked == true && checkBox2.Checked == true)
            {
                label4.Text = "Aucun sexe sélectionné";

            }
            if (!checkBox2.Checked)
            {
                check = true;
            }
            if (!(!validn||textBox_Name.Text == null || textBox_Name.Text == string.Empty || string.IsNullOrWhiteSpace(textBox_Name.Text))
                && !(!validf || textBox_Fisrtname.Text == null || textBox_Fisrtname.Text == string.Empty || string.IsNullOrWhiteSpace(textBox_Fisrtname.Text))
                && (Int32.TryParse(textBox_Age.Text, out age1))
                && (Int32.TryParse(textBox_Height.Text, out age1))
                && (Int32.TryParse(textBox_Weight.Text, out age1))
                && !(checkBox1.Checked == false && checkBox2.Checked == false || checkBox1.Checked == true && checkBox2.Checked == true))
            {
                label7.Text = "Utilisateur Modifié";
                int Age = Int32.Parse(textBox_Age.Text);
                int Weight = Int32.Parse(textBox_Weight.Text);
                int Height = Int32.Parse(textBox_Height.Text);

                Root.Healthy.Utilisateur.modify_firstname(Root.Healthy.Profil, textBox_Fisrtname.Text);
                Root.Healthy.Utilisateur.modify_lastname(Root.Healthy.Profil, textBox_Name.Text);
                Root.Healthy.Utilisateur.modify_age(Root.Healthy.Profil, Age);
                Root.Healthy.Utilisateur.modify_isfemale(Root.Healthy.Profil, check);
                Root.Healthy.Utilisateur.modify_weigth(Root.Healthy.Profil, Weight);
                Root.Healthy.Utilisateur.modify_heigth(Root.Healthy.Profil, Height);
            }
        }

        private void UserControl_Modify_Profil_Load(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_Fisrtname.Clear();
            textBox_Age.Clear();
            textBox_Weight.Clear();
            textBox_Height.Clear();

            if (DesignMode) { }
            else { }
            if (Root == null || Root.Healthy == null || Root.Healthy.Profil == null
                || Root.Healthy.Profil.LastName == null || Root.Healthy.Profil.FirstName == null || Root.Healthy.Profil.Age == 0 || Root.Healthy.Profil.Weight == 0 || Root.Healthy.Profil.Height == 0)
            {
                textBox_Name.Text = "";
                textBox_Fisrtname.Text = "";
                textBox_Age.Text = "";
                textBox_Weight.Text = "";
                textBox_Height.Text = "";
            }
            else
            {
                textBox_Name.Text = Root.Healthy.Profil.LastName;
                textBox_Fisrtname.Text = Root.Healthy.Profil.FirstName;
                textBox_Age.Text = Root.Healthy.Profil.Age.ToString();
                textBox_Weight.Text = Root.Healthy.Profil.Weight.ToString();
                textBox_Height.Text = Root.Healthy.Profil.Height.ToString();
            }
        }

        private void UserControl_Modify_Profil_Enter(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_Fisrtname.Clear();
            textBox_Age.Clear();
            textBox_Weight.Clear();
            textBox_Height.Clear();

            textBox_Name.Text = Root.Healthy.Profil.LastName;
            textBox_Fisrtname.Text = Root.Healthy.Profil.FirstName;
            textBox_Age.Text = Root.Healthy.Profil.Age.ToString();
            textBox_Weight.Text = Root.Healthy.Profil.Weight.ToString();
            textBox_Height.Text = Root.Healthy.Profil.Height.ToString();
            if (Root.Healthy.Profil.IsFemale == true)
            { checkBox2.Checked = true;
                checkBox1.Checked = false; }

            else {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
            }
        }
    }
}

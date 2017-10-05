using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healthyfood;
using System.Text.RegularExpressions;

namespace Healthyfood
{
    public partial class UserControl_Show_Profil : UserControl
    {

        public UserControl_Show_Profil()
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
            bool validn = Regex.IsMatch(textBox_Name.Text, "[a-zA-Z]");
            bool validf = Regex.IsMatch(textBox_Fisrtname.Text, "[a-zA-Z]");
            bool check = false;

            if (!validn ||textBox_Name.Text == null || textBox_Name.Text == string.Empty || string.IsNullOrWhiteSpace(textBox_Name.Text))
            { label1.Text = "Le texte est invalide";
            }
           
            if (!validf||textBox_Fisrtname.Text == null || textBox_Fisrtname.Text == string.Empty || string.IsNullOrWhiteSpace(textBox_Fisrtname.Text))
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

            if (checkBoxM.Checked == false && checkBox2.Checked == false|| checkBoxM.Checked == true && checkBox2.Checked == true)
            {
                label4.Text = "Aucun sexe sélectionné";

            }
            if (!checkBox2.Checked)
            {
                check = true;
            }

            if (!(!validn||textBox_Name.Text == null || textBox_Name.Text == string.Empty || string.IsNullOrWhiteSpace(textBox_Name.Text)) 
                && !(!validf||textBox_Fisrtname.Text == null || textBox_Fisrtname.Text == string.Empty || string.IsNullOrWhiteSpace(textBox_Fisrtname.Text))
                && (Int32.TryParse(textBox_Age.Text, out age1))
                && (Int32.TryParse(textBox_Height.Text, out age1))
                && (Int32.TryParse(textBox_Weight.Text, out age1))
                && !(checkBoxM.Checked == false && checkBox2.Checked == false || checkBoxM.Checked == true && checkBox2.Checked == true))
            {

                label7.Text = "Utilisateur enregistré";
                int Age = Int32.Parse(textBox_Age.Text);
                int Weight = Int32.Parse(textBox_Weight.Text);
                int Height = Int32.Parse(textBox_Height.Text);
                if (checkBox2.Checked) check = true;
                else check = false;

                Root.Healthy.Utilisateur.CreateUser(textBox_Name.Text, textBox_Fisrtname.Text, Age, Weight, Height, check, false);

                textBox_Name.Clear();
                textBox_Fisrtname.Clear();
                textBox_Age.Clear();
                textBox_Weight.Clear();
                textBox_Height.Clear();
                
            }
            

        }


    }
}

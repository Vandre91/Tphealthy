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
    public partial class UserControl_Reserve : UserControl
    {
        public UserControl_Reserve()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            userControl_Show_Reserve21.Visible = true;
            userControl_Show_Reserve21.Focus();
            //userControl_Show1.Visible = true;
            //userControl_Show1.Focus();
        }

        private void button_Add_Remove_Click(object sender, EventArgs e)
        {
            userControl_Reserve_Add_Remove1.Visible = true;
            userControl_Reserve_Add_Remove1.Focus();
        }
    }
}

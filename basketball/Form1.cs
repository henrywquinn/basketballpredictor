using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basketball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblvaluewest.Text = westselect.Text;
        
            lblvalueeast.Text = eastselect.Text;

            scorewest.Text = westselect.Text;
           
            scoreeast.Text = eastselect.Text;

        }

      
    }
}

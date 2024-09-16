using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowWeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowWeight_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"وزن شما {txtWeight.Text} کیلو گرم است");
        }
        

        private void btnChangeBGColor_Click(object sender, EventArgs e)
        {
          this.BackColor = Color.FromName(txtChangeColor.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPage
{
    public partial class ViewButton : Form
    {
        public ViewButton()
        {
            InitializeComponent();
        }

        private void btnViewInven_Click(object sender, EventArgs e)
        {
            ViewCart ViewCart = new ViewCart();
            ViewCart.ShowDialog();
            this.Show();
        }
    }
}

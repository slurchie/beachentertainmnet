using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beachentertainmnet
{
    public partial class disсlaimer : Form
    {
        public disсlaimer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainform frm = new mainform();
            frm.Show();
            this.Hide();
            frm.formochka = this;
        }
    }
}

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
    public partial class mainform : Form
    {
        List <pictures>pics=new List<pictures>(4);
        DateTime selecttime;

        public mainform()
        {
            InitializeComponent();
        }


        private void mainform_Load(object sender, EventArgs e)
        {
            pictures1.setInfo("банан", "Свободен", Properties.Resources.банан);
            pictures2.setInfo("катамаран", "Свободен", Properties.Resources.банан);
            foreach (var i in tableLayoutPanel2.Controls)
            {
                pics.Add((pictures)i);
            }
            selecttime = DateTime.Today;
            richTextBox1.Text = selecttime.ToLongDateString();
        }

 
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                foreach(pictures i in pics)
                i.lighten(listBox3.Items[listBox3.SelectedIndex].ToString(), listBox4.Items[listBox4.SelectedIndex].ToString());
            }
            catch
            {
                foreach (pictures i in pics)
                    i.lighten(listBox3.Items[listBox3.SelectedIndex].ToString(), "Все");
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (pictures i in pics)
                    i.lighten(listBox3.Items[listBox3.SelectedIndex].ToString(), listBox4.Items[listBox4.SelectedIndex].ToString());
            }
            catch
            {
                foreach (pictures i in pics)
                    i.lighten("Все", listBox4.Items[listBox4.SelectedIndex].ToString());
            }
          
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            selecttime= selecttime.AddDays(-1);
            richTextBox1.Text = selecttime.ToLongDateString();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            selecttime = selecttime.AddDays(1);
            richTextBox1.Text = selecttime.ToLongDateString();
        }
    }
    }


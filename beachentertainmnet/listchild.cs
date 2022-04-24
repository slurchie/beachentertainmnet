using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beachentertainmnet
{
    class listchild : ListBox
    {
        displayinfo dispinfo;
        List<IShowInfo> show = new List<IShowInfo>();
        DateTime selectDate=DateTime.Now;
        public displayinfo Displayinfo
        {
            set
            {
                dispinfo = value;
            }
        }
        
        public void addToList(IShowInfo info)
        {
            Items.Add(info.getName());
            show.Add(info);
        }
        public listchild():base()
            {
            Dock = DockStyle.Fill;
            SelectedIndexChanged += new System.EventHandler(changedchoice);



            }
        public void  changedchoice(object sender, EventArgs e)
        {
            dispinfo.showInfo(show[SelectedIndex],selectDate);
            //this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
        }
    }
}

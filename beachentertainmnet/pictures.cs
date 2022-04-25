using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace beachentertainmnet
{
    class pictures:PictureBox
    {
        string name;
        string status;
        public pictures():base() 
        {
            Dock = DockStyle.Fill;
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void lighten(string Name, string Status)
        {
            if((Status==status&&Name==name)||(Status=="Все"&&Name=="Все")||(Status=="Все"&&Name==name)||(Status==status&&Name=="Все"))
            {
                BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                BorderStyle = BorderStyle.None;
            }           
        }
        public string Status
        {
            set
            {
                status = value;
            }
        }
        public void setInfo(string nameofattr,Image attrimage)
        {
            name = nameofattr;
            Image = attrimage;
            

        }
        public void lighten(string [] names, string [] Status)
        {
            bool flagnames = false;
            bool flagstatus = false;
            foreach(string i in names )
            {
                if(i==name)
                {
                    flagnames = true;
                }

            }
            foreach (string j in Status)
            {
                if (j == status)
                {
                    flagstatus = true;
                }
                
            }
            if(flagnames&&flagstatus==true)
            {
                BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                BorderStyle = BorderStyle.None;
            }
            
        }
            
    }
}

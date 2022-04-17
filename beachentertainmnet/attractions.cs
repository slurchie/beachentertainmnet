using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace beachentertainmnet
{
    public class attractions : IShowInfo
    {
        string nameofattraction;
        int priceodarenda;
        Image pic;
        public override string ToString()
        {
            return nameofattraction;
        }
        public Image showimage()
        {
            return pic;
        }
        public string showText(DateTime date)
        {
            string showattrinfo = nameofattraction + "\n";
            showattrinfo += priceodarenda;
            return showattrinfo;
        }
            




    }
}

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
        decimal priceodarenda;
        Image pic;
        public attractions(string NameOfAttraction,decimal PriceOfArenda, Image picattr)
        {
            nameofattraction = NameOfAttraction;
            priceodarenda = PriceOfArenda;
            pic = picattr;

        }
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
        public string getName()
        {
            return nameofattraction;
        }
            




    }
}

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
        public Dictionary<DateTime, status> conditions = new Dictionary<DateTime, status>();
        public attractions(string NameOfAttraction,decimal PriceOfArenda, Image picattr)
        {
            nameofattraction = NameOfAttraction;
            priceodarenda = PriceOfArenda;
            pic = picattr;

        }
        public decimal Price
        {
            get
            {
                return priceodarenda;
            }
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
            showattrinfo += priceodarenda+"\n";
            try
            {
                showattrinfo += conditions[date.Date].GetFullSt;
            }
            catch
            {
                showattrinfo += "нет информации";
            }
          
            return showattrinfo;
        }
        public string getName()
        {
            return nameofattraction;
        }
        public void addToDictionary(status newStatus)
        {
            conditions.Add(newStatus.time, newStatus);
        }
        public string getstatus(DateTime date)
        {
            try
            {
                return conditions[date].status_attractions;
            }
            catch
            {
                return "Неизвестно";
            }
        }
        
            




    }
}

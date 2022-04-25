using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beachentertainmnet
{
    public class status
    {
        public int id_status;
        DateTime current_Time;
        string status_attr;
        public bool profit;
        public status(int id,DateTime curDate,string status_Attr, bool Profit)
        {
            id_status = id;
           current_Time=curDate.Date;
            status_attr = status_Attr;
            profit = Profit;
        }
        public string status_attractions
        {
           get
            {
                return status_attr;
            }
            
        }
        public DateTime time
        {
            get
            {
                return current_Time;
            }
        }
        //public static string textStatus()
        //{
        //    return $"Арендатор:{NameOfArendator}\n Начало аренды:{starrttime}\n Конец аренды:{endtime}\n Сотрудник:{serving}";
        //}
    }
}

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
        string full_status;
        public status(int id,DateTime curDate,string status_Attr, bool Profit,string fullSt)
        {
            id_status = id;
           current_Time=curDate.Date;
            status_attr = status_Attr;
            profit = Profit;
            full_status = fullSt;
        }
        public string GetFullSt
        {
            get
            {
                return status_attr + "\n" + full_status;
            }
        }
        public string FullStatus
        {
            get
            {
                return full_status;
            }
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
       
    }
}

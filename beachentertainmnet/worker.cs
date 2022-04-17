using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace beachentertainmnet
{
   public  class worker: IShowInfo
    {
        string nameofworker;
        string post;
        Image workerpic;
        DateTime startofworkingday;
        DateTime endofworkingday;
        attractions ownattraction;
        worker smenshik;
        public Image showimage()
        {
            return workerpic;
        }
        public override string ToString()
        {
            return nameofworker;
        }
        public string showText(DateTime time)
        {
            string showString = nameofworker+"\n";
            showString += "Должность сотрудника " + post + "\n";
            showString += "На работе:" + startofworkingday.Hour+":"+startofworkingday.Minute+ "-";
            showString += endofworkingday.Hour+":"+endofworkingday.Minute + "\n";
            showString += "Ответсвенен за аттракцион " + ownattraction + "\n";
            showString += "Сменщик:" + smenshik;
            return showString;

        }
    }
}

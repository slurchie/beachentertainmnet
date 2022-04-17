using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace beachentertainmnet
{
    interface IShowInfo
    {
       Image showimage();
       string showText(DateTime date); 

      
    }
}

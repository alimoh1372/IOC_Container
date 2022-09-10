using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_Container
{
    public class MasterCard : ICreditCard
    {
        
        public string Charge()
        {
            return "Swiping with The MasterCard!";
        }
    }
}

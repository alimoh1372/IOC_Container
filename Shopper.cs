using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_Container
{
  public  class Shopper
    {
        private readonly ICreditCard creditCard;
        
        public Shopper(ICreditCard creditCard)
        {
            this.creditCard = creditCard;
        }
        public void charge()
        {
            var chargeMessage = creditCard.Charge();
            Console.WriteLine(chargeMessage);
        }
    }
}

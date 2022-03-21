using System;
using System.Collections.Generic;

namespace StudentProject.BL
{
    public class Shop : Office
    {
        public Shop(string name, Address address, List<OrderItem> stockList) 
        {

        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }
    }
}

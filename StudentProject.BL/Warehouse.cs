using System;
using System.Collections.Generic;

namespace StudentProject.BL
{
    public class Warehouse : Office
    {
        public Warehouse(string name, Address address, List<OrderItem> stockList)
        {

        }
        

        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public void Udelej()
        {
            
        }
    }
}

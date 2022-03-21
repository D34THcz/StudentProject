using System.Collections.Generic;

namespace StudentProject.BL
{
    public abstract class Office : IRepositoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<OrderItem> StockList { get; set; }

        public abstract object Clone();

        public List<OrderItem> GetStockStatusList()  // dopsat
        {
            var stockStatus = StockList;
            return stockStatus;
        }

        public override string ToString()
        {
            return $"{Name}, {Address}";
        }
    }
}

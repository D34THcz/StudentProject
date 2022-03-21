namespace StudentProject.BL
{
    public class Product : IRepositoryModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDetail { get; set; }
        public decimal? ProductPrice { get; set; }
        private static int productId = 0;

        public override string ToString()
        {
            return $"{ProductName} - {ProductDetail}, Price: {ProductPrice}EUR";
        }

               
        public Product()
        {
            productId += 1;
            Id = productId;
        }

        public object Clone()
        {
            return new Product()
            {
                Id = Id,
                ProductName = ProductName,
                ProductDetail = ProductDetail,
                ProductPrice = ProductPrice
            };
        }
    }
}

namespace StudentProject.BL
{
    public class OrderItem 
    {
        public Product Product { get; set; }
        
        public int NeedAmount { get; set; }
        public int ActualAmount { get; set; }
        public decimal PricePerItem { get; set; }
        public int TotalPrice { get { return (int)Product.ProductPrice * NeedAmount; } }
        private int totalPrice { get { return (int)Product.ProductPrice * NeedAmount; } set { } }
        

        public OrderItem(Product product, int needAmount, int actualAmount = 0)
        {
            
            Product = product;
            NeedAmount = needAmount;
            ActualAmount = actualAmount;
            totalPrice = (int)Product.ProductPrice * NeedAmount;
            PricePerItem = (int)(Product.ProductPrice);
        }

        public override string ToString()
        {
            return $"{Product.ProductName} ({Product.ProductPrice}EUR) - {NeedAmount}x";
        }

       
    }
}

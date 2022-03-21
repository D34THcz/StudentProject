namespace StudentProject.BL
{
    public class Address 
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Postcode { get; set; }
        public string Country { get; set; }
        private static int addressId;

        public Address(string street, string city, int postcode, string country)
        {
            Street = street;
            City = city;
            Postcode = postcode;
            Country = country;
            addressId += 1;
            Id = addressId;
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {Postcode}, {Country}";
        }

    }
}

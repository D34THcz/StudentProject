using System.Collections.Generic;

namespace StudentProject.BL
{
    public class Customer : IRepositoryModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int FavoriteShop { get; set; }
        public List<Address> AddressList { get; set; }
        public List<Order> Orders { get; set; }
        public int PhoneNumber { get; set; }
        private static int customerId;

        public Customer()
        {

        }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            AddressList = new List<Address>();
            Orders = new List<Order>();
            SetFullname();
            customerId += 1;
            Id = customerId;
        }

        public void SetFullname ()
        {
            FullName = $"{FirstName} {LastName}";
        }

        public override string ToString()
        {
            if(AddressList != null)
            {
                return $"{FullName}, {AddressList[0]}";
            }
            else
            {
                return FullName;
            }
            
        }

        public object Clone()
        {
            return new Customer()
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                FullName = FullName,
                FavoriteShop = FavoriteShop,
                AddressList = new List<Address>(AddressList),
                Orders = new List<Order>(Orders)
            };
        }
    }
}

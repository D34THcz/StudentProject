using EasyConsole;
using StudentProject.BL;
using StudentProject.ConsoleApp.Pages;

namespace StudentProject.ConsoleApp
{
    public class MenuProgram : Program
    {
        private GenericRepository<Product> _productRepository = new GenericRepository<Product>();

        public GenericRepository<Product> ProductRepository
        {
            get => _productRepository;
            set
            {
                if (_productRepository == null)
                    _productRepository = value;
            }
        }
        
        private GenericRepository<Customer> _customerRepository = new GenericRepository<Customer>();

        public GenericRepository<Customer> CustomerRepository
        {
            get => _customerRepository;
            set
            {
                if (_customerRepository == null)
                    _customerRepository = value;
            }
        }

        private GenericRepository<Shop> _shopRepository = new GenericRepository<Shop>();

        public GenericRepository<Shop> ShopRepository
        {
            get => _shopRepository;
            set
            {
                if (_shopRepository == null)
                    _shopRepository = value;
            }
        }

        private GenericRepository<Warehouse> _warehouseRepository = new GenericRepository<Warehouse>();

        public GenericRepository<Warehouse> WarehouseRepository
        {
            get => _warehouseRepository;
            set
            {
                if (_warehouseRepository == null)
                    _warehouseRepository = value;
            }
        }


        private GenericRepository<Order> _orderRepository = new GenericRepository<Order>();

        public GenericRepository<Order> OrderRepository
        {
            get => _orderRepository;
            set
            {
                if (_orderRepository == null)
                    _orderRepository = value;
            }
        }
        public MenuProgram() : base("Menu", breadcrumbHeader: true)
        {

            AddPage(new MainPage(this));
            AddPage(new ProductAddPage(this));
            AddPage(new ProductListPage(this));
            AddPage(new ProductMenuPage(this));
            AddPage(new ProductUpdatePage(this));
            AddPage(new ProductRemovePage(this));
            AddPage(new CustomerMenuPage(this));
            AddPage(new CustomerListPage(this));
            AddPage(new CustomerAddPage(this));
            AddPage(new CustomerRemovePage(this));
            AddPage(new CustomerUpdatePage(this));
            AddPage(new OfficesMenuPage(this));
            AddPage(new OfficesListPage(this));
            AddPage(new OrderMenuPage(this));
            AddPage(new OrderListPage(this));
            AddPage(new OrderAddPage(this));
            AddPage(new OrderRemovePage(this));
            AddPage(new OrderUpdatePage(this));
            AddPage(new RepositoriesMenuPage(this));
            AddPage(new OrderProcessMenuPage(this));
            AddPage(new OrderProcessPage(this));

            SetPage<MainPage>();
            
        }
    }
}

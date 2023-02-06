using ShopLibrary;

namespace FirstcSharpApp
{
    public partial class Shop : Form
    {

        private Store store=new Store();
        public Shop()
        {
            InitializeComponent();
            SetupData();
        }

        private void SetupData()
        {
            store.vendors=new List<Vendor>();
            store.vendors.Add(new Vendor { vendorID = 001, firstName = "bill", lastName = "smith" });
            store.vendors.Add(new Vendor { vendorID = 002, firstName = "jim", lastName = "panick" });
            store.items.Add(new Item { title="frozen", description="It's chilly", owner = store.vendors[0] });


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
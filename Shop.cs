using ShopLibrary;

namespace FirstcSharpApp
{
    public partial class Shop : Form
    {

        private Store store=new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemBinding=new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();

        public Shop()
        {
            InitializeComponent();
            SetupData();

            itemBinding.DataSource= store.items.Where(x=>x.sold==false).ToList();
            listBox1.DataSource= itemBinding;

            listBox1.DisplayMember= "DisplayItm";
            listBox1.ValueMember= "DisplayItm";

            cartBinding.DataSource = shoppingCartData;
            listBox2.DataSource = cartBinding;

            listBox2.DisplayMember = "DisplayItm";
            listBox2.ValueMember = "DisplayItm";

            vendorBinding.DataSource = store.vendors;
            listBox3.DataSource = vendorBinding;

            listBox3.DisplayMember = "DisplayVendor";
            listBox3.ValueMember = "DisplayVendor";


        }

        private void SetupData()
        {
            store.vendors=new List<Vendor>();
            store.vendors.Add(new Vendor { vendorID = 001, firstName = "bill", lastName = "smith" });
            store.vendors.Add(new Vendor { vendorID = 002, firstName = "jim", lastName = "panick" });
            store.vendors.Add(new Vendor { vendorID = 003, firstName = "micheal", lastName = "cedrick" });

            store.items.Add(new Item { title="mango", 
                                        description="fruit",
                                        price=4.5, 
                                        owner = store.vendors[0] });

            store.items.Add(new Item
            {
                title = "tomato",
                description = "vegetable",
                price = 14.5,
                owner = store.vendors[1]
            });

            store.items.Add(new Item
            {
                title = "kellogs",
                description = "cereal",
                price = 14.5,
                owner = store.vendors[1]
            });

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void addToCart_Button(object sender, EventArgs e)
        {

            Item selectedItem = (Item)listBox1.SelectedItem;
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);

            MessageBox.Show("New item added to Cart !!!");

        }

        private void PurchaseBtn(object sender, EventArgs e)
        {
            foreach(Item item in shoppingCartData)
            {
                item.sold = true;
                item.owner.payment += item.owner.comission * item.price;

            }
            shoppingCartData.Clear();
            itemBinding.DataSource = store.items.Where(x => x.sold == false).ToList();
            cartBinding.ResetBindings(false);
            itemBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
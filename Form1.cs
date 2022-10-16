using System;
using System.Windows.Forms;
using EntityFMysql.context;

namespace EntityFMysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            using (var northwindContext = new NorthwindContext())
            {
                var c = new Customer
                {
                    City = "Antep",
                    CompanyName = "company",
                    Country = "Tr",
                    ContactName = "Contact",
                    CustomerID = "11"
                };
                northwindContext.Customers.Add(c);
                northwindContext.SaveChanges();
                foreach (var northwindContextCustomer in northwindContext.Customers)
                {
                    MessageBox.Show(northwindContextCustomer.CompanyName);
                }
            }

            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data;
using System.Linq;


namespace LINQsql_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(@"Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");

            var custQuery = from cust in db.GetTable<Customer>()
                            where cust.Orders.Any()
                            select cust;

            foreach (var custObj in custQuery)
            {
                ListViewItem item = listView1.Items.Add(custObj.CustomerID.ToString());
                item.SubItems.Add(custObj.City.ToString());
                item.SubItems.Add(custObj.Orders.Count.ToString());
            }
        }
    }
}

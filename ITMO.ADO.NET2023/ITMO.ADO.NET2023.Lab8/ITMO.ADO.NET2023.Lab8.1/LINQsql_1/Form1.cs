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

            var results = from c in db.GetTable<Customer>()
                          where c.City == "London"
                          select c;
            foreach (var c in results)
                listBox1.Items.Add(c.ToString());
        }
    }
}

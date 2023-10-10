using System;
using System.Windows.Forms;

namespace LINQsql_m
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new DataClassesProcDataContext();
            foreach (var r in db.Ten_Most_Expensive_Products())
            {
                ListViewItem item =
                listView1.Items.Add(r.TenMostExpensiveProducts.ToString());
                item.SubItems.Add(r.UnitPrice.ToString());
            }
        }
    }
}

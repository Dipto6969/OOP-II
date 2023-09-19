using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form1 : Form
    {
        List<Shop1>shops = new List<Shop1>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddShopButton_Click(object sender, EventArgs e)
        {
            Shop1 temp = new Shop1(Convert.ToInt32(IdTextbox.Text),NameTextbox.Text,AddressTextbox.Text);
            shops.Add(temp);
            ShopIdTextbox.Clear();
            ShopIdTextbox.Focus();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            product1 temp = new product1(Name,PriceLabel,QuantityLabel,ProductIdLabel,ProductNameLabel,ShopIdLabel);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bills
{
    public partial class Form1 : Form
    {
        private string _ItemName;
        Dictionary<string, float> price = new Dictionary<string, float>();
        private void AddtoData()
        {
            price.Add("ورق A4 80 gm", 1);
            price.Add("ورق مقوى A4 180 gm", 3);
            price.Add("ورق A3 80 gm", 4);
            price.Add("تغليف سلك", 5);
            price.Add("تغليف شطرطون", 3);
        }
      
        public Form1()
        {
           
            InitializeComponent();
            AddtoData();
        }

        private float GetPriceItem(string Item)
        {
            if(price.ContainsKey(Item)) return price[Item];
            return 0;
            
        }
        private float GetPriceTotal()
        {
            return Convert.ToSingle(numPriceItem.Value * numQuantity.Value);
        }
        private float GetTaxrate()
        {
            return  Convert.ToSingle (GetPriceTotal() * 0.15);
        }
        private float GetPriceTotalwithTaxrate()
        {
            return GetPriceTotal() + GetTaxrate();
        }

        private void Price()
        {
            lblTotal.Text=GetPriceTotal().ToString();
            lblTaxrate.Text=GetPriceTotalwithTaxrate().ToString();
            
        }
  

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
             _ItemName= cbItems.SelectedItem.ToString();
            Price();
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            Price();
        }

        private void numPriceItem_ValueChanged(object sender, EventArgs e)
        {
           
            Price();
        }
    }
}

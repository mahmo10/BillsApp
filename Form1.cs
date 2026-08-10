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
        private byte _index;
        private float _NewPrice = 0;
        
        class Bill
        {
         
            private string _Name;
            private short _Quantity;
            private float _Price;
            private float _Total;
            

            public void SetName(string name)
            {
                _Name = name;
            }

            public string GetName()
            {
                return _Name;
            }

            

        }
        public Form1()
        {
            InitializeComponent();
        }

       private decimal GetCalculateTotal()
        {
            return numQuantity.Value*numPriceItem.Value;
        }

        private float GetPriceItem()
        {
            if(_NewPrice!=0)
            {
                return _NewPrice;
            }
            switch (_index)
            {
                case 0: return 1;
                case 1: return 3;
                case 2: return 4;
                case 3: return 5;
                case 4: return 3;
                default: return 0;
            }
        }
        private float GetPriceTotal()
        {
            return GetPriceItem() * Convert.ToSingle(numQuantity.Value);
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
            for (byte i = 0; i < cmItems.Items.Count; i++)
            {
                if (cmItems.SelectedIndex==i)
                {
                    _index = i;
                    Price();
                }
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            Price();
        }

        private void numPriceItem_ValueChanged(object sender, EventArgs e)
        {
            _NewPrice= (float) numPriceItem.Value;
            Price();
        }
    }
}

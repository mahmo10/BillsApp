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
            price.Add("ورق A4 80 gm", 0.85f);
            price.Add("ورق مقوى A4 180 gm", 2.70f);
            price.Add("ورق A3 80 gm", 3.48f);
            price.Add("تغليف سلك", 4.35f);
            price.Add("تغليف شطرطون", 2.61f);
        }
      
        public Form1()
        {
          
            InitializeComponent();
            AddtoData();
        }

        private float GetPriceItem()
        {
            if(price.ContainsKey(_ItemName)) return price[_ItemName];
            return 0;
            
        }
        private float GetPriceTotal()
        {
            return Convert.ToSingle(numPriceItem.Value * numQuantity.Value);
        }
        private float GetTaxrate()
        {
            float TaxRate = 0.15f;
            return   TaxRate;
        }
        private float GetPriceTotalwithTaxrate()
        {
            return   GetTaxrate()* GetPriceTotal();
        }

        private void UpdatePrice()
        {
            lblTotal.Text=GetPriceTotal().ToString("F2");
            lblTaxrate.Text=GetPriceTotalwithTaxrate().ToString("F2");
            
        }
  
        private void UpdateTotalBill()
        {
            float TotalBill=0;
            foreach (DataGridViewRow Row in dgvData.Rows)
            {
                TotalBill += Convert.ToSingle(Row.Cells[3].Value);
            }
            lbltotalfinal.Text=TotalBill.ToString();
        }
        private void AddItemToBill()
        {
            string ItemName=_ItemName;
            decimal price = numPriceItem.Value;
            decimal Quantity = numQuantity.Value;
            float Total= (float)Math.Round(GetPriceTotalwithTaxrate(),2);

            dgvData.Rows.Add(ItemName,Quantity, price, Total);

            UpdateTotalBill();
            Reset();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             _ItemName= cbItems.SelectedItem.ToString();
            numPriceItem.Value = (decimal)GetPriceItem();
        }

        private void Reset()
        {
           // cbItems.Items.;
            
        }
        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void numPriceItem_ValueChanged(object sender, EventArgs e)
        {
           
            UpdatePrice();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItemToBill();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

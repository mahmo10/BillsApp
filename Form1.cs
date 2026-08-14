
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bills
{
    public partial class Form1 : Form
    {
        private string _ItemName;
        private float _Quantity;
        private float _Price;
        private float _TaxRate = 0.15f;
        private float _TotalBill;



        Dictionary<string, float> price = new Dictionary<string, float>();
        private void AddtoData()
        {
            price.Add("ورق A4 80 gm", 1f);
            price.Add("ورق مقوى A4 180 gm", 3f);
            price.Add("ورق A3 80 gm", 4f);
            price.Add("تغليف سلك", 5f);
            price.Add("تغليف شطرطون",3f);
        }
      
        public Form1()
        {
          
            InitializeComponent();
            AddtoData();
    

        }

        private void GeneratePDF()
        {
            var doc = new InvoiceDocument
            {
                CustomerName = txtCustomerName.Text,
                TaxNumber = txtTax.Text,
                Data = dgvData,
                Total = _TotalBill,
                TaxRate = _TaxRate
            };

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\فاتورة.pdf";
            doc.GeneratePdf(path);



            System.Diagnostics.Process.Start(path);
        }
        private float GetPriceItem()
        {
            if(price.ContainsKey(_ItemName)) return price[_ItemName];
            return 0;
            
        }
        private float GetTotalPrice()
        {
            return  _Price * _Quantity;
        }
        public float GetTaxrate()
        {
            return   _TaxRate;
        }
        private float Calculatingtaxwithintotal()
        {
            return GetTaxrate()*GetTotalPrice();
        }
        private float GetPriceTotalwithTaxrate()
        {
            return Calculatingtaxwithintotal() + GetTotalPrice();
        }
        private void UpdatePrice()
        {
            
            lblTaxrate.Text= GetTotalPrice().ToString("F2");
            
        }
        private void HandleChangePrice()
        {
            _Price = Convert.ToSingle(numPriceItem.Value);
            UpdatePrice();
        }
        private void HandleChangeQuantity()
        {
            _Quantity = Convert.ToSingle(numQuantity.Value);
            UpdatePrice() ;

        }
        private void Changeproduct()
        {
            if(numPriceItem.Value==(decimal)_Price)
            {
                UpdatePrice();
                return ;
            }
            numQuantity.Value = (decimal)_Quantity;
            numPriceItem.Value = (decimal)_Price;
        }
        private void UpdateTotalBill()
        {
            lbltotalfinal.Text=_TotalBill.ToString();
        }
        private void AddItemToBill()
        {
            if (_Quantity <= 0 || _Price <= 0)
            {
                MessageBox.Show("الكمية أو السعر غير صحيح");
                return;
            }


            if (cbItems.SelectedItem==null)
            {
                MessageBox.Show("يرجي إختيار الصنف", "الصنف",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            float Total= (float)Math.Round(GetTotalPrice(),2);

            dgvData.Rows.Add(_ItemName,_Quantity, _Price, Total);

            _TotalBill += Total;
            UpdateTotalBill();


        }

        public float GetTotalBill()
        {
            return _TotalBill;
        }
        private void Reset()
        {
            cbItems.SelectedItem = null;

            numPriceItem.ValueChanged-=numPriceItem_ValueChanged; 
            numQuantity.ValueChanged-=numQuantity_ValueChanged;

            numPriceItem.Value=1;
            numQuantity.Value = 1;

            numPriceItem.ValueChanged += numPriceItem_ValueChanged;
            numQuantity.ValueChanged += numQuantity_ValueChanged;

           
            lblTaxrate.Text=0.ToString();

           

        }
        private void ResetForm()
        {
            Reset();
            dgvData.Rows.Clear();
            _TotalBill = 0;
            lbltotalfinal.Text = string.Empty;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbItems.SelectedItem == null)
                return;
            _ItemName = cbItems.SelectedItem.ToString();
           _Price=GetPriceItem();
            _Quantity = 1;
            Changeproduct();

        }
        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(numQuantity.Value !=(decimal) _Quantity )
            {
                HandleChangeQuantity();
            }
            else
            UpdatePrice();

        }
        private void numPriceItem_ValueChanged(object sender, EventArgs e)
        {
            if (numPriceItem.Value != (decimal)_Price)
            {
                HandleChangePrice();
            }
            else
            UpdatePrice();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItemToBill();
            Reset();
        }
        private float GetTaxbyTotal(float Total,float Tax)
        {
            return Total * Tax;
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {


         
            if (dgvData.Rows.Count == 1)
            {
                MessageBox.Show("يرجي إختيار الصنف", "الصنف",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GeneratePDF();
    }

        private void MoveNextControl(Control Next,Control Prev, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                Next.Focus();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Up)
            {
               Prev.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void txtTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }

            if (char.IsDigit(e.KeyChar) && txtTax.Text.Length >= 15)
            {
                e.Handled = true;
            }
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            MoveNextControl(txtTax, btnNew, e);
        }

        private void txtTax_KeyDown(object sender, KeyEventArgs e)
        {
            MoveNextControl(cbItems, txtCustomerName, e);
        }

        private void numQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            MoveNextControl(numPriceItem,cbItems,e) ;
        }

        private void cbItems_KeyDown(object sender, KeyEventArgs e)
        {
            MoveNextControl(numQuantity,txtTax,e);
        }

        private void numPriceItem_KeyDown(object sender, KeyEventArgs e)
        {
            MoveNextControl(btnAdd, numQuantity, e);
        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            MoveNextControl(btnPrint,numPriceItem,e);
        }

        private void btnPrint_KeyDown(object sender, KeyEventArgs e)
        {
            MoveNextControl(btnNew, btnAdd, e);
        }

        private void btnNew_KeyDown(object sender, KeyEventArgs e)
        {
            MoveNextControl(txtCustomerName, btnPrint, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgvData.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

        }
    }
}

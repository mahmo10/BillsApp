using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bills
{
    public partial class Form1 : Form
    {
        private string _ItemName;
        private float _Quantity;
        private float _Price;
        private float TaxRate = 0.15f;
        PrintDocument printDocument = new PrintDocument();


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
    

            printDocument.PrintPage += PrintDocument_PrintPage;
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
        private float GetTaxrate()
        {
            return   TaxRate;
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
            lblTotal.Text= GetTotalPrice().ToString("F2");
            lblTaxrate.Text=GetPriceTotalwithTaxrate().ToString("F2");
            
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
            numQuantity.Value = (decimal)_Quantity;
            numPriceItem.Value = (decimal)_Price;
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
           if(cbItems.SelectedItem==null)
            {
                MessageBox.Show("يرجي إختيار الصنف", "الصنف",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            float Total= (float)Math.Round(GetPriceTotalwithTaxrate(),2);

            dgvData.Rows.Add(_ItemName,_Quantity, _Price, Total);

            UpdateTotalBill();
            
         
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

            lblTotal.Text=0.ToString();
            lblTaxrate.Text=0.ToString();

        }

        private void ResetForm()
        {
            Reset();
            dgvData.Rows.Clear();
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

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Far;
            format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            int safeRightX = e.MarginBounds.Width ;
            int safeRightY = e.MarginBounds.Height ;

            float x = 20;
            float y = 40;



            // Logo
            string Logo = "محمود";
            e.Graphics.DrawString(Logo, new Font("PT Bold Heading", 20, FontStyle.Regular)
                , Brushes.Black, safeRightX, safeRightY-900);



            // Date
           
            e.Graphics.DrawString(DateTime.Now.ToString("yyyy-MM-dd    hh:mm:ff  t")
                , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, safeRightX-50, safeRightY-840);


            // Adddres Bill
          
            e.Graphics.DrawString("فاتورة شراء", new Font("Arial", 24, FontStyle.Bold), 
                Brushes.Black, safeRightX-313, safeRightY-800);
            
            e.Graphics.DrawLine(Pens.Black, safeRightX-580, safeRightY-750, safeRightX+150, safeRightY-750);



            // Head
            e.Graphics.DrawString("الصنف", new Font("PT Bold Heading", 12), Brushes.Black, safeRightX, safeRightY-740);
            e.Graphics.DrawString("السعر", new Font("PT Bold Heading", 12), Brushes.Black, safeRightX-250 , safeRightY - 740);
            e.Graphics.DrawString("الكمية", new Font("PT Bold Heading", 12), Brushes.Black, safeRightX-370 , safeRightY - 740);
            e.Graphics.DrawString("الإجمالي", new Font("PT Bold Heading", 12), Brushes.Black, safeRightX-500 , safeRightY - 740);
            y += 30;

            // طباعة الصفوف
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                // تجاهل الصف الأخير الفاضي
                if (row.IsNewRow)
                    continue;

                // حماية من null
                string item = row.Cells[0].Value?.ToString() ?? "";
                string qty = row.Cells[1].Value?.ToString() ?? "";
                string price = row.Cells[2].Value?.ToString() ?? "";
                string total = row.Cells[3].Value?.ToString() ?? "";

                e.Graphics.DrawString(item, new Font("Arial", 12), Brushes.Black, x, y);
                e.Graphics.DrawString(qty, new Font("Arial", 12), Brushes.Black, x + 150, y);
                e.Graphics.DrawString(price, new Font("Arial", 12), Brushes.Black, x + 250, y);
                e.Graphics.DrawString(total, new Font("Arial", 12), Brushes.Black, x + 350, y);

                y += 25;
            }

            y += 20;

            // إجمالي الفاتورة
            e.Graphics.DrawString("إجمالي الفاتورة: " + lbltotalfinal.Text,
                new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x, y);
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
       
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.ShowDialog();
        

    }
}
}

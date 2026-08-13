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

        private float StartText(float PageWidth,Font font,string Title, PrintPageEventArgs e)
        {
           
            SizeF sizeLogo = e.Graphics.MeasureString(Title, font);

            return  PageWidth - sizeLogo.Width;
        }

        private float CenterText(float PageWidth, Font font, string Title, PrintPageEventArgs e)
        {
            SizeF sizeLogo = e.Graphics.MeasureString(Title, font);

            return (PageWidth - sizeLogo.Width)/2;
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit=GraphicsUnit.Millimeter;

            Pen Pen = new Pen(Brushes.Black, 0.5f);


            // Size A4
            float PageWidth = 210;

            float Height = 297;

            float left = 10;
        
            float right = 200;

            float headerY = 30;

            float center = 105;

            float customerY = 40;

            float tableY = 80;

            float totalY = 240;


            // Logo
            string Logo = "محمود";
            Font fontLogo = new Font("PT Bold Heading", 20, FontStyle.Regular);
      
            float rightX = StartText(PageWidth,fontLogo,Logo,e);

            e.Graphics.DrawString(Logo, fontLogo
                ,Brushes.Black,rightX-20 , headerY);

            // Date

            string DateTimeNow = DateTime.Now.ToString("yyyy-MM-dd    hh:mm:ff  t");

            e.Graphics.DrawString(DateTimeNow
                , new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black,right-50, headerY+15);


            // Adddres Bill
            string title = "فاتورة شراء";
            Font font = new Font("Arial", 20, FontStyle.Bold);
            float centerX = CenterText(PageWidth,font,title,e);
            e.Graphics.DrawString(title, font, Brushes.Black, centerX,tableY);

            // Line
            e.Graphics.DrawLine(Pen, right, tableY+15, left, tableY+15);


            // Head
            e.Graphics.DrawString("الصنف", new Font("PT Bold Heading", 12), Brushes.Black, right - 35, tableY + 20);
            e.Graphics.DrawString("السعر", new Font("PT Bold Heading", 12), Brushes.Black, center+10, tableY + 20);
            e.Graphics.DrawString("الكمية", new Font("PT Bold Heading", 12), Brushes.Black, center - 15, tableY + 20);
            e.Graphics.DrawString("الضريبة", new Font("PT Bold Heading", 12), Brushes.Black, center - 40, tableY + 20);
            e.Graphics.DrawString("الإجمالي شامل الضريبة", new Font("PT Bold Heading", 12), Brushes.Black, left + 15, tableY + 20);


            // PrintLines
            float Line = tableY;

            Font fontline = new Font("Arial", 12, FontStyle.Regular);

            float LineX=StartText(PageWidth, fontline, title,e);

            foreach (DataGridViewRow row in dgvData.Rows)
            {
               
                if (row.IsNewRow)
                    continue;

               
                string item = row.Cells[0].Value?.ToString() ?? "";
                string qty = row.Cells[1].Value?.ToString() ?? "";
                string price = row.Cells[2].Value?.ToString() ?? "";
                string total = row.Cells[3].Value?.ToString() ?? "";

                e.Graphics.DrawString(item, fontline, Brushes.Black, LineX-30, Line + 30);
                e.Graphics.DrawString(qty, fontline, Brushes.Black, center - 30, Line + 30);
                e.Graphics.DrawString(price, fontline, Brushes.Black, center, Line + 30);
                e.Graphics.DrawString(total, fontline, Brushes.Black, left + 20, Line + 30);

                Line += 10;
            }

            //Line
            e.Graphics.DrawLine(Pen, right, totalY, left, totalY);


            //Total Bill

           e.Graphics.DrawString("إجمالي " ,
               new Font("Arial", 16, FontStyle.Bold), Brushes.Black, right-28, totalY + 10);

            string Total=lbltotalfinal.Text;

            e.Graphics.DrawString(Total,
     new Font("Arial", 16, FontStyle.Bold), Brushes.Black, center-55, totalY + 10);

            e.Graphics.DrawString("الضريبة " ,
              new Font("Arial", 16, FontStyle.Bold), Brushes.Black, right - 30, totalY + 20);

            string Tax= 5.ToString();
            e.Graphics.DrawString(Tax,
             new Font("Arial", 16, FontStyle.Bold), Brushes.Black, center - 55, totalY + 20);

            e.Graphics.DrawString("الإجمالي شامل الضريبة ",
             new Font("Arial", 16, FontStyle.Bold), Brushes.Black, right - 57, totalY + 30);

            string TotalwithTax=6.ToString();
              e.Graphics.DrawString(TotalwithTax,
             new Font("Arial", 16, FontStyle.Bold), Brushes.Black, center - 55, totalY + 30);
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count ==1 )
            {
                MessageBox.Show("يرجي إختيار الصنف", "الصنف",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.ShowDialog();
        

    }

        private void txtTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // منع إدخال أي شيء غير الأرقام
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }

            // منع إدخال أكثر من 15 رقم
            if (char.IsDigit(e.KeyChar) && txtTax.Text.Length >= 15)
            {
                e.Handled = true;
            }
        }
    }
}

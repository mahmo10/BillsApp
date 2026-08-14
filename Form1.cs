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
        private float _TaxRate = 0.15f;
        private float _TotalBill;

        PrintDocument printDocument = new PrintDocument();


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
           if(cbItems.SelectedItem==null)
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
        private float GetTaxbyTotal(float Total,float Tax)
        {
            return Total * Tax;
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;

            Pen Pen = new Pen(Brushes.Black, 0.5f);


            // Size A4
            float PageWidth = 210;

            //float Height = 297;

            float left = 10;

            float right = 200;

            float headerY = 30;

            float center = 105;

            float tableY = 80;

            float totalY = 240;


            // Logo
            string Logo = "قرطاسية الراقية العالمية";
            Font fontLogo = new Font("PT Bold Heading", 20, FontStyle.Regular);

            float rightX = StartText(PageWidth, fontLogo, Logo, e);

            e.Graphics.DrawString(Logo, fontLogo, Brushes.Black, rightX - 20, headerY);

            e.Graphics.DrawImage(Properties.Resources.Logo, 90, 20, 30, 30);

            // Date

            string DateTimeNow = DateTime.Now.ToString("yyyy-MM-dd    hh:mm:ff  t");

            e.Graphics.DrawString(DateTimeNow
                , new Font("Arial", 12, FontStyle.Regular),
                Brushes.Black, right - 50, headerY + 15);


            // info Customer

            string Customername = txtCustomerName.Text;
            Font fontCn = new Font("Arial", 12, FontStyle.Regular);

            float rigthCn = StartText(PageWidth, fontCn, Customername, e);

            string Username = "اسم العميل";

            e.Graphics.DrawString(Username, fontCn ,Brushes.Black, right - 20, headerY + 25);
           
            e.Graphics.DrawString(Customername, fontCn,Brushes.Black,rigthCn-37, headerY + 25);

            string Tax = "الرقم الضريبي";
            string Numtax=txtTax.Text;

            float rigthTn = StartText(PageWidth, fontCn, Numtax, e);

            e.Graphics.DrawString(Tax, fontCn, Brushes.Black, right - 20, headerY + 35);

            e.Graphics.DrawString(Numtax, fontCn, Brushes.Black, rigthTn - 35, headerY + 35);


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

            Font fontTo = new Font("Arial", 16, FontStyle.Bold);

            float Taxrate = GetTaxbyTotal(_TotalBill, _TaxRate);

            float Total = _TotalBill - Taxrate;

            string stTotal = Total.ToString("F2");

            e.Graphics.DrawString("إجمالي " , fontTo, Brushes.Black, right-28, totalY + 10);

            e.Graphics.DrawString(stTotal, fontTo, Brushes.Black, center-55, totalY + 10);


            
            string stTaxrate = Taxrate.ToString("F2");

            e.Graphics.DrawString("الضريبة " ,fontTo, Brushes.Black, right - 30, totalY + 20);

            e.Graphics.DrawString(stTaxrate, fontTo, Brushes.Black, center - 55, totalY + 20);


            string TotalwithTax = _TotalBill.ToString("F2");

            e.Graphics.DrawString("الإجمالي شامل الضريبة ",fontTo, Brushes.Black, right - 57, totalY + 30);

            e.Graphics.DrawString(TotalwithTax,fontTo, Brushes.Black, center - 55, totalY + 30);
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
    }
}

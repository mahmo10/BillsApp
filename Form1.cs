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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

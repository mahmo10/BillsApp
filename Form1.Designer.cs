namespace Bills
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numPriceItem = new System.Windows.Forms.NumericUpDown();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.الصنف = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الكمية = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.سعر = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTaxrate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotalfinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.Location = new System.Drawing.Point(57, 348);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(217, 78);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "طباعة الفاتورة";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(361, 348);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(217, 78);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "إضافة الصنف";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbItems
            // 
            this.cbItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Items.AddRange(new object[] {
            "ورق A4 80 gm",
            "ورق مقوى A4 180 gm",
            "ورق A3 80 gm",
            "تغليف سلك",
            "تغليف شطرطون"});
            this.cbItems.Location = new System.Drawing.Point(735, 129);
            this.cbItems.Margin = new System.Windows.Forms.Padding(4);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(257, 24);
            this.cbItems.TabIndex = 2;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(881, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "الصنف";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(880, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "الكمية";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(829, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "سعر الحبة";
            // 
            // numQuantity
            // 
            this.numQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numQuantity.Location = new System.Drawing.Point(736, 226);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.numQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(257, 22);
            this.numQuantity.TabIndex = 8;
            this.numQuantity.Tag = "1";
            this.numQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantity.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // numPriceItem
            // 
            this.numPriceItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPriceItem.DecimalPlaces = 2;
            this.numPriceItem.InterceptArrowKeys = false;
            this.numPriceItem.Location = new System.Drawing.Point(736, 334);
            this.numPriceItem.Margin = new System.Windows.Forms.Padding(4);
            this.numPriceItem.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPriceItem.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numPriceItem.Name = "numPriceItem";
            this.numPriceItem.Size = new System.Drawing.Size(257, 22);
            this.numPriceItem.TabIndex = 9;
            this.numPriceItem.Tag = "0";
            this.numPriceItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPriceItem.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numPriceItem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPriceItem.ValueChanged += new System.EventHandler(this.numPriceItem_ValueChanged);
            // 
            // dgvData
            // 
            this.dgvData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.الصنف,
            this.الكمية,
            this.سعر,
            this.Total});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.NullValue = null;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.Black;
            this.dgvData.Location = new System.Drawing.Point(97, 37);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvData.Size = new System.Drawing.Size(419, 214);
            this.dgvData.TabIndex = 10;
            // 
            // الصنف
            // 
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            this.الصنف.DefaultCellStyle = dataGridViewCellStyle32;
            this.الصنف.HeaderText = "الصنف";
            this.الصنف.MinimumWidth = 6;
            this.الصنف.Name = "الصنف";
            this.الصنف.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.الصنف.Width = 82;
            // 
            // الكمية
            // 
            this.الكمية.HeaderText = "الكمية";
            this.الكمية.MinimumWidth = 6;
            this.الكمية.Name = "الكمية";
            this.الكمية.Width = 76;
            // 
            // سعر
            // 
            this.سعر.HeaderText = "سعر الحبة";
            this.سعر.MinimumWidth = 6;
            this.سعر.Name = "سعر";
            this.سعر.Width = 103;
            // 
            // Total
            // 
            this.Total.HeaderText = "الإجمالي";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 92;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(876, 402);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "الإحمالي";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(728, 402);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(30, 31);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "0";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.Location = new System.Drawing.Point(239, 462);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(217, 78);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "فاتورة جديدة";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(809, 462);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(225, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "شامل الضريبة 15 %";
            // 
            // lblTaxrate
            // 
            this.lblTaxrate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTaxrate.AutoSize = true;
            this.lblTaxrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxrate.Location = new System.Drawing.Point(727, 462);
            this.lblTaxrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxrate.Name = "lblTaxrate";
            this.lblTaxrate.Size = new System.Drawing.Size(30, 31);
            this.lblTaxrate.TabIndex = 15;
            this.lblTaxrate.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "الإجمالي :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbltotalfinal
            // 
            this.lbltotalfinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltotalfinal.AutoSize = true;
            this.lbltotalfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalfinal.Location = new System.Drawing.Point(292, 255);
            this.lbltotalfinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalfinal.Name = "lbltotalfinal";
            this.lbltotalfinal.Size = new System.Drawing.Size(0, 25);
            this.lbltotalfinal.TabIndex = 17;
            this.lbltotalfinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbltotalfinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTaxrate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.numPriceItem);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrint);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.NumericUpDown numPriceItem;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn الصنف;
        private System.Windows.Forms.DataGridViewTextBoxColumn الكمية;
        private System.Windows.Forms.DataGridViewTextBoxColumn سعر;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTaxrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotalfinal;
    }
}


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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numPriceItem = new System.Windows.Forms.NumericUpDown();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTaxrate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotalfinal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.الصنف = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الكمية = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.سعر = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.BackColor = System.Drawing.Color.Crimson;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.FlatAppearance.BorderSize = 2;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Snow;
            this.btnPrint.Location = new System.Drawing.Point(552, 479);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(209, 91);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "طباعة الفاتورة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(659, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(209, 91);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "إضافة الصنف";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbItems
            // 
            this.cbItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbItems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbItems.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Items.AddRange(new object[] {
            "ورق A4 80 gm",
            "ورق مقوى A4 180 gm",
            "ورق A3 80 gm",
            "تغليف سلك",
            "تغليف شطرطون"});
            this.cbItems.Location = new System.Drawing.Point(647, 143);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(232, 30);
            this.cbItems.TabIndex = 2;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(937, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "الصنف";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(936, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "الكمية";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(907, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "سعر الحبة";
            // 
            // numQuantity
            // 
            this.numQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numQuantity.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.Location = new System.Drawing.Point(647, 194);
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
            this.numQuantity.Size = new System.Drawing.Size(232, 29);
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
            this.numPriceItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numPriceItem.DecimalPlaces = 2;
            this.numPriceItem.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPriceItem.InterceptArrowKeys = false;
            this.numPriceItem.Location = new System.Drawing.Point(647, 237);
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
            this.numPriceItem.Size = new System.Drawing.Size(232, 29);
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
            this.dgvData.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.الصنف,
            this.الكمية,
            this.سعر,
            this.Total});
            this.dgvData.Cursor = System.Windows.Forms.Cursors.No;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.Black;
            this.dgvData.Location = new System.Drawing.Point(33, 40);
            this.dgvData.Name = "dgvData";
            this.dgvData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvData.Size = new System.Drawing.Size(476, 491);
            this.dgvData.TabIndex = 10;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.BackColor = System.Drawing.Color.PowderBlue;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(767, 479);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(209, 91);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "فاتورة جديدة";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(767, 293);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(243, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "الإجمالي شامل الضريبة 15 %";
            // 
            // lblTaxrate
            // 
            this.lblTaxrate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTaxrate.AutoSize = true;
            this.lblTaxrate.BackColor = System.Drawing.Color.Transparent;
            this.lblTaxrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxrate.Location = new System.Drawing.Point(678, 294);
            this.lblTaxrate.Name = "lblTaxrate";
            this.lblTaxrate.Size = new System.Drawing.Size(30, 31);
            this.lblTaxrate.TabIndex = 15;
            this.lblTaxrate.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 534);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(115, 41);
            this.label5.TabIndex = 16;
            this.label5.Text = "الإجمالي :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbltotalfinal
            // 
            this.lbltotalfinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltotalfinal.AutoSize = true;
            this.lbltotalfinal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalfinal.Location = new System.Drawing.Point(258, 537);
            this.lbltotalfinal.Name = "lbltotalfinal";
            this.lbltotalfinal.Size = new System.Drawing.Size(32, 33);
            this.lbltotalfinal.TabIndex = 17;
            this.lbltotalfinal.Text = "0";
            this.lbltotalfinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(896, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 33);
            this.label7.TabIndex = 18;
            this.label7.Text = "اسم العميل";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(888, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 33);
            this.label8.TabIndex = 19;
            this.label8.Text = "رقم الضريبي";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(647, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(232, 29);
            this.textBox1.TabIndex = 20;
            // 
            // txtTax
            // 
            this.txtTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTax.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTax.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(647, 86);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(232, 29);
            this.txtTax.TabIndex = 21;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            // 
            // الصنف
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.الصنف.DefaultCellStyle = dataGridViewCellStyle10;
            this.الصنف.Frozen = true;
            this.الصنف.HeaderText = "الصنف";
            this.الصنف.MinimumWidth = 6;
            this.الصنف.Name = "الصنف";
            this.الصنف.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.الصنف.Width = 173;
            // 
            // الكمية
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.الكمية.DefaultCellStyle = dataGridViewCellStyle11;
            this.الكمية.HeaderText = "الكمية";
            this.الكمية.MinimumWidth = 6;
            this.الكمية.Name = "الكمية";
            this.الكمية.Width = 80;
            // 
            // سعر
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.سعر.DefaultCellStyle = dataGridViewCellStyle12;
            this.سعر.HeaderText = "سعر الحبة";
            this.سعر.MinimumWidth = 6;
            this.سعر.Name = "سعر";
            // 
            // Total
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.Total.DefaultCellStyle = dataGridViewCellStyle13;
            this.Total.HeaderText = "الإجمالي";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1039, 692);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbltotalfinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTaxrate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.numPriceItem);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fatora Pro";
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
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTaxrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotalfinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn الصنف;
        private System.Windows.Forms.DataGridViewTextBoxColumn الكمية;
        private System.Windows.Forms.DataGridViewTextBoxColumn سعر;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}


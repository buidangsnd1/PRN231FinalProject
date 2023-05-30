namespace FinalProject
{
    partial class AddEditBillFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.tblSearchCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomerColSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSelectedITem = new System.Windows.Forms.Button();
            this.tblSearchItem = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblItemColSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.numericSelectedQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelCreatedTime = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelTotalDiscount = new System.Windows.Forms.Label();
            this.labelTotalItem = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.tblBillDetail = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBillDetailColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblBillDetailColRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSearchCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSearchItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSelectedQuantity)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBillDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStaff);
            this.groupBox1.Controls.Add(this.tblSearchCustomer);
            this.groupBox1.Controls.Add(this.btnSearchCustomer);
            this.groupBox1.Controls.Add(this.txtSearchCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(167, 83);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(271, 26);
            this.txtStaff.TabIndex = 3;
            this.txtStaff.Leave += new System.EventHandler(this.UpdateStaffInfo);
            // 
            // tblSearchCustomer
            // 
            this.tblSearchCustomer.AllowUserToAddRows = false;
            this.tblSearchCustomer.AllowUserToDeleteRows = false;
            this.tblSearchCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSearchCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblSearchCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.tblSearchCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSearchCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.tblCustomerColSelect});
            this.tblSearchCustomer.Location = new System.Drawing.Point(6, 128);
            this.tblSearchCustomer.Name = "tblSearchCustomer";
            this.tblSearchCustomer.RowHeadersWidth = 51;
            this.tblSearchCustomer.RowTemplate.Height = 24;
            this.tblSearchCustomer.Size = new System.Drawing.Size(587, 206);
            this.tblSearchCustomer.TabIndex = 7;
            this.tblSearchCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCustomerCellClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle26;
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tblCustomerColSelect
            // 
            this.tblCustomerColSelect.HeaderText = "Chọn";
            this.tblCustomerColSelect.MinimumWidth = 6;
            this.tblCustomerColSelect.Name = "tblCustomerColSelect";
            this.tblCustomerColSelect.Text = "Chọn";
            this.tblCustomerColSelect.UseColumnTextForButtonValue = true;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Image = global::FinalProject.Properties.Resources.search;
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.Location = new System.Drawing.Point(459, 50);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(122, 40);
            this.btnSearchCustomer.TabIndex = 2;
            this.btnSearchCustomer.Text = "Tìm";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomerClick);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(167, 30);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(271, 26);
            this.txtSearchCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateSelectedITem);
            this.groupBox2.Controls.Add(this.tblSearchItem);
            this.groupBox2.Controls.Add(this.txtSearchItem);
            this.groupBox2.Controls.Add(this.btnSearchItem);
            this.groupBox2.Controls.Add(this.numericSelectedQuantity);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(605, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mặt hàng";
            // 
            // btnUpdateSelectedITem
            // 
            this.btnUpdateSelectedITem.Image = global::FinalProject.Properties.Resources.sync;
            this.btnUpdateSelectedITem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSelectedITem.Location = new System.Drawing.Point(444, 69);
            this.btnUpdateSelectedITem.Name = "btnUpdateSelectedITem";
            this.btnUpdateSelectedITem.Size = new System.Drawing.Size(122, 40);
            this.btnUpdateSelectedITem.TabIndex = 9;
            this.btnUpdateSelectedITem.Text = "Cập nhập";
            this.btnUpdateSelectedITem.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedITem.Click += new System.EventHandler(this.btnUpdateSelectedItemClick);
            // 
            // tblSearchItem
            // 
            this.tblSearchItem.AllowUserToAddRows = false;
            this.tblSearchItem.AllowUserToDeleteRows = false;
            this.tblSearchItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSearchItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblSearchItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.tblSearchItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSearchItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.tblItemColSelect});
            this.tblSearchItem.Location = new System.Drawing.Point(0, 128);
            this.tblSearchItem.Name = "tblSearchItem";
            this.tblSearchItem.RowHeadersWidth = 51;
            this.tblSearchItem.RowTemplate.Height = 24;
            this.tblSearchItem.Size = new System.Drawing.Size(587, 206);
            this.tblSearchItem.TabIndex = 8;
            this.tblSearchItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblItemCellClick);
            // 
            // Column4
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle28;
            this.Column4.HeaderText = "Mã MH";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên MH";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle29;
            this.Column6.HeaderText = "Số lượng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tblItemColSelect
            // 
            this.tblItemColSelect.HeaderText = "Chọn";
            this.tblItemColSelect.MinimumWidth = 6;
            this.tblItemColSelect.Name = "tblItemColSelect";
            this.tblItemColSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tblItemColSelect.Text = "Chọn";
            this.tblItemColSelect.UseColumnTextForButtonValue = true;
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Location = new System.Drawing.Point(133, 30);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(271, 26);
            this.txtSearchItem.TabIndex = 4;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Image = global::FinalProject.Properties.Resources.search;
            this.btnSearchItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchItem.Location = new System.Drawing.Point(444, 23);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(122, 40);
            this.btnSearchItem.TabIndex = 5;
            this.btnSearchItem.Text = "Tìm";
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItemClick);
            // 
            // numericSelectedQuantity
            // 
            this.numericSelectedQuantity.Location = new System.Drawing.Point(133, 80);
            this.numericSelectedQuantity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericSelectedQuantity.Name = "numericSelectedQuantity";
            this.numericSelectedQuantity.Size = new System.Drawing.Size(271, 26);
            this.numericSelectedQuantity.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên mặt hàng: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelCreatedTime);
            this.groupBox3.Controls.Add(this.labelTotalAmount);
            this.groupBox3.Controls.Add(this.labelTotalDiscount);
            this.groupBox3.Controls.Add(this.labelTotalItem);
            this.groupBox3.Controls.Add(this.labelCustomerName);
            this.groupBox3.Controls.Add(this.tblBillDetail);
            this.groupBox3.Location = new System.Drawing.Point(0, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1193, 361);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết mặt hàng trong hóa đơn";
            // 
            // labelCreatedTime
            // 
            this.labelCreatedTime.AutoSize = true;
            this.labelCreatedTime.Location = new System.Drawing.Point(1056, 294);
            this.labelCreatedTime.Name = "labelCreatedTime";
            this.labelCreatedTime.Size = new System.Drawing.Size(82, 20);
            this.labelCreatedTime.TabIndex = 5;
            this.labelCreatedTime.Text = "Thời gian:";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(813, 294);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(106, 20);
            this.labelTotalAmount.TabIndex = 4;
            this.labelTotalAmount.Text = "Tổng tiền: 0đ";
            // 
            // labelTotalDiscount
            // 
            this.labelTotalDiscount.AutoSize = true;
            this.labelTotalDiscount.Location = new System.Drawing.Point(570, 294);
            this.labelTotalDiscount.Name = "labelTotalDiscount";
            this.labelTotalDiscount.Size = new System.Drawing.Size(104, 20);
            this.labelTotalDiscount.TabIndex = 3;
            this.labelTotalDiscount.Text = "Tổng KM: 0đ";
            // 
            // labelTotalItem
            // 
            this.labelTotalItem.AutoSize = true;
            this.labelTotalItem.Location = new System.Drawing.Point(327, 294);
            this.labelTotalItem.Name = "labelTotalItem";
            this.labelTotalItem.Size = new System.Drawing.Size(106, 20);
            this.labelTotalItem.TabIndex = 2;
            this.labelTotalItem.Text = "Tổng số: 0sp";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(84, 291);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(102, 20);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Khách hàng:";
            // 
            // tblBillDetail
            // 
            this.tblBillDetail.AllowUserToAddRows = false;
            this.tblBillDetail.AllowUserToDeleteRows = false;
            this.tblBillDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblBillDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblBillDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.tblBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.tblBillDetailColEdit,
            this.tblBillDetailColRemove});
            this.tblBillDetail.Location = new System.Drawing.Point(0, 25);
            this.tblBillDetail.Name = "tblBillDetail";
            this.tblBillDetail.RowHeadersWidth = 51;
            this.tblBillDetail.RowTemplate.Height = 24;
            this.tblBillDetail.Size = new System.Drawing.Size(1192, 259);
            this.tblBillDetail.TabIndex = 9;
            this.tblBillDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblBillDetailCellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã HĐ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mã MH";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tên MH";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Số lượng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Giá bán";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Giá sau KM";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Thành tiền";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            // 
            // tblBillDetailColEdit
            // 
            this.tblBillDetailColEdit.HeaderText = "Sửa";
            this.tblBillDetailColEdit.MinimumWidth = 6;
            this.tblBillDetailColEdit.Name = "tblBillDetailColEdit";
            this.tblBillDetailColEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tblBillDetailColEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tblBillDetailColEdit.Text = "Sửa";
            this.tblBillDetailColEdit.UseColumnTextForButtonValue = true;
            // 
            // tblBillDetailColRemove
            // 
            this.tblBillDetailColRemove.HeaderText = "Xóa bỏ";
            this.tblBillDetailColRemove.MinimumWidth = 6;
            this.tblBillDetailColRemove.Name = "tblBillDetailColRemove";
            this.tblBillDetailColRemove.Text = "Xóa bỏ";
            this.tblBillDetailColRemove.UseColumnTextForButtonValue = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.Image = global::FinalProject.Properties.Resources.delete_button;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(931, 734);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 44);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::FinalProject.Properties.Resources.bin;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(685, 734);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(124, 44);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemoveClick);
            // 
            // btnPay
            // 
            this.btnPay.Image = global::FinalProject.Properties.Resources.credit_card;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(439, 734);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(124, 44);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPaymentClick);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::FinalProject.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(193, 734);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 44);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveClick);
            // 
            // AddEditBillFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 790);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditBillFrm";
            this.Text = "THÊM MỚI HÓA ĐƠN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSearchCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSearchItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSelectedQuantity)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblBillDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericSelectedQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tblSearchCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.DataGridView tblSearchItem;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Button btnSearchItem;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Label labelCreatedTime;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelTotalDiscount;
        private System.Windows.Forms.Label labelTotalItem;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.DataGridView tblBillDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn tblItemColSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn tblCustomerColSelect;
        private System.Windows.Forms.Button btnUpdateSelectedITem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewButtonColumn tblBillDetailColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn tblBillDetailColRemove;
    }
}
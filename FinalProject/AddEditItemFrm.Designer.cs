namespace FinalProject
{
    partial class AddEditItemFrm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.comboItemType = new System.Windows.Forms.ComboBox();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.datePickerReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.comboDiscount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::FinalProject.Properties.Resources.delete_button;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(259, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 49);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = global::FinalProject.Properties.Resources.plus1;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(74, 372);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(145, 48);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddItemClick);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(170, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(244, 26);
            this.txtId.TabIndex = 10;
            this.txtId.Text = "0";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(170, 184);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(244, 26);
            this.txtBrand.TabIndex = 11;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(170, 50);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(244, 26);
            this.txtItemName.TabIndex = 12;
            // 
            // comboItemType
            // 
            this.comboItemType.FormattingEnabled = true;
            this.comboItemType.Items.AddRange(new object[] {
            "Thời trang",
            "Điện tử",
            "Thực phẩm",
            "Vật liệu xây dựng"});
            this.comboItemType.Location = new System.Drawing.Point(170, 94);
            this.comboItemType.Name = "comboItemType";
            this.comboItemType.Size = new System.Drawing.Size(244, 28);
            this.comboItemType.TabIndex = 13;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(170, 140);
            this.numericQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(244, 26);
            this.numericQuantity.TabIndex = 14;
            // 
            // datePickerReleaseDate
            // 
            this.datePickerReleaseDate.CustomFormat = "dd/MM/yyyy";
            this.datePickerReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerReleaseDate.Location = new System.Drawing.Point(170, 228);
            this.datePickerReleaseDate.Name = "datePickerReleaseDate";
            this.datePickerReleaseDate.Size = new System.Drawing.Size(244, 26);
            this.datePickerReleaseDate.TabIndex = 15;
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(170, 272);
            this.numericPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(244, 26);
            this.numericPrice.TabIndex = 16;
            // 
            // comboDiscount
            // 
            this.comboDiscount.FormattingEnabled = true;
            this.comboDiscount.Location = new System.Drawing.Point(170, 316);
            this.comboDiscount.Name = "comboDiscount";
            this.comboDiscount.Size = new System.Drawing.Size(244, 28);
            this.comboDiscount.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã mặt hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên mặt hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Loại mặt hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hãng sản xuất:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày sản xuất:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giá bán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Khuyến mãi:";
            // 
            // AddEditItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 433);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDiscount);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.datePickerReleaseDate);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.comboItemType);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditItemFrm";
            this.Text = "THÊM MỚI MẶT HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ComboBox comboItemType;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.DateTimePicker datePickerReleaseDate;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.ComboBox comboDiscount;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
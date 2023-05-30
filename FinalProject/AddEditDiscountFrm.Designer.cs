﻿namespace FinalProject
{
    partial class AddEditDiscountFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtDiscountId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscountName = new System.Windows.Forms.TextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.comboDiscountType = new System.Windows.Forms.ComboBox();
            this.numericDiscountPercent = new System.Windows.Forms.NumericUpDown();
            this.numericDiscountAmount = new System.Windows.Forms.NumericUpDown();
            this.btnCancelClick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscountPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscountAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khuyến mãi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khuyến mãi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết thúc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại khuyến mãi:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddNew.Image = global::FinalProject.Properties.Resources.plus;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(100, 433);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(148, 50);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddEditClick);
            // 
            // txtDiscountId
            // 
            this.txtDiscountId.Enabled = false;
            this.txtDiscountId.Location = new System.Drawing.Point(232, 31);
            this.txtDiscountId.Name = "txtDiscountId";
            this.txtDiscountId.Size = new System.Drawing.Size(245, 26);
            this.txtDiscountId.TabIndex = 7;
            this.txtDiscountId.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "% Giá giảm: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Khuyến mãi:";
            // 
            // txtDiscountName
            // 
            this.txtDiscountName.Location = new System.Drawing.Point(232, 84);
            this.txtDiscountName.Name = "txtDiscountName";
            this.txtDiscountName.Size = new System.Drawing.Size(245, 26);
            this.txtDiscountName.TabIndex = 10;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(232, 137);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(245, 26);
            this.dateTimePickerStart.TabIndex = 11;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(232, 190);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(245, 26);
            this.dateTimePickerEnd.TabIndex = 12;
            // 
            // comboDiscountType
            // 
            this.comboDiscountType.FormattingEnabled = true;
            this.comboDiscountType.Items.AddRange(new object[] {
            "Không áp dụng.",
            "Giảm giá trực tiếp.",
            "Khuyến mãi % giá bán."});
            this.comboDiscountType.Location = new System.Drawing.Point(232, 246);
            this.comboDiscountType.Name = "comboDiscountType";
            this.comboDiscountType.Size = new System.Drawing.Size(245, 28);
            this.comboDiscountType.TabIndex = 13;
            // 
            // numericDiscountPercent
            // 
            this.numericDiscountPercent.Location = new System.Drawing.Point(232, 296);
            this.numericDiscountPercent.Name = "numericDiscountPercent";
            this.numericDiscountPercent.Size = new System.Drawing.Size(245, 26);
            this.numericDiscountPercent.TabIndex = 14;
            // 
            // numericDiscountAmount
            // 
            this.numericDiscountAmount.Location = new System.Drawing.Point(232, 349);
            this.numericDiscountAmount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericDiscountAmount.Name = "numericDiscountAmount";
            this.numericDiscountAmount.Size = new System.Drawing.Size(245, 26);
            this.numericDiscountAmount.TabIndex = 15;
            // 
            // btnCancelClick
            // 
            this.btnCancelClick.Image = global::FinalProject.Properties.Resources.delete_button;
            this.btnCancelClick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelClick.Location = new System.Drawing.Point(322, 433);
            this.btnCancelClick.Name = "btnCancelClick";
            this.btnCancelClick.Size = new System.Drawing.Size(145, 50);
            this.btnCancelClick.TabIndex = 6;
            this.btnCancelClick.Text = "Hủy bỏ";
            this.btnCancelClick.UseVisualStyleBackColor = true;
            this.btnCancelClick.Click += new System.EventHandler(this.btnCancelClick_Click);
            // 
            // AddEditDiscountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 509);
            this.Controls.Add(this.numericDiscountAmount);
            this.Controls.Add(this.numericDiscountPercent);
            this.Controls.Add(this.comboDiscountType);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.txtDiscountName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiscountId);
            this.Controls.Add(this.btnCancelClick);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditDiscountFrm";
            this.Text = "THÊM MỚI CHƯƠNG TRÌNH KHUYẾN MÃI";
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscountPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscountAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancelClick;
        private System.Windows.Forms.TextBox txtDiscountId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscountName;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox comboDiscountType;
        private System.Windows.Forms.NumericUpDown numericDiscountPercent;
        private System.Windows.Forms.NumericUpDown numericDiscountAmount;
    }
}
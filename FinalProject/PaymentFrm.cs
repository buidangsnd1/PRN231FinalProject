using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PaymentFrm : Form
    {
        private IViewController _controller;
        private BillDetail _bill;

        public PaymentFrm()
        {
            InitializeComponent();
            CenterToParent();
        }

        public PaymentFrm(IViewController controller, BillDetail bill) : this()
        {
            _controller = controller;
            _bill = bill;
            showData();
        }

        private void showData()
        {
            txtBillId.Text = _bill.BillId + "";
            txtCustomerName.Text = _bill.Cart?.Customer?.FullName.ToString();
            txtStaffName.Text = _bill.StaffName;
            txtCreatedTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtTotalItem.Text = $"{_bill.TotalItem}sp";
            txtTotalDiscount.Text = $"{_bill.TotalDiscountAmount}đ";
            txtTotalAmount.Text = $"{_bill.TotalAmount:N0}đ";
        }

        private void btnFinishClick(object sender, EventArgs e)
        {
            if(comboPaymentMethod.SelectedIndex == -1)
            {
                var title = "Lỗi thanh toán";
                var msg = "Chọn hình thức thanh toán trước!";
                MessageBox.Show(msg,title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                _bill.Status = "Đã thanh toán";
                _bill.PaymentMethod = comboPaymentMethod.Text;
                _controller.AddNewItem(_bill);
                Dispose();
            }
        }
    }
}

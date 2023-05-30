using System;
using System.Windows.Forms;
using Models;

namespace FinalProject
{
    public partial class AddEditDiscountFrm : Form
    {
        private Discount _discount;
        private IViewController _controller;
        public AddEditDiscountFrm()
        {
            InitializeComponent();
            CenterToParent();
        }
        public AddEditDiscountFrm(IViewController controller, Discount discount=null) : this()
        {
            _controller= controller;
            _discount= discount;
            if(discount != null)
            {
                //update
                Text = "CẬP NHẬP THÔNG TIN KHUYẾN MÃI";
                btnAddNew.Text = "Cập nhập";
                showDiscountInfo();
            }
        }

        private void showDiscountInfo()
        {
            txtDiscountId.Text = _discount.DiscountId + "";
            txtDiscountName.Text = _discount.Name;
            dateTimePickerStart.Value= _discount.StartTime;
            dateTimePickerEnd.Value= _discount.EndTime;
            numericDiscountAmount.Value = _discount.DiscountPriceAmount;
            numericDiscountPercent.Value = _discount.DiscountPercent;
            for(int i = 0; i < comboDiscountType.Items.Count; i++)
            {
                if (_discount.DiscountType.CompareTo(comboDiscountType.Items[i]) == 0)
                {
                    comboDiscountType.SelectedIndex = i;
                    break;
                }
            }

        }

        private void btnCancelClick_Click(object sender, EventArgs e)
        {
            var title = "Xác nhận";
            var message = "Bạn có chắc chắn muốn hủy bỏ?";
            var ans = ShowConfirmMessage(title, message);
            if (ans == DialogResult.Yes)
            {
                Dispose();
            }


        }
        private DialogResult ShowConfirmMessage(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnAddEditClick(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDiscountName.Text)) {
                var title = "Lỗi dữ liệu";
                var msg = "Vui lòng nhập tên khuyến mãi";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(comboDiscountType.SelectedIndex == -1)
            {
                var title = "Lỗi dữ liệu";
                var msg = "Vui lòng chọn loại chương trình khuyến mãi";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(btnAddNew.Text.CompareTo("Cập nhập") == 0)
                {
                    //update
                    _discount.Name= txtDiscountName.Text;
                    _discount.StartTime= dateTimePickerStart.Value;
                    _discount.EndTime= dateTimePickerEnd.Value;
                    _discount.DiscountType = comboDiscountType.Text;
                    _discount.DiscountPercent = (int)numericDiscountPercent.Value;
                    _discount.DiscountPriceAmount = (int)numericDiscountAmount.Value;
                    var title = "Xác nhận";
                    var msg = "Bạn có chắc chắn muốn lưu các thay đổi?";
                    var ans = ShowConfirmMessage(title, msg);
                    if(ans == DialogResult.Yes) {
                        _controller.UpdataItem(_discount);
                        Dispose();
                    }


                }
                else
                {
                    Discount discount = new Discount(0, txtDiscountName.Text, dateTimePickerStart.Value,
                        dateTimePickerEnd.Value, comboDiscountType.Text, (int)numericDiscountAmount.Value,
                        (int)numericDiscountPercent.Value);
                    _controller.AddNewItem(discount);
                }
            }
        }
    }
}

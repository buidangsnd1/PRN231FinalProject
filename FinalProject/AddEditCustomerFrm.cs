using Controllers;
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
    public partial class AddEditCustomerFrm : Form
    {
        private Customer _customer;
        private IViewController _controller;
        public AddEditCustomerFrm()
        {
            InitializeComponent();
            CenterToParent();
        }
        public AddEditCustomerFrm(IViewController controller, Customer customer) : this()  {
            _customer = customer;
            _controller = controller;   
            if(customer != null)
            {
                Text = "SỬA THÔNG TIN KHÁCH HÀNG";
                btnAddNew.Text = "Cập nhập";
                ShowCustomerInfo();
            }
        }

        private void ShowCustomerInfo()
        {
            txtCustomerId.Text = _customer.PersonId;
            txtCustomerId.Enabled = false;
            txtFullName.Text = _customer.FullName.ToString();
            txtAddress.Text = _customer.Address;
            txtEmail.Text = _customer.Email;
            txtPhoneNumber.Text = _customer.PhoneNumber;
            numericPoint.Value = _customer.Point;
            datePickerBirthDate.Value = _customer.BirthDate;
            datePickerCreateAccount.Value = _customer.CreateTime;
            datePickerCreateAccount.Enabled = false;
            for (int i = 0; i < comboCustomerType.Items.Count; i++){
                if (_customer.CustomerType.CompareTo(comboCustomerType.Items[i]) == 0){
                    comboCustomerType.SelectedIndex = i;
                    break;

                }
            }
        }

        private void ClearCustomerIdHintHandle(object sender, EventArgs e)
        {
            txtCustomerId.Text = "";
        }
        private void txtIdTakeFocus(object sender, EventArgs e)
        {
            txtCustomerId.Text = "";
            txtCustomerId.ForeColor = Color.Black;
        }

        private void txtIdLeaveFocus(object sender, EventArgs e)
            {
           if(string.IsNullOrEmpty(txtCustomerId.Text) ) {
            txtCustomerId.Text = "CMND/CCCD";
            txtCustomerId.ForeColor= Color.Gray;
            }
            else
            {
                txtCustomerId.ForeColor = Color.Black;
            }

        }

        private void btnCancelClick(object sender, EventArgs e)
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

        private void btnAddUpdateClick(object sender, EventArgs e)
        {
            var customerController = new CustomerController();
            try
            {
                if(!customerController.IsNameValid(txtFullName.Text)) {
                    throw new InvalidNameException("Họ và tên không hợp.", txtFullName.Text);
                }
                if (!customerController.IsEmailValid(txtEmail.Text))
                {
                    throw new InvalidEmailException("Email không hợp.", txtEmail.Text);
                }
                if (!customerController.IsPhoneValid(txtPhoneNumber.Text))
                {
                    throw new InvalidPhoneNumberException("Số điện thoại không hợp.", txtPhoneNumber.Text);
                }                
                if(btnAddNew.Text.CompareTo("Cập nhập") != 0)
                {
                    var id = txtCustomerId.Text;
                    var name = txtFullName.Text;
                    var address = txtAddress.Text;
                    var email = txtEmail.Text;
                    var phone = txtPhoneNumber.Text;
                    var birthDate = datePickerBirthDate.Value;
                    var createdAccTime = DateTime.Now;
                    var point = (int)numericPoint.Value;
                    var customerType = comboCustomerType.Text;
                    var customer = new Customer(customerType, point, createdAccTime, email);
                    customer.PersonId = id;
                    customer.FullName = new FullName(name);
                    customer.Address = address;
                    customer.PhoneNumber = phone;
                    customer.BirthDate = birthDate;
                    customer.CreateTime = createdAccTime;
                    _controller.AddNewItem(customer);
                }
                else
                {
                  // update customer info
                    _customer.Address = txtAddress.Text;
                    _customer.PhoneNumber = txtPhoneNumber.Text;
                    _customer.FullName = new FullName(txtFullName.Text);
                    _customer.Point= (int)numericPoint.Value;
                    _customer.BirthDate= datePickerBirthDate.Value;
                    _customer.CustomerType = comboCustomerType.Text;
                    _customer.Email = txtEmail.Text;
                    var title = "Xác nhận";
                    var msg = "Bạn có chắc chắn muốn lưu thay đổi";
                    var ans = ShowConfirmMessage(title, msg);   
                    if(ans == DialogResult.Yes)
                    {
                        _controller.UpdataItem(_customer);
                        Dispose();
                    }
                }
            }catch(InvalidNameException ex)
            {
               ShowErrorMessage(ex.Message);
            }
            catch (InvalidEmailException ex)
            {
                ShowErrorMessage(ex.Message);
            }
            catch (InvalidPhoneNumberException ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        private void ShowErrorMessage(string msg)
        {
            var title = "Lỗi dữ liệu";
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

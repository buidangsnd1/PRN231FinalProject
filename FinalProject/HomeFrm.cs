using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;

namespace FinalProject
{
    public enum ActionType
    {
        NORMAL, SEARCH
    }
    public interface IViewController
    {
        void AddNewItem<T>(T item);
        void Remove<T>(T item);
        void UpdataItem<T>(T updatedItem);
    }
    public partial class HomeFrm : Form, IViewController
    {
        private static string DATE_FORMAT = "dd/MM/yyyy";
        private static string DATE_TIME_FORMAT = "dd/MM/yyyy HH:mm:ss";
        private List<Item> _items;
        private List<Discount> _discounts;
        private List<Customer> _customers;
        private CommonController _commonController;
        private ItemController _itemController;
        private List<Item> _searchItemResults;
        private List<Customer> _searchCustomerResults;
        private List<Discount> _searchDiscountResults;
        private ActionType _actionType;
        private CustomerController _customerController;
        private IDiscountController _discountController;
        private List<BillDetail> _bills;
        private List<BillDetail> _searchedBillResults;
        private IOController _ioController;
        private AutoIdUpdater _autoIdUpdater;
        private BillSorter _billSorter;
        public HomeFrm()
        {
            InitializeComponent();
            CenterToScreen();
            _ioController = new IOController();
            _items = new List<Item>();
            _discounts = new List<Discount>();
            _customers = new List<Customer>();
            _bills = new List<BillDetail>();
            _commonController = new CommonController();
            _customerController = new CustomerController();
            _itemController = new ItemController();
            _searchItemResults = new List<Item>();
            _searchCustomerResults = new List<Customer>();
            _searchDiscountResults = new List<Discount>();
            _discountController = new DiscountController();
            _searchedBillResults = new List<BillDetail>();
            _autoIdUpdater = new AutoIdUpdater();
            _billSorter = new BillSorter();
            _actionType = ActionType.NORMAL;
            //nạp dữ liệu 
            _ioController.LoadDataList(_items, _customers, _discounts, _bills);
            //cập nhập mã tự động tăng
            _autoIdUpdater.UpdateDiscountAutoId(_discounts);
            _autoIdUpdater.UpdateItemAutoId(_items);
            _autoIdUpdater.UpdateBillAutoId(_bills);           
            //_items.AddRange(Utils.CreateFakeItems());
            //_customers.AddRange(Utils.CreateFakeCustomer());
            //_discounts.AddRange(Utils.CreateFakeDiscounts());
            //hiển thị dữ liệu
            showItems(_items);
            showCustomer(_customers);
            showDiscount(_discounts);
            showBills(_bills);
        }

        private void showDiscount(List<Discount> discounts)
        {
            tblDiscount.Rows.Clear();
            foreach (Discount discount in discounts)
            {
                tblDiscount.Rows.Add(new object[]
         {
                    discount.DiscountId, discount.Name, discount.StartTime.ToString(DATE_TIME_FORMAT),
                    discount.EndTime.ToString(DATE_TIME_FORMAT), discount.DiscountType,
                    discount.DiscountPercent,$"{discount.DiscountPriceAmount:N0}"
         }
             );
            }
        }

        private void showCustomer(List<Customer> customers)
        {
            tblCustomer.Rows.Clear();
            foreach (var customer in customers)
            {
                tblCustomer.Rows.Add(new object[]
                   {
                    customer.PersonId, customer.FullName?.ToString(), customer.BirthDate.ToString(DATE_FORMAT), customer.Address,
                    customer.PhoneNumber, customer.CustomerType,$"{customer.Point:N0}",
                    customer.CreateTime.ToString(DATE_TIME_FORMAT), customer.Email
                   });
            }
        }

        private void btnAddNewClick(object sender, EventArgs e)
        {
            if (sender.Equals(btnAddNewItem))
            {
                var childView = new AddEditItemFrm(this, _discounts);
                childView.Show();
            }
        }

        public void AddNewItem<T>(T item)
        {
            if (typeof(T) == typeof(Item))
            {
                var newItem = item as Item;
                _commonController.AddNewItem(_items, newItem);
                tblItem.Rows.Add(new object[]
                {
                    newItem.ItemId, newItem.ItemName, newItem.ItemType, newItem.Quantity,
                    newItem.Brand, newItem.ReleaseDate.ToString("dd/MM/yyyy"),$"{newItem.Price:N0}",
                    _itemController.GetDiscountName(newItem.Discount)
                });
            }
            else if (typeof(T) == typeof(Customer))
            {
                //hiển thị lên bảng Customer
                var customer = item as Customer;
                int indexOfCustomer = _commonController.IndexOfItem(_customers, customer);
                if (indexOfCustomer >= 0)
                {
                    var title = "Lỗi trùng lặp";
                    var msg = "Thông tin khách hàng này đã tồn tại!";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    _commonController.AddNewItem(_customers, customer);
                    tblCustomer.Rows.Add(new object[]
                    {
                    customer.PersonId, customer.FullName?.ToString(),customer.BirthDate.ToString(DATE_FORMAT),
                    customer.Address, customer.PhoneNumber, customer.CustomerType, $"{customer.Point:NO}",
                    customer.CreateTime.ToString(DATE_TIME_FORMAT), customer.Email
                    //
                    });
                }
            }
            else if (typeof(T) == typeof(Discount))
            {
                //hiển thị lên bảng khuyến mãi
                var discount = item as Discount;
                _commonController.AddNewItem(_discounts, discount);
                tblDiscount.Rows.Add(new object[]
                {
                    discount.DiscountId, discount.Name, discount.StartTime.ToString(DATE_TIME_FORMAT),
                    discount.EndTime.ToString(DATE_TIME_FORMAT), discount.DiscountType,
                    discount.DiscountPercent,$"{discount.DiscountPriceAmount:N0}"
                }
                    );
            }
            else if (typeof(T) == typeof(BillDetail))
            {
                var billDetail = item as BillDetail;
                if(_commonController.IndexOfItem(_bills, billDetail) >= 0)
                {
                    UpdataItem(item);
                    return;
                }
                _commonController.AddNewItem(_bills, billDetail);
                tblBill.Rows.Add(new object[]
                {
                   billDetail.BillId, billDetail.Cart?.Customer?.FullName?.ToString(),
                   billDetail.StaffName, billDetail.CreatedTime.ToString("dd/MM/yyyy HH:mm:ss"), 
                   $"{billDetail.TotalItem:N0}",
                   $"{billDetail.SubTotal:N0}",
                   $"{billDetail.TotalDiscountAmount:N0}",
                   $"{billDetail.TotalAmount:N0}",
                   billDetail.Status
                });
            }
        }

        public void UpdataItem<T>(T updatedItem)
        {
            if (typeof(T) == typeof(Item))
            {
                var newItem = updatedItem as Item;
                int updatedIndex = -1;
                if (_actionType == ActionType.NORMAL)
                {
                    updatedIndex = _commonController.UpdateItem(_items, newItem);
                }
                else
                {
                    updatedIndex = _commonController.UpdateItem(_searchItemResults, newItem);
                    _commonController.UpdateItem(_items, newItem);
                }

                tblItem.Rows.RemoveAt(updatedIndex);
                tblItem.Rows.Insert(updatedIndex, new object[]
                {
                    newItem.ItemId, newItem.ItemName, newItem.ItemType, newItem.Quantity,
                    newItem.Brand, newItem.ReleaseDate.ToString("dd/MM/yyyy"),$"{newItem.Price:N0}",
                    _itemController.GetDiscountName(newItem.Discount)
                });

            }
            else if (typeof(T) == typeof(Customer))
            {
                var customer = updatedItem as Customer;
                int updatedIndex = -1;
                if (_actionType == ActionType.NORMAL)
                {
                    updatedIndex = _commonController.UpdateItem(_customers, customer);
                }
                else
                {
                    updatedIndex = _commonController.UpdateItem(_searchCustomerResults, customer);
                    _commonController.UpdateItem(_customers, customer);
                }

                tblCustomer.Rows.RemoveAt(updatedIndex);
                tblCustomer.Rows.Insert(updatedIndex, new object[]
                    {
                    customer.PersonId, customer.FullName?.ToString(),customer.BirthDate.ToString(DATE_FORMAT),
                    customer.Address, customer.PhoneNumber, customer.CustomerType, $"{customer.Point:NO}",
                    customer.CreateTime.ToString(DATE_TIME_FORMAT), customer.Email
                    });
            }
            else if (typeof(T) == typeof(Discount))
            {
                var discount = updatedItem as Discount;
                int updatedIndex = -1;
                if (_actionType == ActionType.NORMAL)
                {
                    updatedIndex = _commonController.UpdateItem(_discounts, discount);
                }
                else
                {
                    updatedIndex = _commonController.UpdateItem(_searchDiscountResults, discount);
                    _commonController.UpdateItem(_discounts, discount);
                }

                tblDiscount.Rows.RemoveAt(updatedIndex);
                tblDiscount.Rows.Insert(updatedIndex, new object[]
                {
                    discount.DiscountId, discount.Name, discount.StartTime.ToString(DATE_TIME_FORMAT),
                    discount.EndTime.ToString(DATE_TIME_FORMAT), discount.DiscountType,
                    discount.DiscountPercent,$"{discount.DiscountPriceAmount:N0}"
                }
                    );
            }
            else if (typeof(T) == typeof(BillDetail))
            {
                var bill = updatedItem as BillDetail;
                if(_commonController.IndexOfItem(_bills, bill) == -1)
                {
                    AddNewItem(updatedItem);
                    return;
                }
                int updatedIndex = -1;
                if (_actionType == ActionType.NORMAL)
                {
                    updatedIndex = _commonController.UpdateItem(_bills, bill);
                }
                else
                {
                    updatedIndex = _commonController.UpdateItem(_searchedBillResults, bill);
                    _commonController.UpdateItem(_bills, bill);
                }

                tblBill.Rows.RemoveAt(updatedIndex);
                tblBill.Rows.Insert(updatedIndex, new object[]
               {
                   bill.BillId, bill.Cart?.Customer?.FullName?.ToString(),
                   bill.StaffName, bill.CreatedTime.ToString("dd/MM/yyyy HH:mm:ss"),
                   $"{bill.TotalItem:N0}",
                   $"{bill.SubTotal:N0}",
                   $"{bill.TotalDiscountAmount:N0}",
                   $"{bill.TotalAmount:N0}",
                   bill.Status
                });
            }
        }

        private void tblItemCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tblItem.Columns["tblItemEdit"].Index)
            {
                Item item = _items[e.RowIndex];
                if (_actionType == ActionType.SEARCH)
                {
                    item = _searchItemResults[e.RowIndex];
                }
                var updateItemView = new AddEditItemFrm(this, _discounts, item);
                updateItemView.Show();
            }
            //tblItemRemove
            else if (e.RowIndex >= 0 && e.ColumnIndex == tblItem.Columns["tblItemRemove"].Index)
            {
                var title = "Xác nhận xóa";
                var msg = "Bạn có chắc chắn muốn xóa bản ghi này không?";
                var ans = ShowConfirmDialog(msg, title);
                if (ans == DialogResult.Yes)
                {

                    int removeItemIndex = -1;
                    if (_actionType == ActionType.NORMAL)
                    {
                        Item item = _items[e.RowIndex];
                        item = _searchItemResults[e.RowIndex];
                        removeItemIndex = _commonController.DeleteItem(_items, item);
                    }
                    else if (_actionType == ActionType.SEARCH)
                    {
                        Item item = _searchItemResults[e.RowIndex];
                        removeItemIndex = _commonController.DeleteItem(_searchItemResults, item);
                        _commonController.DeleteItem(_items, item);
                    }
                    tblItem.Rows.RemoveAt(removeItemIndex);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private DialogResult ShowConfirmDialog(string msg, string title)
        {
            return MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void SortItemHandle(object sender, EventArgs e)
        {
            if (radioSortItemByPriceASC.Checked)
            {
                _commonController.Sort(_items, _itemController.CompareItemByPriceACS);
            }
            else if (radioSortItemByPriceDESC.Checked)
            {
                _commonController.Sort(_items, _itemController.CompareItemByPriceDECS);
            }
            else if (radioItemByQuantity.Checked)
            {
                _commonController.Sort(_items, _itemController.CompareItemByQuantity);
            }
            else if (radioSortItemByProductDate.Checked)
            {
                _commonController.Sort(_items, _itemController.CompareItemByDate);
            }
            else if (radioSortItemByName.Checked)
            {
                _commonController.Sort(_items, _itemController.CompareItemByName);
            }
            //if (radioSortItemByPriceASC.Equals(sender))
            //{
            //    _commonController.Sort(_items, _itemController.CompareItemByPriceACS);
            //}
            //else if (radioSortItemByPriceDESC.Equals(sender))
            //{
            //    _commonController.Sort(_items, _itemController.CompareItemByPriceDECS);
            //}
            //else if (radioItemByQuantity.Equals(sender))
            //{
            //    _commonController.Sort(_items, _itemController.CompareItemByQuantity);
            //}
            //else if (radioSortItemByProductDate.Equals(sender))
            //{
            //    _commonController.Sort(_items, _itemController.CompareItemByDate);
            //}
            //else if (radioSortItemByName.Equals(sender))
            //{
            //    _commonController.Sort(_items, _itemController.CompareItemByName);
            //}
            showItems(_items);

        }
        void showItems(List<Item> items)
        {
            tblItem.Rows.Clear();
            foreach (var item in items)
            {
                tblItem.Rows.Add(new object[]
                   {
                    item.ItemId, item.ItemName, item.ItemType, item.Quantity,
                    item.Brand, item.ReleaseDate.ToString("dd/MM/yyyy"),$"{item.Price:N0}",
                    item.Discount == null ? "-" : item.Discount.Name
                   });
            }
        }

        private void ComboSearchSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboSearchItem.SelectedIndex)
            {
                case 0:
                case 2:
                case 3:
                    txtSearchItem.Enabled = true;
                    numericItemFrom.Enabled = false;
                    numericItemTo.Enabled = false;
                    break;
                case 1:
                case 4:
                    txtSearchItem.Enabled = false;
                    numericItemFrom.Enabled = true;
                    numericItemTo.Enabled = true;
                    break;
                default:
                    break;

            }
        }

        private void btnSearchItemClick(object sender, EventArgs e)
        {
            tblItem.Rows.Clear();
            _actionType = ActionType.SEARCH;
            if (comboSearchItem.SelectedIndex == -1)
            {
                var msg = "Vui lòng chọn tiêu chí tìm kiếm để tiếp tục";
                var title = "Lỗi dữ liệu";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboSearchItem.SelectedIndex == 0)
            {
                var key = txtSearchItem.Text;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemNameMatch, key);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào!";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    showItems(_searchItemResults);
                }
            }
            else if (comboSearchItem.SelectedIndex == 1)// giá tiền
            {
                int from = (int)numericItemFrom.Value;
                int to = (int)numericItemTo.Value;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemPriceMatch, from, to);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào!";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    showItems(_searchItemResults);
                }
            }
            else if (comboSearchItem.SelectedIndex == 2)// loại mặt hàng
            {
                var key = txtSearchItem.Text;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemTypeMatch, key);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào!";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    showItems(_searchItemResults);
                }
            }
            else if (comboSearchItem.SelectedIndex == 3)// hãng
            {
                var key = txtSearchItem.Text;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemBrandMatch, key);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào!";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    showItems(_searchItemResults);
                }
            }
            else if (comboSearchItem.SelectedIndex == 4)// số lượng sp
            {
                int from = (int)numericItemFrom.Value;
                int to = (int)numericItemTo.Value;
                _searchItemResults = _commonController.Search(_items, _itemController.IsItemQuantityMatch, from, to);
                if (_searchItemResults.Count == 0)
                {
                    var msg = "Không tìm thấy kết quả nào!";
                    var title = "Kết quả tìm kiếm";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    showItems(_searchItemResults);
                }
            }
        }

        private void btnRefreshClick(object sender, EventArgs e)
        {
            _actionType = ActionType.NORMAL;
            if (sender.Equals(btnRefreshItem))
            {
                showItems(_items);
            }
            else if (sender.Equals(btnRefreshCustomer))
            {
                showCustomer(_customers);
            }
            else if (sender.Equals(btnRefreshDiscount))
            {
                showDiscount(_discounts);
            }
        }

        private void btnAddNewCustomerClick(object sender, EventArgs e)
        {
            var childView = new AddEditCustomerFrm(this, null);
            childView.Show();
        }

        private void tblCustomerCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tblCustomer.Columns["tblCustomerColEdit"].Index)
            {
                Customer customer = _customers[e.RowIndex];
                if (_actionType == ActionType.SEARCH)
                {
                    customer = _searchCustomerResults[e.RowIndex];
                }
                var updateCustomerView = new AddEditCustomerFrm(this, customer);
                updateCustomerView.Show();
            }
            //tblItemRemove
            else if (e.RowIndex >= 0 && e.ColumnIndex == tblCustomer.Columns["tblCustomerColRemove"].Index)
            {
                var title = "Xác nhận xóa";
                var msg = "Bạn có chắc chắn muốn xóa bản ghi này không?";
                var ans = ShowConfirmDialog(msg, title);
                if (ans == DialogResult.Yes)
                {

                    int removeCustomerIndex = -1;
                    if (_actionType == ActionType.NORMAL)
                    {
                        Customer customer = _customers[e.RowIndex];
                        removeCustomerIndex = _commonController.DeleteItem(_customers, customer);
                    }
                    else if (_actionType == ActionType.SEARCH)
                    {
                        Customer customer = _searchCustomerResults[e.RowIndex];
                        removeCustomerIndex = _commonController.DeleteItem(_searchCustomerResults, customer);
                        _commonController.DeleteItem(_customers, customer);
                    }
                    tblCustomer.Rows.RemoveAt(removeCustomerIndex);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RadioSortCheckCustomerCheckedChanged(object sender, EventArgs e)
        {
            if (radioSortCustomerById.Checked)
            {
                _commonController.Sort(_customers, _customerController.CompareCustomerById);
            }
            else if (radioSortCustomerByName.Checked)
            {
                _commonController.Sort(_customers, _customerController.CompareCustomerByName);

            }
            else if (radioSortCustomerByPoint.Checked)
            {
                _commonController.Sort(_customers, _customerController.CompareCustomerByPointDESC);

            }
            else if (radioSortCustomerByCreatedDate.Checked)
            {
                _commonController.Sort(_customers, _customerController.CompareCustomerByCreateDate);

            }
            else if (radioSortCustomerByBirthDate.Checked)
            {
                _commonController.Sort(_customers, _customerController.CompareCustomerByBirthDate);

            }
            showCustomer(_customers);

        }

        private void btnSearchCustomerClick(object sender, EventArgs e)
        {
            if (comboSearchCustomer.SelectedIndex == -1)
            {
                var title = "Lỗi dữ liệu";
                var msg = "Vui lòng chọn tiêu chí tìm kiếm trước.";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _actionType = ActionType.SEARCH;
                _searchCustomerResults.Clear();
                switch (comboSearchCustomer.SelectedIndex)
                {
                    case 0:
                        _searchCustomerResults.AddRange(_commonController.Search
                            (_customers, _customerController.IsCustomerNameMatch, txtSearchCustomer.Text));
                        break;
                    case 1:
                        _searchCustomerResults.AddRange(_commonController.Search
                            (_customers, _customerController.IsCustomerIdMatch, txtSearchCustomer.Text));
                        break;
                    case 2:
                        _searchCustomerResults.AddRange(_commonController.Search
                            (_customers, _customerController.IsCustomerTypeMatch, txtSearchCustomer.Text));
                        break;
                    case 3:
                        _searchCustomerResults.AddRange(_commonController.Search
                            (_customers, _customerController.IsCustomerAddressMatch, txtSearchCustomer.Text));
                        break;
                    case 4:
                        _searchCustomerResults.AddRange(_commonController.Search
                            (_customers, _customerController.IsCustomerPhoneMatch, txtSearchCustomer.Text));
                        break;
                    default:
                        break;

                }
                showCustomer(_searchCustomerResults);
                if (_searchCustomerResults.Count == 0)
                {
                    var title = "Kết quả tìm kiếm";
                    var msg = "Không tìm thấy kết quả nào";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAddNewDiscountClick(object sender, EventArgs e)
        {
            var childView = new AddEditDiscountFrm(this);
            childView.Show();
        }

        private void btnAddNewDicountClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tblDiscount.Columns["tblDiscountColEdit"].Index)
            {
                Discount discount = _discounts[e.RowIndex];
                if (_actionType == ActionType.SEARCH)
                {
                    discount = _searchDiscountResults[e.RowIndex];
                }
                var updateCustomerView = new AddEditDiscountFrm(this, discount);
                updateCustomerView.Show();
            }
            //tblItemRemove
            else if (e.RowIndex >= 0 && e.ColumnIndex == tblDiscount.Columns["tblDiscountColRemove"].Index)
            {
                var title = "Xác nhận xóa";
                var msg = "Bạn có chắc chắn muốn xóa bản ghi này không?";
                var ans = ShowConfirmDialog(msg, title);
                if (ans == DialogResult.Yes)
                {

                    int removeCustomerIndex = -1;
                    if (_actionType == ActionType.NORMAL)
                    {
                        Discount discount = _discounts[e.RowIndex];
                        removeCustomerIndex = _commonController.DeleteItem(_discounts, discount);
                    }
                    else if (_actionType == ActionType.SEARCH)
                    {
                        Discount discount = _searchDiscountResults[e.RowIndex];
                        removeCustomerIndex = _commonController.DeleteItem(_searchDiscountResults, discount);
                        _commonController.DeleteItem(_discounts, discount);
                    }
                    tblDiscount.Rows.RemoveAt(removeCustomerIndex);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSearchDiscountClick(object sender, EventArgs e)
        {
            if (comboSearchDiscount.SelectedIndex == -1)
            {
                var title = "Lỗi tìm kiếm";
                var msg = "Vui lòng chọn tiêu chí tìm kiếm trước";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtSearchDiscount.Text))
            {
                var title = "Lỗi tìm kiếm";
                var msg = "Vui lòng nhập giá trị cần tìm kiếm trước";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var key = txtSearchDiscount.Text;
                _actionType = ActionType.SEARCH;
                _searchDiscountResults.Clear();
                switch (comboSearchDiscount.SelectedIndex)
                {
                    case 0:
                        _searchDiscountResults.AddRange(_commonController.Search
                            (_discounts, _discountController.IsStartTimeMatch, txtSearchDiscount.Text));
                        break;
                    case 1:
                        _searchDiscountResults.AddRange(_commonController.Search
                            (_discounts, _discountController.IsEndTimeMatch, txtSearchDiscount.Text));
                        break;
                    case 2:
                        _searchDiscountResults.AddRange(_commonController.Search
                            (_discounts, _discountController.IsDiscountNameMatch, txtSearchDiscount.Text));
                        break;
                }
            }
            showDiscount(_searchDiscountResults);
            if (_searchDiscountResults.Count == 0)
            {
                var title = "Kết quả tìm kiếm";
                var msg = "Không tìm thấy kết quả nào";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddNewBillClick(object sender, EventArgs e)
        {
            var createBillView = new AddEditBillFrm(this ,_customers, _items, _bills, _commonController);
            createBillView.Show();
        }
        public void Remove<T>(T item)
        {
            if(typeof(T) == typeof(BillDetail))
            {
                //xóa trong bảng hóa đơn
                showBills(_bills);
            }
        }

        private void tblCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tblBill.Columns["tblBillColViewDetail"].Index)
            {
                var bill = _bills[e.RowIndex];
                var createBillView = new AddEditBillFrm(this, _customers, _items, _bills, _commonController, bill);
                createBillView.Show();
            }
        }

        private void btnRefreshBillClick(object sender, EventArgs e)
        {
            showBills(_bills);
        }

        private void showBills(List<BillDetail> bills)
        {
            tblBill.Rows.Clear();
            foreach (var bill in bills)
            {              
                var billDetail = bill;              
                tblBill.Rows.Add(
                    new object[]{
                   billDetail.BillId, billDetail.Cart?.Customer?.FullName?.ToString(),
                   billDetail.StaffName, billDetail.CreatedTime.ToString("dd/MM/yyyy HH:mm:ss"),
                   $"{billDetail.TotalItem:N0}",
                   $"{billDetail.SubTotal:N0}",
                   $"{billDetail.TotalDiscountAmount:N0}",
                   $"{billDetail.TotalAmount:N0}",
                   billDetail.Status
                });
            }
        }

        private void MenuItemSaveDataClick(object sender, EventArgs e)
        {
            _ioController.SaveDataList(_items, _customers, _discounts, _bills);
            var title = "Thông báo";
            var message = "Lưu file dữ liệu ra thành công";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SortBill(object sender, EventArgs e)
        {
            switch(comboSortBill.SelectedIndex)
            {
                case 0:
                    _commonController.Sort(_bills, _billSorter.CompareBillTotalItems);
                    break; 
                case 1:
                    _commonController.Sort(_bills, _billSorter.CompareBillTotalAmount);
                    break;
                case 2:
                    _commonController.Sort(_bills, _billSorter.CompareBillByCreatedDateTimeASC);
                    break;
                case 3:
                    _commonController.Sort(_bills, _billSorter.CompareBillByCreatedDateTimeDSC);
                    break;
                case 4:
                    _commonController.Sort(_bills, _billSorter.CompareBillByCustomerName);
                    break;
            }
            showBills(_bills);
        }

        private void btnSearchBillClick(object sender, EventArgs e)
        {
            if(comboSearchBill.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm trước!", "Lỗi tìm kiếm", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }else if(txtSearchBill.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập giá trị cần tìm kiếm trước!", "Lỗi tìm kiếm",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                BillFinder finder= new BillFinder();
                _actionType = ActionType.SEARCH;
                _searchedBillResults.Clear();
                switch(comboSearchBill.SelectedIndex)
                {
                    case 0:
                        _searchedBillResults.AddRange(
                            _commonController.Search(
                                _bills, finder.IsBillCreateTimeMatch, txtSearchBill.Text));
                        break;
                    case 1:
                        _searchedBillResults.AddRange(
                            _commonController.Search(
                                _bills, finder.IsBillCustomerNameMatch, txtSearchBill.Text));
                        break;
                    case 2:
                        _searchedBillResults.AddRange(
                            _commonController.Search(
                                _bills, finder.IsBillStatusMatch, txtSearchBill.Text));
                        break;
                    case 3:
                        _searchedBillResults.AddRange(
                            _commonController.Search(
                                _bills, finder.IsBillStaffNameMatch, txtSearchBill.Text));
                        break;
                }
                showBills(_searchedBillResults);
                if (_searchedBillResults.Count == 0)
                {
                    var title = "Kết quả tìm kiếm";
                    var msg = "Không tìm thấy kết quả nào!";
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

 using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    //thao tac doc/ghi du lieu
    public interface IIOController
    {
        void WriteData(object obj, string fileName);
        List<T> ReadData<T>(string fileName, string root);
        void LoadDataList(List<Item> items, List<Customer> customers,
            List<Discount> discounts, List<BillDetail> billDetails);
        bool SaveDataList(List<Item> items, List<Customer> customers,
            List<Discount> discounts, List<BillDetail> billDetails);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    //hanh dong chung them/sua/xoa/tim kiem/sap xep
    public delegate bool FindItemDelegate1<T, V>(T item, V value);
    public delegate bool FindItemDelegate2<T, V>(T item, V from, V to);
    public interface ICommonController
    {
        void AddNewItem<T> (List<T> items,T item);
        int UpdateItem<T> (List<T> values, T item);
        int DeleteItem<T>(List<T> items, T item);
        int IndexOfItem<T>(List<T> items, T item);
        void Sort<T> (List<T> items, Comparison<T> comparer);
        List<T> Search<T, V>(List<T> items, FindItemDelegate1<T, V> del, V value);
        List<T> Search<T, V>(List<T> items, FindItemDelegate2<T, V> del, V from, V to);

    }
}

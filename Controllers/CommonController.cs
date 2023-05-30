using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CommonController : ICommonController
    {
        public void AddNewItem<T>(List<T> items, T item)
        {
            items.Add(item);
        }

        public int DeleteItem<T>(List<T> items, T item)
        {
            int index = IndexOfItem(items, item);   
            if(index != -1)
            {
                items.RemoveAt(index);
            }
            return index;   
        }

        public int IndexOfItem<T>(List<T> items, T item)
        {
            return items.IndexOf(item);
        }

        public List<T> Search<T, V>(List<T> items, FindItemDelegate1<T, V> del, V value)
        {
            List<T> _searchItemResults = new List<T>();
            foreach(var item in items)
            {
                if(del(item, value))
                {
                    _searchItemResults.Add(item);
                }
            }
            return _searchItemResults;
        }

        public List<T> Search<T, V>(List<T> items, FindItemDelegate2<T, V> del, V from, V to)
        {
            List<T> _searchItemResults = new List<T>();
            foreach (var item in items)
            {
                if (del(item, from, to))
                {
                    _searchItemResults.Add(item);
                }
            }
            return _searchItemResults;
        }

        public void Sort<T>(List<T> items, Comparison<T> comparer)
        {
            items.Sort(comparer);
        }

        public int UpdateItem<T>(List<T> values, T item)
        {
            int index = IndexOfItem(values, item);
            if (index >= 0)
            {
                values.RemoveAt(index);
                values.Insert(index, item);
            }            
            return index;
        }
    }
}

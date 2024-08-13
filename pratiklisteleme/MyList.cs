using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratiklisteleme
{
    public class MyList<T>
    {
        T[] _array;
        T[] _tamparray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tamparray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tamparray.Length; i++)
            {
                _array[i] = _tamparray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }
        public T this[int index]
        {
            get
            {
                return _array[index];
            }

        }
    }
}

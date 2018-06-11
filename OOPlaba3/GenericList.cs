using System;
using System.Collections;

namespace OOPlaba2
{
    public class GenericList<T> : IEnumerable
    { 
        public T[] Storage;

        public GenericList(int capacity = 16)
        {
            if(capacity<1)
                throw new ArgumentOutOfRangeException(nameof(capacity), "Размерность неправильная");
            Storage = new T[capacity];
        }

        public int Count { get; set; }

        public void Add(T obj){ }
        public void AddRange(T obj) { }
        public void RemoveAt(int index) { }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        internal int Sum(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}

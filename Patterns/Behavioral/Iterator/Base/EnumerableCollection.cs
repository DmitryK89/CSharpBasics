using System;
using System.Collections;
using System.Collections.Generic;

namespace Patterns.Behavioral.Iterator.Base
{
    public class EnumerableCollection : IEnumerable
    {
        public List<int> _collection = new List<int> {1, 2, 3};

        public int this[int index]
        {
            get => _collection[index];
            set => _collection.Insert(index, value);
        }

        public int Count { get => _collection.Count; }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
    }
}
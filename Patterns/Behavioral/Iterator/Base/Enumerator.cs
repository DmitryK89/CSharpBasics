using System.Collections;

namespace Patterns.Behavioral.Iterator.Base
{
    public class  Enumerator : IEnumerator
    {
        private EnumerableCollection _collection;
        private int _current = -1;
        public Enumerator(EnumerableCollection collection)
        {
            _collection = collection;
        }

        public bool MoveNext()
        {
            if (_current < _collection.Count - 1)
            {
                _current++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _current = -1;
        }

        public object Current { get=>_collection[_current]; }
    }
}
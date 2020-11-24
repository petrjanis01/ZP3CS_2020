using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture9
{
    public class IntList : IEnumerable<int>
    {
        private int[] _arrayOfNumbers;

        public int Count => _arrayOfNumbers.Length;

        public IntList()
        {
            _arrayOfNumbers = new int[0];
        }

        public int this[int index]
        {
            get => _arrayOfNumbers[index];
            set => _arrayOfNumbers[index] = value;
        }

        public void Add(int number)
        {
            EnsureCapacity();
            _arrayOfNumbers[Count - 1] = number;
        }

        private void EnsureCapacity()
        {
            var tmp = _arrayOfNumbers;
            _arrayOfNumbers = new int[Count + 1];

            for (var i = 0; i < tmp.Length; i++)
            {
                _arrayOfNumbers[i] = tmp[i];
            }
        }

        public void Remove()
        {
            var tmp = _arrayOfNumbers;
            _arrayOfNumbers = new int[Count - 1];

            for (var i = 0; i < tmp.Length - 1; i++)
            {
                _arrayOfNumbers[i] = tmp[i];
            }
        }

        public int IndexOf(int number)
        {
            for (var i = 0; i < Count; i++)
            {
                if (_arrayOfNumbers[i] == number)
                {
                    return i;
                }
            }

            return -1;
        }

        public int LastIndexOf(int number)
        {
            var index = -1;

            for (var i = 0; i < Count; i++)
            {
                if (_arrayOfNumbers[i] == number)
                {
                    index = i;
                }
            }

            return index;
        }

        public void Sort()
        {
            _arrayOfNumbers = _arrayOfNumbers.OrderBy(n => n).ToArray();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new IntArrayEnumerator(_arrayOfNumbers);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static IntList operator +(IntList list1, IntList list2)
        {
            foreach (var number in list2)
            {
                list1.Add(number);
            }

            return list1;
        }

        public static IntList operator -(IntList list1, IntList list2)
        {
            var newList = new IntList();

            foreach (var number in list1)
            {
                if (list2.IndexOf(number) == -1)
                {
                    newList.Add(number);
                }
            }

            return newList;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            foreach (var number in _arrayOfNumbers)
            {
                builder.Append($"{number} ");
            }

            return builder.ToString();
        }

        internal class IntArrayEnumerator : IEnumerator<int>
        {
            private int[] _array;

            private int _index;

            public IntArrayEnumerator(int[] array)
            {
                _array = array;
                _index = -1;
            }

            public void Dispose()
            {
                _array = null;
            }

            public bool MoveNext()
            {
                _index++;
                return _index < _array.Length;
            }

            public void Reset()
            {
                _index = -1;
            }

            public int Current => _array[_index];

            object IEnumerator.Current => Current;
        }
    }
}

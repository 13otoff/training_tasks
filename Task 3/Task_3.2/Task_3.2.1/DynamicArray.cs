using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_3._2._1
{
    class DynamicArray<T>: IEnumerable<T>
    {
        private int length;
        private T[] data;
        private int capacity = 8;

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value >= length && value > 0)
                    capacity = value;
                else
                    throw new ArgumentOutOfRangeException("Capacity can not be less length");
            }
        }

        public int Length => length;

        private void Doubler(int length)
        {
            while (Capacity <= length)
            {
                Capacity *= 2;
            }

            T[] tempArr = new T[Capacity];
            data.CopyTo(tempArr, 0);
            data = tempArr;
        }
        public DynamicArray()
        {

        }
        public DynamicArray(int capacity)
        {
            Capacity = capacity;
            data = new T[capacity];
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            if (collection == null || collection.Count() == 0)
                data = new T[capacity];

            data = collection.ToArray();
            length = data.Length;
            Doubler(length);
        }

        public void Add(T item)
        {
            Doubler(Length);
            data[length++] = item;
        }

        public void AddRange(IEnumerable<T> elements)
        {
            var newElements = elements.ToArray();
            Doubler(Length + newElements.Length);

            Array.Copy(newElements, 0, data, Length, newElements.Length);

            length += newElements.Length;
        }

        public bool Remove(T item)
        {
            bool res = data.Contains(item);
            if (res)
                RemoveAt(IndexOf(item));

            return res;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (data[i]?.Equals(item) ?? false)
                {
                    return i;
                }
            }

            return -1;
        }

        public void RemoveAt(int index)
        {
            if (index <= 0 && index > Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            length--;
            for (int i = index; i < Length; i++)
            {
                data[i] = data[i + 1];
            }
        }

        public void Insert(int index, T item)
        {
            if (index <= 0 && index > Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            Doubler(Length);

            for (int i = Length; i > index; i--)
            {
                data[i] = data[i - 1];
            }

            length++;
            data[index] = item;
        }

        public T this[int index]
        {
            get
            {
                if (index > Length)
                    throw new ArgumentOutOfRangeException(nameof(index));

                if (index < 0)
                    return data[Length + index];
                else
                    return data[index];
            }

            set
            {
                if (index <= 0 && index > Length)
                    throw new ArgumentOutOfRangeException(nameof(index));

                if (index < 0)
                    data[Length + index] = value;
                else
                    data[index] = value;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return data[i];
            }   
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return data[i];
            }
        }
    }
}

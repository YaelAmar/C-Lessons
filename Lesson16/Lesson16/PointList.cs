using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    class PointList : ArrayList
    {
        public override object this[int index] { get => base[index]; set => base[index] = value; }

        public override int Capacity { get => base.Capacity; set => base.Capacity = value; }

       
        public override int Count => base.Count;


        public override bool IsFixedSize => base.IsFixedSize;

        public override bool IsReadOnly => base.IsReadOnly;

        public override bool IsSynchronized => base.IsSynchronized;

        public override object SyncRoot => base.SyncRoot;

        public override int Add(object value)
        {
            return base.Add(value);
        }

        public override void AddRange(ICollection c)
        {
            base.AddRange(c);
        }

        public override int BinarySearch(int index, int count, object value, IComparer comparer)
        {
            return base.BinarySearch(index, count, value, comparer);
        }

        public override int BinarySearch(object value)
        {
            return base.BinarySearch(value);
        }

        public override int BinarySearch(object value, IComparer comparer)
        {
            return base.BinarySearch(value, comparer);
        }

        public override void Clear()
        {
            base.Clear();
        }

        public override object Clone()
        {
            return base.Clone();
        }
       

        public override bool Contains(object item)
        {
            return base.Contains(item);
        }

        public override void CopyTo(Array array)
        {
            base.CopyTo(array);
        }

        public override void CopyTo(Array array, int arrayIndex)
        {
            base.CopyTo(array, arrayIndex);
        }

        public override void CopyTo(int index, Array array, int arrayIndex, int count)
        {
            base.CopyTo(index, array, arrayIndex, count);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override IEnumerator GetEnumerator()
        {
            return base.GetEnumerator();
        }

        public override IEnumerator GetEnumerator(int index, int count)
        {
            return base.GetEnumerator(index, count);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override ArrayList GetRange(int index, int count)
        {
            return base.GetRange(index, count);
        }

        public override int IndexOf(object value)
        {
            return base.IndexOf(value);
        }

        public override int IndexOf(object value, int startIndex)
        {
            return base.IndexOf(value, startIndex);
        }

        public override int IndexOf(object value, int startIndex, int count)
        {
            return base.IndexOf(value, startIndex, count);
        }

        public override void Insert(int index, object value)
        {
            base.Insert(index, value);
        }

        public override void InsertRange(int index, ICollection c)
        {
            base.InsertRange(index, c);
        }

        public override int LastIndexOf(object value)
        {
            return base.LastIndexOf(value);
        }

        public override int LastIndexOf(object value, int startIndex)
        {
            return base.LastIndexOf(value, startIndex);
        }

        public override int LastIndexOf(object value, int startIndex, int count)
        {
            return base.LastIndexOf(value, startIndex, count);
        }

        public override void Remove(object obj)
        {
            base.Remove(obj);
        }

        public override void RemoveAt(int index)
        {
            base.RemoveAt(index);
        }

        public override void RemoveRange(int index, int count)
        {
            base.RemoveRange(index, count);
        }

        public override void Reverse()
        {
            base.Reverse();
        }

        public override void Reverse(int index, int count)
        {
            base.Reverse(index, count);
        }

        public override void SetRange(int index, ICollection c)
        {
            base.SetRange(index, c);
        }

        public override void Sort()
        {
            base.Sort();
        }

        public override void Sort(IComparer comparer)
        {
            base.Sort(comparer);
        }

        public override void Sort(int index, int count, IComparer comparer)
        {
            base.Sort(index, count, comparer);
        }

        public override object[] ToArray()
        {
            return base.ToArray();
        }

        public override Array ToArray(Type type)
        {
            return base.ToArray(type);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void TrimToSize()
        {
            base.TrimToSize();
        }
    }
}

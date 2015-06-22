using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tmds.MDns
{
	public class HashSet<T> : ICollection<T>
	{
		readonly Dictionary<T, int> _values = new Dictionary<T, int>();

		public HashSet()
		{
		}

		public HashSet(IEnumerable<T> items)
		{
			foreach (var i in items)
			{
				Add(i);
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			return _values.Keys.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(T item)
		{
			_values.Add(item, 1);
		}

		public void Clear()
		{
			_values.Clear();
		}

		public bool Contains(T item)
		{
			return _values.ContainsKey(item);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			_values.Keys.CopyTo(array, arrayIndex);
		}

		public bool Remove(T item)
		{
			return _values.Remove(item);
		}

		public int Count { get { return _values.Count; }}
		public bool IsReadOnly { get { return false; }  }
	}
}

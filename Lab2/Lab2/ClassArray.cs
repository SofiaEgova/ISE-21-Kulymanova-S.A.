using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class ClassArray<T> where T:ITransport
	{
		private T[] places;
		private T defaultValue;

		public ClassArray(int size, T defVal)
		{
			defaultValue = defVal;
			places = new T[size];
			for(int i = 0; i < places.Length; i++)
			{
				places[i] = defaultValue;
			}
		}

		public static int operator +(ClassArray<T> p, T plane)
		{
			for(int i = 0; i < p.places.Length; i++)
			{
				if (p.checkFree(i))
				{
					p.places[i] = plane;
					return i;
				}
			}
			return -1;
		}

		public static T operator -(ClassArray<T> p, int index)
		{
			if (!p.checkFree(index))
			{
				T plane = p.places[index];
				p.places[index] = p.defaultValue;
				return plane;
			}
			return p.defaultValue;
		}

		public bool checkFree(int index)
		{
			if (index < 0 || index > places.Length) return false;
			if (places[index] == null) return true;
			if (places[index].Equals(defaultValue)) return true;

			return false;
		}

		public T getObject(int index)
		{
			if (index > -1 && index < places.Length) return places[index];

			return defaultValue;
		}

	}
}

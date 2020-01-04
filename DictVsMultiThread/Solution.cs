using System.Collections.Generic;

namespace org.pv.AlgoPlayground.DictVsMultiThread
{
	public class Provider<T, V>
	{
		private Provider<T, V> _SinleInstance;
		private Dictionary<T, V> storage; 

		private object locker = new object();

		private Provider()
		{
			storage = new Dictionary<T, V>();
		}

		public Provider<T, V> GetInstance()
		{
			if(_SinleInstance == null)
			lock(locker)
			{
				_SinleInstance = new Provider<T, V>();
			}

			return _SinleInstance;
		}


		// API
		public void Insert(T key, V value)
		{
			storage[key] = value;
		}

		public V Get(T key)
		{
			if(storage.ContainsKey(key))
				return storage[key];

			return default(V);
		}
	}
}
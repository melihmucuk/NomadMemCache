using System;
using System.Runtime.Caching;

namespace NomadMemCache
{
    public class Cacher
    {
        public static readonly Cacher Instance = new Cacher();
        private static readonly MemoryCache Cache = MemoryCache.Default;

        Cacher(){}

        public T GetValue<T>(string key)
        {
            return (T)Cache.Get(key);
        }

        public bool Add(string key, object value, DateTimeOffset absExpiration)
        {
            return Cache.Add(key, value, absExpiration);
        }
        
        public void Delete(string key)
        {
            if (Cache.Contains(key))
                Cache.Remove(key);
        }

        
    }
}

using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;

namespace CoreArchitecture.API.Controllers
{
    public class MemoryCacheController
    {
        const string cacheKey = "xKey";
        private readonly IMemoryCache _memCache;
        public MemoryCacheController(IMemoryCache memCache)
        {
            _memCache = memCache;
        }
        public MemoryCacheEntryOptions ConfiguretMemoryCache(int absouluteExpiration = 30)
        {
            var cacheExpOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddMinutes(absouluteExpiration),
                Priority = CacheItemPriority.Normal
            };
            return cacheExpOptions;
        }

        public void SetMemoryCache(MemoryCacheEntryOptions cacheEntryOptions, List<object> dataList)
        {
            _memCache.Set(cacheKey, dataList, cacheEntryOptions);
        }

        public void DeleteCache()
        {
            _memCache.Remove(cacheKey);
        }
    }
}

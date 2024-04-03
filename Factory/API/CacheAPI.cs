using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory.API
{
    public class CacheAPI
    {
        private readonly ICacheService _cacheService;

        public CacheAPI(ICacheServiceFactory cacheServiceFactory)
        {
            _cacheService = cacheServiceFactory.CreateCacheService();
        }

        public void SetCacheForSevenDays()
        {
            _cacheService.SetCacheForDays(7);
        }

        public void SetCacheForOneDay()
        {
            _cacheService.SetCacheForDays(1);
        }

        public void SetCacheForThirtyDays()
        {
            _cacheService.SetCacheForDays(30);
        }
    }
}
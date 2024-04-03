using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory.Service
{
    public class CacheServiceFactory : ICacheServiceFactory
    {
        public ICacheService CreateCacheService()
        {
            return new CacheService();
        }

    }
}
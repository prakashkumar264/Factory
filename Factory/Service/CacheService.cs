using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory.Service
{
    public class CacheService : ICacheService
    {
        public void SetCacheForDays(int days)
        {
            Console.WriteLine($"Setting cache for {days} days.");
        }
    }
}
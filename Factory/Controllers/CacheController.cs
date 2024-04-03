using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Factory.API;
using Factory.Interfaces;

namespace Factory.Controllers
{
    [System.Web.Http.RoutePrefix("api/cache")]
    public class CacheController : ApiController
    {
        // GET: Cache
        private readonly CacheAPI _cacheAPI;

        public CacheController(ICacheServiceFactory cacheServiceFactory)
        {
            _cacheAPI = new CacheAPI(cacheServiceFactory);
        }

        [Route("setcache/sevendays")]
        [HttpPost]
        public IHttpActionResult SetCacheForSevenDays()
        {
            _cacheAPI.SetCacheForSevenDays();
            return Ok();
        }

        [Route("setcache/oneday")]
        [HttpPost]
        public IHttpActionResult SetCacheForOneDay()
        {
            _cacheAPI.SetCacheForOneDay();
            return Ok();
        }

        [Route("setcache/thirtydays")]
        [HttpPost]
        public IHttpActionResult SetCacheForThirtyDays()
        {
            _cacheAPI.SetCacheForThirtyDays();
            return Ok();
        }
    }
}
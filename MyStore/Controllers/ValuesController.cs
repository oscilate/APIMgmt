using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyStore.Controllers
{
    public class ValuesController : ApiController
    {
        private static List<string> store=new List<string>(); 
        // GET api/values
        public IEnumerable<string> Get()
        {
            return store;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return store[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            store.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            store[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            store.RemoveAt(id);
        }
    }
}

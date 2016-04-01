using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vote_WebAPI_.Models;

namespace Vote_WebAPI_.Controllers
{
    public class VoiceController : ApiController
    {
        // GET api/values

        ContexDB db = new ContexDB(); 
        public IEnumerable<User> Get()
        {

            return db.Users.ToList();//new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
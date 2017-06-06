using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vote_WebAPI_.Models;
using Vote_WebAPI_.DAL;

namespace Vote_WebAPI_.Controllers
{
    public class VoiceController : ApiController
    {
        // GET api/values

   
        public IEnumerable<User> Get()
        {
         using(UnitOfWork uow = new UnitOfWork())
         {
             return uow.User.GetAll().ToList();
         }  

    
            //return db.Users.ToList();//new string[] { "value1", "value2" };
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
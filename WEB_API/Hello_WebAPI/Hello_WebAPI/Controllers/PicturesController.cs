using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics;
using Hello_WebAPI.Models;

namespace Hello_WebAPI.Controllers
{
    public class PicturesController : ApiController
    {

        List<Picture> Pictures = new List<Picture>{
            new Picture { Id = 1, Title = "Spring", Author = "Unknown author", Price = 50 }, 
            new Picture { Id = 2, Title = "Flowers", Author = "Best master", Price = 400.99M }, 
            new Picture { Id = 3, Title = "Forest", Author = "Master", Price = 100.99M } 
        };

        public IEnumerable<Picture> GetAllPictures()
        {
            return Pictures;
        }

        public IHttpActionResult GetPicture(int id)
        {
            var Picture = Pictures.FirstOrDefault((p) => p.Id == id);
            if (Picture == null)
            {
                return NotFound();
            }
            return Ok(Picture);
        }
        private void Debug_write()
                {
                    Debug.WriteLine("\r\nNew request processing");
                    foreach (var item in Pictures)
                    {
                        Debug.WriteLine("Picture Id {0}, Title {1}, Author {2}, Price {3}",item.Id, item.Title,item.Author,item.Price);
                    }
                }

        // POST api/Pictures
        public HttpResponseMessage PostPicture(Picture value)
        {
            try
            {
                Pictures.Add(value);
                Debug_write();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // PUT api/values/1
        public HttpResponseMessage PutPicture(int id, Picture value)      
        {
            try
            {
                    Picture found_pict = Pictures.SingleOrDefault<Picture>(b => b.Id == id);
                    if(!(found_pict == null))
                    {
                        found_pict.Title = value.Title;
                        found_pict.Author = value.Author;
                        found_pict.Price = value.Price;
                        Debug_write();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError);
                    }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // DELETE api/values/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                    Picture found_pict = Pictures.SingleOrDefault<Picture>(b => b.Id == id);
                    if (!(found_pict == null))
                    {
                        Pictures.RemoveAt(id);
                        Debug_write();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError);
                    }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookOfKnowledge.RESTAPI.Controllers
{
    [RoutePrefix("Rekv")]
    public class BookController : ApiController
    {

        [HttpGet]
        [Route("Books")]
        public List<string> ListBooks()
        {

            List<string> listOfBooks = new List<string>();

            listOfBooks.Add("Book Of Islam");
            listOfBooks.Add("Book Of Iman");
            listOfBooks.Add("Book Of Salah");




            return listOfBooks;
        }

        // GET: api/Book/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Book
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Book/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Book/5
        public void Delete(int id)
        {
        }
    }
}

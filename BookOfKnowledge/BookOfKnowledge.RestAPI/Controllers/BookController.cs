using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookOfKnowledge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET: api/Book
        [HttpGet]
        public List<Models.Book.Book> GetBookList()
        {          
           return new BookOfKnowledge.DataService.BookDataService().ListBooks();
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "GetBook")]
        public Models.Book.Book GetBook(int id)
        {
            return new BookOfKnowledge.DataService.BookDataService().FindBookById(id);
        }

        // POST: api/Book
        [HttpPost]
        public Models.Book.Book Post([FromBody] Models.Book.Book book) // create a book
        {         
            return new BookOfKnowledge.DataService.BookDataService().CreateBook(book);  
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public Models.Book.Book Put(int id, [FromBody] Models.Book.Book book) // Update a book
        {

            return new BookOfKnowledge.DataService.BookDataService().UpdateBook(id, book);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Models.Book.Book Delete(int id)
        {
            return new BookOfKnowledge.DataService.BookDataService().DeleteBook(id);
        }
    }
}

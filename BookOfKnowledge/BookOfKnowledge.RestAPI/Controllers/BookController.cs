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
        public Models.Book.Book Put([FromBody] Models.Book.Book book) // Update a book
        {

            return new BookOfKnowledge.DataService.BookDataService().UpdateBook(book);

            //var updateBook = GetBook(book.Id);
            //if (updateBook != null)
            //{
            //    Console.WriteLine("Add New Title: ");
            //    book.Title = Console.ReadLine();
            //    Console.WriteLine("Add New Description");
            //    book.Description = Console.ReadLine();

            //    return new BookOfKnowledge.DataService.BookDataService().UpdateBook(book);
            //}
            //else
            //{
            //    throw new System.InvalidOperationException("Book was not Found");
            //}
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<Models.Book.Book> Delete(int id)
        {
            return new BookOfKnowledge.DataService.BookDataService().DeleteBook(id);
        }
    }
}

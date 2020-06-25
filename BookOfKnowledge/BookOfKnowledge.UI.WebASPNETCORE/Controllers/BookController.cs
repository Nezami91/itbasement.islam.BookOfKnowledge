using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FastMember;
using Microsoft.AspNetCore.Mvc;

namespace BookOfKnowledge.UI.WebASPNETCORE.Controllers
{
    public class BookController : Controller
    {
        BookOfKnowledge.Service.Book.BookService bookService = new Service.Book.BookService();
        

        public IActionResult Index()
        {
            var bookList = bookService.ListBooks().ToList();
           
            return View(bookList);
          
        }

        public IActionResult ListBooks()
        {
            var bookList = bookService.ListBooks().ToList();

            return Ok(bookList);
        }

        public IActionResult GetList()
        {

            var bookList = bookService.ListBooks().ToList();
            return View(bookList);

        }

        public IActionResult Create([Bind] BookOfKnowledge.Models.Book.Book book)
        {
            return View();
        }

        public IActionResult Update(int id, [Bind] BookOfKnowledge.Models.Book.Book book)
        {
            try
            {
                bookService.UpdateBook(id, book);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }                      
        }

        public IActionResult Delete(int id)
        {
            try
            {
                bookService.DeleteBook(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
          
        }
        public IActionResult CreateOrUpdate(int id, [Bind] BookOfKnowledge.Models.Book.Book book)
        {
            return View();
        }
    }
}

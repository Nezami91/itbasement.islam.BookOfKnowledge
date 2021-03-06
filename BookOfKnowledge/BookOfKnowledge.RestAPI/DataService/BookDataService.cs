﻿using BookOfKnowledge.Models.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.ProjectModel;
using BookOfKnowledge.RestAPI.DataService;

namespace BookOfKnowledge.DataService
{
    public class BookDataService : IBookDataService
    {
        private readonly BookOfKnowledge.Service.Book.BookService _bookService ;

        public BookDataService()
        {
            _bookService = new Service.Book.BookService();
        }

        //public BookDataService(BookOfKnowledge.Service.Book.BookService bookService)
        //{
        //    _bookService = new Service.Book.BookService();
        //}
      
        public List<Models.Book.Book> ListBooks()
        {
            return _bookService.ListBooks();     
        }

        public Models.Book.Book FindBookById(int bookReferenceId)
        {
            return _bookService.FindBookById(bookReferenceId);
        }

        public Models.Book.Book DeleteBook(int id)
        {
            return _bookService.DeleteBook(id);           
        }

        public Models.Book.Book CreateBook(Models.Book.Book book)
        {
            return _bookService.CreateBook(book);
        }
        public Models.Book.Book UpdateBook(int id, Models.Book.Book book)
        {
            return _bookService.UpdateBook(id, book);
        }
    }
}

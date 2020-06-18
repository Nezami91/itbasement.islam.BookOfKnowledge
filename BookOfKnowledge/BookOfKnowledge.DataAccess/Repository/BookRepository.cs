using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BookOfKnowledge.Models.Book;
using Dapper;
using DapperExtensions;
using Microsoft.AspNetCore.Mvc;


namespace BookOfKnowledge.DataAccess.Repository
{
    public class BookRepository : BookOfKnowledge.DataAccess.Repository.IBookRepository
    {
        private string _labsysConnectionString = "Data Source=EUHMBWS009;Initial Catalog=BookOfKnowledge;Integrated Security=false;User Id = sa; Password = milanax11";


        public List<BookOfKnowledge.Models.Book.Book> ListBooks()
        {
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Book_List";

            using (var _connection = new SqlConnection(_labsysConnectionString))
            {
                var listOfBooksFromDatabase =
                    _connection.Query<Models.Book.Book>(sqlStoredProcedure, CommandType.StoredProcedure).ToList();

                if (listOfBooksFromDatabase.Any())
                {
                    return listOfBooksFromDatabase;
                }
            }
            throw new InvalidExpressionException("Nothing from the data base");
        }

        public Models.Book.Book FindBookById(int bookReferenceId)
        {
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Book_GetById";

            using (var _connection = new SqlConnection(_labsysConnectionString))
            {
                var bookListFromDatabase =
                    _connection.Query<Models.Book.Book>(sqlStoredProcedure, new { Id = bookReferenceId }, commandType: CommandType.StoredProcedure).ToList();

                return bookListFromDatabase.Find(x => x.Id == bookReferenceId);
            }
        }

        public Models.Book.Book CreateBook(Models.Book.Book book)
        {
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Book_Create";

            using (var _connection = new SqlConnection(_labsysConnectionString))
            {
                _connection.Query<Models.Book.Book>(sqlStoredProcedure,
                    new { Title = book.Title, Description = book.Description }, commandType: CommandType.StoredProcedure);

                //var createdBook = ListBooks().Find(x => x.Id == book.Id);

                var message = new HttpResponseMessage(HttpStatusCode.OK);

            }

            return ListBooks().Find(x => x.Id == book.Id);
        }

        public Models.Book.Book UpdateBook(int id, Models.Book.Book book)
        {
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Book_Update";

            if (FindBookById(id) != null)
            {
                using (var _connection = new SqlConnection(_labsysConnectionString))
                {
                    _connection.Query<Models.Book.Book>(sqlStoredProcedure,
                        new { Id = book.Id, Title = book.Title, Description = book.Description }, commandType: CommandType.StoredProcedure);

                    return ListBooks().Find(x => x.Id == id);
                }

            }
            else
            {
                throw new InvalidExpressionException("No Book with Id = " + book.Id + " was Found");
            }
        }

        public Models.Book.Book DeleteBook(int id)
        {
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Book_Delete";

            using (var _connection = new SqlConnection(_labsysConnectionString))
            {
                var bookDeleted = FindBookById(id);
                _connection.Query<Models.Book.Book>
                    (sqlStoredProcedure, new { Id = id }, commandType: CommandType.StoredProcedure);

                return bookDeleted;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BookOfKnowledge.DataAccess.Repository
{
    public class BookRepository
    {




        private string _labsysConnectionString = "Data Source=EUHMBWS009;Initial Catalog=BookOfKnowledge;Integrated Security=false;User Id = sa; Password = milanax11";


        public List<BookOfKnowledge.Models.Book.Book> ListBooks()
        {


            //try
            //{
            string sqlStoredProcedure = @"BookOfKnowledge.dbo.Book_list";


            using (var _connection = new SqlConnection(_labsysConnectionString))
                {


                    var listOfBooksFromDatabase = _connection.Query<Models.Book.Book>(sqlStoredProcedure, CommandType.StoredProcedure).ToList();


                    if (listOfBooksFromDatabase.Any())
                    {

                        return listOfBooksFromDatabase;
                    }


                }




            //    var listOfBooks = new List<BookOfKnowledge.Models.Book.Book>();

            //    var bookOne = new BookOfKnowledge.Models.Book.Book();
            //    bookOne.Id = 1;
            //    bookOne.Title = "Book Of Salah";
            //    bookOne.Description = " Salhaa...";
            //    bookOne.Progress = 77;



            //    listOfBooks.Add(bookOne);

            //    var bookTwo = new BookOfKnowledge.Models.Book.Book()
            //    {
            //        Id = 1,
            //        Title = "Book Of Salah",
            //        Description = " Salhaa...",
            //        Progress = 77,
            //    };


            //    listOfBooks.Add(bookTwo);
            //}
            //catch (Exception ex)
            //{

            //    string test = "wsegegeg";
            //}




            return new List<Models.Book.Book>(); ;

        }


        public string FindBookById(int bookReferenceId)
        {
            var listOfBooks = new List<string>();


            listOfBooks.Add("Book Of Salah");
            listOfBooks.Add("Book Of Imaan");
            listOfBooks.Add("Book Of ISlam");

            var bookFound = listOfBooks.Where(s => s.Contains("Book Of Salah")).FirstOrDefault();

            return bookFound;

        }


    }
}

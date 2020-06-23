using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOfKnowledge.UI.WindowsForms
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        BookOfKnowledge.Service.Book.BookService bookService = new Service.Book.BookService();
        List<BookOfKnowledge.Models.Book.Book> bookList = new List<Models.Book.Book>();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_GetListBooks_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            bookList = bookService.ListBooks();
            dataGridView_Books.DataSource = bookList;
        }

        private void btn_CreateOrUpdate_Click(object sender, EventArgs e)
        {
            CreateOrUpdateBookForm createOrUpdateBook = new CreateOrUpdateBookForm();
            createOrUpdateBook.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            int bookId = (int)dataGridView_Books.CurrentRow.Cells[0].Value;
            bookService.DeleteBook(bookId);

        }
    }
}

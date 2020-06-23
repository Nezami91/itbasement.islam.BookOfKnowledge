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
    public partial class CreateOrUpdateBookForm : Form
    {
        public CreateOrUpdateBookForm()
        {
            InitializeComponent();
        }

        BookOfKnowledge.Service.Book.BookService bookService = new BookOfKnowledge.Service.Book.BookService();
        BookOfKnowledge.Models.Book.Book book = new Models.Book.Book();
        private void txtB_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            book.Id = Convert.ToInt32(txtB_Id.Text);
            book.Title = txtB_Title.Text;
            book.Description = txtB_Description.Text;

            bookService.CreateBook(book);
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            book.Id = Convert.ToInt32(txtB_Id.Text);
            book.Title = txtB_Title.Text;
            book.Description = txtB_Description.Text;

            bookService.UpdateBook(book.Id, book);
            this.Close();
        }
    }
}

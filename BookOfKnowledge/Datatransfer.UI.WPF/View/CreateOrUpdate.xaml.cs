using BookOfKnowledge.Models.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Datatransfer.UI.WPF.View
{
    /// <summary>
    /// Interaction logic for CreateOrUpdate.xaml
    /// </summary>
    public partial class CreateOrUpdate : Window
    {
        public CreateOrUpdate()
        {
            InitializeComponent();
        }

        Datatransfer.UI.WPF.DataService.BookDataService bookService = new DataService.BookDataService();
        BookOfKnowledge.Models.Book.Book book = new Book();

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {          
            book.Id = Convert.ToInt32(TextBox_Id.Text);
            book.Title = TextBox_Title.Text;
            book.Description = TextBox_Description.Text;

            bookService.CreateBook(book);
            this.Close();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {           
            book.Id = Convert.ToInt32(TextBox_Id.Text);
            book.Title = TextBox_Title.Text;
            book.Description = TextBox_Description.Text;

            bookService.UpdateBook(book.Id, book);
            this.Close();
        }
    }
}

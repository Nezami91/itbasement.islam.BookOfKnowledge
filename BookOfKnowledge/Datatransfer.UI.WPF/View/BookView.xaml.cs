using Datatransfer.UI.WPF.DataService;
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
    /// Interaction logic for BookView.xaml
    /// </summary>
    public partial class BookView : Window
    {
        public BookView()
        {
            InitializeComponent();
        }

        Datatransfer.UI.WPF.DataService.BookDataService bookService = new BookDataService(); 
        List<BookOfKnowledge.Models.Book.Book> listOfBooks;

        private void Button_GetList(object sender, RoutedEventArgs e)
        {
            listOfBooks = bookService.ListBook();
            ListBookView.Items.Clear();

            foreach (var item in listOfBooks)
            {
                ListBookView.Items.Add(item);
            }
        }
        private void ListBookView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Create_Update(object sender, RoutedEventArgs e)
        {
            Datatransfer.UI.WPF.View.CreateOrUpdate createOrUpdate = new CreateOrUpdate();
            createOrUpdate.Show();
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            var book = this.ListBookView.SelectedItem as BookOfKnowledge.Models.Book.Book;                       
            bookService.DeleteBook(book.Id);     
        }

     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfKnowledge.Models.Book
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Progress { get; set; }
        public List<Chapters> Chapters { get; set; }

        public Book()
        {
            Chapters = new List<Chapters>();
        }
    }

    public class Chapters{

        public int Id { get; set; }
}



}

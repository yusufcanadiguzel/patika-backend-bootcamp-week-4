using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibraryApp
{
    internal class Book
    {
        private string? _title;
        private string? _author;
        private int _pageCount;
        private string? _publisher;
        private DateTime _publishDate;

        public string? Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string? Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int PageCount
        {
            get { return _pageCount; }
            set { _pageCount = value; }
        }

        public string? Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public DateTime PublishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; }
        }

        //yayimlanma tarihine instance anindaki tarihi atar
        public Book()
        {
            PublishDate = DateTime.Now;
        }

        //isim, yazar, sayfa sayisi ve yayimciyi instance esnasinda atar ve default ctoru calistirir
        public Book(string name, string author, int pageCount, string publisher) : this() 
        {
            Title = name;
            Author = author;
            PageCount = pageCount;
            Publisher = publisher;
        }
    }
}

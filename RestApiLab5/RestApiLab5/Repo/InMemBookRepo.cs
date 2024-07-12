using RestApiLab5.Models;

namespace RestApiLab5.Repo
{
    public class InMemBookRepo : IBook
    {
        //Create the repo as List
        private List<Book> _Books;
        //The Constructor
        public InMemBookRepo()
        {
            // καταχώριση ενός πρώτου βιβλίου
            _Books = new() { new Book
            { Id=Guid.NewGuid(), Title="Book 0", Price=10}
            };
        }

        public IEnumerable<Book> GetBooks()
        {
            return _Books;
        }

        public Book GetBook(Guid id)
        {
            var book = _Books.Where(x => x.Id == id).SingleOrDefault();
            return book;
        }
        public void CreateBook(Book book)
        {
            _Books.Add(book);
        }

        public void DeleteBook(Guid id)
        {
            var bookIndex = _Books.FindIndex(x => x.Id == id);
            if (bookIndex > -1)
                _Books.RemoveAt(bookIndex);
        }

        public void UpdateBook(Guid id, Book book)
        {
            var bookIndex = _Books.FindIndex(x => x.Id == id);
            if (bookIndex > -1)
                _Books[bookIndex] = book;
        }
    }
}

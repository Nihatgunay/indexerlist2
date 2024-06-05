

namespace classlibraryTASK
{
    public class Library
    {
        List<Book> _books = new List<Book>();
        public Book this[int index]
        {
            get { return _books[index]; }
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> _newbooks = new List<Book>();
            foreach (var book in _books)
            {
                if (book.Name.Contains(value))
                {
                    _newbooks.Add(book);                   
                }
            }
            return _newbooks;
        }
        public Book FindBookByCode(string code)
        {
            foreach (var book in _books)
            {
                if (book.Code == code)
                    return book;                
            }
            return null;
        }
        public Book RemoveAllBooksByName(string name)
        {
            foreach (var item in _books)
            {
                if (item.Name.Trim().ToLower() == name.Trim().ToLower())
                {
                    _books.Remove(item);
                }
            }
            return null; ;           
        }
        public List<Book> SearchBooks(string value)
        {
            List<Book> _newbooks = new List<Book>();
            foreach (var item in _books)
            {
                if (item.Code.Trim().ToLower() == value.Trim().ToLower() || 
                    item.Name.Trim().ToLower() == value.Trim().ToLower() || 
                    item.AuthorName.Trim().ToLower() == value.Trim().ToLower() || 
                    item.PageCount == int.Parse(value))
                {
                    _newbooks.Add(item);
                }
            }
            return _newbooks;
        }
        public List<Book> FindAllBooksByPageCountRange(int minpagecount, int maxpagecount)
        {
            List<Book> _newbooks = new List<Book>();
            if (minpagecount < 0 || minpagecount > maxpagecount)
            {
                Console.WriteLine("Invalid min max page count");
                return _newbooks;
            }
            foreach (var book in _books)
            {
                if (book.PageCount >= minpagecount && book.PageCount <= maxpagecount)
                {
                    _newbooks.Add(book);
                }
            }
            return _newbooks;          
        }
        public Book RemoveBookByCode(string value)
        {
            foreach (var book in _books)
            {
                if (book.Code == value)
                    _books.Remove(book);
            }
            return null;
        }
        
    }
}

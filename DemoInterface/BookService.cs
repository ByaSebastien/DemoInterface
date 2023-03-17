using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class BookService : IBookService
    {
        public void Add(Book b)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Book b)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public interface IBookService
    {
        public void Add(Book b);
        public void Update(int id, Book b);
        public void Delete(int id);
        public Book GetOne(int id);
        public List<Book> GetAll();
    }
}

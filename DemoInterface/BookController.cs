using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class BookController
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public void Add(BookDTO bookDTO)
        {
            _bookService.Add(new Book());
        }
    }
}

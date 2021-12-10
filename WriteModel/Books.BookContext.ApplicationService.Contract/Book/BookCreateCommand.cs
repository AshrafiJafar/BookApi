using Framework.Core.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.BookContext.ApplicationService.Contract.Book
{
    public class BookCreateCommand : Command
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public Guid CategorySubTypeId { get; set; }
    }
}

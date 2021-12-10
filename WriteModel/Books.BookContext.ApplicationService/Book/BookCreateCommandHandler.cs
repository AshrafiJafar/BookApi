using Books.BookContext.ApplicationService.Contract.Book;
using Framework.Core.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.BookContext.ApplicationService.Book
{
    class BookCreateCommandHandler : ICommandHandler<BookCreateCommand>
    {
        public void Execute(BookCreateCommand command)
        {
            throw new NotImplementedException();
        }
    }
}

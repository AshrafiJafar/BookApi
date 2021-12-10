using Books.BookContext.ApplicationService.Contract.Book;
using Books.BookContext.Facade.Contract;
using Framework.Core.Application;
using Framework.Facade;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.BookContext.Facade
{
    [Route("api/Book/[action]")]
    [ApiController]
    public class BookCommandFacade : FacadeCommandBase, IBookCommandFacade
    {
        public BookCommandFacade(ICommandBus commandBus) : base(commandBus)
        {

        }
        [HttpPost]
        public void CreateBook(BookCreateCommand command)
        {
            CommandBus.Dispatch(command);
        }
    }
}

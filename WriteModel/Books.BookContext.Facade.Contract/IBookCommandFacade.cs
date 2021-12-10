using Books.BookContext.ApplicationService.Contract.Book;

namespace Books.BookContext.Facade.Contract
{
    public interface IBookCommandFacade
    {
        void CreateBook(BookCreateCommand command);
    }
}

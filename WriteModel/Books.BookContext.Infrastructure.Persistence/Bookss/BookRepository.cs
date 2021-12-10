using Books.BookContext.Domain.Bookss;
using Books.BookContext.Domain.Bookss.Services;
using Framework.Core.Persistence;
using Framework.Persistence;

namespace Books.BookContext.Infrastructure.Persistence.Bookss
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(IDbContext dbContext) : base(dbContext)
        {
        }

        public void CreateBook(Book book)
        {
            Create(book);
        }
    }
}

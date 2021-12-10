using Books.ReadModel.Queries.Contracts.Books.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.ReadModel.Queries.Contracts.Books
{
    public interface IBooksQueryFacade
    {
        IList<TypeDto> GetTypes();
        IList<AuthorDto> GetAuthors();
        IList<SubTypeDto> GetSubTypesForType(Guid id);
        IList<BookDto> GetBooks(Guid? typeId, Guid? subTypeId, Guid? authorId, string name = "");
        IList<BookDto> GetBooksWithStoreProcedure(Guid? typeId, Guid? subTypeId, Guid? authorId, string name = "");

    }
}

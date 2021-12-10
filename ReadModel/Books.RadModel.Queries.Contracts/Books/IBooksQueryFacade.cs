using Books.ReadModel.Queries.Contracts.Books.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.ReadModel.Queries.Contracts.Books
{
    public interface IBooksQueryFacade
    {
        IList<SubTypeDto> GetSubTypesForType(Guid id);
    }
}

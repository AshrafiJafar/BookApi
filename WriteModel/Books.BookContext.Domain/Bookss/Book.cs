using Framework.Core.Domain;
using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Books.BookContext.Domain.Bookss
{
    public class Book : EntityBase<Book>, IAggregateRoot<Book>
    {

        public string Name { get; set; }
        public int PageCount { get; set; }
        public Guid SubTypeId { get; set; }
        public Guid AuthorId { get; set; }

        public IEnumerable<Expression<Func<Book, object>>> GetAggregateExpressions()
        {
            yield return null;
        }
    }
}

using Books.ReadModel.Context.Models;
using Books.ReadModel.Queries.Contracts.Books;
using Books.ReadModel.Queries.Contracts.Books.DataContracts;
using Framework.Core.Mapper;
using Framework.Facade;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books.ReadModel.Queries.Facade.Books
{
    [Route("library/api/Books/[action]")]
    [ApiController]
    public class BooksQueryFacade : FacadeQueryBase, IBooksQueryFacade
    {
        private readonly LibraryContext db;
        private readonly IMapper mapper;

        public BooksQueryFacade(LibraryContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        [HttpGet]
        public IList<TypeDto> GetTypes()
        {
            return mapper.Map<TypeDto, Context.Models.Type>(db.Types.ToList());
        }
        [HttpGet]
        public IList<AuthorDto> GetAuthors()
        {
            return mapper.Map<AuthorDto, Author>(db.Authors.ToList());
        }
        [HttpGet]
        public IList<SubTypeDto> GetSubTypesForType(Guid id)
        {
            return mapper.Map<SubTypeDto, SubType>(db.SubTypes.Where(x => x.TypeId == id).ToList());
        }

        [HttpGet]
        public IList<BookDto> GetBooks(Guid? typeId, Guid? subTypeId, Guid? authorId, string name = "")
        {
            var query = db.Books.Include(x => x.SubType).Where(x => x.Name.Contains(name));
            if (typeId.HasValue)
            {
                query = query.Where(x => x.SubType.TypeId == typeId.Value);
            }
            if (subTypeId.HasValue)
            {
                query = query.Where(x => x.SubTypeId == subTypeId.Value);
            }
            if (authorId.HasValue)
            {
                query = query.Where(x => x.AuthorId == authorId.Value);
            }
            return mapper.Map<BookDto, Book>(query.ToList());
        }

        [HttpGet]
        public IList<BookDto> GetBooksWithStoreProcedure(Guid? typeId, Guid? subTypeId, Guid? authorId, string name = "")
        {
            var query = db.Books.Include(x => x.SubType).Where(x => x.Name.Contains(name));
            if (typeId.HasValue)
            {
                query = query.Where(x => x.SubType.TypeId == typeId.Value);
            }
            if (subTypeId.HasValue)
            {
                query = query.Where(x => x.SubTypeId == subTypeId.Value);
            }
            if (authorId.HasValue)
            {
                query = query.Where(x => x.AuthorId == authorId.Value);
            }
            return mapper.Map<BookDto, Book>(query.ToList());
        }
    }
}

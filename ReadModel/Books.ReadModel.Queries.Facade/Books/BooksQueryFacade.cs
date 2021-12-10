using Books.ReadModel.Context.Models;
using Books.ReadModel.Queries.Contracts.Books;
using Books.ReadModel.Queries.Contracts.Books.DataContracts;
using Framework.Core.Mapper;
using Framework.Facade;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books.ReadModel.Queries.Facade.Books
{
    [Route("api/Books/[action]")]
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
        public IList<SubTypeDto> GetSubTypesForType(Guid id)
        {
            return mapper.Map<SubTypeDto, SubType>(db.SubTypes.Where(x => x.TypeId == id).ToList());
        }
    }
}

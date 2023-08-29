using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.Category.Queries.GetCategoryPagedList
{
    public class GetCategoryPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public int Hour { get; set; }
    }
}

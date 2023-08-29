using Lms.Comman.Domain.Entities;
using System;

namespace Lms.Application.Features.AchievementCategory.Queries.GetAchievementCategoryPagedList
{
    public class GetAchievementCategoryPagedListQueryResponse : AAuditableEntity<Guid> //Tabloda görünmesini istediğimiz bilgiler
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}

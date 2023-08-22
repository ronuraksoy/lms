using Lms.Common.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Application.Dtos.EntityBase
{
    public abstract class AEntityDto<TKey> : AEntity<TKey>, IEntity where TKey : struct
    {
        [System.Text.Json.Serialization.JsonIgnore]
        object IEntity.Id { get { return Id; } set { Id = (TKey)Convert.ChangeType(value, typeof(TKey)); } }
    }


    public abstract class AAuditableEntityDto<TKey> : AAuditableEntity<TKey>, IAuditableEntity, IEntity<TKey> where TKey : struct
    {
        [System.Text.Json.Serialization.JsonIgnore]
        object IEntity.Id { get { return Id; } set { Id = (TKey)Convert.ChangeType(value, typeof(TKey)); } }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedById { get; set; }
        public bool IsDeleted { get; set; }

        [DefaultValue(false)]
        public bool IsPassive { get; set; }
    }
}

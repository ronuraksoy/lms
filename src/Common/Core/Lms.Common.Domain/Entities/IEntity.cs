﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Comman.Domain.Entities
{
    public interface IEntityBase
    {
    }
    public interface IEntity : IEntityBase
    {
        object Id { get; set; }
    }
    public interface IEntity<TKey> : IEntity
    {
        TKey Id { get; set; }
    }
    public interface ICreateDate
    {
        DateTime? CreatedDate { get; set; }
    }
    public interface ICreatedById
    {
        Guid? CreatedById { get; set; }
    }
    public interface IUpdatedDate
    {
        DateTime? UpdatedDate { get; set; }
    }
    public interface IUpdatedById
    {
        Guid? UpdatedById { get; set; }
    }

    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
    public interface ICreateAuditableEntity : ICreateDate, ICreatedById
    {
    }
    public interface IUpdateAuditableEntity : IUpdatedDate, IUpdatedById
    {
    }
    public interface IDeleteAuditableEntity : IUpdateAuditableEntity, ISoftDelete
    {
    }
    public interface IAuditableEntity : ICreateAuditableEntity, IDeleteAuditableEntity, IEntity
    {
    }
    public interface IAuditableEntity<TKey> : IAuditableEntity, IEntity<TKey>
    {
    }

    public abstract class AEntity<TKey> : IEntity<TKey> where TKey : struct
    {
        object IEntity.Id { get { return Id; } set { Id = (TKey)Convert.ChangeType(value, typeof(TKey)); } }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public virtual TKey Id { get; set; }
    }

    public abstract class AAuditableEntity<TKey> : AEntity<TKey>, IAuditableEntity<TKey>, IEntity<TKey> where TKey : struct
    {
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedById { get; set; }
        public bool IsDeleted { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}

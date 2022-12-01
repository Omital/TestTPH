using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTPH.Peopels
{
    [Table("Person")]
    public abstract class Person : Entity, IFullAudited
    {
        [MaxLength(128)]
        public string FormalName { get; set; }

        [ForeignKey("PersonId")]
        public virtual PersonExtraDetail ExtraDetail { get; set; }

        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}

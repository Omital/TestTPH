using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTPH.Peopels
{
    [Table("PersonExtraDetail")]
    public class PersonExtraDetail : Entity, IFullAudited
    {
        [Key]
        public int PersonId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        [NotMapped]
        public new int Id { get; set; }

        [MaxLength(128)]
        public string Address { get; set; }

        [MaxLength(128)]
        public string Code { get; set; }


        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}

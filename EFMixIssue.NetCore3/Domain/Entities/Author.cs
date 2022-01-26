using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFMixIssue.NetCore3.Domain.DbUtility;
using EFMixIssue.NetCore3.Domain.Entities.Identity;

namespace EFMixIssue.NetCore3.Domain.Entities
{
    public class Author : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Oid { get; set; }

        [Required, StringLength(255), Column(TypeName = "VARCHAR")]
        public string PenName { get; set; }

        // 1 on 1 relationship with ApplicationUserId
        public long ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}

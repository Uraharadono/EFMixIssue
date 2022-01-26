using EFMixIssue.NetCore3.Domain.DbUtility;
using Microsoft.AspNetCore.Identity;

namespace EFMixIssue.NetCore3.Domain.Entities.Identity
{
    public class ApplicationRole : IdentityRole<long>, IIdentityEntity
    {
        public ApplicationRole() { }
        public ApplicationRole(string name) { Name = name; }
    }
}

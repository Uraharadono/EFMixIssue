using EFMixIssue.NetCore3.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EFMixIssue.NetCore3.Entities.Identity.Util
{
    public class ApplicationRoleStore : RoleStore<ApplicationRole, Microsoft.EntityFrameworkCore.DbContext, long>
    {
        public ApplicationRoleStore(Microsoft.EntityFrameworkCore.DbContext context)
            : base(context)
        {
        }
    }
}

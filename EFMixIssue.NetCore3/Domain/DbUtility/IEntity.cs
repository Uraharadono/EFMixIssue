namespace EFMixIssue.NetCore3.Domain.DbUtility
{
    public interface IEntity
    {
        long Oid { get; set; }
    }

    public interface IIdentityEntity
    {
        long Id { get; set; }
    }
}

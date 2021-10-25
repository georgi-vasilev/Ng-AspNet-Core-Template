namespace AspNetCore_Angular_Template.Data.Common.Models.Common
{
    public interface IIdentifiableEntity<TKey>
    {
        TKey Id { get; set; }
    }
}

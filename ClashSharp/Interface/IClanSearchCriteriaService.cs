using ClashSharp.Data;

namespace ClashSharp.Interface
{
    public interface IClanSearchCriteriaService
    {
        bool IsValidSearchCriteria(ClanSearchCriteria criteria);
        string BuildQueryStringFromCriteria(ClanSearchCriteria criteria);
    }
}

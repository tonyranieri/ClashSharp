using ClashSharp.Data;
using ClashSharp.Interface;
using System.Text;

namespace ClashSharp.Service
{
    public class ClanSearchCriteriaService : IClanSearchCriteriaService
    {
        public bool IsValidSearchCriteria(ClanSearchCriteria criteria)
        {
            //todo: this should probably return a descriptive validation failure reason...

            if(criteria.Name.Length < 3)
            {
                return false;
            }

            if(criteria.ItemsAfter.HasValue && criteria.ItemsBefore.HasValue)
            {
                return false;
            }

            return true;
        }

        public string BuildQueryStringFromCriteria(ClanSearchCriteria criteria)
        {
            if(IsValidSearchCriteria(criteria) == false)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            sb.Append("?");

            if(criteria.Name != null)
            {
                sb.AppendFormat("name={0}&", criteria.Name);
            }

            if(criteria.WarFrequency != null)
            {
                sb.AppendFormat("warFrequency={0}&", criteria.WarFrequency);
            }

            if(criteria.LocationId.HasValue)
            {
                sb.AppendFormat("locationId={0}&", criteria.LocationId.Value);
            }

            if(criteria.MinimumMembers.HasValue)
            {
                sb.AppendFormat("minMembers={0}&", criteria.MinimumMembers.Value);
            }

            if (criteria.MaximumMembers.HasValue)
            {
                sb.AppendFormat("maxMembers={0}&", criteria.MaximumMembers.Value);
            }

            if (criteria.MinimumClanPoints.HasValue)
            {
                sb.AppendFormat("minClanPoints={0}&", criteria.MinimumClanPoints.Value);
            }

            if (criteria.MinimumClanLevel.HasValue)
            {
                sb.AppendFormat("minClanLevel={0}&", criteria.MinimumClanLevel.Value);
            }

            if (criteria.Limit.HasValue)
            {
                sb.AppendFormat("limit={0}&", criteria.Limit.Value);
            }

            if (criteria.ItemsAfter.HasValue)
            {
                sb.AppendFormat("after={0}&", criteria.ItemsAfter.Value);
            }

            if (criteria.ItemsBefore.HasValue)
            {
                sb.AppendFormat("before={0}&", criteria.ItemsBefore.Value);
            }

            return sb.ToString();
        }
    }
}

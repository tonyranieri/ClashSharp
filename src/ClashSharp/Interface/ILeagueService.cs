using ClashSharp.Data;
using System.Collections.Generic;

namespace ClashSharp.Interface
{
    public interface ILeagueService
    {
        IEnumerable<League> ListLeagues();
    }
}

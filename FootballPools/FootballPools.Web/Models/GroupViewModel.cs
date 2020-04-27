using FootballPools.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballPools.Web.Models
{
    public class GroupViewModel : GroupEntity
    {
        public int TournamentId { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballPools.Web.Data.Entities;
using FootballPools.Web.Models;

namespace FootballPools.Web.Helpers
{
    public class ConvertHelper : IConverterHelper
    {
        public TeamEntity ToTeamEntity(TeamViewModel model, string path, bool isNew)
        {
            return new TeamEntity
            {
                Id = isNew ? 0 : model.Id,
                LogoPath = path,
                Name = model.Name
            };
        }

        public TeamViewModel ToTeamViewModel(TeamEntity teamEntity)
        {
            return new TeamViewModel
            {
                Id=teamEntity.Id,
                LogoPath=teamEntity.LogoPath,
                Name=teamEntity.Name
            };
        }
    }
}

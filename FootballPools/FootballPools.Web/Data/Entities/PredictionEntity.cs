using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballPools.Web.Data.Entities
{
    public class PredictionEntity
    {
        public int Id { get; set; }

        public MatchEntity Match { get; set; }

        public UserEntity User { get; set; }

        [Display(Name = "Goals Local")]
        public int? GoalsLocal { get; set; }

        [Display(Name = "Goals Visitor")]
        public int? GoalsVisitor { get; set; }

        public int Points { get; set; }

    }
}

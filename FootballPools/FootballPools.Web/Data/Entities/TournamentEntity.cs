﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballPools.Web.Data.Entities
{
    public class TournamentEntity
    {
        public int Id { get; set; }
        [MaxLength(100, ErrorMessage ="The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage ="The field {0] is mandatory.")]
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name ="Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode =false)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDateLocal => StartDate.ToLocalTime();


        [DataType(DataType.DateTime)]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime EndDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDateLocal => EndDate.ToLocalTime();

        [Display(Name ="Is Active")]
        public bool IsActive { get; set; }

        [Display(Name ="Logo")]
        public string LogoPath { get; set; }

        public ICollection<GroupEntity> Groups { get; set; }

    }
}

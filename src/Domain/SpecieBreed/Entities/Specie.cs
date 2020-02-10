using HerdManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.SpecieBreed.Entities
{
    public class Specie : AuditableEntity
    {
        public string Label { get; set; }

        public TimeSpan ChildhoodDuration { get; set; }

        public TimeSpan PregnancyDuration { get; set; }

        public TimeSpan MinimumTimeSpanBetweenCalvingAndHeat { get; set; }
    }
}

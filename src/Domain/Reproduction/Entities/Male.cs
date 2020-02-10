using HerdManagement.Domain.Reproduction.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.Reproduction.Entities
{
    public class Male : AdultAnimal
    {
        /// <summary>
        /// Animal's sex
        /// </summary>
        public override SexEnum Sex { get => SexEnum.Male; }

        public ValueObjects.Reproduction HasMated(Female female, DateTime date,
                                              ReproductionTypeEnum type, ReproductionStateEnum status,
                                              string commentary)
        {   
            return new ValueObjects.Reproduction(female, this, date, type, status, commentary);
        }
    }
}

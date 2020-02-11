using HerdManagement.Domain.Reproduction.Enumerations;
using System;

namespace HerdManagement.Domain.Reproduction.Entities
{
    public class Male : AdultAnimal
    {
        /// <summary>
        /// Animal's sex
        /// </summary>
        public override SexEnum Sex => SexEnum.Male;

        public ValueObjects.Reproduction HasMated(Female female, DateTime date,
                                              ReproductionTypeEnum type, ReproductionStateEnum status,
                                              string commentary)
        {   
            return ValueObjects.Reproduction.Initialize(female, this, date, type, status, commentary);
        }
    }
}

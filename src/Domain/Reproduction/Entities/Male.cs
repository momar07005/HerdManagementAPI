using HerdManagement.Domain.Reproduction.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.Reproduction.Entities
{
    public class Male : AdultAnimal
    {
        public override SexEnum Sex { get => SexEnum.Male; }

        public ValueObjects.Reproduction Mate(Female female, DateTime date, ReproductionTypeEnum reproductionType, string Commentary)
        {   
            if (CanMate() && female.CanBeMated())
            {
                return new ValueObjects.Reproduction
                {
                    Female = female,
                    Male = this,
                    Type = reproductionType,
                    Status = ReproductionStatusEnum.Initial,
                    Date = date,
                    Commentary = Commentary

                };
            }
        }

        private bool CanMate()
        {
            throw new NotImplementedException();
        }
    }
}

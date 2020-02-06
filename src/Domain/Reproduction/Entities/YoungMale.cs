using HerdManagement.Domain.Reproduction.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.Reproduction.Entities
{
    public class YoungMale : Animal
    {
        public override SexEnum Sex { get => SexEnum.Male; }
    }
}

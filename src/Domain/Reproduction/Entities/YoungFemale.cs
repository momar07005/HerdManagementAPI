using HerdManagement.Domain.Reproduction.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.Reproduction.Entities
{
    public class YoungFemale : YoungAnimal
    {
        public override SexEnum Sex { get => SexEnum.Female; }      
    }
}

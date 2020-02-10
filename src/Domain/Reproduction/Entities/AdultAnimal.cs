using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.Reproduction.Entities
{
    public abstract class AdultAnimal : Animal
    {
        public List<ValueObjects.Reproduction> reproductions { get; } = new List<ValueObjects.Reproduction>();
    }
}

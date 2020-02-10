using HerdManagement.Domain.Common;
using HerdManagement.Domain.SpecieBreed.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.SpecieBreed.ValueObjects
{
    public class Breed : ValueObject
    {
        public string Label { get; set; }

        public Specie Specie { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Label;
            yield return Specie;
        }
    }
}

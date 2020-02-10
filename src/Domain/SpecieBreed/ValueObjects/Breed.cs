using HerdManagement.Domain.Common;
using HerdManagement.Domain.SpecieBreed.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.SpecieBreed.ValueObjects
{
    public class Breed : ValueObject<Breed>
    {
        public string Label { get; protected set; }

        public Specie Specie { get; protected set; }

        protected override bool EqualsCore(Breed obj)
        {
            return Label == obj.Label && Specie == obj.Specie;
        }

        protected override int GetHashCodeCore()
        {
            return Label.GetHashCode() ^ Specie.GetHashCode();
        }
    }
}

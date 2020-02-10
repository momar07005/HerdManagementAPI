using HerdManagement.Domain.Common;
using HerdManagement.Domain.Common.ValueObjects;
using HerdManagement.Domain.SpecieBreed.Enumerations;
using System.Collections.Generic;

namespace HerdManagement.Domain.SpecieBreed.ValueObjects
{
    public class Characteristic : ValueObject
    {
        public CharacteristicValueTypeEnum valueType { get; set; }

        public string Label { get; set; }

        public MeasurementUnit ValueUnit { get; set; }

        public string Commentary { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return valueType;
            yield return Label;
            yield return ValueUnit;
        }
    }
}

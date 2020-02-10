using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.Common.ValueObjects
{
    public class MeasurementUnit : ValueObject<MeasurementUnit>
    {
        public string Label { get; set; }

        protected override bool EqualsCore(MeasurementUnit obj)
        {
            return Label == obj.Label;
        }

        protected override int GetHashCodeCore()
        {
            return Label.GetHashCode();
        }

    }
}

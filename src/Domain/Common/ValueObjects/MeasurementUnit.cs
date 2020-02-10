using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.Common.ValueObjects
{
    public class MeasurementUnit : ValueObject
    {
        public string Label { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Label;
        }
    }
}

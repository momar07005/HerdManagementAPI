using HerdManagement.Domain.Common;
using System;
using System.Collections.Generic;

namespace HerdManagement.Domain.Reproduction.Entities
{
    public class Calving : ValueObject
    {
        public Calving() { }

        public DateTime Date { get; set; }
        public ValueObjects.Reproduction Reproduction { get; set; }
        public uint NumberOfNewborn { get; set; }
        public string Commentary { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}

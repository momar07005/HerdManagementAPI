using HerdManagement.Domain.Common;
using System;

namespace HerdManagement.Domain.Reproduction.ValueObjects
{
    public class Calving : ValueObject<Calving>
    {
        public DateTime Date { get; protected set; }
        public Reproduction Reproduction { get; protected set; }
        public uint NumberOfNewborn { get; protected set; }
        public string Commentary { get; protected set; }

        protected override bool EqualsCore(Calving obj)
        {
            return Date == obj.Date
                   && Reproduction == obj.Reproduction
                   && NumberOfNewborn == obj.NumberOfNewborn;
        }

        protected override int GetHashCodeCore()
        {
            return Date.GetHashCode() ^ Reproduction.GetHashCode() ^ (int)NumberOfNewborn;
        }
    }
}

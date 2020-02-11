using HerdManagement.Domain.Common;
using HerdManagement.Domain.Reproduction.Enumerations;
using System;

namespace HerdManagement.Domain.Reproduction.ValueObjects
{
    public class ReproductionState : ValueObject<ReproductionState>
    {
        public ReproductionStateEnum State { get; protected set; }

        public DateTime Date { get; protected set; }

        public ReproductionState(ReproductionStateEnum state, DateTime date)
        {
            State = state;
            Date = date;
        }

        protected override bool EqualsCore(ReproductionState obj)
        {
            return State == obj.State && Date == obj.Date;
        }

        protected override int GetHashCodeCore()
        {
            return (int)State ^ Date.GetHashCode();
        }

        public static bool operator <(ReproductionState a, ReproductionState b) => a.Date < b.Date && a.State < b.State;
       
        public static bool operator >(ReproductionState a, ReproductionState b) => a.Date > b.Date && a.State > b.State;


    }
}

using HerdManagement.Domain.Common;
using HerdManagement.Domain.Reproduction.Entities;
using HerdManagement.Domain.Reproduction.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HerdManagement.Domain.Reproduction.ValueObjects
{
    public class Reproduction : ValueObject<Reproduction>
    {
        public static Reproduction None => new Reproduction(null, null, DateTime.MinValue,
                                                            ReproductionTypeEnum.Artificial,
                                                            ReproductionStateEnum.Initial);
        public Female Female { get; set; }
        public Male Male { get; set; }      
        public DateTime Date { get; protected set; }
        public ReproductionTypeEnum Type { get; protected set; }
        public IEnumerable<ReproductionState> States { get; } = new List<ReproductionState>();
        public string Commentary { get; protected set; }
        public ReproductionState ActualState => States.Max();

        public Reproduction(Female female, Male male, DateTime date,
                            ReproductionTypeEnum type, ReproductionStateEnum status,
                            string commentary)
        {
            if(female != null && date != null && female.CanBeMated(date) && status == ReproductionStateEnum.Initial)
            {
                Female = female;
                Male = male;
                Date = date;
                Type = type;
                States.Append(new ReproductionState(status, date));
                Commentary = commentary;
            }
            else
            {
                Female = null;
                Male = null;
                Date = DateTime.MinValue;
                Type = ReproductionTypeEnum.Artificial;               
            }
        }

        public Reproduction(Female female, Male male, DateTime date,ReproductionTypeEnum type,
                            ReproductionStateEnum status) : this(female, male, date, type, status, null){}

        protected override bool EqualsCore(Reproduction obj)
        {
            return Date == obj.Date
                   && Male == obj.Male
                   && Female == obj.Female
                   && Type == obj.Type
                   && States == obj.States;
        }

        protected override int GetHashCodeCore()
        {
            return Date.GetHashCode() 
                    ^ Male.Id.GetHashCode()
                    ^ Female.Id.GetHashCode()
                    ^ Type.GetHashCode() 
                    ^ States.GetHashCode();
        }

    //    private Reproduction ToNextState(DateTime date)
    //    {
    //        switch(ActualState.State)
    //        {
    //            case ReproductionStateEnum.Initial:
                    

    //        }             
    //    }
    //}
}

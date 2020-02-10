using HerdManagement.Domain.Common;
using HerdManagement.Domain.Reproduction.Entities;
using HerdManagement.Domain.Reproduction.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.Reproduction.ValueObjects
{
    public class Reproduction : ValueObject
    {
        public DateTime Date { get; set; }
        public string Commentary { get; set; }
        public Male Male { get; set; }
        public Female Female { get; set; }
        public ReproductionTypeEnum Type { get; set; }
        public ReproductionStatusEnum Status { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}

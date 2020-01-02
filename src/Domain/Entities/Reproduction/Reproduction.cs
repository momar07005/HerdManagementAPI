using HerdManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.Entities.Reproduction
{
    public class Reproduction
    {
        public DateTime Date { get; set; }
        public string Commentary { get; set; }
        public Male Male { get; set; }
        public Female Female { get; set; }
        public ReproductionTypeEnum Type { get; set; }
        public ReproductionStatusEnum Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.Reproduction.Entities
{
    public class Calving
    {
        public Calving() { }

        public DateTime Date { get; set; }
        public Reproduction Reproduction { get; set; }
        public uint NumberOfNewborn { get; set; }
        public string Commentary { get; set; }
    }
}

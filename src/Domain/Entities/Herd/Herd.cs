﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.Entities.Herd
{
    class Herd
    {
        public Herd()
        {

        }

        public string Name {get; set;}
        public string Descrition { get; set; }
        public string Color { get; set; }
        public uint LivingMembersNumber { get; set; }

    }
}

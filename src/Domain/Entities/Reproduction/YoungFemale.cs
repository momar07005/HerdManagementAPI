﻿using HerdManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerdManagement.Domain.Entities.Reproduction
{
    public class YoungFemale : YoungAnimal
    {
        public override SexEnum Sex { get => SexEnum.Female; }
    }
}

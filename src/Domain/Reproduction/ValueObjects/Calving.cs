﻿using HerdManagement.Domain.Common;
using System;

namespace HerdManagement.Domain.Reproduction.ValueObjects
{
    public class Calving : ValueObject<Calving>
    {
        public DateTime Date { get; protected set; }
        public Reproduction Reproduction { get; protected set; }
        public uint NumberOfNewborn { get; protected set; }
        public string Commentary { get; protected set; }

        /// <summary>
        /// Expresses equality of two Calving objects.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        protected override bool EqualsCore(Calving obj)
        {
            return Date == obj.Date
                   && Reproduction == obj.Reproduction
                   && NumberOfNewborn == obj.NumberOfNewborn;
        }

        /// <summary>
        /// Gets the object's hash code.
        /// </summary>
        /// <returns></returns>
        protected override int GetHashCodeCore()
        {
            return Date.GetHashCode() ^ Reproduction.GetHashCode() ^ (int)NumberOfNewborn;
        }
    }
}

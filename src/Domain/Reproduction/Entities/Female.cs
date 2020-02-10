﻿using HerdManagement.Domain.Reproduction.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HerdManagement.Domain.Reproduction.Entities
{
    public class Female : AdultAnimal
    {
        /// <summary>
        /// Animal Sex
        /// </summary>
        public override SexEnum Sex { get => SexEnum.Female; }

        /// <summary>
        /// Different female's calvings
        /// </summary>
        public IEnumerable<ValueObjects.Calving> Calvings { get; } = new List<ValueObjects.Calving>();

        /// <summary>
        /// Indicates wether this female can be mated or not at the given date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>true if this female is able to be mated at the given date. False otherwise</returns>
        public bool CanBeMated(DateTime date)
        {
            DateTime lastCalvingDate = Calvings.Max(calving => calving.Date).Date;
            return this.Breed.Specie.MinimumTimeSpanBetweenCalvingAndHeat < date.Subtract(lastCalvingDate);
        }

        /// <summary>
        /// Creates a reproduction between male et female
        /// </summary>
        /// <param name="male"></param>
        /// <param name="date"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="commentary"></param>
        /// <returns>A correct reproduction object if possible. Otherwise return a default one</returns>
        public ValueObjects.Reproduction HasBeenMated(Male male, DateTime date,ReproductionTypeEnum type,
                                                      ReproductionStateEnum status,string commentary)
        {
            return new ValueObjects.Reproduction(this, male, date, type, status, commentary);
        }


    }
}

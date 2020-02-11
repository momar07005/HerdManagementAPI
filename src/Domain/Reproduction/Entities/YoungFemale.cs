using HerdManagement.Domain.Reproduction.Enumerations;

namespace HerdManagement.Domain.Reproduction.Entities
{
    public class YoungFemale : YoungAnimal
    {
        /// <summary>
        /// Gets the sex.
        /// </summary>
        /// <value>
        /// The sex.
        /// </value>
        public override SexEnum Sex => SexEnum.Female;      
    }
}

using HerdManagement.Domain.Reproduction.Enumerations;

namespace HerdManagement.Domain.Reproduction.Entities
{
    public class YoungFemale : YoungAnimal
    {
        public override SexEnum Sex => SexEnum.Female;      
    }
}

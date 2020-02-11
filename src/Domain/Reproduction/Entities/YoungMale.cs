using HerdManagement.Domain.Reproduction.Enumerations;

namespace HerdManagement.Domain.Reproduction.Entities
{
    public class YoungMale : Animal
    {
        public override SexEnum Sex => SexEnum.Male;
    }
}

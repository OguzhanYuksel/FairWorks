using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class ParticipantHandBookProfile : ProfileBase
    {
        public ParticipantHandBookProfile()
        {
            CreateMap<ParticipantHandBook, ParticipantHandBookDTO>().ReverseMap();
        }
    }
}

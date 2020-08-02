using FairWorks.Core.Services;
using FairWorks.DAL.Data.UnitOfWork;
using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLL.Services
{
    public class InterviewService : ServiceBase<Interview, InterviewDTO>, IInterviewService
    {
        public InterviewService(IUnitofWork uow) : base(uow)
        {
        }

        public async Task<List<InterviewDTO>> GetAllWithIncludesAsync()
        {
            var interviews = await _repo.GetIncludesAsync(null, 
                x => x.Company,
                x => x.Salon,
                x => x.SalesPerson,
                x => x.Interviewer,
                x => x.InterviewFairs,
                x => x.Sector);
            var result =  MapperFactory.CurrentMapper.Map<List<InterviewDTO>>(interviews.ToList());
            var json = JsonConvert.SerializeObject(result, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            var resultList = JsonConvert.DeserializeObject<List<InterviewDTO>>(json);
            return resultList;
        }

        public async Task<InterviewDTO> GetAllWithIncludesAsyncById(Guid Id)
        {
            var interview = await _repo.GetIncludesAsync(x => x.Id == Id,
                x => x.Company,
                x => x.Salon,
                x => x.SalesPerson,
                x => x.Interviewer,
                x => x.InterviewFairs,
                x => x.Sector);
            var interviewDto = MapperFactory.CurrentMapper.Map<InterviewDTO>(interview.FirstOrDefault());
            var json = JsonConvert.SerializeObject(interviewDto, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            var result = JsonConvert.DeserializeObject<InterviewDTO>(json);
            return result;
        }
    }
}

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
    public class FairService : ServiceBase<Fair, FairDTO>, IFairService
    {
        public FairService(IUnitofWork uow) : base(uow)
        {
        }

        public async Task<List<FairDTO>> GetActiveFairsWithSalons()
        {
            var fairs = await _repo.GetAsyncQueryable(x => x.Active,x => x.Salons);
            var fairDtoList =  MapperFactory.CurrentMapper.Map<List<FairDTO>>(fairs.ToList());
            var json = JsonConvert.SerializeObject(fairDtoList,new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore});
            var resultList =  JsonConvert.DeserializeObject<List<FairDTO>>(json);
            foreach (var fair in resultList)
            {
                foreach (var salon in fair.Salons)
                {
                    salon.Fair = new FairDTO { Id = fair.Id, Name = fair.Name};
                }
            }
            return resultList;
        }
    }
}

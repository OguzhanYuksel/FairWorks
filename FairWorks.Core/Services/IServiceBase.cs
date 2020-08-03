using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Core.Services
{
    public interface IServiceBase<T,TDto>
    {
        List<TDto> GetAll();
        Task<List<TDto>> GetAllAsync();
        TDto Get(Guid Id);
        Task<TDto> GetAsync(Guid id);
        TDto GetByName(string name);
        List<TDto> GetByNameList(string name);
        Task<TDto> GetByNameAsync(string name);
        Task<List<TDto>> GetByNameListAsync(string name);
        TDto Add(TDto dto);
        Task<TDto> AddAsync(TDto dto, bool isNameControlRequired = false);
        TDto Update(TDto dto);
        Task<TDto> UpdateAsync(TDto dto);
        bool Delete(Guid id);
        Task<bool> DeleteAsync(Guid id);
    }
}

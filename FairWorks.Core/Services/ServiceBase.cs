using FairWorks.DAL.BaseEntities;
using FairWorks.DAL.Data.Repositories;
using FairWorks.DAL.Data.UnitOfWork;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Core.Services
{
    public class ServiceBase<T, TDto> : IServiceBase<T, TDto> where T : Entity<Guid> where TDto : BaseDTO
    {
        public readonly IUnitofWork _uow;
        public readonly IRepository<T> _repo;
        public ServiceBase(IUnitofWork uow)
        {
            _uow = uow;
            _repo = _uow.GetRepository<T>();
        }
        public TDto Add(TDto dto)
        {
            if (!_repo.GetAll().Any(x => x.Name == dto.Name))
            {
                var added = MapperFactory.CurrentMapper.Map<T>(dto);
                added = _repo.Add(added);
                _uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<TDto>(added);
            }
            else
            {
                return default;
            }
        }

        public async Task<TDto> AddAsync(TDto dto,bool isNameControlRequired = false)
        {
            if (isNameControlRequired && !_repo.GetAll().Any(x => x.Name == dto.Name))
            {
                var added = MapperFactory.CurrentMapper.Map<T>(dto);
                added = _repo.Add(added);
                await _uow.SaveChangesAsync();
                return MapperFactory.CurrentMapper.Map<TDto>(added);
            }
            else
            {
                var added = MapperFactory.CurrentMapper.Map<T>(dto);
                added = _repo.Add(added);
                await _uow.SaveChangesAsync();
                return MapperFactory.CurrentMapper.Map<TDto>(added);
                //return default;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var entity = _repo.Get(x => x.Id == id);
                _repo.Delete(entity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var entity = _repo.Get(x => x.Id == id);
                _repo.Delete(entity);
                await _uow.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        public TDto Get(Guid id)
        {
            var entity = _repo.Get(x => x.Id == id);
            var result = MapperFactory.CurrentMapper.Map<TDto>(entity);
            return result;
        }

        public async Task<TDto> GetAsync(Guid id)
        {
            var entity = await _repo.GetAsync(x => x.Id == id);
            var result = MapperFactory.CurrentMapper.Map<TDto>(entity);
            return result;
        }

        public List<TDto> GetAll()
        {
            var entityList = _repo.GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<TDto>>(entityList);
        }
        public async Task<List<TDto>> GetAllAsync()
        {
            var entityList = await _repo.GetAll().ToListAsync();
            return MapperFactory.CurrentMapper.Map<List<TDto>>(entityList);
        }

        public List<TDto> GetByNameList(string name)
        {
            var entityList = _repo.Get(x => x.Name.Contains(name), null).ToList();
            return MapperFactory.CurrentMapper.Map<List<TDto>>(entityList);
        }

        public TDto GetByName(string name)
        {
            var entityList = _repo.Get(x => x.Name.Contains(name), null).FirstOrDefault();
            return MapperFactory.CurrentMapper.Map<TDto>(entityList);
        }

        public async Task<List<TDto>> GetByNameListAsync(string name)
        {
            var entityList = await _repo.Get(x => x.Name.Contains(name), null).ToListAsync();
            return MapperFactory.CurrentMapper.Map<List<TDto>>(entityList);
        }

        public async Task<TDto> GetByNameAsync(string name)
        {
            var entityList = await _repo.Get(x => x.Name.Contains(name), null).FirstOrDefaultAsync();
            return MapperFactory.CurrentMapper.Map<TDto>(entityList);
        }

        public TDto Update(TDto dto)
        {
            var selected = _repo.Get(x => x.Id == dto.Id);
            selected = MapperFactory.CurrentMapper.Map<T>(dto);
            _repo.Update(selected);
            _uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<TDto>(selected);
        }

        public async Task<TDto> UpdateAsync(TDto dto)
        {
            var selected = _repo.Get(x => x.Id == dto.Id);
            selected = MapperFactory.CurrentMapper.Map<T>(dto);
            _repo.Update(selected);
            await _uow.SaveChangesAsync();
            return MapperFactory.CurrentMapper.Map<TDto>(selected);
        }
    }
}

using FairWorks.Core.Data.Repositories;
using FairWorks.Core.Data.UnitOfWork;
using FairWorks.Core.Services;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using FairWorks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FairWorks.BLL.Services
{
    public class CompanyService : ServiceBase<Company, CompanyDTO>,IServiceBase<Company, CompanyDTO>
    {
        private readonly IUnitofWork _uow;
        private readonly IRepository<Company> _repo;
        public CompanyService(IUnitofWork uow)
        {
            _uow = uow;
            _repo = _uow.GetRepository<Company>();
        }

        public CompanyDTO Add(CompanyDTO company)
        {
            if (!_repo.GetAll().Any(x => x.Name == company.Name))
            {
                var added = MapperFactory.CurrentMapper.Map<Company>(company);
                added = _repo.Add(added);
                _uow.SaveChanges();
                return MapperFactory.CurrentMapper.Map<CompanyDTO>(added);
            }
            else
            {
                return null;
            }
        }

        //public bool Delete(Guid companyId)
        //{
        //    try
        //    {
        //        var company = _repo.Get(x => x.Id == companyId);
        //        _repo.Delete(company);
        //        _uow.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //public CompanyDTO Get(Guid Id)
        //{
        //    var company = _repo.Get(x => x.Id == Id);
        //    return MapperFactory.CurrentMapper.Map<CompanyDTO>(company);
        //}

        //public List<CompanyDTO> GetAll()
        //{
        //    var companyList = _repo.GetAll().ToList();
        //    return MapperFactory.CurrentMapper.Map<List<CompanyDTO>>(companyList);
        //}

        //public List<CompanyDTO> GetByName(string companyName)
        //{
        //    var companyList = _repo.Get(x => x.Name.Contains(companyName), null).ToList();
        //    return MapperFactory.CurrentMapper.Map<List<CompanyDTO>>(companyList);
        //}

        //public CompanyDTO Update(CompanyDTO company)
        //{
        //    var selected = _repo.Get(x => x.Id == company.Id);
        //    selected = MapperFactory.CurrentMapper.Map<Company>(company);
        //    _repo.Update(selected);
        //    _uow.SaveChanges();
        //    return MapperFactory.CurrentMapper.Map<CompanyDTO>(selected);
        //}
    }
}
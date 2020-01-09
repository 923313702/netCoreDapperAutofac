using NetCoreDapperAutoFac.Entitys;
using NetCoreDapperAutoFac.Repositorys.IRepository;
using NetCoreDapperAutoFac.Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreDapperAutoFac.Services.Services
{
    public class PersonService:BaseService<Person>,IPersonService
    {
        private IPersonRepository _repository;
        public PersonService(IPersonRepository repository):base (repository)
        {
            _repository = repository;
        }
    }
}

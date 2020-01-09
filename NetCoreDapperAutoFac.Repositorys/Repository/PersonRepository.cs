using Microsoft.Extensions.Configuration;
using NetCoreDapperAutoFac.Entitys;
using NetCoreDapperAutoFac.Repositorys.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreDapperAutoFac.Repositorys.Repository
{
    public class PersonRepository : BaseRepository<Person>,IPersonRepository
    {
        private readonly IConfiguration config;
        public PersonRepository(IConfiguration _config) : base(_config)
        {
            config = _config;
        }
       
    }
}

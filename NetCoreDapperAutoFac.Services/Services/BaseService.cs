using NetCoreDapperAutoFac.Repositorys.IRepository;
using NetCoreDapperAutoFac.Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreDapperAutoFac.Services.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {

        private readonly IBaseRepository<T> _repository;
        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
        public int Add(string strSql, T model, bool isTran)
        {
            return _repository.Add(strSql, model, isTran);
        }

        public int Update(string strSql, T model, bool isTran)
        {
            return _repository.Add(strSql, model, isTran);
        }
    }
}

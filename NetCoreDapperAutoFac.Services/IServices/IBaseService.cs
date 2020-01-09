using NetCoreDapperAutoFac.Repositorys.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreDapperAutoFac.Services.IServices
{
    public interface IBaseService<T>:IBaseRepository<T> where T:class
    {
    }
}

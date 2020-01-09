using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreDapperAutoFac.Repositorys.IRepository
{
    public interface IBaseRepository<T> where T:class
    {

        int Add(string strSql, T model, bool isTran);
        int Update(string strSql, T model, bool isTran);
    }
}

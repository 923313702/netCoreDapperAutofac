using Dapper;
using Microsoft.Extensions.Configuration;
using NetCoreDapperAutoFac.Repositorys.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace NetCoreDapperAutoFac.Repositorys.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private IConfiguration icg;


        public BaseRepository(IConfiguration _icg)
        {
            icg = _icg;
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(icg.GetConnectionString("DefaultConnection"));
            }
        }
        public int Add(string strSql, T model, bool isTran)
        {
            int ret = -1;
            try
            {
                using (IDbConnection conn = Connection)
                {
                    IDbTransaction tran = null;
                    if (isTran)
                        tran = Connection.BeginTransaction();
                    conn.Execute(strSql, model, tran);
                }
                ret = 1;
            }
            catch (Exception ex)
            {

                //throw;
            }
            return ret;
        }

        public int Update(string strSql, T model, bool isTran)
        {
            int ret = -1;
            try
            {
                using (IDbConnection conn = Connection)
                {
                    IDbTransaction tran = null;
                    if (isTran)
                        tran = Connection.BeginTransaction();
                    conn.Execute(strSql, model, tran);
                }
                ret = 1;
            }
            catch (Exception)
            {

                //throw;
            }
            return ret;
        }
    }
}

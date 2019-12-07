using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Midleware.Infra.Database
{
    public class DbManager : IDisposable
    {
        private readonly SqlConnection _Connetion;

        /// <param name="memory">verifica se a connection string é usada para o banco do parceiro </param>
        public DbManager(bool memory = false)
        {
            _Connetion = new SqlConnection(!memory ? new Configuration().getDatabase() : new Configuration().getDatabase());
        }

        public IEnumerable<T> ExecuteProcedure<T>(string NomeProcedure, DynamicParameters param = null)
        {
            _Connetion.Open();

            if (param != null)
                return _Connetion.Query<T>(NomeProcedure, param, commandType: CommandType.StoredProcedure, commandTimeout: 0).ToList();
            else
                return _Connetion.Query<T>(NomeProcedure, commandType: CommandType.StoredProcedure, commandTimeout: 0).ToList();
        }

        public bool ExecuteProcedure(string NomeProcedure, DynamicParameters param = null)
        {
            _Connetion.Open();

            if (param != null)
                _Connetion.Query(NomeProcedure, param, commandType: CommandType.StoredProcedure, commandTimeout: 0);
            else
                _Connetion.Query(NomeProcedure, commandType: CommandType.StoredProcedure, commandTimeout: 0);

            return true;
        }

        public bool ExecuteCommand(string NameCommand)
        {
            _Connetion.Open();

            _Connetion.Execute(NameCommand);

            return true;
        }

        public void Dispose()
        {
            if (_Connetion != null && _Connetion.State != ConnectionState.Closed)
            {
                _Connetion.Close();
                _Connetion.Dispose();
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;

namespace Donation.Midleware.Infra.Database
{
    public class DbManager : IDisposable
    {
        private readonly Configuration _DbConfiguration;
        private readonly SqlCommand _SqlCommand;
        private readonly SqlConnection _Connetion;

        public DbManager()
        {
            _DbConfiguration = new Configuration();
            _Connetion = new SqlConnection(_DbConfiguration.getDatabase());
            _SqlCommand = new SqlCommand();
        }

        public SqlDataReader ExecuteProcedure(string NomeProcedure)
        {
            _Connetion.Open();

            _SqlCommand.CommandText = NomeProcedure;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.Connection = _Connetion;

            return _SqlCommand.ExecuteReader();
        }


        public bool ExecuteNonQuery(string NomeProcedure)
        {
            _Connetion.Open();

            _SqlCommand.CommandText = NomeProcedure;
            _SqlCommand.CommandType = CommandType.StoredProcedure;
            _SqlCommand.Connection = _Connetion;

            return _SqlCommand.ExecuteNonQuery() > 0;
        }

        public void AddParams(string key, string Value, SqlDbType Type)
        {
            _SqlCommand.Parameters.Add(new SqlParameter(key, Type)).Value = Value;
        }

        public void Dispose()
        {
            if (_Connetion != null && _Connetion.State == ConnectionState.Open)
            {
                _Connetion.Close();
                _Connetion.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }
}

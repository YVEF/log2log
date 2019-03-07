using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Services.DbConfig
{
    class DbContext : IContext
    {
        private IDbConnection connection;
        internal DbContext(IDbConnection connection)
        {
            this.connection = connection;
        }

        public IDbCommand CreateCommand()
        {
            connection.Open();
            return connection.CreateCommand();
        }


        public void Dispose() => connection.Close();

    }
}

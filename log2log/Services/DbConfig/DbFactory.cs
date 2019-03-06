using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Services.DbConfig
{
    internal class DbFactory
    {
        private ConnectionStringSettings stringSections;

        public DbFactory(ConnectionStringSettings stringSections)
        {
            this.stringSections = stringSections;
        }


        public IContext CreateContext()
        {
            DbProviderFactory providerFactory = DbProviderFactories.GetFactory(stringSections.ProviderName);
            var connection = providerFactory.CreateConnection();
            connection.ConnectionString = stringSections.ConnectionString;
            return new DbContext(connection);            
        }
        
    }
}

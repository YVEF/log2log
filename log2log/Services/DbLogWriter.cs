using System;
using System.Collections.Generic;
using System.Data;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log2log.Core;
using log2log.Services.DbConfig;

namespace log2log.Services
{
    internal class DbLogWriter : ILogWriter
    {
        private static object lockObj = new object();
        public Queue<ILogData> loggerQueue { get; set; }
        private IDbConnection connection;
        private IContext context;
        
        public DbLogWriter(IContext context)
        {
            this.context = context;
            using (var command = context.CreateCommand())
            {                
                command.CommandText = "CREATE TABLE [Loglog] ( [Id] INT PRIMARY KEY IDENTITY NOT NULL, " +
                    "[Level] VARCHAR(20) NOT NULL, [Time] VARCHAR(30) NOT NULL, [Message] VARCHAR(60) NULL ) GO";
                command.ExecuteNonQuery();
            }
        }

        public bool Write()
        {
            var builder = new StringBuilder();
            builder.Append("INSERT INTO [Loglog] ([Level], [Time], [Message]) VALUES ");
            while (loggerQueue.Count > 0)
            {
                var data = loggerQueue.Dequeue();
                builder.AppendFormat(" ({0}, {1}, {2}), \n", data.Level, data.LogTime, data.Message);
            }
            string addCommand = builder.ToString();

            using (var command = context.CreateCommand())
            {

                command.CommandText = addCommand;
                command.ExecuteNonQuery();
            }
            return true;            
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}

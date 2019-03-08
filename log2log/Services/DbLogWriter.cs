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
        //private IDbConnection connection;
        private IContext context;
        
        public DbLogWriter(IContext context)
        {
            this.context = context;
            
            using (var currentContext = context)
            {
                var command = currentContext.CreateCommand();
                command.CommandText = "IF exists (SELECT 1 FROM [Loglog]) BEGIN RETURN END ELSE BEGIN " +
                    " CREATE TABLE [Loglog] ( [Id] INT PRIMARY KEY IDENTITY NOT NULL, " +
                    "[Level] VARCHAR(20) NOT NULL, [Time] NVARCHAR(30) NOT NULL, [Message] NVARCHAR(60) NULL ) END;";
                command.ExecuteNonQuery();
            }
        }

        public bool Write()
        {
            var builder = new StringBuilder();
            builder.Append("INSERT INTO [Loglog] ([Level], [Time], [Message]) VALUES ");
            while (loggerQueue.Count > 1)
            {
                var data = loggerQueue.Dequeue();
                builder.AppendFormat(" ({0}, {1}, {2}), ", data.Level, data.LogTime, data.Message);
            }
            var lastdata = loggerQueue.Dequeue();
            builder.AppendFormat(" ({0}, {1}, {2}); ", lastdata.Level, lastdata.LogTime, lastdata.Message);
            
            string addCommand = builder.ToString();

            using (var currentContext = context)
            {
                var command = currentContext.CreateCommand();
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

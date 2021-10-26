using System;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace ConfigChangePipeLine
{
    public class RunQuery
    {
        public void Run()
        {
            string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\neeraj.kumar\source\repos\ConfigChangePipeLine\ConfigChangePipeLine\TestDb.mdf;Integrated Security=True";

            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string script = File.ReadAllText(Path.Combine(sCurrentDirectory+ @"\Queries\query.sql"));

            SqlConnection conn = new SqlConnection(sqlConnectionString);

            Server server = new Server(new ServerConnection(conn));

            server.ConnectionContext.ExecuteNonQuery(script);
        }
    }
}

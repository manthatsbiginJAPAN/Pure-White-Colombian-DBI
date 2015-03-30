using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;

namespace FrontEndV0._1
{
    class Connection
    {
        private string oradb;

        public Connection(string user, string password)
        {
            oradb = "Data Source=ictoraclesvm1.ict.swin.edu.au/dba;User Id=" + user + ";Password=" + password +";";
        }

        public OracleConnection oraConn()
        {
            OracleConnection conn = new OracleConnection(oradb);
            return conn;
        }
    }
}

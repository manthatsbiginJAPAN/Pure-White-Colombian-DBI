using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;

namespace FrontEndV0._1.forms
{
    class Executor
    {
        private Connection _conn = new Connection("s7663285", "123");
        private string _command;
        private OracleConnection _oconn;

        //private string[] <list of variables>
        //something like this

        public Executor(string command)
        {
            _command = command;
            _oconn = _conn.oraConn();

        }

        public void Execute()
        {
            OracleCommand cmd = new OracleCommand(_command, _oconn);
            //TODO: Build Parameters etc
            //cmd.addParameter("VALUE", <type>).value = something

            _oconn.Open();
            cmd.ExecuteNonQuery();
            _oconn.Close();
        }
    }
}

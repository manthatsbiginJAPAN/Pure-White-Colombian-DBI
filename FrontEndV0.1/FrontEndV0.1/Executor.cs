using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FrontEndV0._1.forms
{
    class Executor
    {
        private Connection _conn = new Connection("s7663285", "123");
        private string _command;
        private OracleConnection _oconn;
        private string[] _parameters = null;


        //private string[] <list of variables>
        //something like this

        public Executor(string command)
        {
            _command = command;
            _oconn = _conn.oraConn();
        }

        public Executor(string command, string[] parameters, string[] tables)
        {
            _command = command;
            _oconn = _conn.oraConn();
            _parameters = parameters;
        }

        public void Execute()
        {
            OracleCommand cmd = new OracleCommand(_command, _oconn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (_parameters != null)
            {


                for (int i = 0; i <= _parameters.Count() - 1; i++)
                {
                    cmd.Parameters.Add("PARAM"+ i);
                }
            }

            _oconn.Open();
            cmd.ExecuteNonQuery();
            _oconn.Close();
        }

        /*private string[] getTypes()
        {
           
        }*/
    }
}

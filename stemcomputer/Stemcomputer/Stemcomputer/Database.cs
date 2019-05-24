using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Stemcomputer
{
    class Database
    {
        private MySqlConnection _con;
        public MySqlCommand Cmd;
        private MySqlDataAdapter _da;
        private DataTable _dt;

        public Database()
        {
            _con = new MySqlConnection("Server=localhost; Database = StemComputer; username=root; password=");
            _con.Open();

        }
        public void SqlQuery(string queryText)
        {
            Cmd = new MySqlCommand(queryText, _con);
        }

        public DataTable QueryEx()
        {
            _da = new MySqlDataAdapter(Cmd);
            _dt = new DataTable();
            _da.Fill(_dt);

            return _dt;
        }

        public void NonQueryEx()
        {
            Cmd.ExecuteNonQuery();
        }
    }
}

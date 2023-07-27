using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;


namespace Hospital_Project
{
    public class Sql_Baglanti
    {
        public SqlConnection baglanti() 
        {
            SqlConnection sql = new SqlConnection("Data Source=DESKTOP-3HN2204\\SQLEXPRESS;Initial Catalog=HastaneProjesi;Integrated Security=True");
            sql.Open();
            return sql;
        }

    }
}
